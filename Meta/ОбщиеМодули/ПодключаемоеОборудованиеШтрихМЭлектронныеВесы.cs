﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеШтрихМЭлектронныеВесы
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
			/*ПараметрыПодключения.Вставить("ИДУстройства", "");*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Проверка настроенных параметров
*/
			/*Порт         = Неопределено;*/
			/*Скорость     = Неопределено;*/
			/*Четность     = Неопределено;*/
			/*ТипВесов     = Неопределено;*/
			/*Наименование = Неопределено;*/
			/*Параметры.Свойство("Порт"        , Порт);*/
			/*Параметры.Свойство("Скорость"    , Скорость);*/
			/*Параметры.Свойство("Четность"    , Четность);*/
			/*Параметры.Свойство("ТипВесов"    , ТипВесов);*/
			/*Параметры.Свойство("Наименование", Наименование);*/
			if(true/*Порт         = Неопределено
	 Или Скорость     = Неопределено
	 Или Четность     = Неопределено
	 Или ТипВесов     = Неопределено
	 Или Наименование = Неопределено*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				/*Результат = Ложь;*/
			}
			if(true/*Результат*/)
			{
				/*ОбъектДрайвера.ДобавитьУстройство();*/
				if(true/*ОбъектДрайвера.Результат = 0*/)
				{
					/*ПараметрыПодключения.ИДУстройства = ОбъектДрайвера.НомерТекущегоУстройства;*/
					/*ОбъектДрайвера.НаименованиеТекущегоУстройства = Параметры.Наименование;*/
					/*ОбъектДрайвера.Модель	        = Число(Параметры.ТипВесов);*/
					/*ОбъектДрайвера.НомерПорта       = Параметры.Порт;*/
					/*ОбъектДрайвера.СкоростьОбмена   = Параметры.Скорость;*/
					/*ОбъектДрайвера.Четность         = Параметры.Четность;*/
					/*ОбъектДрайвера.УстройствоВключено = Истина;*/
					if(true/*ОбъектДрайвера.Результат <> 0*/)
					{
						/*ВыходныеПараметры.Очистить();*/
						/*ВыходныеПараметры.Добавить(999);*/
						/*ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);*/
						/*ОбъектДрайвера.УдалитьУстройство();*/
						/*ПараметрыПодключения.ИДУстройства = Неопределено;*/
						/*Результат = Ложь;*/
					}
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
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;*/
			/*ОбъектДрайвера.УстройствоВключено = 0;*/
			/*ОбъектДрайвера.УдалитьУстройство();*/
			/*ПараметрыПодключения.ИДУстройства = Неопределено;*/
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Тарирование 
*/
			if(true/*Команда = "Тарировать" ИЛИ Команда = "Calibrate"*/)
			{
				/*ВесТары = ?(ТипЗнч(ВходныеПараметры) = Тип("Массив")
		            И ВходныеПараметры.Количество() > 0,
		            ВходныеПараметры[0],
		            Неопределено);*/
				/*Результат = Тарировать(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВесТары, ВыходныеПараметры);*/
				/*// Получение веса
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Функция осуществляет установку веса тары на весах.
		//

		public object Тарировать(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВесТары = Неопределено, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;*/
			if(true/*ВесТары = Неопределено*/)
			{
				/*ОбъектДрайвера.Тара();*/
			}
			if(true/*ОбъектДрайвера.Результат <> 0*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);*/
				/*Результат = Ложь;*/
			}
			return null;
		}
		// Функция осуществляет получение веса груза, расположенного на весах.
		//

		public object ПолучитьВес(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;*/
			/*ОбъектДрайвера.ПолучитьВес();*/
			if(true/*ОбъектДрайвера.Результат = 0*/)
			{
				/*ВыходныеПараметры.Добавить(ОбъектДрайвера.Вес);*/
			}
			return null;
		}
		// Функция осуществляет установку нуля на весах.
		//

		public object УстановитьНоль(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;*/
			/*ОбъектДрайвера.Ноль();*/
			if(true/*ОбъектДрайвера.Результат <> 0*/)
			{
				/*ВыходныеПараметры.Очистить();*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеРезультата);*/
				/*Результат = Ложь;*/
			}
			return null;
		}
		// Функция осуществляет тестирование устройства.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметрыВрем = Неопределено;*/
			/*Результат = ПодключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметрыВрем);*/
			/*ОбъектДрайвера.НомерТекущегоУстройства = ПараметрыПодключения.ИДУстройства;*/
			/*ОбъектДрайвера.ПолучитьВес();*/
			/*Результат = ОбъектДрайвера.Результат = 0;*/
			/*ВыходныеПараметры.Очистить();*/
			/*ВыходныеПараметры.Добавить(?(Результат, 0, 999));*/
			/*ВыходныеПараметры.Добавить(?(Результат, 
		НСтр("ru='Текущий вес:'") + ОбъектДрайвера.Вес,
		НСтр("ru='Ошибка при подключении устройства'")));*/
			/*ОтключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметрыВрем);*/
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
		ВыходныеПараметры[1] = ОбъектДрайвера.Версия;*/
			/*Исключение
	КонецПопытки;*/
			return null;
		}
	}
}

