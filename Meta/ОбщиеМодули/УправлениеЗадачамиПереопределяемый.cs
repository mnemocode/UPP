﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеЗадачамиПереопределяемый
	{
		// Процедура заполняет реквизиты адресации у задачи
		//

		public void ЗаписатьАдресациюЗадачиДополнительно(/*Задача, Подразделение*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// Процедура добавляет задачи, специфические для конкретной конфигурации
		//

		public void ДобавитьЗадачи(/*
			ВидЗадачиПользователей,
			ТекущаяДата,
			АктуальныйПериодРегистрации,
			СписокГоловныхОрганизаций,
			СписокОрганизаций*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// Функция возвращает список видов договоров, для использования
		// в процедурах генерации задач
		//
		// Для ЗУП некоторые строчки необходимо закоментировать
		//

		public object ВернутьВидыДоговоров(/*ВернутьГражданских, ВернутьВоенных*/)
		{
			/*СтрокаДоговора = "";*/
			if(true/*ВернутьГражданских*/)
			{
				/*СтрокаДоговора = СтрокаДоговора + "ЗНАЧЕНИЕ(Перечисление.ВидыДоговоровСФизЛицами.ТрудовойДоговор)";*/
			}
			return null;
		}

		public void ДополнитьТекстОписанияЗадачи(/*ТекстСообщения, РеквизитыАдресации*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ДополнитьОтборНабораЗаписей(/*НаборЗаписей*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ДополнитьОтборНабораЗаписей()

		public void УстановитьОтборНабораЗаписей(/*НаборЗаписей, СтрокаТаблицы*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// УстановитьОтборНабораЗаписей()

		public void ДополнитьСтруктуруПоиска(/*СтруктураПоиска, СтрокаТаблицы*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ДополнитьСтруктуруПоиска()

		public void ФормаЗадачиПередОткрытиемДополнительно(/*Форма, ЗадачаОбъект, ДополнительныеДействия*/)
		{
			/*Форма.ЭлементыФормы.ОсновнаяПанель.ОтображениеЗакладок = ОтображениеЗакладок.НеИспользовать;*/
		}
		// ФормаЗадачиПередОткрытиемДополнительно

		public void ФормаЗадачиДополнительноВыбор(/*Форма, Элемент, ВыбраннаяСтрока, Колонка, СтандартнаяОбработка*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// ФормаЗадачиДополнительноВыбор

		public void УстановитьОтборТаблицаНастройкиРолиИИсполнителиДополнительно(/*ЭлементыФормы*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}
		// УстановитьОтборТаблицаНастройкиРолиИИсполнителиДополнительно()
	}
}

