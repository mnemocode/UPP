﻿
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class УстановкаПараметровУчетаНоменклатуры:ДокументОбъект
	{
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public string/*(0)*/ Комментарий;
		public bool ЗаполнятьСчетаУчетаВДокументах;//Заполнять счета учета в документах
	}
}
