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
	///(Общ)
	///</summary>
	public partial class ПлатежноеПоручениеИсходящее:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public object ДокументОснование;//Документ основание
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ) Банковский счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации;//Счет организации
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;//Получатель
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОплаты;//Дата оплаты
		///<summary>
		///(Общ) Банковский счет контрагента
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетКонтрагента;//Счет контрагента
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		///<summary>
		///(Общ) электронно, почтой, телеграфом
		///</summary>
		public string/*(15)*/ ВидПлатежа;//Вид платежа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(1)*/ ОчередностьПлатежа;//Очередность платежа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ НазначениеПлатежа;//Назначение платежа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ТекстПлательщика;//Текст плательщика
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ТекстПолучателя;//Текст получателя
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public bool Оплачено;
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИННПлательщика;//ИНН плательщика
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПППлательщика;//КПП плательщика
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИННПолучателя;//ИНН получателя
		///<summary>
		///(Регл)
		///</summary>
		public string/*(9)*/ КПППолучателя;//КПП получателя
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Регл) Код бюджетной классификации доходов РФ
		///</summary>
		public string/*(20)*/ КодБК;//Код БК
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтраженоВОперУчете;//Отражено в опер. учете
		///<summary>
		///(Регл) Код ОКАТО сборщика платежей
		///</summary>
		public string/*(11)*/ КодОКАТО;//Код ОКАТО
		///<summary>
		///(Регл) Дата документа - основания перечисления  налога, сбора или иного платежа
		///</summary>
		public DateTime ПоказательДаты;//Показатель даты
		///<summary>
		///(Регл) Номер документа - основания перечисления  налога, сбора или иного платежа
		///</summary>
		public string/*(18)*/ ПоказательНомера;//Показатель номера
		///<summary>
		///(Регл) Условное обозначение основания налогового платежа
		///</summary>
		public string/*(2)*/ ПоказательОснования;//Показатель основания
		///<summary>
		///(Регл) Условное обозначение периода, за который перечисляется налог
		///</summary>
		public string/*(10)*/ ПоказательПериода;//Показатель периода
		///<summary>
		///(Регл) Условное обозначение типа налогового платежа
		///</summary>
		public string/*(2)*/ ПоказательТипа;//Показатель типа платежа
		///<summary>
		///(Регл) Статус составителя платежного документа на перечисление налогов, сборов и иных обязательных платежей
		///</summary>
		public string/*(2)*/ СтатусСоставителя;//Статус составителя платежного документа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///(Общ)
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыОперацийППИсходящее ВидОперации;//Вид операции
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств СтатьяДвиженияДенежныхСредств;//Статья движения денежных средств
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентом;//Счет учета расчетов с контрагентом
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт1;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт2;//Субконто Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт3;//Субконто Дт1
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо;//Физическое лицо
		///<summary>
		///(общ)
		///</summary>
		public V82.ДокументыСсылка.ДоговорЗаймаСРаботником ДоговорЗайма;//Договор займа
		///<summary>
		///(Общ) Валюта, в которой работник отчитывается за полученный займ
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаВзаиморасчетовРаботника;//Валюта взаиморасчетов работника
		///<summary>
		///(общ)
		///</summary>
		public bool ЧастичнаяОплата;//По документу происходит оплата частями
		public string/*(200)*/ Содержание_УСН;//Содержание УСН
		public decimal/*(15.2)*/ Графа4_УСН;//Графа4 УСН
		public decimal/*(15.2)*/ Графа5_УСН;//Графа5 УСН
		public decimal/*(15.2)*/ Графа6_УСН;//Графа5
		public decimal/*(15.2)*/ Графа7_УСН;//Графа5
		public bool ДоходыЕНВД_УСН;//ДоходыЕНВД
		public bool РасходыЕНВД_УСН;//Расходы ЕНВД УСН
		public decimal/*(15.2)*/ НДС_УСН;//НДС УСН
		public bool РучнаяНастройка_УСН;//Ручная настройка УСН
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Регл)
		///</summary>
		public object СчетУчетаРасчетовСКонтрагентомНУ;//Счет учета расчетов с контрагентом НУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУДт1;//Субконто НУ Дт1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУДт2;//Субконто НУ Дт2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУДт3;//Субконто НУ Дт3
		///<summary>
		///(Упр) срок погашения аванса подотчетником
		///</summary>
		public DateTime ДатаПогашенияАванса;//Дата погашения аванса
		///<summary>
		///(Упр)
		///</summary>
		public V82.ДокументыСсылка.АвансовыйОтчет РасчетныйДокументРаботника;//Расчетный документ работника
		public bool УдалитьПеречислениеВБюджет;//Удалить перечисление в бюджет
		public V82.Перечисления/*Ссылка*/.УдалитьВидыПеречисленийВБюджет УдалитьВидПеречисленияВБюджет;//Удалить вид перечисления в бюджет
		public bool ПеречислениеВБюджет;//Перечисление в бюджет
		public V82.Перечисления/*Ссылка*/.ВидыПеречисленийВБюджет ВидПеречисленияВБюджет;//Вид перечисления в бюджет
	}
}
