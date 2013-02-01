﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum НаправленияРаспределенияЗатрат
	{
		ПустаяСсылка = - 1,
		Выпуск = 0,//На выпуск
		Затраты = 1,//На затраты
		Результат = 2,//На результат
	}
	public static partial class НаправленияРаспределенияЗатрат_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Выпуск = new Guid("22946b86-6916-b532-41a7-02f63079035f");//На выпуск
		public static readonly Guid Затраты = new Guid("2d6f06be-9c93-03f8-4b9b-0db159c0c74b");//На затраты
		public static readonly Guid Результат = new Guid("107518ab-8ce5-f512-4e20-3ca8e1505055");//На результат
		public static НаправленияРаспределенияЗатрат Получить(this НаправленияРаспределенияЗатрат Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static НаправленияРаспределенияЗатрат Получить(this НаправленияРаспределенияЗатрат Значение, Guid Ссылка)
		{
			if(Ссылка == Выпуск)
			{
				return НаправленияРаспределенияЗатрат.Выпуск;
			}
			else if(Ссылка == Затраты)
			{
				return НаправленияРаспределенияЗатрат.Затраты;
			}
			else if(Ссылка == Результат)
			{
				return НаправленияРаспределенияЗатрат.Результат;
			}
			return НаправленияРаспределенияЗатрат.ПустаяСсылка;
		}
		public static byte[] Ключ(this НаправленияРаспределенияЗатрат Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this НаправленияРаспределенияЗатрат Значение)
		{
			switch (Значение)
			{
				case НаправленияРаспределенияЗатрат.Выпуск: return Выпуск;
				case НаправленияРаспределенияЗатрат.Затраты: return Затраты;
				case НаправленияРаспределенияЗатрат.Результат: return Результат;
			}
			return Guid.Empty;
		}
	}
}
