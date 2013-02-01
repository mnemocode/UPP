﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеИНПАСЭквайринговыеТерминалы
	{
		///////////////////////////////////////////////////////////////////////////////
		// ПРОГРАММНЫЙ ИНТЕРФЕЙС
		// Функция осуществляет подключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера   - <*>
		//           - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ПодключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Проверка настроенных параметров
*/
			/*АдресСА         = Неопределено;*/
			/*ПортСА          = Неопределено;*/
			/*СкриптX25       = Неопределено;*/
			/*ТаймаутACK      = Неопределено;*/
			/*ТаймаутСА       = Неопределено;*/
			/*ЧислоNAK        = Неопределено;*/
			/*РазмерПакета    = Неопределено;*/
			/*ТаймаутОперации = Неопределено;*/
			/*АдресКУ                = Неопределено;*/
			/*ПортКУ                 = Неопределено;*/
			/*ТаймаутКУ              = Неопределено;*/
			/*ИдентификаторТерминала = Неопределено;*/
			/*COMПортДО              = Неопределено;*/
			/*СкоростьОбменаСДО      = Неопределено;*/
			/*РазмерДанныхДО         = Неопределено;*/
			/*ЧетностьДО             = Неопределено;*/
			/*СтопБитыДО             = Неопределено;*/
			/*УправлениеПотокомДО    = Неопределено;*/
			/*ШиринаСлипЧека          = Неопределено;*/
			/*КоличествоКопийСлипчека = Неопределено;*/
			/*ДанныеМакетаСлипЧека    = Неопределено;*/
			/*Параметры.Свойство("АдресСА",         АдресСА);*/
			/*Параметры.Свойство("ПортСА",          ПортСА);*/
			/*Параметры.Свойство("СкриптX25",       СкриптX25);*/
			/*Параметры.Свойство("ТаймаутACK",      ТаймаутACK);*/
			/*Параметры.Свойство("ТаймаутСА",       ТаймаутСА);*/
			/*Параметры.Свойство("ЧислоNAK",        ЧислоNAK);*/
			/*Параметры.Свойство("РазмерПакета",    РазмерПакета);*/
			/*Параметры.Свойство("ТаймаутОперации", ТаймаутОперации);*/
			/*Параметры.Свойство("АдресКУ",                АдресКУ);*/
			/*Параметры.Свойство("ПортКУ",                 ПортКУ);*/
			/*Параметры.Свойство("ТаймаутКУ",              ТаймаутКУ);*/
			/*Параметры.Свойство("ИдентификаторТерминала", ИдентификаторТерминала);*/
			/*Параметры.Свойство("COMПортДО",              COMПортДО);*/
			/*Параметры.Свойство("СкоростьОбменаСДО",      СкоростьОбменаСДО);*/
			/*Параметры.Свойство("РазмерДанныхДО",         РазмерДанныхДО);*/
			/*Параметры.Свойство("ЧетностьДО",             ЧетностьДО);*/
			/*Параметры.Свойство("СтопБитыДО",             СтопБитыДО);*/
			/*Параметры.Свойство("УправлениеПотокомДО",    УправлениеПотокомДО);*/
			/*Параметры.Свойство("ШиринаСлипЧека",          ШиринаСлипЧека);*/
			/*Параметры.Свойство("КоличествоКопийСлипчека", КоличествоКопийСлипчека);*/
			/*Параметры.Свойство("ДанныеМакетаСлипЧека",    ДанныеМакетаСлипЧека);*/
			if(true/*АдресСА                 = Неопределено
	 Или ПортСА                  = Неопределено
	 Или СкриптX25               = Неопределено
	 Или ТаймаутACK              = Неопределено
	 Или ТаймаутСА               = Неопределено
	 Или ЧислоNAK                = Неопределено
	 Или РазмерПакета            = Неопределено
	 Или ТаймаутОперации         = Неопределено
	 Или АдресКУ                 = Неопределено
	 Или ПортКУ                  = Неопределено
	 Или ТаймаутКУ               = Неопределено
	 Или ИдентификаторТерминала  = Неопределено
	 Или COMПортДО               = Неопределено
	 Или СкоростьОбменаСДО       = Неопределено
	 Или РазмерДанныхДО          = Неопределено
	 Или ЧетностьДО              = Неопределено
	 Или СтопБитыДО              = Неопределено
	 Или УправлениеПотокомДО     = Неопределено
	 Или ШиринаСлипЧека          = Неопределено
	 Или КоличествоКопийСлипчека = Неопределено
	 Или ДанныеМакетаСлипЧека    = Неопределено*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				/*Результат = Ложь;*/
			}
			/*// Конец: Проверка настроенных параметров
*/
			if(true/*Результат*/)
			{
				/*ПараметрыПодключения.Вставить("КодОригинальнойТранзакции", Неопределено);*/
				/*ПараметрыПодключения.Вставить("ТипТранзакции", "");*/
			}
			return null;
		}
		// Функция осуществляет отключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера - <*>
		//         - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ОтключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Оплата платежной картой
*/
			if(true/*Команда = "AuthorizeSales"*/)
			{
				/*Сумма      = ВходныеПараметры[0];*/
				/*НомерКарты = ВходныеПараметры[1];*/
				/*Результат = ОплатитьПлатежнойКартой(ОбъектДрайвера, Параметры, ПараметрыПодключения,
		                                    Сумма, НомерКарты, ВыходныеПараметры);*/
				/*// Возрат платежа
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция осуществляет авторизацию (оплату) по карте.
		//

		public object ОплатитьПлатежнойКартой(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                Сумма, НомерКарты, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*СсылочныйНомер = "";*/
			/*НомерЧека      = "";*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Оплатить'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*// Преобразование номера карты в код карты и срок действия
*/
			/*КодКарты = "";*/
			/*СрокДействия = "";*/
			if(true/*Не ПустаяСтрока(НомерКарты)*/)
			{
				/*ПозицияРазделителя = Найти(НомерКарты, "=");*/
				if(true/*ПозицияРазделителя > 0*/)
				{
					/*КодКарты     = Лев(НомерКарты, ПозицияРазделителя - 1);*/
					/*СрокДействия = Сред(НомерКарты, ПозицияРазделителя + 1, 4);*/
					/*ОбъектДрайвера.СрокДействияКарты = СрокДействия;*/
				}
			}
			if(true/*Результат*/)
			{
				/*СуммаВременная = Сумма * 100;*/
				/*Ответ = ОбъектДрайвера.ОплатитьПлатежнойКартой(КодКарты,
		                                               СуммаВременная,
		                                               СсылочныйНомер,
		                                               НомерЧека);*/
				if(true/*Не Ответ*/)
				{
					/*ПараметрыПодключения.ТипТранзакции = "Отказ";*/
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
			}
			return null;
		}
		// Функция осуществляет возврат платежа по карте.
		//

		public object ВернутьПлатежПоПлатежнойКарте(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                      Сумма, НомерКарты, СсылочныйНомер, НомерЧека, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*//СсылочныйНомер = Неопределено;
*/
			/*//НомерЧека      = Неопределено;
*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Вернуть платеж'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*// Преобразование номера карты в код карты и срок действия
*/
			/*КодКарты = "";*/
			/*СрокДействия = "";*/
			if(true/*Не ПустаяСтрока(НомерКарты)*/)
			{
				/*ПозицияРазделителя = Найти(НомерКарты, "=");*/
				if(true/*ПозицияРазделителя > 0*/)
				{
					/*КодКарты     = Лев(НомерКарты, ПозицияРазделителя - 1);*/
					/*СрокДействия = Сред(НомерКарты, ПозицияРазделителя + 1, 4);*/
					/*ОбъектДрайвера.СрокДействияКарты = СрокДействия;*/
				}
			}
			if(true/*Результат*/)
			{
				/*СуммаВременная = Сумма * 100;*/
				/*Ответ = ОбъектДрайвера.ВернутьПлатежПоПлатежнойКарте(КодКарты,
		                                                     СуммаВременная,
		                                                     СсылочныйНомер,
		                                                     НомерЧека);*/
				if(true/*Не Ответ*/)
				{
					/*ПараметрыПодключения.ТипТранзакции = "Отказ";*/
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
			}
			return null;
		}
		// Функция осуществляет отмену платежа по карте.
		//

		public object ОтменитьПлатежПоПлатежнойКарте(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                      Сумма, СсылочныйНомер, НомерЧека, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*СсылочныйНомер = Неопределено;*/
			/*НомерЧека      = Неопределено;*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Отменить платеж'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			if(true/*Результат*/)
			{
				/*СуммаВременная = Сумма * 100;*/
				/*Ответ = ОбъектДрайвера.ОтменитьПлатежаПоПлатежнойКарте("",
		                                                       СуммаВременная,
		                                                       СсылочныйНомер);*/
				if(true/*Не Ответ*/)
				{
					/*ПараметрыПодключения.ТипТранзакции = "Отказ";*/
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
			}
			return null;
		}
		// Функция осуществляет аварийную отмену операции по карте.
		//

		public object АварийнаяОтменаОперации(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                Сумма, СсылочныйНомер, НомерЧека, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*ОбъектДрайвера.ИдентификаторОперацииНаТерминале = ПараметрыПодключения.КодОригинальнойТранзакции;*/
			/*СуммаВременная = Сумма * 100;*/
			/*Ответ = ОбъектДрайвера.АварийнаяОтменаОперации("", СуммаВременная * 100, СсылочныйНомер, НомерЧека);*/
			if(true/*Не Ответ*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*Результат = Ложь;*/
			}
			return null;
		}
		// Функция осуществляет сверку итогов по картам.
		//

		public object ИтогиДняПоКартам(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Ответ     = Неопределено;*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Сверка итогов'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*Ответ = ОбъектДрайвера.ИтогиДняПоКартам();*/
			if(true/*Не Ответ*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*Результат = Ложь;*/
			}
			return null;
		}
		// Функция осуществляет преавторизацию по карте.
		//

		public object ПреавторизоватьПоПлатежнойКарте(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                        Сумма, НомерКарты, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*СсылочныйНомер = Неопределено;*/
			/*НомерЧека      = Неопределено;*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Преавторизовать платеж'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*// Преобразование номера карты в код карты и срок действия
*/
			/*КодКарты = "";*/
			/*СрокДействия = "";*/
			if(true/*Не ПустаяСтрока(НомерКарты)*/)
			{
				/*ПозицияРазделителя = Найти(НомерКарты, "=");*/
				if(true/*ПозицияРазделителя > 0*/)
				{
					/*КодКарты     = Лев(НомерКарты, ПозицияРазделителя - 1);*/
					/*СрокДействия = Сред(НомерКарты, ПозицияРазделителя + 1, 4);*/
					/*ОбъектДрайвера.СрокДействияКарты = СрокДействия;*/
				}
			}
			if(true/*Результат*/)
			{
				/*СуммаВременная = Сумма * 100;*/
				/*Ответ = ОбъектДрайвера.ПреавторизацияПоПлатежнойКарте(КодКарты,
		                                                      СуммаВременная,
		                                                      СсылочныйНомер,
		                                                      НомерЧека);*/
				if(true/*Не Ответ*/)
				{
					/*ПараметрыПодключения.ТипТранзакции = "Отказ";*/
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
			}
			return null;
		}
		// Функция осуществляет завершение преавторизации по карте.
		//

		public object ЗавершитьПреавторизациюПоПлатежнойКарте(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                                Сумма, НомерКарты, СсылочныйНомер, НомерЧека, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Завершить преавторизацию'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*// Преобразование номера карты в код карты и срок действия
*/
			/*КодКарты = "";*/
			/*СрокДействия = "";*/
			if(true/*Не ПустаяСтрока(НомерКарты)*/)
			{
				/*ПозицияРазделителя = Найти(НомерКарты, "=");*/
				if(true/*ПозицияРазделителя > 0*/)
				{
					/*КодКарты     = Лев(НомерКарты, ПозицияРазделителя - 1);*/
					/*СрокДействия = Сред(НомерКарты, ПозицияРазделителя + 1, 4);*/
					/*ОбъектДрайвера.СрокДействияКарты = СрокДействия;*/
				}
			}
			if(true/*Результат*/)
			{
				/*СуммаВременная = Сумма * 100;*/
				/*Ответ = ОбъектДрайвера.ЗавершениеПреавторизацииПоПлатежнойКарте(КодКарты,
		                                                                СуммаВременная,
		                                                                СсылочныйНомер,
		                                                                НомерЧека);*/
				if(true/*Не Ответ*/)
				{
					/*ПараметрыПодключения.ТипТранзакции = "Отказ";*/
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
			}
			return null;
		}
		// Функция осуществляет отмену преавторизации по карте.
		//

		public object ОтменитьПреавторизациюПоПлатежнойКарте(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                               Сумма, НомерКарты, СсылочныйНомер, НомерЧека, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ПараметрыПодключения.ТипТранзакции = НСтр("ru='Отменить преавторизацию'");*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*// Преобразование номера карты в код карты и срок действия
*/
			/*КодКарты = "";*/
			/*СрокДействия = "";*/
			if(true/*Не ПустаяСтрока(НомерКарты)*/)
			{
				/*ПозицияРазделителя = Найти(НомерКарты, "=");*/
				if(true/*ПозицияРазделителя > 0*/)
				{
					/*КодКарты     = Лев(НомерКарты, ПозицияРазделителя - 1);*/
					/*СрокДействия = Сред(НомерКарты, ПозицияРазделителя + 1, 4);*/
					/*ОбъектДрайвера.СрокДействияКарты = СрокДействия;*/
				}
			}
			if(true/*Результат*/)
			{
				/*СуммаВременная = Сумма * 100;*/
				/*Ответ = ОбъектДрайвера.ОтменитьПреавторизациюПоПлатежнойКарте(КодКарты,
		                                                              СуммаВременная,
		                                                              СсылочныйНомер);*/
				if(true/*Не Ответ*/)
				{
					/*ПараметрыПодключения.ТипТранзакции = "Отказ";*/
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*КодОперации = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
			}
			return null;
		}
		// Функция осуществляет тестирование устройства.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*РезультатТеста = "";*/
			/*УстановитьПараметрыДрайвера(ОбъектДрайвера, Параметры);*/
			/*Результат = ОбъектДрайвера.ТестУстройства(РезультатТеста);*/
			/*ВыходныеПараметры.Добавить(?(Результат, 0, 999));*/
			/*ВыходныеПараметры.Добавить(РезультатТеста);*/
			return null;
		}
		// Функция возвращает версию установленного драйвера
		//

		public object ПолучитьВерсиюДрайвера(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры.Добавить(НСтр("ru='Установлен'"));*/
			/*ВыходныеПараметры.Добавить(НСтр("ru='Не определена'"));*/
			/*Попытка
		ВыходныеПараметры[1] = ОбъектДрайвера.ПолучитьНомерВерсии();*/
			/*Исключение
	КонецПопытки;*/
			return null;
		}
		// Заполняет массив строками слип-чека для последующей печати на ФР
		//

		public object ПолучитьСтрокиСлипЧека(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, СлипЧек, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Документ     = Новый ТекстовыйДокумент();*/
			/*Область      = Неопределено;*/
			/*ИмяМакета    = "СлипЧекИНПАС";*/
			/*ЗначениеПоля = "";*/
			/*КодыВалют = Новый Соответствие();*/
			/*КодыВалют.Вставить("643", "RUR");*/
			/*КодыВалют.Вставить("840", "USD");*/
			/*КодыВалют.Вставить("978", "EUR");*/
			/*КодыВалют.Вставить("826", "GBP");*/
			/*КодыВалют.Вставить("036", "AUD");*/
			/*КодыВалют.Вставить("974", "BYR");*/
			/*КодыВалют.Вставить("208", "DKK");*/
			/*КодыВалют.Вставить("352", "ISK");*/
			/*КодыВалют.Вставить("398", "KZT");*/
			/*КодыВалют.Вставить("124", "CAD");*/
			/*КодыВалют.Вставить("578", "NOK");*/
			/*КодыВалют.Вставить("702", "SGD");*/
			/*КодыВалют.Вставить("792", "TRL");*/
			/*КодыВалют.Вставить("980", "UAH");*/
			/*КодыВалют.Вставить("752", "SEK");*/
			/*КодыВалют.Вставить("756", "CHF");*/
			/*КодыВалют.Вставить("392", "JPY");*/
			/*КодыВалют.Вставить("999", "BONUS");*/
			if(true/*ПараметрыПодключения.ТипТранзакции = "Оплатить"
	 Или ПараметрыПодключения.ТипТранзакции = "Вернуть платеж"
	 Или ПараметрыПодключения.ТипТранзакции = "Отменить платеж"
	 Или ПараметрыПодключения.ТипТранзакции = "Преавторизовать платеж"
	 Или ПараметрыПодключения.ТипТранзакции = "Завершить преавторизацию"
	 Или ПараметрыПодключения.ТипТранзакции = "Отменить преавторизацию"*/)
			{
				/*ОбластьПараметры = Новый Структура();*/
				/*ОбластьПараметры.Вставить("Банк"       , Параметры.ДанныеМакетаСлипЧека[0].Значение);*/
				/*ОбластьПараметры.Вставить("Организация", Параметры.ДанныеМакетаСлипЧека[1].Значение);*/
				/*ОбластьПараметры.Вставить("Город"      , Параметры.ДанныеМакетаСлипЧека[2].Значение);*/
				/*ОбластьПараметры.Вставить("Адрес"      , Параметры.ДанныеМакетаСлипЧека[3].Значение);*/
				/*ОбластьПараметры.Вставить("Отдел"      , Параметры.ДанныеМакетаСлипЧека[4].Значение);*/
				/*ОбластьПараметры.Вставить("Кассир"     , Параметры.ДанныеМакетаСлипЧека[5].Значение);*/
				/*ОбластьПараметры.Вставить("TID"        , ОбъектДрайвера.ИдентификаторТерминала);*/
				/*ОбластьПараметры.Вставить("MID"        , ОбъектДрайвера.ИдентификаторПродавца);*/
				if(true/*ПараметрыПодключения.ТипТранзакции = "Оплатить"*/)
				{
					/*ОбластьПараметры.Вставить("Операция", "ОПЛАТА ТОВАРА");*/
				}
				/*ОбластьПараметры.Вставить("Сумма",
		                          Формат(Число(ОбъектДрайвера.Сумма),
		                                 "ЧЦ=15; ЧДЦ=2; ЧС=2; ЧРГ=' '; ЧГ=3,0")
		                         + " "
		                         + КодыВалют[ОбъектДрайвера.КодВалюты]);*/
				/*ОбластьПараметры.Вставить("Итого", 
		                          Формат(Число(ОбъектДрайвера.Сумма),
		                                 "ЧЦ=15; ЧДЦ=2; ЧС=2; ЧРГ=' '; ЧГ=3,0")
		                         + " "
		                         + КодыВалют[ОбъектДрайвера.КодВалюты]);*/
				/*ОбластьПараметры.Вставить("НазваниеКарты", ОбъектДрайвера.ТипКарты);*/
				/*ОбластьПараметры.Вставить("PIN", ?(ОбъектДрайвера.СпособВводаPin = 0, "", "PIN"));*/
				/*ОбластьПараметры.Вставить("НомерКарты",
		                          Лев(ОбъектДрайвера.НомерКарты, 4) + " "
		                         + Сред(ОбъектДрайвера.НомерКарты, 5, 2) + "** **** "
		                         + Прав(ОбъектДрайвера.НомерКарты, 4));*/
				/*ОбластьПараметры.Вставить("СрокДействия",
		                          Лев(ОбъектДрайвера.СрокДействияКарты,2) + "/" + Прав(ОбъектДрайвера.СрокДействияКарты,2));*/
				/*ОбластьПараметры.Вставить("КодАвторизации", Формат(ОбъектДрайвера.КодАвторизации, "ЧГ=0"));*/
				/*ОбластьПараметры.Вставить("КодRRN", ОбъектДрайвера.КодRRN);*/
				/*ОбластьПараметры.Вставить("КодОтветаХоста", ОбъектДрайвера.КодОтветаХоста);*/
				/*ОбластьПараметры.Вставить("ОписаниеОтветаХоста", ОбъектДрайвера.ОписаниеОтветаХоста);*/
				/*ОбластьПараметры.Вставить("Дата", Формат(Дата(ОбъектДрайвера.ВремяОперацииНаТерминале), "ДФ=yy/MM/dd"));*/
				/*ОбластьПараметры.Вставить("Время", Формат(Дата(ОбъектДрайвера.ВремяОперацииНаТерминале), "ДФ=HH:mm:ss"));*/
				/*ОбластьПараметры.Вставить("ИдентификаторПриложения", ОбъектДрайвера.ИдентификаторПриложения);*/
				/*ОбластьПараметры.Вставить("НазваниеПриложения", ОбъектДрайвера.НазваниеПриложения);*/
				/*ОбластьПараметры.Вставить("TVR", ОбъектДрайвера.TVR);*/
				/*ОбластьПараметры.Вставить("ИмяДержателяКарты", ОбъектДрайвера.ИмяДержателяКарты);*/
				/*ОбластьПараметры.Вставить("ТекстПодвала", Параметры.ДанныеМакетаСлипЧека[6].Значение);*/
				/*СлипЧек =
		   МенеджерОборудованияКлиент.ПолучитьСлипЧек(ИмяМакета, Параметры.ШиринаСлипЧека, ОбластьПараметры);*/
			}
			if(true/*Результат*/)
			{
				/*КопииСлипЧека = "";*/
				/*СлипЧек = КопииСлипЧека;*/
			}
			return null;
		}
		// Установить параметры драйвера
		//

		public void УстановитьПараметрыДрайвера(/*ОбъектДрайвера, Параметры*/)
		{
			/*// Параметры системы
*/
			/*ОбъектДрайвера.АдресСервераАвторизации   = Параметры.АдресСА;*/
			/*ОбъектДрайвера.ПортСервераАвторизации    = Параметры.ПортСА;*/
			/*ОбъектДрайвера.СкриптX25                 = Параметры.СкриптX25;*/
			/*ОбъектДрайвера.ТаймаутACK                = Параметры.ТаймаутACK;*/
			/*ОбъектДрайвера.ТаймаутСервераАвторизации = Параметры.ТаймаутСА;*/
			/*ОбъектДрайвера.ЧислоNAK                  = Параметры.ЧислоNAK;*/
			/*ОбъектДрайвера.РазмерПакета              = Параметры.РазмерПакета;*/
			/*ОбъектДрайвера.ТаймаутОперации           = Параметры.ТаймаутОперации;*/
			/*ОбъектДрайвера.АдресКаналаУправления     = Параметры.АдресКУ;*/
			/*ОбъектДрайвера.ПортКаналаУправления      = Параметры.ПортКУ;*/
			/*ОбъектДрайвера.ТаймаутКаналаУправления   = Параметры.ТаймаутКУ;*/
			/*ОбъектДрайвера.COMПортДО                 = Параметры.COMПортДО;*/
			/*ОбъектДрайвера.СкоростьОбменаСДО         = Параметры.СкоростьОбменаСДО;*/
			/*ОбъектДрайвера.РазмерДанныхДО            = Параметры.РазмерДанныхДО;*/
			/*ОбъектДрайвера.ЧетностьДО                = Параметры.ЧетностьДО;*/
			/*ОбъектДрайвера.СтопБитыДО                = Параметры.СтопБитыДО;*/
			/*ОбъектДрайвера.УправлениеПотокомДО       = Параметры.УправлениеПотокомДО;*/
			/*ОбъектДрайвера.ИдентификаторТерминала    = Параметры.ИдентификаторТерминала;*/
			/*ОбъектДрайвера.КодВалюты                 = Параметры.КодВалюты;*/
			/*ОбъектДрайвера.ВремяОперацииНаТерминале  = Формат(ТекущаяДата(), "ДФ=yyyyMMddЧЧммсс");*/
		}
	}
}

