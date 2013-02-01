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
	public partial class РассылкаАнкет:ДокументСсылка
	{
		public Guid Ссылка;
		public ulong Версия;
		public bool ПометкаУдаления;
		public DateTime Дата;
		public DateTime ПрефиксНомера;
		public string Номер;
		public bool Проведен;
		public V82.СправочникиСсылка.ТиповыеАнкеты Анкета;
		public object ЭлектронныйАдресОтветов;//Электронный адрес ответов
		public bool СУведомлениемОПолучении;//С уведомлением о получении
		public object УчетнаяЗаписьДляОтправки;//Учетная запись для отправки
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты ЭлектронныйАдресОтветовВстроенныйПочтовыйКлиент;//Электронный адрес ответов встроенный почтовый клиент
		public V82.ДокументыСсылка.РассылкаАнкет ПервичнаяРассылка;//Первичная рассылка
		public string/*(0)*/ ТекстПисьма;//Текст письма
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
	}
}
