﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum СпособыРезервирования
	{
		ПустаяСсылка = - 1,
		НеРезервировать = 0,//Не резервировать
		ПоЗаказу = 1,//По заказу
		ПоЗаказуНаПроизводство = 2,//По заказу на производство
	}
	public static partial class СпособыРезервирования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НеРезервировать = new Guid("b409efa0-81c8-35a7-458b-90e5913a2362");//Не резервировать
		public static readonly Guid ПоЗаказу = new Guid("2a78ae9f-9234-c62d-44d3-c12cd3eea29f");//По заказу
		public static readonly Guid ПоЗаказуНаПроизводство = new Guid("67c092a7-c6c9-b6fc-4402-c3a99c47ff26");//По заказу на производство
		public static СпособыРезервирования Получить(this СпособыРезервирования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыРезервирования Получить(this СпособыРезервирования Значение, Guid Ссылка)
		{
			if(Ссылка == НеРезервировать)
			{
				return СпособыРезервирования.НеРезервировать;
			}
			else if(Ссылка == ПоЗаказу)
			{
				return СпособыРезервирования.ПоЗаказу;
			}
			else if(Ссылка == ПоЗаказуНаПроизводство)
			{
				return СпособыРезервирования.ПоЗаказуНаПроизводство;
			}
			return СпособыРезервирования.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыРезервирования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыРезервирования Значение)
		{
			switch (Значение)
			{
				case СпособыРезервирования.НеРезервировать: return НеРезервировать;
				case СпособыРезервирования.ПоЗаказу: return ПоЗаказу;
				case СпособыРезервирования.ПоЗаказуНаПроизводство: return ПоЗаказуНаПроизводство;
			}
			return Guid.Empty;
		}
	}
}
