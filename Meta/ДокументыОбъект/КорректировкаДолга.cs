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
	///(Общ)
	///</summary>
	public partial class КорректировкаДолга:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		public V82.Перечисления/*Ссылка*/.ВидыОперацийКорректировкаДолга ВидОперации;//Вид операции
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты КонтрагентДебитор;//Дебитор
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Контрагенты КонтрагентКредитор;//Кредитор
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Валюты ВалютаДокумента;//Валюта документа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.4)*/ КурсДокумента;//Курс документа
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10)*/ КратностьДокумента;//Кратность документа
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента;//Договор контрагента
		public bool ИспользоватьВспомогательныйСчет;//Использовать вспомогательный счет
		///<summary>
		///(Регл)
		///</summary>
		public object СчетДт;//Вспомогательный счет дебиторской задолженности
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт1;//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт2;//Субконто 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДт3;//Субконто 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетКт;//Вспомогательный счет кредиторской задолженности
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт1;//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт2;//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКт3;//Субконто 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетДтНУ;//Счет списания дебиторской задолженности (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДтНУ1;//Субконто 1 (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДтНУ2;//Субконто 2 (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоДтНУ3;//Субконто 3 (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СчетКтНУ;//Счет списания кредиторской задолженности (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКтНУ1;//Субконто 1 (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКтНУ2;//Субконто 2 (НУ)
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоКтНУ3;//Субконто 3 (НУ)
	}
}
