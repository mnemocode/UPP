﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ДоговорНаВыполнениеРаботСФизЛицомПереопределяемый
	{

		public void ДобавитьСтрокуВРеглУчетПлановыхНачисленийРаботниковОрганизаций(/*Объект, ВыборкаПоШапкеДокумента*/)
		{
			/*// регистрируем способы отражения в учете
*/
			if(true/*НЕ ЗначениеЗаполнено(Объект.СпособОтраженияВБухучете) И НЕ ЗначениеЗаполнено(Объект.ОтнесениеРасходовКДеятельностиЕНВД)*/)
			{
				/*//не задан способ отражения, не регистрируем в регистре сведений
*/
			}
			/*//Движения по регистру "РеглУчетПлановыхНачисленийРаботниковОрганизаций"
*/
			//Движение = Объект.Движения.РеглУчетПлановыхНачисленийРаботниковОрганизаций.Добавить();
			if(true/*Объект.ХарактерОплаты = Перечисления.ХарактерВыплатыПоДоговору.ОднократноВКонцеСрока*/)
			{
				//Движение.Период	= НачалоМесяца(Объект.ДатаОкончания);
			}
			/*// Измерения
*/
			//Движение.Сотрудник			= Объект.Сотрудник;
			//Движение.Организация		= ОбщегоНазначения.ГоловнаяОрганизация(Объект.Организация);
			//Движение.ВидРасчета			= Объект.ВидРасчета;
			//Движение.ДокументОснование 	= Объект.Ссылка;
			/*// Ресурсы
*/
			//Движение.СпособОтраженияВБухучете			= Объект.СпособОтраженияВБухучете;
			//Движение.КодДоходаЕСН						= ВыборкаПоШапкеДокумента.КодДоходаЕСН;
			//Движение.ОтнесениеРасходовКДеятельностиЕНВД = Объект.ОтнесениеРасходовКДеятельностиЕНВД;
		}
		// Формирует понятное описание порядка отражения в учете
		//
		// Параметры
		//  Объект - ДокументОбъект.ДоговорНаВыполнениеРаботСФизЛицом -
		//                 документ, данные которого отображаются на форме
		//
		// Возвращаемое значение:
		//   строка
		//

		public object ПолучитьОписаниеОтраженияВУчете(/*Объект, РасшифровкаОтражениеВБухучете = Неопределено*/)
		{
			if(true/*РасшифровкаОтражениеВБухучете = Неопределено*/)
			{
				//РасшифровкаОтражениеВБухучете = РаботаСДиалогамиДополнительный.ПолучитьПредставлениеСпособаОтраженияНачисленияВУчетах(Объект.СпособОтраженияВБухучете, Истина);
			}
			return null;
		}
		// ПолучитьОписаниеОтраженияВУчете()

		public void ОформитьКоманднуюПанельФормы(/*КоманднаяПанель*/)
		{
			//ДоговорНаВыполнениеРаботСФизЛицомДополнительный.УточнитьВводНаОсновании(КоманднаяПанель);
		}
	}
}
