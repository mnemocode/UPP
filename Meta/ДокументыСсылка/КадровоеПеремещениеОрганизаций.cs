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
	public partial class КадровоеПеремещениеОрганизаций:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public bool ИндексацияЗаработка;//Индексация заработка
		public decimal/*(6.3)*/ КоэффициентИндексацииЗаработка;//Коэффициент индексации заработка
		public decimal/*(5.2)*/ УдалитьРайонныйКоэффициент;//Удалить районный коэффициент
		public V82.СправочникиСсылка.Организации ОбособленноеПодразделениеОткуда;//Обособленное подразделение откуда
		public V82.СправочникиСсылка.Организации ОбособленноеПодразделениеКуда;//Обособленное подразделение куда
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public bool ДанныеПрошлойВерсии;//Перенесен из 7.7
		public V82.ДокументыСсылка.КадровоеПеремещениеОрганизаций ИсправляемыйДокумент;//Исправляемый документ
		public ХранилищеЗначения ДвиженияИсправляемогоДокумента;//Движения исправляемого документа
	}
}
