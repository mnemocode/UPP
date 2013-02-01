﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ОбязательностьЗаполненияОтветаНаВопрос
	{
		ПустаяСсылка = - 1,
		НеОбязателенКЗаполнению = 0,//Не обязателен к заполнению
		ОбязателенКЗаполнению = 1,//Обязателен к заполнению
		УсловноОбязателенКЗаполнению = 2,//Условно обязателен к заполнению
		УсловноНеЗаполнять = 3,//Условно не заполнять
	}
	public static partial class ОбязательностьЗаполненияОтветаНаВопрос_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеОбязателенКЗаполнению = new Guid("d26024bd-dc11-f690-49d4-abcec9407984");//Не обязателен к заполнению
		public static readonly Guid ОбязателенКЗаполнению = new Guid("db334a90-01df-9708-4bd8-e4f822effe32");//Обязателен к заполнению
		public static readonly Guid УсловноОбязателенКЗаполнению = new Guid("41d8b4b0-3893-4da5-4150-15101a7213c3");//Условно обязателен к заполнению
		public static readonly Guid УсловноНеЗаполнять = new Guid("cd8c37a0-a0bd-e03f-46b8-292ca1613f15");//Условно не заполнять
		public static ОбязательностьЗаполненияОтветаНаВопрос Получить(this ОбязательностьЗаполненияОтветаНаВопрос Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ОбязательностьЗаполненияОтветаНаВопрос Получить(this ОбязательностьЗаполненияОтветаНаВопрос Значение, Guid Ссылка)
		{
			if(Ссылка == НеОбязателенКЗаполнению)
			{
				return ОбязательностьЗаполненияОтветаНаВопрос.НеОбязателенКЗаполнению;
			}
			else if(Ссылка == ОбязателенКЗаполнению)
			{
				return ОбязательностьЗаполненияОтветаНаВопрос.ОбязателенКЗаполнению;
			}
			else if(Ссылка == УсловноОбязателенКЗаполнению)
			{
				return ОбязательностьЗаполненияОтветаНаВопрос.УсловноОбязателенКЗаполнению;
			}
			else if(Ссылка == УсловноНеЗаполнять)
			{
				return ОбязательностьЗаполненияОтветаНаВопрос.УсловноНеЗаполнять;
			}
			return ОбязательностьЗаполненияОтветаНаВопрос.ПустаяСсылка;
		}
		public static byte[] Ключ(this ОбязательностьЗаполненияОтветаНаВопрос Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ОбязательностьЗаполненияОтветаНаВопрос Значение)
		{
			switch (Значение)
			{
				case ОбязательностьЗаполненияОтветаНаВопрос.НеОбязателенКЗаполнению: return НеОбязателенКЗаполнению;
				case ОбязательностьЗаполненияОтветаНаВопрос.ОбязателенКЗаполнению: return ОбязателенКЗаполнению;
				case ОбязательностьЗаполненияОтветаНаВопрос.УсловноОбязателенКЗаполнению: return УсловноОбязателенКЗаполнению;
				case ОбязательностьЗаполненияОтветаНаВопрос.УсловноНеЗаполнять: return УсловноНеЗаполнять;
			}
			return Guid.Empty;
		}
	}
}
