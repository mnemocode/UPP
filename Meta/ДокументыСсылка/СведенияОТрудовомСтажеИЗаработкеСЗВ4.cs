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
	public partial class СведенияОТрудовомСтажеИЗаработкеСЗВ4:ДокументСсылка
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
		public string/*(100)*/ КраткийСоставДокумента;//Краткий состав документа
		public string/*(7)*/ ТипФормДокументов;//Тип форм документов
		public V82.Перечисления/*Ссылка*/.КатегорииЗастрахованныхЛицПФР КатегорияЗастрахованныхЛиц;//Категория застрахованных лиц
		public DateTime ОтчетныйПериод;//Отчетный период
		public V82.Перечисления/*Ссылка*/.ТипыСведенийСЗВ ТипСведенийСЗВ;//Тип сведений СЗВ
		public DateTime КорректируемыйПериод;//Корректируемый период
		public string/*(5)*/ НомерПачки;//Номер пачки
		public bool ПринятоВПФР;//Принято в ПФР
		public V82.СправочникиСсылка.ФизическиеЛица Руководитель;
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьРуководителя;//Должность руководителя
		public V82.Перечисления/*Ссылка*/.ФорматФайлаПФР ФорматФайла;//Формат файла
		public V82.СправочникиСсылка.ТерриториальныеУсловия ТерриториальныеУсловия;//Территориальные условия
		public string/*(4)*/ ВидКорректировки;//Вид корректировки
		public decimal/*(4)*/ Год;
		public string/*(4)*/ УдалитьТипСведений;//Удалить тип сведений
		///<summary>
		///Ведет себя по правилам 2009 года.
		///</summary>
		public bool СпециальныйДокумент2010года;//Специальный документ 2010 года
		public bool НеПередаватьДоуплаченныеСуммы;//Не передавать доуплаченные суммы
		///<summary>
		///Такие документы создает обработка загрузки из принятых ПФРом файлов
		///</summary>
		public bool ЗаполненПринятымиСведениями;//Заполнен принятыми сведениями
	}
}
