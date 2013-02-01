﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыОперацийЗаказПокупателя
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ПродажаКомиссия = 0,//продажа, комиссия
	///<summary>
	///(Общ)
	///</summary>
		Переработка = 1,
	}
	public static partial class ВидыОперацийЗаказПокупателя_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПродажаКомиссия = new Guid("fb827598-5b23-be7b-4754-6043e5cb04f7");//продажа, комиссия
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Переработка = new Guid("8c5a29ab-9981-88d1-492b-793af83daf12");
		public static ВидыОперацийЗаказПокупателя Получить(this ВидыОперацийЗаказПокупателя Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийЗаказПокупателя Получить(this ВидыОперацийЗаказПокупателя Значение, Guid Ссылка)
		{
			if(Ссылка == ПродажаКомиссия)
			{
				return ВидыОперацийЗаказПокупателя.ПродажаКомиссия;
			}
			else if(Ссылка == Переработка)
			{
				return ВидыОперацийЗаказПокупателя.Переработка;
			}
			return ВидыОперацийЗаказПокупателя.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийЗаказПокупателя Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийЗаказПокупателя Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийЗаказПокупателя.ПродажаКомиссия: return ПродажаКомиссия;
				case ВидыОперацийЗаказПокупателя.Переработка: return Переработка;
			}
			return Guid.Empty;
		}
	}
}
