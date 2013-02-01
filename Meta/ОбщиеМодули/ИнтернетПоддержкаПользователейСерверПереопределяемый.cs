﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ИнтернетПоддержкаПользователейСерверПереопределяемый
	{
		// Переопределяет наличие регламентированной отчетности в данной конфигураци.
		//
		// Параметры:
		//	Наличие - Булево - Истина, если есть регламентированная отчетность, Ложь - иначе. (По умолчанию Истина)
		//

		public void НаличиеРегОтчетности(/*Наличие*/)
		{
			/*Наличие = Истина;*/
		}
		// Переопределяет условное имя конфигурации, необходимо только для регламентированной отчетности.
		//
		// Параметры:
		// 	УсловноеИмяКонфигурации - Строка - условное имя конфигурации.
		//

		public void ПолучитьУсловноеИмяКонфигурации(/*УсловноеИмяКонфигурации*/)
		{
			/*УсловноеИмяКонфигурации = РегламентированнаяОтчетность.ИДКонфигурации();*/
		}
		// Переопределяет версию обработки "Обновление конфигурации".
		//
		// Параметры:
		//	Версия - Строка - версия обработки.
		//
		// Пример для БП:
		//	Версия = Обработки.ОбновлениеКонфигурации.Создать().Метаданные().Комментарий;
		//

		public void ПолучитьВерсиюОбработкиОбновленияКонфигурации(/*Версия*/)
		{
			/*Версия = Обработки.ОбновлениеКонфигурации.Создать().Метаданные().Комментарий;*/
		}
		// Процедура получает таблицу значений регламентированной отчетности.
		//
		// Параметры:
		//	ТаблицаРезультатаЗапроса - ТаблицаЗначений с колонками:
		//		ВерсияОтчета - Строка - версия внешнего отчета.
		//		НаименованияОтчета - Строка - источник отчета.
		//		Наименование - Строка - наименование отчета.
		//

		public void ПолучитьРегламентированныеОтчеты(/*ТаблицаРезультатаЗапроса*/)
		{
			/*Запрос = Новый Запрос;*/
			/*Запрос.Текст = "ВЫБРАТЬ
		|	РегламентированныеОтчеты.ВнешнийОтчетВерсия КАК ВерсияОтчета,
		|	РегламентированныеОтчеты.ИсточникОтчета КАК НаименованияОтчета,
		|	РегламентированныеОтчеты.Наименование как Наименование
		|ИЗ
		|	Справочник.РегламентированныеОтчеты КАК РегламентированныеОтчеты
		|ГДЕ
		|	РегламентированныеОтчеты.ПометкаУдаления = &ПометкаУдаления
		|	И РегламентированныеОтчеты.НеПоказыватьВСписке = &НеПоказыватьВСписке
		|	И РегламентированныеОтчеты.ВнешнийОтчетИспользовать = &ВнешнийОтчетИспользовать";*/
			/*Запрос.УстановитьПараметр("ПометкаУдаления",			Ложь);*/
			/*Запрос.УстановитьПараметр("НеПоказыватьВСписке",		Ложь);*/
			/*Запрос.УстановитьПараметр("ВнешнийОтчетИспользовать",	Истина);*/
			/*ТаблицаРезультатаЗапроса = Запрос.Выполнить().Выгрузить();*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ РАБОТЫ С ЭЛЕКТРОННЫМ ДОКУМЕНТООБОРОТОМ
		// Процедура полцчения пароля к закрытому ключу ЭЦП
		//
		// Параметры
		//	СертификатЭЦП - СправочникСсылкаСертификатЭЦП - ссылка сертификата ЭЦП
		//	ПарольДоступаЭЦП - Строка - пароль доступа
		//

		public void ОпределитьСохраненныйПарольСертификатаЭЦП(/*СертификатЭЦП, ПарольДоступаЭЦП*/)
		{
			if(true/*СертификатЭЦП.ЗапомнитьПарольКСертификату*/)
			{
				/*ПарольДоступаЭЦП = СертификатЭЦП.ПарольПользователя;*/
			}
		}
		// Процедура рашифровки зашифрованного маркера, полученного с сервера на основе выбранного сертификата
		//
		// Параметры
		//	ЗашифрованныеДвоичныеДанные - зашифрованные двоичные данные, полученные с сервера
		//	СертификатЭЦП - выбранный сертификат, при помощи которого было выполнено шифрование
		//	МаркерИдентификации - возвращаемый расшифрованный маркер идентификации
		//

		public void РасшифроватьМаркерИдентификацииВладельцаСертификата(/*ЗашифрованныеДвоичныеДанные, СертификатЭЦП, МаркерИдентификации, Знач ПарольДоступа*/)
		{
			/*// Инициализация менеджера криптографии
*/
			/*НастройкиКриптографии  = ЭлектроннаяЦифроваяПодпись.ПолучитьПерсональныеНастройкиРаботыСЭЦПСервер();*/
			/*ПровайдерЭЦП           = НастройкиКриптографии.ПровайдерЭЦП;*/
			/*ПутьМодуляКриптографии = НастройкиКриптографии.ПутьМодуляКриптографии;*/
			/*ТипПровайдераЭЦП       = НастройкиКриптографии.ТипПровайдераЭЦП;*/
			/*Попытка
		МенеджерКриптографии = Новый МенеджерКриптографии(ПровайдерЭЦП, ПутьМодуляКриптографии, ТипПровайдераЭЦП);*/
			/*МенеджерКриптографии.АлгоритмПодписи     = НастройкиКриптографии.АлгоритмПодписи;*/
			/*МенеджерКриптографии.АлгоритмХеширования = НастройкиКриптографии.АлгоритмХеширования;*/
			/*МенеджерКриптографии.АлгоритмШифрования  = НастройкиКриптографии.АлгоритмШифрования;*/
			/*// менеджер криптографии генерирует ошибку при создании, если заданы неправильно настройки, либо
*/
			/*// отсутствует ПО криптопровайдера
*/
			/*КонецПопытки;*/
			/*МенеджерКриптографии.ПарольДоступаКЗакрытомуКлючу = ПарольДоступа;*/
			/*// Расшифровка
*/
			/*Попытка
		РасшифрованныеДвоичныеДанные = МенеджерКриптографии.Расшифровать(ЗашифрованныеДвоичныеДанные);*/
			/*Исключение
		МаркерИдентификации = "НесовпадениеПароля";*/
			/*КонецПопытки;*/
			/*ИмяФайлаДвоичныхДанных = ПолучитьИмяВременногоФайла("txt");*/
			/*РасшифрованныеДвоичныеДанные.Записать(ИмяФайлаДвоичныхДанных);*/
			/*ТекстовыйДок = Новый ТекстовыйДокумент;*/
			/*ТекстовыйДок.Прочитать(ИмяФайлаДвоичныхДанных);*/
			/*МаркерИдентификации = ТекстОвыйДок.ПолучитьТекст();*/
			/*Попытка
		УдалитьФайлы(ИмяФайлаДвоичныхДанных);*/
			/*Исключение
	КонецПопытки;*/
		}
		// Процедура заполняет данные для заполнения формы регистрации на основании выбранной организации
		//
		// Параметры
		//	Организация - ссылка справочника Организация
		//	ВозвращаемаяСтруктура - возвращаемая структура с данными об организации
		//

		public void ПолучитьРегистрационныеДанныеОрганизации(/*Организация, ВозвращаемаяСтруктура*/)
		{
			/*ПакетЗапросов = Новый Запрос;*/
			/*ПакетЗапросов.Текст = 
	"ВЫБРАТЬ ПЕРВЫЕ 1
	|	КонтактнаяИнформация.Вид,
	|	КонтактнаяИнформация.Поле1 КАК Индекс,
	|	КонтактнаяИнформация.Поле2 КАК Регион,
	|	КонтактнаяИнформация.Поле3 КАК Район,
	|	КонтактнаяИнформация.Поле4 КАК Город,
	|	КонтактнаяИнформация.Поле5 КАК НаселенныйПункт,
	|	КонтактнаяИнформация.Поле6 КАК Улица,
	|	КонтактнаяИнформация.Поле7 КАК Дом,
	|	КонтактнаяИнформация.Поле8 КАК Корпус,
	|	КонтактнаяИнформация.Поле9 КАК Квартира
	|ИЗ
	|	РегистрСведений.КонтактнаяИнформация КАК КонтактнаяИнформация
	|ГДЕ
	|	КонтактнаяИнформация.Объект = &Организация
	|	И КонтактнаяИнформация.Тип = ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Адрес)
	|
	|УПОРЯДОЧИТЬ ПО
	|	КонтактнаяИнформация.Вид
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	КонтактнаяИнформация.Объект,
	|	КонтактнаяИнформация.Представление КАК Телефон
	|ИЗ
	|	РегистрСведений.КонтактнаяИнформация КАК КонтактнаяИнформация
	|ГДЕ
	|	КонтактнаяИнформация.Объект = &Организация
	|	И КонтактнаяИнформация.Тип = ЗНАЧЕНИЕ(Перечисление.ТипыКонтактнойИнформации.Телефон)
	|
	|УПОРЯДОЧИТЬ ПО
	|	КонтактнаяИнформация.Вид УБЫВ
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	Организации.НаименованиеСокращенное КАК Наименование,
	|	ВЫБОР
	|		КОГДА Организации.ЮрФизЛицо = ЗНАЧЕНИЕ(Перечисление.ЮрФизЛицо.ФизЛицо)
	|			ТОГДА ""ФизЛицо""
	|		ИНАЧЕ ""ЮрЛицо""
	|	КОНЕЦ               КАК ЮрФизЛицо,
	|	Организации.ИНН     КАК ИНН,
	|	Организации.КПП     КАК КПП,
	|	Организации.ОГРН    КАК ОГРН,
	|	Организации.КодИМНС КАК КодИМНС
	|ИЗ
	|	Справочник.Организации КАК Организации
	|ГДЕ
	|	Организации.Ссылка = &Организация
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ФИОФиз.Фамилия  КАК Фамилия,
	|	ФИОФиз.Имя      КАК Имя,
	|	ФИОФиз.Отчество КАК Отчество
	|ИЗ
	|	РегистрСведений.ОтветственныеЛицаОрганизаций.СрезПоследних КАК ОтвЛица
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ РегистрСведений.ФИОФизЛиц.СрезПоследних КАК ФИОФиз
	|		ПО (ФИОФиз.ФизЛицо = ОтвЛица.ФизическоеЛицо)
	|ГДЕ
	|	ОтвЛица.СтруктурнаяЕдиница = &Организация
	|	И ОтвЛица.ОтветственноеЛицо = ЗНАЧЕНИЕ(Перечисление.ОтветственныеЛицаОрганизаций.Руководитель)";*/
			/*ПакетЗапросов.Параметры.Вставить("Организация", Организация);*/
			/*МассивРезультатов = ПакетЗапросов.ВыполнитьПакет();*/
			/*// Возвращаемая структура должна содержать все перечисленные ниже
*/
			/*// ключи и их значения - строки
*/
			/*// Проверка свойств в дальнейшем не выполняется
*/
			/*ВозвращаемаяСтруктура.Очистить();*/
			/*ВозвращаемаяСтруктура.Вставить("ОрганизацияСсылка", Организация);*/
			/*ВыборкаАдреса = МассивРезультатов[0].Выбрать();*/
			if(true/*ВыборкаАдреса.Следующий()*/)
			{
				/*ВозвращаемаяСтруктура.Вставить("Индекс"         , ВыборкаАдреса.Индекс);*/
				/*ВозвращаемаяСтруктура.Вставить("Регион"         , ВыборкаАдреса.Регион);*/
				/*ВозвращаемаяСтруктура.Вставить("Район"          , ВыборкаАдреса.Район);*/
				/*ВозвращаемаяСтруктура.Вставить("Город"          , ВыборкаАдреса.Город);*/
				/*ВозвращаемаяСтруктура.Вставить("НаселенныйПункт", ВыборкаАдреса.НаселенныйПункт);*/
				/*ВозвращаемаяСтруктура.Вставить("Улица"          , ВыборкаАдреса.Улица);*/
				/*ВозвращаемаяСтруктура.Вставить("Дом"            , ВыборкаАдреса.Дом);*/
				/*ВозвращаемаяСтруктура.Вставить("Корпус"         , ВыборкаАдреса.Корпус);*/
				/*ВозвращаемаяСтруктура.Вставить("Квартира"       , ВыборкаАдреса.Квартира);*/
			}
			/*ВыборкаТелефона = МассивРезультатов[1].Выбрать();*/
			if(true/*ВыборкаТелефона.Следующий()*/)
			{
				/*ВозвращаемаяСтруктура.Вставить("Телефон", ВыборкаТелефона.Телефон);*/
			}
			/*ВыборкаСведенияОбОрганизации = МассивРезультатов[2].Выбрать();*/
			if(true/*ВыборкаСведенияОбОрганизации.Следующий()*/)
			{
				/*ВозвращаемаяСтруктура.Вставить("Наименование", ВыборкаСведенияОбОрганизации.Наименование);*/
				/*ВозвращаемаяСтруктура.Вставить("ИНН"         , ВыборкаСведенияОбОрганизации.ИНН);*/
				/*ВозвращаемаяСтруктура.Вставить("КПП"         , ВыборкаСведенияОбОрганизации.КПП);*/
				/*ВозвращаемаяСтруктура.Вставить("ОГРН"        , ВыборкаСведенияОбОрганизации.ОГРН);*/
				/*ВозвращаемаяСтруктура.Вставить("КодИМНС"     , ВыборкаСведенияОбОрганизации.КодИМНС);*/
				/*ВозвращаемаяСтруктура.Вставить("ЮрФизЛицо"   , ВыборкаСведенияОбОрганизации.ЮрФизЛицо);*/
			}
			/*ВыборкаФИОРуководителя = МассивРезультатов[3].Выбрать();*/
			if(true/*ВыборкаФИОРуководителя.Следующий()*/)
			{
				/*ВозвращаемаяСтруктура.Вставить("Фамилия" , ВыборкаФИОРуководителя.Фамилия);*/
				/*ВозвращаемаяСтруктура.Вставить("Имя"     , ВыборкаФИОРуководителя.Имя);*/
				/*ВозвращаемаяСтруктура.Вставить("Отчество", ВыборкаФИОРуководителя.Отчество);*/
			}
		}
		// Процедура возвращающая двоичные данные выбранного сертификата
		//
		// Параметры
		//	СертификатЭЦп - выбранный сертификат - ссылка
		//	ДвоичныеДанныеСертификата - Двоичные данные сертификата
		//

		public void ПолучитьДвоичныеДанныеСертификата(/*СертификатЭЦП, ДвоичныеДанныеСертификата*/)
		{
			/*Попытка
		ДвоичныеДанныеСертификата = СертификатЭЦП.ФайлСертификата.Получить();*/
			/*Исключение
		
	КонецПопытки;*/
		}
		// Процедура передает в обработку тип значения справочника сертификатов ЭЦП
		//

		public void ОписаниеТиповСправочникаСертификатовЭД(/*ОписаниеТиповСертификатаЭЦП*/)
		{
			/*ОписаниеТиповСертификатаЭЦП = Новый ОписаниеТипов("СправочникСсылка.СертификатыЭЦП");*/
		}
		// Процедура поиска элемента справочника СертификатыЭЦП по отпечатку
		// Параметры:
		//	Отпечаток - Строка - строка отпечатка
		//	СсылкаСправочникаЭЦП - СправочникСсылкаСертификатыЭЦП - найденная ссылка справочника сертификата ЭЦП
		//

		public void НайтиСертификатЭЦППоОтпечатку(/*Отпечаток, СсылкаСправочникаЭЦП*/)
		{
			/*Запрос = Новый Запрос;*/
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	СертификатыЭЦП.Ссылка КАК Ссылка
	|ИЗ
	|	Справочник.СертификатыЭЦП КАК СертификатыЭЦП
	|ГДЕ
	|	СертификатыЭЦП.Отпечаток = &Отпечаток";*/
			/*Запрос.Параметры.Вставить("Отпечаток", Отпечаток);*/
			/*Выборка = Запрос.Выполнить().Выбрать();*/
			if(true/*Выборка.Следующий()*/)
			{
				/*СсылкаСправочникаЭЦП = Выборка.Ссылка;*/
			}
		}
		// Процедура Получения отпечатка сертификата
		// Параметры
		// СертификатЭЦП - ссылка на справочник сертификатов
		// ОтпечатокСертификата - Отпечаток сертификата
		//

		public void ПолучитьОтпечатокСертификата(/*СертификатЭЦП, ОтпечатокСертификата*/)
		{
			if(true/*ТипЗнч(СертификатЭЦП) = Тип("СправочникСсылка.СертификатыЭЦП") И ЗначениеЗаполнено(СертификатЭЦП)*/)
			{
				/*ОтпечатокСертификата = СертификатЭЦП.Отпечаток;*/
			}
		}
	}
}

