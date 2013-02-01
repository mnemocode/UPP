﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Упр)
	///</summary>
	public partial class ЗаказНаОбслуживаниеОС:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		///<summary>
		///(Упр)
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Номенклатура Услуга;//Работа по обслуживанию
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.ПричиныОбслуживанияОС ПричинаЗаказаНаОбслуживаниеОС;//Причина заказа на обслуживание ОС
		///<summary>
		///(Упр)
		///</summary>
		public DateTime ДатаОбслуживанияОС;//Дата обслуживания ОС
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.ВидыОбслуживанияОсновныхСредств ВидОбслуживанияОС;//Вид обслуживания ОС
	}
}
