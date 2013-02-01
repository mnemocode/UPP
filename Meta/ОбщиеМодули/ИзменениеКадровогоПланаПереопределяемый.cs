﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ИзменениеКадровогоПланаПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public void ДополнитьДвижение(/*Движение, ВыборкаПоШапкеДокумента, ВыборкаПоСтрокамДокумента*/)
		{
			if(true/*ВыборкаПоШапкеДокумента.РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				/*Движение.ПодразделениеОрганизации	= ВыборкаПоСтрокамДокумента.Подразделение;*/
			}
		}

		public object СформироватьЗапросПоРасхождениям(/*ЭтотОбъект*/)
		{
			/*РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();*/
			/*Запрос = Новый Запрос;*/
			/*Запрос.УстановитьПараметр("ТекущаяДата",	ОбщегоНазначения.ПолучитьРабочуюДату());*/
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				/*Запрос.УстановитьПараметр("Организация",	ЭтотОбъект.Организация);*/
				/*Запрос.Текст =
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ
		|	КадровоеПланирование.Подразделение КАК Подразделение,
		|	КадровоеПланирование.Должность КАК Должность,
		|	КадровоеПланирование.ЗанятоСтавок КАК Количество
		|ИЗ
		|	(ВЫБРАТЬ
		|		КадровоеПланирование.Подразделение КАК Подразделение,
		|		КадровоеПланирование.Должность КАК Должность,
		|		МАКСИМУМ(КадровоеПланирование.КоличествоСтавок) КАК КоличествоСтавок,
		|		МАКСИМУМ(КадровоеПланирование.ЗанятоСтавок) КАК ЗанятоСтавок
		|	ИЗ
		|		(ВЫБРАТЬ
		|			КадровыйПланСрезПоследних.ПодразделениеОрганизации КАК Подразделение,
		|			КадровыйПланСрезПоследних.Должность КАК Должность,
		|			СУММА(КадровыйПланСрезПоследних.Количество) КАК КоличествоСтавок,
		|			СУММА(0) КАК ЗанятоСтавок
		|		ИЗ
		|			РегистрСведений.КадровыйПлан.СрезПоследних(
		|					&ТекущаяДата,
		|					Подразделение = ЗНАЧЕНИЕ(Справочник.Подразделения.ПустаяСсылка)
		|						И ПодразделениеОрганизации.Владелец = &Организация) КАК КадровыйПланСрезПоследних
		|		
		|		СГРУППИРОВАТЬ ПО
		|			КадровыйПланСрезПоследних.ПодразделениеОрганизации,
		|			КадровыйПланСрезПоследних.Должность
		|		
		|		ОБЪЕДИНИТЬ ВСЕ
		|		
		|		ВЫБРАТЬ
		|			ЗанятыеШтатныеЕдиницыОрганизацийОстатки.ПодразделениеОрганизации,
		|			ЗанятыеШтатныеЕдиницыОрганизацийОстатки.Должность.Должность,
		|			СУММА(0),
		|			СУММА(ЗанятыеШтатныеЕдиницыОрганизацийОстатки.КоличествоСтавокОстаток)
		|		ИЗ
		|			РегистрНакопления.ЗанятыеШтатныеЕдиницыОрганизаций.Остатки(
		|					&ТекущаяДата,
		|					ПодразделениеОрганизации.Владелец = &Организация
		|						И Должность.Должность <> ЗНАЧЕНИЕ(Справочник.Должности.ПустаяСсылка)) КАК ЗанятыеШтатныеЕдиницыОрганизацийОстатки
		|		
		|		СГРУППИРОВАТЬ ПО
		|			ЗанятыеШтатныеЕдиницыОрганизацийОстатки.ПодразделениеОрганизации,
		|			ЗанятыеШтатныеЕдиницыОрганизацийОстатки.Должность.Должность
		|		
		|		ОБЪЕДИНИТЬ ВСЕ
		|		
		|		ВЫБРАТЬ
		|			Вакансии.Подразделение,
		|			Вакансии.Должность,
		|			СУММА(1),
		|			СУММА(0)
		|		ИЗ
		|			Справочник.Вакансии КАК Вакансии
		|		ГДЕ
		|			(НЕ Вакансии.Закрыта)
		|			И Вакансии.Подразделение ССЫЛКА Справочник.ПодразделенияОрганизаций
		|			И Вакансии.Подразделение.Владелец = &Организация
		|		
		|		СГРУППИРОВАТЬ ПО
		|			Вакансии.Подразделение,
		|			Вакансии.Должность
		|		
		|		ОБЪЕДИНИТЬ ВСЕ
		|		
		|		ВЫБРАТЬ
		|			ШтатноеРасписаниеОрганизацийСрезПоследних.ПодразделениеОрганизации,
		|			ШтатноеРасписаниеОрганизацийСрезПоследних.Должность.Должность,
		|			СУММА(ШтатноеРасписаниеОрганизацийСрезПоследних.КоличествоСтавок),
		|			СУММА(0)
		|		ИЗ
		|			РегистрСведений.ШтатноеРасписаниеОрганизаций.СрезПоследних(
		|					&ТекущаяДата,
		|					ПодразделениеОрганизации.Владелец = &Организация
		|						И Должность.Должность <> ЗНАЧЕНИЕ(Справочник.Должности.ПустаяСсылка)
		|						И (НЕ (ПодразделениеОрганизации, Должность.Должность) В
		|								(ВЫБРАТЬ РАЗЛИЧНЫЕ
		|									КадровыйПлан.ПодразделениеОрганизации,
		|									КадровыйПлан.Должность
		|								ИЗ
		|									РегистрСведений.КадровыйПлан.СрезПоследних(&ТекущаяДата, Подразделение = ЗНАЧЕНИЕ(Справочник.Подразделения.ПустаяСсылка)
		|										И ПодразделениеОрганизации.Владелец = &Организация) КАК КадровыйПлан
		|								ГДЕ
		|									КадровыйПлан.Количество <> 0))) КАК ШтатноеРасписаниеОрганизацийСрезПоследних
		|		
		|		СГРУППИРОВАТЬ ПО
		|			ШтатноеРасписаниеОрганизацийСрезПоследних.ПодразделениеОрганизации,
		|			ШтатноеРасписаниеОрганизацийСрезПоследних.Должность.Должность) КАК КадровоеПланирование
		|	
		|	СГРУППИРОВАТЬ ПО
		|		КадровоеПланирование.Подразделение,
		|		КадровоеПланирование.Должность) КАК КадровоеПланирование
		|ГДЕ
		|	КадровоеПланирование.КоличествоСтавок - КадровоеПланирование.ЗанятоСтавок <> 0
		|
		|УПОРЯДОЧИТЬ ПО
		|	Должность,
		|	Подразделение
		|АВТОУПОРЯДОЧИВАНИЕ";*/
			}
			return null;
		}

		public object СформироватьЗапросПоТекущемуСостоянию(/*ЭтотОбъект*/)
		{
			/*РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();*/
			/*Запрос = Новый Запрос;*/
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				/*Запрос.УстановитьПараметр("Организация",	ЭтотОбъект.Организация);*/
				/*Запрос.Текст = 
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ
		|	РаботникиСрезПоследних.ПодразделениеОрганизации КАК Подразделение,
		|	РаботникиСрезПоследних.Должность.Должность КАК Должность,
		|	СУММА(РаботникиСрезПоследних.ЗанимаемыхСтавок) КАК Количество,
		|	ВЫБОР
		|		КОГДА РаботникиСрезПоследних.Должность.Должность = ЗНАЧЕНИЕ(Справочник.Должности.ПустаяСсылка)
		|			ТОГДА ЛОЖЬ
		|		ИНАЧЕ ИСТИНА
		|	КОНЕЦ КАК ДолжностьЗаполнена,
		|	ВЫБОР
		|		КОГДА РаботникиСрезПоследних.Должность.Должность = ЗНАЧЕНИЕ(Справочник.Должности.ПустаяСсылка)
		|			ТОГДА РаботникиСрезПоследних.Должность.Наименование
		|		ИНАЧЕ """"
		|	КОНЕЦ КАК ДолжностьОрганизации
		|ИЗ
		|	РегистрСведений.РаботникиОрганизаций.СрезПоследних(, ОбособленноеПодразделение = &Организация) КАК РаботникиСрезПоследних
		|ГДЕ
		|	РаботникиСрезПоследних.ПричинаИзмененияСостояния <> ЗНАЧЕНИЕ(Перечисление.ПричиныИзмененияСостояния.Увольнение)
		|
		|СГРУППИРОВАТЬ ПО
		|	РаботникиСрезПоследних.ПодразделениеОрганизации,
		|	РаботникиСрезПоследних.Должность.Должность,
		|	ВЫБОР
		|		КОГДА РаботникиСрезПоследних.Должность.Должность = ЗНАЧЕНИЕ(Справочник.Должности.ПустаяСсылка)
		|			ТОГДА РаботникиСрезПоследних.Должность.Наименование
		|		ИНАЧЕ """"
		|	КОНЕЦ";*/
			}
			return null;
		}

		public void ПроверитьЗначенияРеквизитов(/*ВыборкаПоШапкеДокумента, ВыборкаПоСтрокамДокумента, Отказ, СтрокаНачалаСообщенияОбОшибке*/)
		{
			if(true/*ВыборкаПоШапкеДокумента.РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				if(true/*ВыборкаПоСтрокамДокумента.ЭтоУправленческоеПодразделение*/)
				{
					/*СтрокаНачалаСообщенияОбОшибке = СтрокаНачалаСообщенияОбОшибке + "недопустимо указывать управленческие подразделения при текущем режиме кадрового планирования!";*/
					/*Отказ = Истина;*/
				}
			}
		}
		// Формирует запрос по шапке документа
		//
		// Параметры:
		//  Режим - режим проведения
		//
		// Возвращаемое значение:
		//  Результат запроса
		//

		public object СформироватьЗапросПоШапке(/*Режим, Ссылка*/)
		{
			/*Запрос = Новый Запрос;*/
			/*// Установим параметры запроса
*/
			/*Запрос.УстановитьПараметр("ДокументСсылка",	Ссылка);*/
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	ИзменениеКадровогоПлана.ДатаИзменений,
	|	ИзменениеКадровогоПлана.Ссылка,
	|	Константы.РежимНабораПерсонала
	|ИЗ
	|	Документ.ИзменениеКадровогоПлана КАК ИзменениеКадровогоПлана,
	|	Константы КАК Константы
	|ГДЕ
	|	ИзменениеКадровогоПлана.Ссылка = &ДокументСсылка";*/
			return null;
		}
		// СформироватьЗапросПоШапке()
		// Формирует запрос по таблице "Штатные единицы" документа
		//
		// Параметры:
		//  Режим - режим проведения
		//
		// Возвращаемое значение:
		//  Результат запроса
		//

		public object СформироватьЗапросПоРабочиеМеста(/*ВыборкаПоШапкеДокумента, Режим, Ссылка*/)
		{
			/*Запрос = Новый Запрос;*/
			/*// Установим параметры запроса
*/
			/*Запрос.УстановитьПараметр("ДокументСсылка",			Ссылка);*/
			/*Запрос.УстановитьПараметр("РежимНабораПерсонала",	ВыборкаПоШапкеДокумента.РежимНабораПерсонала);*/
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	""РабочиеМеста"" КАК ВидСтрокиЗапроса,
	|	Док.НомерСтроки КАК НомерСтроки,
	|	Док.Подразделение КАК Подразделение,
	|	Док.Должность,
	|	Док.Количество,
	|	NULL КАК КонфликтныйДокумент,
	|	ВЫБОР
	|		КОГДА Док.Подразделение ССЫЛКА Справочник.Подразделения
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ЭтоУправленческоеПодразделение
	|ИЗ
	|	Документ.ИзменениеКадровогоПлана.РабочиеМеста КАК Док
	|ГДЕ
	|	Док.Ссылка = &ДокументСсылка
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	""КонфликтныйДокумент"",
	|	ИзменениеКадровогоПланаРабочиеМеста.НомерСтроки,
	|	NULL,
	|	NULL,
	|	NULL,
	|	ПРЕДСТАВЛЕНИЕ(КадровыйПлан.Регистратор),
	|	NULL
	|ИЗ
	|	Документ.ИзменениеКадровогоПлана.РабочиеМеста КАК ИзменениеКадровогоПланаРабочиеМеста
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ РегистрСведений.КадровыйПлан КАК КадровыйПлан
	|		ПО ИзменениеКадровогоПланаРабочиеМеста.Должность = КадровыйПлан.Должность
	|			И ИзменениеКадровогоПланаРабочиеМеста.Ссылка.ДатаИзменений = КадровыйПлан.Период
	|			И (ВЫБОР
	|				КОГДА &РежимНабораПерсонала = ЗНАЧЕНИЕ(Перечисление.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц)
	|					ТОГДА ИзменениеКадровогоПланаРабочиеМеста.Подразделение = КадровыйПлан.ПодразделениеОрганизации
	|				ИНАЧЕ ИзменениеКадровогоПланаРабочиеМеста.Подразделение = КадровыйПлан.Подразделение
	|			КОНЕЦ)
	|ГДЕ
	|	ИзменениеКадровогоПланаРабочиеМеста.Ссылка = &ДокументСсылка";*/
			return null;
		}
		// СформироватьЗапросПоРабочиеМеста()
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа

		public void ПриОткрытииДополнительно(/*ЭтаФорма, ЭтотОбъект*/)
		{
			/*РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();*/
			if(true/*ЭтотОбъект.ЭтоНовый()*/)
			{
				if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности*/)
				{
					/*ЭтотОбъект.Организация = Справочники.Организации.ПустаяСсылка();*/
				}
			}
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоЦентрамОтветственности*/)
			{
				/*ЭтаФорма.ЭлементыФормы.ПанельОрганизация.Свертка = РежимСверткиЭлементаУправления.Верх;*/
			}
		}

		public void ПриНачалеРедактированияДополнительно(/*Элемент*/)
		{
			/*РежимНабораПерсонала = ПроцедурыУправленияПерсоналомДополнительный.ПолучитьРежимНабораПерсонала();*/
			if(true/*РежимНабораПерсонала = Перечисления.ВидыОрганизационнойСтруктурыПредприятия.ПоСтруктуреЮридическихЛиц*/)
			{
				/*Элемент.ТекущаяСтрока.Подразделение = Справочники.ПодразделенияОрганизаций.ПустаяСсылка();*/
			}
		}
	}
}

