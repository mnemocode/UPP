﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеШтрихМФискальныеРегистраторы
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
			/*ПараметрыПодключения.Вставить("СерийныйНомерККМ", "0");*/
			/*ПараметрыПодключения.Вставить("ИДУстройства", "");*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Проверка параметров устройства
*/
			/*Порт                       = Неопределено;*/
			/*Скорость                   = Неопределено;*/
			/*Таймаут                    = Неопределено;*/
			/*ПарольПользователя         = Неопределено;*/
			/*ПарольАдминистратора       = Неопределено;*/
			/*ОтменятьЧекПриПодключении  = Неопределено;*/
			/*НаименованиеОплаты1        = Неопределено;*/
			/*НаименованиеОплаты2        = Неопределено;*/
			/*НомерСекции                = Неопределено;*/
			/*КодСимволаЧастичногоОтреза = Неопределено;*/
			/*ЖурналОперацийДрайвера     = Неопределено;*/
			/*СовместимыеВерсии          = Неопределено;*/
			/*Параметры.Свойство("Порт"                      , Порт);*/
			/*Параметры.Свойство("Скорость"                  , Скорость);*/
			/*Параметры.Свойство("Таймаут"                   , Таймаут);*/
			/*Параметры.Свойство("ПарольПользователя"        , ПарольПользователя);*/
			/*Параметры.Свойство("ПарольАдминистратора"      , ПарольАдминистратора);*/
			/*Параметры.Свойство("ОтменятьЧекПриПодключении" , ОтменятьЧекПриПодключении);*/
			/*Параметры.Свойство("НаименованиеОплаты1"       , НаименованиеОплаты1);*/
			/*Параметры.Свойство("НаименованиеОплаты2"       , НаименованиеОплаты2);*/
			/*Параметры.Свойство("НомерСекции"               , НомерСекции);*/
			/*Параметры.Свойство("КодСимволаЧастичногоОтреза", КодСимволаЧастичногоОтреза);*/
			/*Параметры.Свойство("ЖурналОперацийДрайвера"    , ЖурналОперацийДрайвера);*/
			if(true/*Порт                       = Неопределено
	 Или Скорость                   = Неопределено
	 Или Таймаут                    = Неопределено
	 Или ПарольПользователя         = Неопределено
	 Или ПарольАдминистратора       = Неопределено
	 Или ОтменятьЧекПриПодключении  = Неопределено
	 Или НаименованиеОплаты1        = Неопределено
	 Или НаименованиеОплаты2        = Неопределено
	 Или НомерСекции                = Неопределено
	 Или КодСимволаЧастичногоОтреза = Неопределено
	 Или ЖурналОперацийДрайвера    = Неопределено*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				/*Результат = Ложь;*/
			}
			if(true/*Результат*/)
			{
				/*мНДС = Новый Массив();*/
				/*мНДС.Добавить(18.00);*/
				/*мНДС.Добавить(10.00);*/
				/*мНДС.Добавить(20.00);*/
				/*мНДС.Добавить(0);*/
				/*МассивЗначений = Новый Массив;*/
				/*МассивЗначений.Добавить(Параметры.Порт);*/
				/*МассивЗначений.Добавить(Параметры.Скорость);*/
				/*МассивЗначений.Добавить(Параметры.ПарольПользователя);*/
				/*МассивЗначений.Добавить(Параметры.ПарольАдминистратора);*/
				/*МассивЗначений.Добавить(Параметры.Таймаут);*/
				/*МассивЗначений.Добавить(ПараметрыПодключения.СерийныйНомерККМ);*/
				/*МассивЗначений.Добавить(мНДС[0]);*/
				/*МассивЗначений.Добавить(мНДС[1]);*/
				/*МассивЗначений.Добавить(мНДС[2]);*/
				/*МассивЗначений.Добавить(мНДС[3]);*/
				/*МассивЗначений.Добавить(Ложь);*/
				/*МассивЗначений.Добавить(Параметры.ЖурналОперацийДрайвера);*/
				/*МассивЗначений.Добавить(Параметры.НаименованиеОплаты1);*/
				/*МассивЗначений.Добавить(Параметры.НаименованиеОплаты2);*/
				if(true/*НЕ ОбъектДрайвера.Подключить(МассивЗначений, ПараметрыПодключения.ИДУстройства)*/)
				{
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить("");*/
					/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
					/*Результат = Ложь;*/
				}
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
			/*Результат = Ложь;*/
			/*// Обязательные выходные
*/
			/*ВыходныеПараметры = Новый Массив();*/
			if(true/*НЕ ОбъектДрайвера.Отключить(ПараметрыПодключения.ИДУстройства)*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
			}
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Открыть смену
*/
			if(true/*Команда = "OpenDay"*/)
			{
				/*Результат = ОткрытьСмену(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
				/*// Печать чека
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция осуществляет открытие смены

		public object ОткрытьСмену(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*// Заполнение выходных параметров
*/
			/*ВыходныеПараметры.Добавить(0);*/
			/*ВыходныеПараметры.Добавить(0);*/
			/*ВыходныеПараметры.Добавить(0);*/
			/*ВыходныеПараметры.Добавить(ТекущаяДата());*/
			return null;
		}
		// Осуществляет печать фискального чека

		public object ПечатьЧека(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВходныеПараметры, ВыходныеПараметры*/)
		{
			return null;
		}
		// Осуществляет печать слип-чека

		public object ПечатьТекста(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                       СтрокаТекста, ВыходныеПараметры*/)
		{
			/*Результат  = Истина;*/
			/*// Открываем чек
*/
			/*Результат = ОткрытьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, Ложь, Ложь, ВыходныеПараметры);*/
			/*// Печатаем строки чека
*/
			if(true/*Результат*/)
			{
			}
			/*// Закрываем чек
*/
			if(true/*Результат*/)
			{
				/*ТаблицаОплат = Новый Массив();*/
				/*Результат = ЗакрытьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ТаблицаОплат, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет открытие нового чека.
		//

		public object ОткрытьЧек(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ЧекВозврата, ФискальныйЧек, ВыходныеПараметры*/)
		{
			/*Результат  = Истина;*/
			/*НомерСмены = 0;*/
			/*НомерЧека  = 0;*/
			/*// Открываем чек
*/
			/*Результат = ОбъектДрайвера.ОткрытьЧек(ПараметрыПодключения.ИДУстройства, ФискальныйЧек, ЧекВозврата,
	                                      Истина, НомерЧека, НомерСмены);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
			}
			return null;
		}
		// Функция осуществляет печать фискальной строки.
		//

		public object НапечататьФискальнуюСтроку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения,
                                   Наименование, Количество, Цена, ПроцентСкидки, Сумма,
                                   НомерСекции, СтавкаНДС, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Результат = ОбъектДрайвера.НапечататьФискСтроку(ПараметрыПодключения.ИДУстройства, Наименование, Количество, Цена,
	                                                Сумма, НомерСекции, СтавкаНДС);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*ОтменитьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет печать нефискальной строки.
		//

		public object НапечататьНефискальнуюСтроку(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, СтрокаТекста, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Результат = ОбъектДрайвера.НапечататьНефискСтроку(ПараметрыПодключения.ИДУстройства, СтрокаТекста);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*ОтменитьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет закрытие ранее открытого чека.
		//

		public object ЗакрытьЧек(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ТаблицаОплат, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*СуммаНаличнойОплаты     = 0;*/
			/*СуммаБезналичнойОплаты1 = 0;*/
			/*СуммаБезналичнойОплаты2 = 0;*/
			/*Результат = ОбъектДрайвера.ЗакрытьЧек(ПараметрыПодключения.ИДУстройства,
	                                      СуммаНаличнойОплаты,
	                                      СуммаБезналичнойОплаты1,
	                                      СуммаБезналичнойОплаты2);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*ОтменитьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет отмену ранее открытого чека.
		//

		public object ОтменитьЧек(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ОбъектДрайвера.ОтменитьЧек(ПараметрыПодключения.ИДУстройства);*/
			return null;
		}
		// Функция осуществляет внесение или выемку суммы на ФР.
		//

		public object Инкассация(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ТипИнкассации, Сумма, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Результат = ОбъектДрайвера.НапечататьЧекВнесенияВыемки(ПараметрыПодключения.ИДУстройства,
	                           ?(ТипИнкассации = 1, Сумма, -Сумма));*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*КодОшибки = ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*ОтменитьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет снятие отчёта без гашения.
		//

		public object НапечататьОтчетБезГашения(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Результат = ОбъектДрайвера.НапечататьОтчетБезГашения(ПараметрыПодключения.ИДУстройства);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*ОтменитьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет снятие отчёта с гашением.
		//

		public object НапечататьОтчетСГашением(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Результат = ОбъектДрайвера.НапечататьОтчетСГашением(ПараметрыПодключения.ИДУстройства);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
				/*ОтменитьЧек(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			}
			return null;
		}
		// Функция осуществляет открытие денежного ящика
		//

		public object ОткрытьДенежныйЯщик(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Попытка
		Результат = ОбъектДрайвера.ОткрытьДенежныйЯщик(ПараметрыПодключения.ИДУстройства, 0);*/
			/*// номер ящика по умолчанию 0
*/
			/*Исключение
		ВыходныеПараметры.Добавить(999);*/
			/*ВыходныеПараметры.Добавить(НСтр("ru='Команда ""Открыть денежный ящик"" не поддерживается данным драйвером.'"));*/
			/*КонецПопытки;*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить("");*/
				/*ОбъектДрайвера.ПолучитьОшибку(ВыходныеПараметры[1]);*/
			}
			return null;
		}
		// Функция осуществляет снятие отчёта без гашения.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат      = Истина;*/
			/*РезультатТеста = "";*/
			/*СерийныйНомерККМ = "0";*/
			/*мНДС = Новый Массив();*/
			/*мНДС.Добавить(18.00);*/
			/*мНДС.Добавить(10.00);*/
			/*мНДС.Добавить(20.00);*/
			/*мНДС.Добавить(0);*/
			/*МассивЗначений = Новый Массив;*/
			/*МассивЗначений.Добавить(Параметры.Порт);*/
			/*МассивЗначений.Добавить(Параметры.Скорость);*/
			/*МассивЗначений.Добавить(Параметры.ПарольПользователя);*/
			/*МассивЗначений.Добавить(Параметры.ПарольАдминистратора);*/
			/*МассивЗначений.Добавить(Параметры.Таймаут);*/
			/*МассивЗначений.Добавить(СерийныйНомерККМ);*/
			/*МассивЗначений.Добавить(мНДС[0]);*/
			/*МассивЗначений.Добавить(мНДС[1]);*/
			/*МассивЗначений.Добавить(мНДС[2]);*/
			/*МассивЗначений.Добавить(мНДС[3]);*/
			/*МассивЗначений.Добавить(Ложь);*/
			/*МассивЗначений.Добавить(Параметры.ЖурналОперацийДрайвера);*/
			/*МассивЗначений.Добавить(Параметры.НаименованиеОплаты1);*/
			/*МассивЗначений.Добавить(Параметры.НаименованиеОплаты2);*/
			/*Результат = ОбъектДрайвера.ТестУстройства(МассивЗначений, РезультатТеста);*/
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
	}
}

