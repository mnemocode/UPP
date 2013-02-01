﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class ДоговорНаВыполнениеРаботСФизЛицом:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо;//Физическое лицо
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///Сумма в валюте документа
		///</summary>
		public decimal/*(15.2)*/ СуммаЗаРаботу;//Сумма за работу
		public object ВидРасчета;//Вид расчета
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public object ВидДоговора;//Вид договора
		public V82.Перечисления/*Ссылка*/.ВидыАвторскогоДоговора ВидАвторскогоДоговора;//Вид авторского договора
		public DateTime ДатаНачала;//Дата начала
		public DateTime ДатаОкончания;//Дата окончания
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		public V82.Перечисления/*Ссылка*/.ХарактерВыплатыПоДоговору ХарактерОплаты;//Характер оплаты
		public V82.Перечисления/*Ссылка*/.ОтнесениеРасходовКДеятельностиЕНВД ОтнесениеРасходовКДеятельностиЕНВД;//Отнесение расходов к деятельности ЕНВД
		public V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете СпособОтраженияВБухучете;//Способ отражения в бухучете
		public V82.СправочникиСсылка.ВычетыНДФЛ КодВычета;//Код вычета
		public bool ЗаключенСоСтудентомРаботающимВСтудотряде;//Заключен со студентом работающим в студотряде
	}
}
