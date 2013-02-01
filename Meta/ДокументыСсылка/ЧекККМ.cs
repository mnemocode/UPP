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
	public partial class ЧекККМ:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.Перечисления/*Ссылка*/.ВидыОперацийЧекККМ ВидОперации;//Вид операции
		public V82.СправочникиСсылка.Склады Склад;
		public V82.СправочникиСсылка.КассыККМ КассаККМ;//Касса ККМ
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен;//Тип цен
		///<summary>
		///Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		public decimal/*(15.2)*/ СуммаДокумента;//Сумма документа
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.ДокументыСсылка.ЧекККМ ЧекККМПродажа;//Чек ККМ (продажа)
		public bool ЧекПробитНаККМ;//Чек пробит на ККМ
		public decimal/*(8)*/ НомерЧекаККМ;//Номер чека ККМ
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.ИнформационныеКарты ДисконтнаяКарта;//Дисконтная карта
		public decimal/*(4)*/ НомерСменыККМ;//Номер смены ККМ
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж;//Условие продаж
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Контрагенты ВладелецДисконтнойКарты;//Владелец дисконтной карты
	}
}
