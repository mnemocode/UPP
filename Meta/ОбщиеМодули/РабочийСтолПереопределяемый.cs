﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class РабочийСтолПереопределяемый
	{

		public object ФормаРабочегоСтола(/*ТекущийПользователь*/)
		{
			return null;
		}

		public void ОткрытьРабочийСтол(/**/)
		{
			/*ТекущийПользователь = глЗначениеПеременной("глТекущийПользователь");*/
			/*ФормаРабочегоСтола = РабочийСтолПереопределяемый.ФормаРабочегоСтола(ТекущийПользователь);*/
			/*ФормаРабочегоСтола.Открыть();*/
			/*ИспользоватьРабочийСтол = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекущийПользователь, "ОткрыватьПриЗапускеРабочийСтол");*/
			if(true/*Не ИспользоватьРабочийСтол*/)
			{
				/*// для текущего пользователя установим использование рабочего стола
*/
				/*НаборЗаписей = РегистрыСведений.НастройкиПользователей.СоздатьНаборЗаписей();*/
				/*НаборЗаписей.Отбор.Пользователь.Установить(ТекущийПользователь);*/
				/*НаборЗаписей.Отбор.Настройка.Установить(ПланыВидовХарактеристик.НастройкиПользователей.ОткрыватьПриЗапускеРабочийСтол);*/
				/*НаборЗаписей.Прочитать();*/
				if(true/*НаборЗаписей.Количество() = 0*/)
				{
					/*НоваяЗапись = НаборЗаписей.Добавить();*/
					/*НоваяЗапись.Пользователь = ТекущийПользователь;*/
					/*НоваяЗапись.Настройка = ПланыВидовХарактеристик.НастройкиПользователей.ОткрыватьПриЗапускеРабочийСтол;*/
					/*НоваяЗапись.Значение = Истина;*/
				}
				if(true/*ОбщегоНазначения.ЗаписатьНабор(НаборЗаписей)*/)
				{
					/*// оповестим форму настройки параметров пользователя
*/
					/*Оповестить("ИзмененаНастройкаОткрыватьПриЗапускеРабочийСтол", Новый Структура("ТекущийПользователь, ОткрыватьПриЗапускеРабочийСтол", ТекущийПользователь, Истина));*/
				}
			}
		}

		public void ФормаНачисленийПередОткрытием(/*Форма*/)
		{
			/*// В этой конфигурации дополнительных действий не предусмотрено
*/
		}

		public void ИнициализироватьРабочийСтол(/**/)
		{
			if(true/*УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(глЗначениеПеременной("глТекущийПользователь"), "ОткрыватьПриЗапускеРабочийСтол")*/)
			{
				/*ФормаРабочегоСтола = РабочийСтолПереопределяемый.ФормаРабочегоСтола(глЗначениеПеременной("глТекущийПользователь"));*/
				/*ФормаРабочегоСтола.Открыть();*/
			}
		}
	}
}

