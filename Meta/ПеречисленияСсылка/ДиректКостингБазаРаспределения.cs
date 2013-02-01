﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ДиректКостингБазаРаспределения
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		Себестоимость = 0,
	///<summary>
	///(Общ)
	///</summary>
		ВыручкаОтПродаж = 1,//Выручка от продаж
	}
	public static partial class ДиректКостингБазаРаспределения_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Себестоимость = new Guid("751f389f-03f1-c41d-4c85-9d50dc5c71ce");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВыручкаОтПродаж = new Guid("54e2f08c-5ed2-b2d0-49ab-02f852695f32");//Выручка от продаж
		public static ДиректКостингБазаРаспределения Получить(this ДиректКостингБазаРаспределения Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ДиректКостингБазаРаспределения Получить(this ДиректКостингБазаРаспределения Значение, Guid Ссылка)
		{
			if(Ссылка == Себестоимость)
			{
				return ДиректКостингБазаРаспределения.Себестоимость;
			}
			else if(Ссылка == ВыручкаОтПродаж)
			{
				return ДиректКостингБазаРаспределения.ВыручкаОтПродаж;
			}
			return ДиректКостингБазаРаспределения.ПустаяСсылка;
		}
		public static byte[] Ключ(this ДиректКостингБазаРаспределения Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ДиректКостингБазаРаспределения Значение)
		{
			switch (Значение)
			{
				case ДиректКостингБазаРаспределения.Себестоимость: return Себестоимость;
				case ДиректКостингБазаРаспределения.ВыручкаОтПродаж: return ВыручкаОтПродаж;
			}
			return Guid.Empty;
		}
	}
}
