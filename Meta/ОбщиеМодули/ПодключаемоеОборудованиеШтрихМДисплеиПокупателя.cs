﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудованиеШтрихМДисплеиПокупателя
	{
		////////// ОБЩИЕ КОМАНДЫ ВСЕХ ОБРАБОТЧИКОВ //////////////
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
			/*ПараметрыПодключения.Вставить("ИДУстройства", Неопределено);*/
			/*// Проверка настроенных параметров
*/
			/*Порт			= Неопределено;*/
			/*Таймаут			= Неопределено;*/
			/*КолвоПовторов	= Неопределено;*/
			/*Параметры.Свойство("Порт",			Порт);*/
			/*Параметры.Свойство("Таймаут",		Таймаут);*/
			/*Параметры.Свойство("КолвоПовторов", КолвоПовторов);*/
			if(true/*Порт = Неопределено
		ИЛИ Таймаут = Неопределено
		ИЛИ КолвоПовторов = Неопределено*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				/*Результат = Ложь;*/
			}
			/*МассивЗначений = Новый Массив;*/
			/*МассивЗначений.Добавить(Параметры.Порт);*/
			/*МассивЗначений.Добавить(Параметры.Таймаут);*/
			/*МассивЗначений.Добавить(Параметры.КолвоПовторов);*/
			if(true/*Результат*/)
			{
				/*Ответ = ОбъектДрайвера.Подключить(МассивЗначений, ПараметрыПодключения.ИДУстройства);*/
				if(true/*НЕ Ответ*/)
				{
					/*ВыходныеПараметры.Добавить(999);*/
					/*ВыходныеПараметры.Добавить(ОбъектДрайвера.ТекстОшибки);*/
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
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*ОбъектДрайвера.Отключить(ПараметрыПодключения.ИДУстройства);*/
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры = Новый Массив();*/
			/*// Вывод строк на дисплей
*/
			if(true/*Команда = "ВывестиСтрокуНаДисплейПокупателя" ИЛИ Команда = "DisplayText"*/)
			{
				/*СтрокаТекста = ВходныеПараметры[0];*/
				/*Результат = ВывестиСтрокуНаДисплейПокупателя(ОбъектДрайвера, Параметры, ПараметрыПодключения, СтрокаТекста, ВыходныеПараметры);*/
				/*// Очистка дисплея
*/
			}
			return null;
		}
		/////////////////////////////////////
		// Функции-исполнители команд
		///////// СПЕЦИФИЧНЫЕ ПО ТИПУ ОБОРУДОВАНИЯ КОМАНДЫ ////////////////
		// Функция осуществляет вывод списка строк на дисплей покупателя.
		//

		public object ВывестиСтрокуНаДисплейПокупателя(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, СтрокаТекста, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*МассивСтрок = Новый Массив();*/
			/*МассивСтрок.Добавить(СтрПолучитьСтроку(СтрокаТекста, Параметры.ОтображатьНаДисплее));*/
			/*Ответ = ОбъектДрайвера.ВывестиСтрокуНаДисплейПокупателя(ПараметрыПодключения.ИДУстройства, МассивСтрок);*/
			if(true/*Не Ответ*/)
			{
				/*Результат = Ложь;*/
				/*ОбъектДрайвера.ПолучитьОшибку(ОбъектДрайвера.ОписаниеОшибки);*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеОшибки);*/
			}
			return null;
		}
		// Функция осуществляет очистку дисплея покупателя.
		//

		public object ОчиститьДисплейПокупателя(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Ответ = ОбъектДрайвера.ОчиститьДисплейПокупателя(ПараметрыПодключения.ИДУстройства);*/
			if(true/*Не Ответ*/)
			{
				/*Результат = Ложь;*/
				/*ОбъектДрайвера.ПолучитьОшибку(ОбъектДрайвера.ОписаниеОшибки);*/
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(ОбъектДрайвера.ОписаниеОшибки);*/
			}
			return null;
		}
		// Функция возвращает параметры вывода на дисплей покупателя)

		public object ПолучитьПараметрыВывода(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*ВыходныеПараметры.Очистить();*/
			/*ВыходныеПараметры.Добавить(20);*/
			/*ВыходныеПараметры.Добавить(2);*/
			return null;
		}
		//////////// ДОПОЛНИТЕЛЬНЫЕ КОМАНДЫ ////////////////////
		// Функция осуществляет тестирование устройства.
		//

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			/*Результат = Истина;*/
			/*Результат = ПодключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
			if(true/*НЕ Результат*/)
			{
				/*ВыходныеПараметры.Добавить(999);*/
				/*ВыходныеПараметры.Добавить(НСтр("ru='Ошибка при подключении устройства'"));*/
			}
			/*ОтключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);*/
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
		///////// ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ОБРАБОТЧИКА ///////////
		// Процедура формирует задержку указанной длительности
		//
		// Параметры:
		//  Время - <Число>
		//        - Длительность задержки в секундах.
		//

		public void Пауза(/*Время*/)
		{
			/*ВремяЗавершения = ТекущаяДата() + Время;*/
			while(true/*ТекущаяДата() < ВремяЗавершения*/)
			{
			}
			/*;;*/
		}
	}
}

