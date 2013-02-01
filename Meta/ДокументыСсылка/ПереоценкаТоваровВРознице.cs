﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class ПереоценкаТоваровВРознице:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Склады Склад;
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПереоценкаТоваровВРознице ВидОперации;//Вид операции
		public V82.ДокументыСсылка.УстановкаЦенНоменклатуры ДокументУстановкаЦен;//Документ установка цен
	}
}
