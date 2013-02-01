﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ПакетЭД:ДокументОбъект
	{
		public V82.Перечисления/*Ссылка*/.НаправленияЭД Направление;
		public string/*(80)*/ Получатель;
		public string/*(80)*/ Отправитель;
		public bool ДанныеЗашифрованы;//Данные зашифрованы
		public object АдресРесурсаОрганизации;//Адрес ресурса организации
		public string/*(200)*/ АдресРесурсаКонтрагента;//Адрес ресурса контрагента
		public string/*(100)*/ СертификатШифрования;//Сертификат шифрования
		public V82.СправочникиСсылка.СоглашенияОбИспользованииЭД Соглашение;
		public V82.Перечисления/*Ссылка*/.СтатусыПакетовЭД СтатусПакета;//Статус пакета
		public V82.СправочникиСсылка.Контрагенты Контрагент;
		public V82.СправочникиСсылка.Организации Организация;
		public V82.Перечисления/*Ссылка*/.СпособыОбменаЭД СпособОбменаЭД;//Способ обмена
		public string/*(0)*/ Комментарий;
		public string/*(80)*/ ВнешнийУИД;//Внешний уникальный идентификатор
	}
}
