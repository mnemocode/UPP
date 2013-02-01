﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class СчетФактураВыданный:ДокументОбъект
	{
		public DateTime ДатаВыставления;//Счет-фактура передан
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public V82.Перечисления/*Ссылка*/.ВидСчетаФактурыВыставленного ВидСчетаФактуры;//Вид счета-фактуры
		public object ДокументОснование;//Документ основание
		public bool Под0;//Аванс под 0%
		///<summary>
		///Сумма по документу основанию в валюте документа
		///</summary>
		public decimal/*(14.2)*/ ВалютнаяСумма;//Сумма по документу-основанию
		public V82.Перечисления/*Ссылка*/.СтавкиНДС СтавкаНДС;//Ставка НДС
		public decimal/*(14.2)*/ Сумма;
		public decimal/*(14.2)*/ СуммаНДС;//Сумма НДС
		public DateTime ДатаПлатежноРасчетногоДокумента;//Дата платежно расчетного документа
		public string/*(30)*/ НомерПлатежноРасчетногоДокумента;//Номер платежно расчетного документа
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		public decimal/*(14.2)*/ СуммаДокумента;//Сумма документа
		public bool СформированПриВводеНачальныхОстатковНДС;//Сформирован при вводе начальных остатков НДС
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public bool Исправление;
		public decimal/*(1)*/ КодСпособаВыставления;//Код способа выставления
		public string/*(10)*/ КодВидаОперации;//Код вида операции
		public bool Выставлен;
		public decimal/*(10)*/ НомерИсправления;//Номер исправления
		public string/*(15)*/ НомерИсходногоДокумента;//Номер корректируемого счета-фактуры
		public DateTime ДатаИсходногоДокумента;//Дата корректируемого счета-фактуры
		public decimal/*(10)*/ НомерИсправленияИсходногоДокумента;//Номер исправления исходного документа
		public DateTime ДатаИсправленияИсходногоДокумента;//Дата исправления исходного документа
		///<summary>
		///Сумма по документу основанию в валюте документа увеличение
		///</summary>
		public decimal/*(14.2)*/ СуммаУвеличение;//Сумма по документу-основанию увеличение
		///<summary>
		///Сумма по документу основанию в валюте документа уменьшение
		///</summary>
		public decimal/*(14.2)*/ СуммаУменьшение;//Сумма по документу-основанию уменьшение
		public bool УчитыватьИсправлениеИсходногоДокумента;//Учитывать исправление исходного документа
		public V82.СправочникиСсылка.Организации Организация;
		public string/*(15)*/ НомерИсправляемогоКорректировочногоДокумента;//Номер исправляемого корректировочного счета-фактуры
		public DateTime ДатаИсправляемогоКорректировочногоДокумента;//Дата исправляемого корректировочного счета-фактуры
		public bool СчетФактураБезНДС;//Счет-фактура без НДС
		public bool СчетФактураНеВыставляется;//Счет-фактура не выставляется
		///<summary>
		///Сумма НДС по документу основанию в валюте документа увеличение
		///</summary>
		public decimal/*(14.2)*/ СуммаНДСУвеличение;//Сумма НДС по документу-основанию увеличение
		///<summary>
		///Сумма НДС по документу основанию в валюте документа уменьшение
		///</summary>
		public decimal/*(14.2)*/ СуммаНДСУменьшение;//Сумма НДС по документу-основанию уменьшение
		///<summary>
		///Сумма НДС по документу основанию в валюте документа
		///</summary>
		public decimal/*(14.2)*/ СуммаНДСДокумента;//Сумма НДС по документу-основанию
		public V82.ДокументыСсылка.СчетФактураВыданный ИсправляемыйСчетФактура;//Исправляемый счет-фактура
		public V82.СправочникиСсылка.Контрагенты Комитент;
		public V82.СправочникиСсылка.ФизическиеЛица Руководитель;
		public V82.СправочникиСсылка.ФизическиеЛица ГлавныйБухгалтер;//Главный бухгалтер
	}
}
