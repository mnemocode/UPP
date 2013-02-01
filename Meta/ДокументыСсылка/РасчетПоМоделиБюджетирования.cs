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
	public partial class РасчетПоМоделиБюджетирования:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public DateTime ДатаРасчета;//Дата расчета
		public V82.СправочникиСсылка.СценарииПланирования Сценарий;
		public bool ПересчитыватьРегламентно;//Пересчитывать регламентно
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.Перечисления/*Ссылка*/.СостоянияОбъектов Состояние;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public object ОсновнойИсточникДанных;//Основной источник данных
		public string/*(50)*/ КодОсновногоИсточника;//Код основного источника
	}
}
