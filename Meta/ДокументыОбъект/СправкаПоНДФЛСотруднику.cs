﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Регл)
	///</summary>
	public partial class СправкаПоНДФЛСотруднику:ДокументОбъект
	{
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public decimal/*(4)*/ НалоговыйПериод;//Налоговый период
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Регл)
		///</summary>
		public string/*(21)*/ ОКАТО_КПП;//ОКАТО/КПП
		public V82.Перечисления/*Ссылка*/.ПорядокФормированияСправкиОДоходахФизлица СпособФормирования;//Способ формирования
		public string/*(20)*/ Телефон;
		public V82.СправочникиСсылка.ФизическиеЛица СправкуПодписал;//Справку подписал
		public V82.СправочникиСсылка.ДолжностиОрганизаций ДолжностьПодписавшегоЛица;//Должность подписавшего лица
		public V82.СправочникиСсылка.ФизическиеЛица Сотрудник;
		public V82.Перечисления/*Ссылка*/.НДФЛСтавки Ставка;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Фамилия;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Имя;
		///<summary>
		///(Общ)
		///</summary>
		public string/*(40)*/ Отчество;
		public string/*(240)*/ АдресРФ;//Адрес РФ
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ВидДокумента;//Вид документа
		public string/*(14)*/ СерияДокумента;//Серия документа
		public string/*(14)*/ НомерДокумента;//Номер документа
		public decimal/*(15.2)*/ ОбщаяСуммаДохода;//Общая сумма дохода
		public decimal/*(15.2)*/ ОблагаемаяСуммаДохода;//Облагаемая сумма дохода
		public decimal/*(12)*/ Исчислено;
		public decimal/*(12)*/ Задолженность;
		public decimal/*(12)*/ ИзлишнеУдержано;//Излишне удержано
		public decimal/*(12)*/ Удержано;
		public decimal/*(12)*/ Перечислено;
		public string/*(240)*/ АдресЗарубежом;//Адрес зарубежом
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаРождения;//Дата рождения
		///<summary>
		///(Регл)
		///</summary>
		public string/*(12)*/ ИНН;
		public V82.СправочникиСсылка.КлассификаторСтранМира Гражданство;
		public V82.Перечисления/*Ссылка*/.СтатусыНалогоплательщиковПоНДФЛ СтатусНалогоплательщика;//Статус налогоплательщика
		public DateTime ДатаУведомления;//Дата уведомления
		public string/*(20)*/ НомерУведомления;//Номер уведомления
		public string/*(4)*/ КодНалоговогоОрганаУведомления;//Код налогового органа уведомления
		///<summary>
		///Ведет себя по правилам 2010 года.
		///</summary>
		public bool СпециальныйДокумент2011года;//Специальный документ 2011 года
		public string/*(4)*/ КодИФНС;//Код ИФНС
	}
}
