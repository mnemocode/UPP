﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыОперацийПКО
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ОплатаПокупателя = 0,//Оплата от покупателя
	///<summary>
	///(Общ)
	///</summary>
		ПриходДенежныхСредствРозничнаяВыручка = 1,//Прием розничной выручки
	///<summary>
	///(Общ)
	///</summary>
		ВозвратДенежныхСредствПодотчетником = 2,//Возврат денежных средств подотчетником
	///<summary>
	///(Общ)
	///</summary>
		ВозвратДенежныхСредствПоставщиком = 3,//Возврат денежных средств поставщиком
	///<summary>
	///(Общ)
	///</summary>
		ПолучениеНаличныхДенежныхСредствВБанке = 4,//Получение наличных денежных средств в банке
		РасчетыПоКредитамИЗаймамСКонтрагентами = 5,//Расчеты по кредитам и займам с контрагентами
	///<summary>
	///(Общ)
	///</summary>
		ВозвратДенежныхСредствРаботником = 6,//Возврат денежных средств работником
		РасчетыПоКредитамИЗаймамСРаботниками = 7,//Расчеты по кредитам и займам с работниками
	///<summary>
	///(Общ)
	///</summary>
		ПриходДенежныхСредствПрочее = 8,//Прочий приход денежных средств
		ПрочиеРасчетыСКонтрагентами = 9,//Прочие расчеты с контрагентами
	}
	public static partial class ВидыОперацийПКО_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ОплатаПокупателя = new Guid("7061efab-140b-98c0-4e58-4ece73398a84");//Оплата от покупателя
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПриходДенежныхСредствРозничнаяВыручка = new Guid("efb62bb8-2ab1-8e0d-4ca8-d4b5049f47c2");//Прием розничной выручки
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратДенежныхСредствПодотчетником = new Guid("da9670b8-6340-f388-490f-c09393826d22");//Возврат денежных средств подотчетником
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратДенежныхСредствПоставщиком = new Guid("32633aa7-dc6c-23fb-459c-305b2ed1e96c");//Возврат денежных средств поставщиком
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПолучениеНаличныхДенежныхСредствВБанке = new Guid("4acf2087-2379-c1e1-4840-073dae168908");//Получение наличных денежных средств в банке
		public static readonly Guid РасчетыПоКредитамИЗаймамСКонтрагентами = new Guid("91ec8cb7-3b00-99dd-4dca-4726d2caa23f");//Расчеты по кредитам и займам с контрагентами
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВозвратДенежныхСредствРаботником = new Guid("4653e0a4-d27b-cb83-4c44-016ffaef26be");//Возврат денежных средств работником
		public static readonly Guid РасчетыПоКредитамИЗаймамСРаботниками = new Guid("492facbf-4ec2-0ee6-4397-975e7116f06b");//Расчеты по кредитам и займам с работниками
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПриходДенежныхСредствПрочее = new Guid("a54986b1-631f-acb7-45d2-20e52376ebf3");//Прочий приход денежных средств
		public static readonly Guid ПрочиеРасчетыСКонтрагентами = new Guid("0897a993-b051-1b82-437a-795f8016240f");//Прочие расчеты с контрагентами
		public static ВидыОперацийПКО Получить(this ВидыОперацийПКО Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийПКО Получить(this ВидыОперацийПКО Значение, Guid Ссылка)
		{
			if(Ссылка == ОплатаПокупателя)
			{
				return ВидыОперацийПКО.ОплатаПокупателя;
			}
			else if(Ссылка == ПриходДенежныхСредствРозничнаяВыручка)
			{
				return ВидыОперацийПКО.ПриходДенежныхСредствРозничнаяВыручка;
			}
			else if(Ссылка == ВозвратДенежныхСредствПодотчетником)
			{
				return ВидыОперацийПКО.ВозвратДенежныхСредствПодотчетником;
			}
			else if(Ссылка == ВозвратДенежныхСредствПоставщиком)
			{
				return ВидыОперацийПКО.ВозвратДенежныхСредствПоставщиком;
			}
			else if(Ссылка == ПолучениеНаличныхДенежныхСредствВБанке)
			{
				return ВидыОперацийПКО.ПолучениеНаличныхДенежныхСредствВБанке;
			}
			else if(Ссылка == РасчетыПоКредитамИЗаймамСКонтрагентами)
			{
				return ВидыОперацийПКО.РасчетыПоКредитамИЗаймамСКонтрагентами;
			}
			else if(Ссылка == ВозвратДенежныхСредствРаботником)
			{
				return ВидыОперацийПКО.ВозвратДенежныхСредствРаботником;
			}
			else if(Ссылка == РасчетыПоКредитамИЗаймамСРаботниками)
			{
				return ВидыОперацийПКО.РасчетыПоКредитамИЗаймамСРаботниками;
			}
			else if(Ссылка == ПриходДенежныхСредствПрочее)
			{
				return ВидыОперацийПКО.ПриходДенежныхСредствПрочее;
			}
			else if(Ссылка == ПрочиеРасчетыСКонтрагентами)
			{
				return ВидыОперацийПКО.ПрочиеРасчетыСКонтрагентами;
			}
			return ВидыОперацийПКО.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийПКО Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийПКО Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийПКО.ОплатаПокупателя: return ОплатаПокупателя;
				case ВидыОперацийПКО.ПриходДенежныхСредствРозничнаяВыручка: return ПриходДенежныхСредствРозничнаяВыручка;
				case ВидыОперацийПКО.ВозвратДенежныхСредствПодотчетником: return ВозвратДенежныхСредствПодотчетником;
				case ВидыОперацийПКО.ВозвратДенежныхСредствПоставщиком: return ВозвратДенежныхСредствПоставщиком;
				case ВидыОперацийПКО.ПолучениеНаличныхДенежныхСредствВБанке: return ПолучениеНаличныхДенежныхСредствВБанке;
				case ВидыОперацийПКО.РасчетыПоКредитамИЗаймамСКонтрагентами: return РасчетыПоКредитамИЗаймамСКонтрагентами;
				case ВидыОперацийПКО.ВозвратДенежныхСредствРаботником: return ВозвратДенежныхСредствРаботником;
				case ВидыОперацийПКО.РасчетыПоКредитамИЗаймамСРаботниками: return РасчетыПоКредитамИЗаймамСРаботниками;
				case ВидыОперацийПКО.ПриходДенежныхСредствПрочее: return ПриходДенежныхСредствПрочее;
				case ВидыОперацийПКО.ПрочиеРасчетыСКонтрагентами: return ПрочиеРасчетыСКонтрагентами;
			}
			return Guid.Empty;
		}
	}
}
