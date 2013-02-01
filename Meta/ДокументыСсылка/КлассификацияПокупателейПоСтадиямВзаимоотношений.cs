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
	public partial class КлассификацияПокупателейПоСтадиямВзаимоотношений:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public DateTime ДатаОкончания;//Дата окончания
		public V82.Перечисления/*Ссылка*/.Периодичность Периодичность;
		public decimal/*(3)*/ КоличествоПериодовАнализа;//Количество периодов анализа
		public decimal/*(10)*/ РазовыйПокупательНач;//Разовый покупатель нач
		public decimal/*(10)*/ РазовыйПокупательКон;//Разовый покупатель кон
		public decimal/*(15.2)*/ XКлассНач;//X класс нач
		public decimal/*(15.2)*/ XКлассКон;//X класс кон
		public decimal/*(15.2)*/ YКлассНач;//Y класс нач
		public decimal/*(15.2)*/ YКлассКон;//Y класс кон
		public decimal/*(15.2)*/ ZКлассНач;//Z класс нач
		public decimal/*(15.2)*/ ZКлассКон;//Z класс кон
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
	}
}
