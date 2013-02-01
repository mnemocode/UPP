﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СреднийЗаработокКлиентПереопределяемый
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы форм
		// Формирует понятное пользователю описание
		//
		// Параметры
		//  Ссылка - вид расчета
		//
		// Возвращаемое значение:
		//   Строка
		//

		public object ОписаниеСоставляющейСреднегоЗаработка(/*Ссылка*/)
		{
			/*ИспользованиеЗаработкаТекст = "";*/
			if(true/*Ссылка = ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособийС2010
		ИЛИ Ссылка = ПланыВидовРасчета.СреднийЗаработок.ПоПремиямПособийС2010*/)
			{
				/*ИспользованиеЗаработкаТекст = "Для расчета пособий по социальному страхованию (по больничным листам и по уходу за ребенком)";*/
			}
			return null;
		}
		// ОписаниеСоставляющейСреднегоЗаработка()
		// Формирует массив в.р., чья расчетная база может включать как основные, так и дополнительные начисления
		//
		// Параметры
		//  нет
		//
		// Возвращаемое значение:
		//   массив
		//

		public object СоставляющиеСреднегоИзОбоихПВР(/**/)
		{
			/*МассивВР = Новый Массив;*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработку);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуБЛ);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособий);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособийС2010);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуИндексируемые);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуНеИндексируемые);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииНеИндексируемые);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремии);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииБЛ);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииИндексируемые);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииНеИндексируемые);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремии);*/
			/*МассивВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииБЛ);*/
			return null;
		}
		// МассивПремийКромеГодовых()
		// Формирует дерево значений, в котором все в.р. сгруппированы для показа пользователю
		//
		// Параметры
		//  нет
		//
		// Возвращаемое значение:
		//   Дерево значений
		//

		public void УстановитьПараметрыЗапроса(/*Запрос*/)
		{
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособийС2010);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямПособийС2010);*/
			/*Запрос.УстановитьПараметр("Список",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособий);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямПособий);*/
			/*Запрос.УстановитьПараметр("СписокДо2010",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиямНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииНеИндексируемые);*/
			/*Запрос.УстановитьПараметр("Отпуска",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиямБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииБЛ);*/
			/*Запрос.УстановитьПараметр("СписокСтарый",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработку);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиям);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиям);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремии);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремии);*/
			/*Запрос.УстановитьПараметр("ОтпускаСтарый",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработку);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособий);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоЗаработкуПособийС2010);*/
			/*Запрос.УстановитьПараметр("Заработок",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямПособий);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямПособийС2010);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиям);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиям);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиямБЛ);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоПремиямНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксПремиямНеИндексируемые);*/
			/*Запрос.УстановитьПараметр("Премии",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремии);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремии);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоГодовойПремииНеИндексируемые);*/
			/*СписокПВР.Добавить(ПланыВидовРасчета.СреднийЗаработок.ПоФиксГодовойПремииНеИндексируемые);*/
			/*Запрос.УстановитьПараметр("ГодовыеПремии",СписокПВР);*/
			/*СписокПВР = Новый Массив;*/
			/*Запрос.УстановитьПараметр("ПособияНеФСС",СписокПВР);*/
		}
		// УстановитьПараметрыЗапроса()
		// Возвращает строку для заголовка строки дерева по пособиям не ФСС (за счет бюджета)
		//
		// Возвращаемое значение:
		//   Строка
		//

		public object ПолучитьЗаголовокПособияНеФСС(/**/)
		{
			return null;
		}
		// ПолучитьЗаголовокПособияНеФСС()
		// Формирует массив не редактируемых в.р.
		//
		// Возвращаемое значение:
		//   Массив
		//

		public object ПолучитьМассивНеРедактируемыхЗаработков(/**/)
		{
			/*МассивНеРедактируемыхЗаработков = Новый Массив;*/
			/*МассивНеРедактируемыхЗаработков.Добавить(ОбщегоНазначенияЗК.ОсобыйЭлемент(ПланыВидовРасчета.СреднийЗаработок, "ПоЗаработкуПособийС2011"));*/
			return null;
		}
	}
}

