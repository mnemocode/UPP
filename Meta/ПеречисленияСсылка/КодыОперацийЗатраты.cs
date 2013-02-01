﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum КодыОперацийЗатраты
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		СписаниеПартийВПроизводствоОперативно = 0,//Списание партий в производство оперативно
	///<summary>
	///(Общ)
	///</summary>
		ПрочиеПостоянныеЗатраты = 1,//Прочие постоянные затраты
	///<summary>
	///(Общ)
	///</summary>
		ВнутренниеУслугиНаПостоянныеЗатраты = 2,//Внутренние услуги на постоянные затраты
	///<summary>
	///(Общ)
	///</summary>
		УслугиКонтрагентаНаПостоянныеЗатраты = 3,//Услуги контрагента на постоянные затраты
	///<summary>
	///(Общ)
	///</summary>
		СписаниеОХР_Регламент = 4,//Списание ОХР (26-й счет) (регламент.)
	///<summary>
	///(Общ)
	///</summary>
		СписаниеОПР_Регламент = 5,//Списание ОПР (25-й счет) (регламент.)
		ЗакрытиеКосвенныхРасходовНУ = 6,//Закрытие косвенных расходов (НУ)
		СписаниеРасходовНаПродажу = 7,//Списание расходов на продажу (регламент.)
		РасчетБазыРаспределения = 8,//Расчет базы распределения
		ЗакрытиеКосвенныхРасходовНУФикс = 9,//Закрытие косвенных расходов (НУ) по фиксированной стоимости
	}
	public static partial class КодыОперацийЗатраты_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеПартийВПроизводствоОперативно = new Guid("6b6a798b-5024-866d-457d-1362b8bc0dbb");//Списание партий в производство оперативно
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ПрочиеПостоянныеЗатраты = new Guid("90a9e29e-02f5-3308-4a90-aba281b7f347");//Прочие постоянные затраты
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ВнутренниеУслугиНаПостоянныеЗатраты = new Guid("f2a17991-fbb8-720d-446e-628e36b69abd");//Внутренние услуги на постоянные затраты
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid УслугиКонтрагентаНаПостоянныеЗатраты = new Guid("74ab798f-9537-3a8f-486b-64c7490a733b");//Услуги контрагента на постоянные затраты
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеОХР_Регламент = new Guid("d9a49993-c798-e1ba-4e72-91aaeea8cc30");//Списание ОХР (26-й счет) (регламент.)
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid СписаниеОПР_Регламент = new Guid("4a5c119c-167f-5618-4739-d938aa77bc18");//Списание ОПР (25-й счет) (регламент.)
		public static readonly Guid ЗакрытиеКосвенныхРасходовНУ = new Guid("f0a42bbb-4b15-7027-4ad7-2a4a42942420");//Закрытие косвенных расходов (НУ)
		public static readonly Guid СписаниеРасходовНаПродажу = new Guid("9cdb36a7-3c77-ed50-4e77-6e2f8fafa0a2");//Списание расходов на продажу (регламент.)
		public static readonly Guid РасчетБазыРаспределения = new Guid("5a209da5-2bfe-d735-4474-a0bb9be6b32f");//Расчет базы распределения
		public static readonly Guid ЗакрытиеКосвенныхРасходовНУФикс = new Guid("7d5f59bb-afd5-bb50-42a5-08d3c37f0794");//Закрытие косвенных расходов (НУ) по фиксированной стоимости
		public static КодыОперацийЗатраты Получить(this КодыОперацийЗатраты Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static КодыОперацийЗатраты Получить(this КодыОперацийЗатраты Значение, Guid Ссылка)
		{
			if(Ссылка == СписаниеПартийВПроизводствоОперативно)
			{
				return КодыОперацийЗатраты.СписаниеПартийВПроизводствоОперативно;
			}
			else if(Ссылка == ПрочиеПостоянныеЗатраты)
			{
				return КодыОперацийЗатраты.ПрочиеПостоянныеЗатраты;
			}
			else if(Ссылка == ВнутренниеУслугиНаПостоянныеЗатраты)
			{
				return КодыОперацийЗатраты.ВнутренниеУслугиНаПостоянныеЗатраты;
			}
			else if(Ссылка == УслугиКонтрагентаНаПостоянныеЗатраты)
			{
				return КодыОперацийЗатраты.УслугиКонтрагентаНаПостоянныеЗатраты;
			}
			else if(Ссылка == СписаниеОХР_Регламент)
			{
				return КодыОперацийЗатраты.СписаниеОХР_Регламент;
			}
			else if(Ссылка == СписаниеОПР_Регламент)
			{
				return КодыОперацийЗатраты.СписаниеОПР_Регламент;
			}
			else if(Ссылка == ЗакрытиеКосвенныхРасходовНУ)
			{
				return КодыОперацийЗатраты.ЗакрытиеКосвенныхРасходовНУ;
			}
			else if(Ссылка == СписаниеРасходовНаПродажу)
			{
				return КодыОперацийЗатраты.СписаниеРасходовНаПродажу;
			}
			else if(Ссылка == РасчетБазыРаспределения)
			{
				return КодыОперацийЗатраты.РасчетБазыРаспределения;
			}
			else if(Ссылка == ЗакрытиеКосвенныхРасходовНУФикс)
			{
				return КодыОперацийЗатраты.ЗакрытиеКосвенныхРасходовНУФикс;
			}
			return КодыОперацийЗатраты.ПустаяСсылка;
		}
		public static byte[] Ключ(this КодыОперацийЗатраты Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this КодыОперацийЗатраты Значение)
		{
			switch (Значение)
			{
				case КодыОперацийЗатраты.СписаниеПартийВПроизводствоОперативно: return СписаниеПартийВПроизводствоОперативно;
				case КодыОперацийЗатраты.ПрочиеПостоянныеЗатраты: return ПрочиеПостоянныеЗатраты;
				case КодыОперацийЗатраты.ВнутренниеУслугиНаПостоянныеЗатраты: return ВнутренниеУслугиНаПостоянныеЗатраты;
				case КодыОперацийЗатраты.УслугиКонтрагентаНаПостоянныеЗатраты: return УслугиКонтрагентаНаПостоянныеЗатраты;
				case КодыОперацийЗатраты.СписаниеОХР_Регламент: return СписаниеОХР_Регламент;
				case КодыОперацийЗатраты.СписаниеОПР_Регламент: return СписаниеОПР_Регламент;
				case КодыОперацийЗатраты.ЗакрытиеКосвенныхРасходовНУ: return ЗакрытиеКосвенныхРасходовНУ;
				case КодыОперацийЗатраты.СписаниеРасходовНаПродажу: return СписаниеРасходовНаПродажу;
				case КодыОперацийЗатраты.РасчетБазыРаспределения: return РасчетБазыРаспределения;
				case КодыОперацийЗатраты.ЗакрытиеКосвенныхРасходовНУФикс: return ЗакрытиеКосвенныхРасходовНУФикс;
			}
			return Guid.Empty;
		}
	}
}
