﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыРезервов
	{
		ПустаяСсылка = - 1,
		ПоСомнительнымДолгам = 0,//По сомнительным долгам
		ПодОбесцениваниеЦенныхБумаг = 1,//Под обесценивание ценных бумаг
		НаПокрытиеИныхЗатрат = 2,//На покрытие иных затрат
	}
	public static partial class ВидыРезервов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоСомнительнымДолгам = new Guid("24bba889-2980-8df6-4f00-5a887741cdac");//По сомнительным долгам
		public static readonly Guid ПодОбесцениваниеЦенныхБумаг = new Guid("d8931ba0-8274-5a5e-44b5-7ab52f520f1b");//Под обесценивание ценных бумаг
		public static readonly Guid НаПокрытиеИныхЗатрат = new Guid("4eafd8b3-afb7-6188-4a48-112d0a5f34bc");//На покрытие иных затрат
		public static ВидыРезервов Получить(this ВидыРезервов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыРезервов Получить(this ВидыРезервов Значение, Guid Ссылка)
		{
			if(Ссылка == ПоСомнительнымДолгам)
			{
				return ВидыРезервов.ПоСомнительнымДолгам;
			}
			else if(Ссылка == ПодОбесцениваниеЦенныхБумаг)
			{
				return ВидыРезервов.ПодОбесцениваниеЦенныхБумаг;
			}
			else if(Ссылка == НаПокрытиеИныхЗатрат)
			{
				return ВидыРезервов.НаПокрытиеИныхЗатрат;
			}
			return ВидыРезервов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыРезервов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыРезервов Значение)
		{
			switch (Значение)
			{
				case ВидыРезервов.ПоСомнительнымДолгам: return ПоСомнительнымДолгам;
				case ВидыРезервов.ПодОбесцениваниеЦенныхБумаг: return ПодОбесцениваниеЦенныхБумаг;
				case ВидыРезервов.НаПокрытиеИныхЗатрат: return НаПокрытиеИныхЗатрат;
			}
			return Guid.Empty;
		}
	}
}
