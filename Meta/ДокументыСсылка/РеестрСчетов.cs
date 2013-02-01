﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class РеестрСчетов:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Банки ИсполняющийБанк;//Исполняющий банк
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Расчетный счет организации
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетОрганизации;//Расчетный счет организации
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		///<summary>
		///Расчетный счет контрагента
		///</summary>
		public V82.СправочникиСсылка.БанковскиеСчета СчетКонтрагента;//Расчетный счет контрагента
		public string/*(10)*/ НомерАккредитива;//Номер аккредитива
		public DateTime ДатаАккредитива;//Дата аккредитива
		public decimal/*(15.2)*/ СуммаАккредитива;//Сумма аккредитива
		///<summary>
		///Дата закрытия аккредитива
		///</summary>
		public DateTime ДатаЗакрытия;//Дата закрытия
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.ДокументыСсылка.АккредитивПереданный ДокументОснование;//Документ основание
	}
}
