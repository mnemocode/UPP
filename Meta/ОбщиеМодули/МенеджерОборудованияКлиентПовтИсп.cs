﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class МенеджерОборудованияКлиентПовтИсп
	{
		// Функция возвращает список подключенного в справочнике ПО
		//

		public object ПолучитьСписокОборудования(/*ТипыПО = Неопределено, Идентификатор = Неопределено, РабочееМесто = Неопределено*/)
		{
			return null;
		}
		// Возвращает структуру параметров конкретного экземпляра устройства
		// При первом обращении получает из БД сохраненные ранее параметры.

		public object ПолучитьПараметрыУстройства(/*Идентификатор*/)
		{
			return null;
		}
		// Функция возвращает структуру с данными устройства
		//(со значениями реквизитов элемента справочника)

		public object ПолучитьДанныеУстройства(/*Идентификатор*/)
		{
			return null;
		}
		// Возвращает имя формы настройки обработчика драйвера
		// При первом обращении возвращает сформированное на сервере имя

		public object ПолучитьИмяФормыНастройкиПараметров(/*НаименованиеОбработчикаДрайвера*/)
		{
			/*НаименованиеФормыНастройки = 
	    СтрЗаменить(МенеджерОборудованияСервер.ПолучитьИмяДрайвераЭкземпляра(НаименованиеОбработчикаДрайвера),
	                "Обработчик",
	                "ФормаНастройки");*/
			return null;
		}
		// Возвращает имя компьютера клиента
		// При первом обращении получает имя компьютера из переменной сеанса

		public object ПолучитьРабочееМестоКлиента(/**/)
		{
			return null;
		}
		// Возвращает имя компьютера клиента
		// При первом обращении получает имя компьютера из переменной сеанса

		public object НайтиРабочиеМестаПоИД(/*ИдентификаторКлиента*/)
		{
			return null;
		}
		// Возвращает макет слип чека по наименованию макета
		//

		public object ПолучитьСлипЧек(/*ИмяМакета, ШиринаСлипЧека, Параметры, АвторизацияПИН = Ложь*/)
		{
			return null;
		}
		// Функция возвращает имя перечисления из его метаданных
		//

		public object ПолучитьИмяТипаОборудования(/*ТипОборудования*/)
		{
			return null;
		}
		// Функция возвращает пользовательские настройки подключаемого оборудования
		//

		public object ПолучитьПользовательскиеНастройкиПодключаемогоОборудования(/**/)
		{
			return null;
		}
	}
}

