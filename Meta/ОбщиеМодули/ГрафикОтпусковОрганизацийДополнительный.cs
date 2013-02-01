﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ГрафикОтпусковОрганизацийДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		// Возвращает общую часть запроса, используемого для автозаполнения документа
		//
		// Параметры
		//  нет
		//
		// Возвращаемое значение:
		//   строка
		//

		public object ПолучитьТекстЗапросаАвтозаполнения(/**/)
		{
			/*СтрокаЗапроса = 
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	СотрудникиОрганизаций.Ссылка КАК Ссылка,
	|	СотрудникиОрганизаций.Физлицо
	|ПОМЕСТИТЬ ВТСотрудники
	|ИЗ
	|	Справочник.СотрудникиОрганизаций КАК СотрудникиОрганизаций
	|ГДЕ
	|	СотрудникиОрганизаций.Организация = &ГоловнаяОрганизация
	|	И СотрудникиОрганизаций.ВидДоговора = ЗНАЧЕНИЕ(Перечисление.ВидыДоговоровСФизЛицами.ТрудовойДоговор)
	|	И СотрудникиОрганизаций.Физлицо В
	|			(ВЫБРАТЬ
	|				ФизЛица.ФизЛицо
	|			ИЗ
	|				ВТФизЛица КАК ФизЛица)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Ссылка";*/
			/*ГрафикОтпусковПереопределяемый.ТекстЗапросаАвтозаполненияДополнительно(СтрокаЗапроса);*/
			/*СтрокаЗапроса = СтрокаЗапроса + ";" + 
	"ВЫБРАТЬ РАЗЛИЧНЫЕ
	|	СобытийныйПланЗанятостиФизлиц.Период КАК ДатаНачала,
	|	СобытийныйПланЗанятостиФизлиц.ПериодЗавершения КАК ДатаОкончания,
	|	СобытийныйПланЗанятостиФизлиц.ФизЛицо КАК ФизЛицо,
	|	РаботникиОрганизацииСрезПоследних.Сотрудник,
	|	РаботникиОрганизацииСрезПоследних.Сотрудник.Наименование КАК СотрудникНаименование
	|ИЗ
	|	ВТФизЛица КАК СобытийныйПланЗанятостиФизлиц
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.РаботникиОрганизаций.СрезПоследних(
	|				&ДатаАктуальности,
	|				Организация = &ГоловнаяОрганизация
	|					И Сотрудник В
	|						(ВЫБРАТЬ РАЗЛИЧНЫЕ
	|							СотрудникиОрганизаций.Ссылка
	|						ИЗ
	|							ВТСотрудники КАК СотрудникиОрганизаций)) КАК РаботникиОрганизацииСрезПоследних
	|		ПО СобытийныйПланЗанятостиФизлиц.ФизЛицо = РаботникиОрганизацииСрезПоследних.Сотрудник.Физлицо
	|			И (ВЫБОР
	|				КОГДА РаботникиОрганизацииСрезПоследних.ПериодЗавершения <= &ДатаАктуальности
	|						И РаботникиОрганизацииСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|					ТОГДА РаботникиОрганизацииСрезПоследних.ОбособленноеПодразделениеЗавершения
	|				ИНАЧЕ РаботникиОрганизацииСрезПоследних.ОбособленноеПодразделение
	|			КОНЕЦ = &Организация)
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ГрафикОтпусковОрганизаций КАК ГрафикОтпусковОрганизаций
	|		ПО (РаботникиОрганизацииСрезПоследних.Сотрудник = ГрафикОтпусковОрганизаций.Сотрудник)
	|			И (СобытийныйПланЗанятостиФизлиц.Период МЕЖДУ ГрафикОтпусковОрганизаций.Период И ГрафикОтпусковОрганизаций.ДатаОкончания
	|				ИЛИ СобытийныйПланЗанятостиФизлиц.ПериодЗавершения МЕЖДУ ГрафикОтпусковОрганизаций.Период И ГрафикОтпусковОрганизаций.ДатаОкончания)
	|			И (ГрафикОтпусковОрганизаций.Регистратор <> &Ссылка)
	|ГДЕ
	|	РаботникиОрганизацииСрезПоследних.Сотрудник ЕСТЬ НЕ NULL 
	|	И ГрафикОтпусковОрганизаций.Период ЕСТЬ NULL 
	|
	|УПОРЯДОЧИТЬ ПО
	|	СотрудникНаименование";*/
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		// Заполняет табличную часть документа отпусками по утвержденным отпускам управленческого учета
		//
		// Параметры
		//  Объект - ДокументОбъект.ГрафикОтпусковОрганизаций, заполняемый документ
		//	ДатаНачала, ДатаОкончания	- даты начала и окончания
		//								  просмотра графика отпусков
		//

		public void Автозаполнение(/*Объект, ДатаНачала, ДатаОкончания*/)
		{
			/*Запрос = Новый Запрос;*/
			/*Запрос.МенеджерВременныхТаблиц = Новый МенеджерВременныхТаблиц;*/
			/*Запрос.УстановитьПараметр("ГоловнаяОрганизация",	ОбщегоНазначения.ГоловнаяОрганизация(Объект.Организация));*/
			/*Запрос.УстановитьПараметр("Организация",			Объект.Организация);*/
			/*Запрос.УстановитьПараметр("ДатаАктуальности",		ДатаОкончания);*/
			/*Запрос.УстановитьПараметр("ДатаНачала",				ДатаНачала);*/
			/*Запрос.УстановитьПараметр("ДатаОкончания",			ДатаОкончания);*/
			/*Запрос.УстановитьПараметр("Ссылка",					Объект.Ссылка);*/
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	СобытийныйПланЗанятостиФизлиц.Период,
	|	СобытийныйПланЗанятостиФизлиц.ПериодЗавершения,
	|	СобытийныйПланЗанятостиФизлиц.ФизЛицо КАК ФизЛицо
	|ПОМЕСТИТЬ ВТФизЛица
	|ИЗ
	|	РегистрСведений.СобытийныйПланЗанятостиФизлиц КАК СобытийныйПланЗанятостиФизлиц
	|ГДЕ
	|	СобытийныйПланЗанятостиФизлиц.Период МЕЖДУ &ДатаНачала И &ДатаОкончания
	|	И СобытийныйПланЗанятостиФизлиц.Состояние = ЗНАЧЕНИЕ(Перечисление.ТипыПериодическихЗадачРаботника.ОтпускЕжегодный)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ФизЛицо";*/
			/*Результат = Запрос.Выполнить().Выгрузить();*/
			if(true/*Результат[0].Количество = 0*/)
			{
				/*// нет данных
*/
			}
			/*Запрос.Текст = ПолучитьТекстЗапросаАвтозаполнения();*/
			/*Объект.РаботникиОрганизации.Загрузить(Запрос.Выполнить().Выгрузить());*/
		}
	}
}

