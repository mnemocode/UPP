﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class ФормированиеЗаписейКнигиПокупок:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public bool ПредъявленНДСКВычету0;//Предъявлен НДС к вычету 0%
		public bool ИмеетсяРешениеОВозмещенииНДС;//Имеется решение о возмещении НДС
	}
}
