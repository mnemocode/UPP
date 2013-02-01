﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class НДФЛПерерасчетПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		// Проверяет правильность заполнения строки документа.

		public void ПроверитьЗаполнениеРаботникиОрганизации(/*ЭтотОбъект, Отказ, Заголовок = ""*/)
		{
			if(true/*Год(ЭтотОбъект.Дата) > ЭтотОбъект.НалоговыйПериод*/)
			{
				/*МесяцНалоговогоПериода = Дата(ЭтотОбъект.НалоговыйПериод, 12, 1);*/
			}
			/*Запрос = Новый Запрос;*/
			/*// Установим параметры запроса
*/
			/*Запрос.УстановитьПараметр("ДокументСсылка" , ЭтотОбъект.Ссылка);*/
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	ТЧРаботникиОрганизации.НомерСтроки,
	|	ТЧРаботникиОрганизации.ФизЛицо,
	|	ТЧРаботникиОрганизации.НалогПоСтавке09,
	|	ТЧРаботникиОрганизации.НалогПоСтавке13,
	|	ТЧРаботникиОрганизации.НалогПоСтавке35,
	|	ТЧРаботникиОрганизации.ПримененныйВычетЛичный,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаДетей,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаДетейДвойной,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаДетейДвойнойВторой,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаТретьегоРебенка,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаТретьегоРебенкаДвойной,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаТретьегоРебенкаДвойнойВторой,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаВторогоРебенка,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаВторогоРебенкаДвойной,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаВторогоРебенкаДвойнойВторой,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаДетейИнвалидов,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаДетейИнвалидовДвойной,
	|	ТЧРаботникиОрганизации.ПримененныйВычетНаДетейИнвалидовДвойнойВторой,
	|	ТЧРаботникиОрганизации.ПримененныйВычетИмущественныйРасход,
	|	ТЧРаботникиОрганизации.ПримененныйВычетИмущественныйПроцентыПоКредитам,
	|	ТЧРаботникиОрганизации.ПримененныйВычетИмущественныйПроцентыПриПерекредитовании,
	|	ТЧРаботникиОрганизации.ПодразделениеОрганизации,
	|	ВЫБОР
	|		КОГДА ТЧРаботникиОрганизации.ПодразделениеОрганизации.Владелец <> ТЧРаботникиОрганизации.Ссылка.Организация
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ОшибкаПодразделениеНеПринадлежитОрганизации
	|ИЗ
	|	Документ.НДФЛПерерасчет.РаботникиОрганизации КАК ТЧРаботникиОрганизации
	|ГДЕ
	|	ТЧРаботникиОрганизации.Ссылка = &ДокументСсылка";*/
			/*ВыборкаПоРаботникиОрганизации = Запрос.Выполнить().Выбрать();*/
			while(true/*ВыборкаПоРаботникиОрганизации.Следующий()*/)
			{
				/*НачалоСообщения = "В строке № """+ СокрЛП(ВыборкаПоРаботникиОрганизации.НомерСтроки) +
										""" табл. части ""Сотрудники организации"": ";*/
				if(true/*НЕ ЗначениеЗаполнено(ВыборкаПоРаботникиОрганизации.ФизЛицо)*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке(НачалоСообщения + "не указано физическое лицо!", Отказ, Заголовок);*/
				}
				if(true/*НЕ ЗначениеЗаполнено(ВыборкаПоРаботникиОрганизации.НалогПоСтавке09 + ВыборкаПоРаботникиОрганизации.НалогПоСтавке13 + ВыборкаПоРаботникиОрганизации.НалогПоСтавке35 
			+ ВыборкаПоРаботникиОрганизации.ПримененныйВычетЛичный + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаДетей + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаВторогоРебенка + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаТретьегоРебенка + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаДетейИнвалидов 
			+ ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаДетейДвойной + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаВторогоРебенкаДвойной + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаТретьегоРебенкаДвойной + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаДетейИнвалидовДвойной
			+ ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаДетейДвойнойВторой + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаВторогоРебенкаДвойнойВторой + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаТретьегоРебенкаДвойнойВторой + ВыборкаПоРаботникиОрганизации.ПримененныйВычетНаДетейИнвалидовДвойнойВторой
			+ ВыборкаПоРаботникиОрганизации.ПримененныйВычетИмущественныйРасход + ВыборкаПоРаботникиОрганизации.ПримененныйВычетИмущественныйПроцентыПоКредитам + ВыборкаПоРаботникиОрганизации.ПримененныйВычетИмущественныйПроцентыПриПерекредитовании)*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке(НачалоСообщения + "не указаны суммы перерасчета налога!", Отказ, Заголовок);*/
				}
				if(true/*ЗначениеЗаполнено(ВыборкаПоРаботникиОрганизации.ПодразделениеОрганизации) И ВыборкаПоРаботникиОрганизации.ОшибкаПодразделениеНеПринадлежитОрганизации*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке(НачалоСообщения + "указано подразделение, принадлежащее другой организации!", Отказ, Заголовок);*/
				}
			}
			/*;;*/
		}
		// ПроверитьЗаполнениеРаботникиОрганизации()
		// По документу формируем движения по НДФЛРасчетыСБюджетом
		//
		// Параметры:
		//  ШапкаДокумента				- выборка по данным шапки документа
		//
		// Возвращаемое значение:
		//  Нет.
		//

		public void СформироватьВзаиморасчетыСБюджетом(/*ЭтотОбъект, ШапкаДокумента*/)
		{
			/*// получим учетную политику
*/
			/*УпрощенныйУчетНДФЛ = ПроцедурыУправленияПерсоналом.ЗначениеУчетнойПолитикиПоПерсоналуОрганизации(глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации"), ЭтотОбъект.Организация, "УпрощенныйУчетНДФЛ");*/
			/*// Перерасчет - начисление налога
*/
			if(true/*Год(ШапкаДокумента.Дата) > ШапкаДокумента.НалоговыйПериод*/)
			{
				/*МесяцНалоговогоПериода = Дата(ШапкаДокумента.НалоговыйПериод, 12, 1);*/
			}
			/*// Заполним записи в наборах записей регистров
*/
		}
		//ЗаполнитьНаборЗаписейНДФЛПоНачислениям
		// По документу формируем движения по взаиморасчетам с работником
		//
		// Параметры:
		//  ШапкаДокумента				- выборка по данным шапки документа
		//
		// Возвращаемое значение:
		//  Нет.
		//

		public void СформироватьВзаиморасчетыСРаботниками(/*ЭтотОбъект, ШапкаДокумента*/)
		{
			/*// Перерасчет - начисление налога
*/
			if(true/*Год(ШапкаДокумента.Дата) > ШапкаДокумента.НалоговыйПериод*/)
			{
				/*МесяцНалоговогоПериода = Дата(ШапкаДокумента.НалоговыйПериод, 12, 1);*/
			}
			/*// Заполним записи в наборах записей регистров
*/
		}
		//ЗаполнитьНаборЗаписейНДФЛПоНачислениям
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта

		public void РассчитатьДополнительно(/*ЭтотОбъект, ГоловнаяОрганизация, МесяцНалоговогоПериода*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// Формирует запрос для расчета сумм НДФЛ к зачету
		//
		// Параметры:
		//	нет
		// Возвращаемое значение:
		//  Результат запроса.
		//

		public object СформироватьЗапросПоНДФЛКЗачету(/*ЭтотОбъект*/)
		{
			/*Запрос = Новый Запрос;*/
			/*// Установим параметры запроса
*/
			/*Запрос.УстановитьПараметр("ДокументСсылка", 	ЭтотОбъект.Ссылка);*/
			/*Запрос.УстановитьПараметр("Организация", 		ЭтотОбъект.Организация);*/
			/*Запрос.УстановитьПараметр("ПериодРегистрации", 	ЭтотОбъект.ПериодВзаиморасчетов);*/
			/*Запрос.УстановитьПараметр("Ставка13", 			Перечисления.НДФЛСтавкиНалогообложенияРезидента.Ставка13);*/
			/*Запрос.УстановитьПараметр("Ставка09", 			Перечисления.НДФЛСтавкиНалогообложенияРезидента.Ставка09);*/
			/*Запрос.УстановитьПараметр("Ставка35", 			Перечисления.НДФЛСтавкиНалогообложенияРезидента.Ставка35);*/
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	СУММА(СтрокиНДФЛ.НалогПоСтавке13) КАК Налог,
	|	ВЫБОР
	|		КОГДА ЕСТЬNULL(НДФЛКЗачету.СуммаНДФЛКЗачетуОстаток, 0) > ВЫБОР
	|				КОГДА СУММА(СтрокиНДФЛ.НалогПоСтавке13) > 0
	|					ТОГДА СУММА(СтрокиНДФЛ.НалогПоСтавке13)
	|				ИНАЧЕ 0
	|			КОНЕЦ
	|			ТОГДА СУММА(СтрокиНДФЛ.НалогПоСтавке13)
	|		ИНАЧЕ ЕСТЬNULL(НДФЛКЗачету.СуммаНДФЛКЗачетуОстаток, 0)
	|	КОНЕЦ КАК НДФЛКЗачетуУчтено,
	|	СтрокиНДФЛ.ФизЛицо,
	|	&Ставка13 КАК СтавкаНалогообложенияРезидента
	|ИЗ
	|	Документ.НДФЛПерерасчет.РаботникиОрганизации КАК СтрокиНДФЛ
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрНакопления.НДФЛКЗачету.Остатки(
	|		&ПериодРегистрации,
	|		Физлицо В
	|				(ВЫБРАТЬ РАЗЛИЧНЫЕ
	|					НДФЛПерерасчетРаботникиОрганизации.ФизЛицо
	|				ИЗ
	|					Документ.НДФЛПерерасчет.РаботникиОрганизации КАК НДФЛПерерасчетРаботникиОрганизации
	|				ГДЕ
	|					НДФЛПерерасчетРаботникиОрганизации.Ссылка = &ДокументСсылка)
	|			И Организация = &Организация) КАК НДФЛКЗачету
	|		ПО НДФЛКЗачету.ФизЛицо = СтрокиНДФЛ.ФизЛицо
	|ГДЕ
	|	СтрокиНДФЛ.Ссылка = &ДокументСсылка
	|
	|СГРУППИРОВАТЬ ПО
	|	СтрокиНДФЛ.ФизЛицо,
	|	НДФЛКЗачету.СуммаНДФЛКЗачетуОстаток
	|
	|ИМЕЮЩИЕ
	|	(СУММА(СтрокиНДФЛ.НалогПоСтавке13) < 0
	|		ИЛИ ВЫБОР
	|			КОГДА ЕСТЬNULL(НДФЛКЗачету.СуммаНДФЛКЗачетуОстаток, 0) > ВЫБОР
	|					КОГДА СУММА(СтрокиНДФЛ.НалогПоСтавке13) > 0
	|						ТОГДА СУММА(СтрокиНДФЛ.НалогПоСтавке13)
	|					ИНАЧЕ 0
	|				КОНЕЦ
	|				ТОГДА СУММА(СтрокиНДФЛ.НалогПоСтавке13)
	|			ИНАЧЕ ЕСТЬNULL(НДФЛКЗачету.СуммаНДФЛКЗачетуОстаток, 0)
	|		КОНЕЦ <> 0)
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	СУММА(СтрокиНДФЛ.НалогПоСтавке09),
	|	0,
	|	СтрокиНДФЛ.ФизЛицо,
	|	&Ставка09
	|ИЗ
	|	Документ.НДФЛПерерасчет.РаботникиОрганизации КАК СтрокиНДФЛ
	|ГДЕ
	|	СтрокиНДФЛ.Ссылка = &ДокументСсылка
	|
	|СГРУППИРОВАТЬ ПО
	|	СтрокиНДФЛ.ФизЛицо
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	СУММА(СтрокиНДФЛ.НалогПоСтавке35),
	|	0,
	|	СтрокиНДФЛ.ФизЛицо,
	|	&Ставка35
	|ИЗ
	|	Документ.НДФЛПерерасчет.РаботникиОрганизации КАК СтрокиНДФЛ
	|ГДЕ
	|	СтрокиНДФЛ.Ссылка = &ДокументСсылка
	|
	|СГРУППИРОВАТЬ ПО
	|	СтрокиНДФЛ.ФизЛицо";*/
			return null;
		}
		// СформироватьЗапросПоНДФЛКЗачету

		public object СформироватьЗапросПоНДФЛудержанный(/*ЭтотОбъект*/)
		{
			/*Запрос = Новый Запрос;*/
			/*// Установим параметры запроса
*/
			/*Запрос.УстановитьПараметр("ДокументСсылка", 	ЭтотОбъект.Ссылка);*/
			/*Запрос.УстановитьПараметр("Организация", 		ЭтотОбъект.Организация);*/
			/*Запрос.УстановитьПараметр("ПериодРегистрации", 	ЭтотОбъект.ПериодВзаиморасчетов);*/
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	СУММА(СтрокиНДФЛ.НалогПоСтавке13) КАК Налог,
	|	СтрокиНДФЛ.ФизЛицо КАК ФизЛицо,
	|	СтрокиНДФЛ.ПодразделениеОрганизации,
	|	ЗНАЧЕНИЕ(Перечисление.НДФЛСтавкиНалогообложенияРезидента.Ставка13) КАК СтавкаНалогообложенияРезидента
	|ИЗ
	|	Документ.НДФЛПерерасчет.РаботникиОрганизации КАК СтрокиНДФЛ
	|ГДЕ
	|	СтрокиНДФЛ.Ссылка = &ДокументСсылка
	|
	|СГРУППИРОВАТЬ ПО
	|	СтрокиНДФЛ.ФизЛицо,
	|	СтрокиНДФЛ.ПодразделениеОрганизации
	|
	|ИМЕЮЩИЕ
	|	СУММА(СтрокиНДФЛ.НалогПоСтавке13) > 0
	|
	|УПОРЯДОЧИТЬ ПО
	|	ФизЛицо";*/
			return null;
		}
		// СформироватьЗапросПоНДФЛудержанный()
		// По строке выборок из результатов запроса по документу формируем движения по регистрам
		//
		// Параметры:
		//  ВыборкаПоСтрокамДокумента	- спозиционированная на определенной строке выборка
		//				  				  из результата запроса к ТЧ документа,
		//  ВыборкаПоШапкеДокумента		- выборка по данным шапки документа
		//	НаборЗаписей				- набор записей для НДФЛРасчетыСБюджетом
		//
		// Возвращаемое значение:
		//  Нет.
		//

		public void ДобавитьСтрокуНДФЛКЗачету(/*ЭтотОбъект, ВыборкаПоСтрокамДокумента, ВыборкаПоШапкеДокумента*/)
		{
			/*// НДФЛ к зачету
*/
			if(true/*ВыборкаПоСтрокамДокумента.Налог < 0*/)
			{
				/*Движение = ЭтотОбъект.Движения.НДФЛКЗачету.Добавить();*/
				/*// Свойства
*/
				/*Движение.Период						= ВыборкаПоШапкеДокумента.Дата;*/
				/*Движение.ВидДвижения				= ВидДвиженияНакопления.Приход;*/
				/*// Измерения
*/
				/*Движение.ФизЛицо                        = ВыборкаПоСтрокамДокумента.ФизЛицо;*/
				/*Движение.Организация				    = ВыборкаПоШапкеДокумента.Организация;*/
				/*Движение.СтавкаНалогообложенияРезидента	= ВыборкаПоСтрокамДокумента.СтавкаНалогообложенияРезидента;*/
				/*// Ресурсы
*/
				/*Движение.СуммаНДФЛКЗачету			= - ВыборкаПоСтрокамДокумента.Налог;*/
			}
		}
		// ДобавитьСтрокуНДФЛКЗачету

		public void ОбработкаПроведенияДополнительно(/*ЭтотОбъект, ВыборкаПоШапкеДокумента, Отказ, Режим, Заголовок*/)
		{
			/*// проверим строки табличной части РаботникиОрганизации
*/
			/*ПроверитьЗаполнениеРаботникиОрганизации(ЭтотОбъект, Отказ, Заголовок);*/
			/*// Движения стоит добавлять, если в проведении еще не отказано (отказ = ложь)
*/
			if(true/*НЕ Отказ*/)
			{
				/*// получим учетную политику
*/
				/*УпрощенныйУчетНДФЛ = ПроцедурыУправленияПерсоналом.ЗначениеУчетнойПолитикиПоПерсоналуОрганизации(глЗначениеПеременной("глУчетнаяПолитикаПоПерсоналуОрганизации"), ЭтотОбъект.Организация, "УпрощенныйУчетНДФЛ");*/
				/*СформироватьВзаиморасчетыСБюджетом(ЭтотОбъект, ВыборкаПоШапкеДокумента);*/
				/*СформироватьВзаиморасчетыСРаботниками(ЭтотОбъект, ВыборкаПоШапкеДокумента);*/
				/*// Вычеты предоставленные (стандартные и имущественные)
*/
				/*ЭтотОбъект.СформироватьВычетыПоНДФЛ(ВыборкаПоШапкеДокумента, УпрощенныйУчетНДФЛ, Отказ, Заголовок);*/
				/*// НДФЛ к зачету
*/
				/*// получим реквизиты табличной части
*/
				if(true/*НЕ Отказ*/)
				{
					/*ВыборкаПоНДФЛКЗачету = СформироватьЗапросПоНДФЛКЗачету(ЭтотОбъект).Выбрать();*/
					while(true/*ВыборкаПоНДФЛКЗачету.Следующий()*/)
					{
						/*// Заполним записи в наборах записей регистров
*/
						/*ДобавитьСтрокуНДФЛКЗачету(ЭтотОбъект, ВыборкаПоНДФЛКЗачету, ВыборкаПоШапкеДокумента);*/
					}
					if(true/*УпрощенныйУчетНДФЛ*/)
					{
						/*ВыборкаПоНДФЛуд = СформироватьЗапросПоНДФЛудержанный(ЭтотОбъект).Выбрать();*/
						while(true/*ВыборкаПоНДФЛуд.Следующий()*/)
						{
							/*// Заполним записи в наборах записей регистров
*/
							/*ЭтотОбъект.ДобавитьСтрокуНДФЛудержанный(ВыборкаПоНДФЛуд, ВыборкаПоНДФЛКЗачету, ВыборкаПоШапкеДокумента);*/
						}
						/*;;*/
					}
				}
			}
		}

		public void ДополнитьСтруктуруПоиска(/*СтруктураПоиска*/)
		{
			/*// В этой конфигурации структура поиска не дополняется
*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы документа
	}
}

