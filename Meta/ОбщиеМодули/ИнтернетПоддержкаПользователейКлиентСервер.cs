﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ИнтернетПоддержкаПользователейКлиентСервер
	{
		// Определение адреса web-сервиса.
		//
		// Возвращаемое значение - Строка - адрес web-сервиса.
		//

		public object ИмяWSОпределения(/**/)
		{
			return null;
		}
		// Определение имени URIСервиса.
		//
		// Возвращаемое значение - Строка - URI сервиса.
		//

		public object ИмяURIСервиса(/**/)
		{
			/*;;*/
			return null;
		}
		// Подставляет параметры в строку. Максимально возможное число параметров - 9.
		// Параметры в строке задаются как %<номер параметра>. Нумерация параметров начинается с единицы.
		//
		// Параметры:
		//  СтрокаПодстановки  – Строка – шаблон строки с параметрами (вхождениями вида "%ИмяПараметра");
		//  Параметр<n>        - Строка - подставляемый параметр.
		//
		// Возвращаемое значение:
		//  Строка   – текстовая строка с подставленными параметрами.
		//
		// Пример:
		//  ПодставитьПараметрыВСтроку(НСтр("ru='%1 пошел в %2'"), "Вася", "Зоопарк") = "Вася пошел в Зоопарк".
		//

		public object ПодставитьПараметрыВСтроку(/*Знач СтрокаПодстановки,
	Знач Параметр1,	Знач Параметр2 = Неопределено, Знач Параметр3 = Неопределено,
	Знач Параметр4 = Неопределено, Знач Параметр5 = Неопределено, Знач Параметр6 = Неопределено,
	Знач Параметр7 = Неопределено, Знач Параметр8 = Неопределено, Знач Параметр9 = Неопределено*/)
		{
			if(true/*СтрокаПодстановки = Неопределено ИЛИ СтрДлина(СтрокаПодстановки) = 0*/)
			{
			}
			/*Результат = "";*/
			/*НачПозиция = 1;*/
			/*Позиция = 1;*/
			while(true/*Позиция <= СтрДлина(СтрокаПодстановки)*/)
			{
				/*СимволСтроки = Сред(СтрокаПодстановки, Позиция, 1);*/
				if(true/*СимволСтроки <> "%"*/)
				{
					/*Позиция = Позиция + 1;*/
					/*Продолжить;*/
				}
				/*Результат = Результат + Сред(СтрокаПодстановки, НачПозиция, Позиция - НачПозиция);*/
				/*Позиция = Позиция + 1;*/
				/*СимволСтроки = Сред(СтрокаПодстановки, Позиция, 1);*/
				if(true/*СимволСтроки = "%"*/)
				{
					/*Позиция = Позиция + 1;*/
					/*НачПозиция = Позиция;*/
					/*Результат = Результат + "%";*/
					/*Продолжить;*/
				}
				/*Попытка
			НомерПараметра = Число(СимволСтроки);*/
				/*Исключение
			ВызватьИсключение НСтр("ru='Входная строка СтрокаПодстановки имеет неверный формат: %'" + СимволСтроки);*/
				/*КонецПопытки;*/
				if(true/*СимволСтроки = "1"*/)
				{
					/*ЗначениеПараметра = Параметр1;*/
				}
				if(true/*ЗначениеПараметра = Неопределено*/)
				{
					/*ЗначениеПараметра = "";*/
				}
				/*Результат = Результат + ЗначениеПараметра;*/
				/*Позиция = Позиция + 1;*/
				/*НачПозиция = Позиция;*/
			}
			if(true/*(НачПозиция <= СтрДлина(СтрокаПодстановки))*/)
			{
				/*Результат = Результат + Сред(СтрокаПодстановки, НачПозиция, СтрДлина(СтрокаПодстановки) - НачПозиция + 1);*/
			}
			return null;
		}
	}
}

