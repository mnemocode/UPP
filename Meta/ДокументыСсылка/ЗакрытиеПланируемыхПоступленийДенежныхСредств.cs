﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	public partial class ЗакрытиеПланируемыхПоступленийДенежныхСредств:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public bool ОтборЦФО;//Отбор по ЦФО
		public V82.СправочникиСсылка.Подразделения ЦФО;
		public bool ОтборПроект;//Отбор по проекту
		public V82.СправочникиСсылка.Проекты Проект;
		public bool ОтборОтветственный;//Отбор ответственный
		///<summary>
		///Ответственный для отбора планируемых поступлений
		///</summary>
		public V82.СправочникиСсылка.Пользователи ОтветственныйПоступление;//Ответственный за поступление
		public bool ОтборКонтрагент;//Отбор по контрагенту
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public DateTime ОтборДатаНач;//Дата начала отбора
		public DateTime ОтборДатаКон;//Дата конца отбора
	}
}
