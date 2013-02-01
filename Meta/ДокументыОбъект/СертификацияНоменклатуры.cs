﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class СертификацияНоменклатуры:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.ВидыОперацийСертификацияНоменклатуры ВидОперации;//Вид операции
		///<summary>
		///Дата начала испытаний образцов (при внутренней сертификации)
		///</summary>
		public DateTime ДатаНачалаИспытаний;//Дата начала испытаний
		///<summary>
		///Дата окончания испытаний образцов (при внутренней сертификации)
		///</summary>
		public DateTime ДатаОкончанияИспытаний;//Дата окончания испытаний
		public DateTime ДатаСертификата;//Дата сертификата
		public object ДокументОснование;//Документ основание
		///<summary>
		///Заключение контролирующего подразделения или органа сертификации
		///</summary>
		public string/*(0)*/ Заключение;
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Номенклатура Номенклатура;
		public string/*(30)*/ НомерСертификата;//Номер сертификата
		///<summary>
		///Нормативный документ, согласно которому осуществляется сертификация (для внутренней сертификации)
		///</summary>
		public V82.СправочникиСсылка.НормативныеДокументыСертификацииНоменклатуры НормативныйДокумент;//Нормативный документ
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Организация, проводящая отбор проб (для внешней сертификации)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты ОрганПоСертификации;//Орган по сертификации
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///"Отказ", если была предпринята попытка сертификации, но она не увенчалась успехом. "Сертификация" - увенчалась успехом
		///</summary>
		public V82.Перечисления/*Ссылка*/.РезультатыСертификацииНоменклатуры РезультатСертификации;//Результат сертификации
		public V82.СправочникиСсылка.СерииНоменклатуры СерияНоменклатуры;//Серия номенклатуры
		///<summary>
		///Срок окончания действия сертификата
		///</summary>
		public DateTime СрокГодностиСертификата;//Срок годности сертификата
	}
}
