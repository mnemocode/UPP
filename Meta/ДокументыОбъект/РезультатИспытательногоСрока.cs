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
	public partial class РезультатИспытательногоСрока:ДокументОбъект
	{
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		public V82.СправочникиСсылка.Пользователи Ответственный;
		public V82.СправочникиСсылка.СотрудникиОрганизаций Сотрудник;
		public V82.СправочникиСсылка.ФизическиеЛица ФизЛицо;//Физическое лицо
		public V82.Перечисления/*Ссылка*/.РезультатыИспытательногоСрока Результат;
		public string/*(100)*/ УдалитьКраткийСоставДокумента;//Удалить краткий состав документа
		public DateTime ДатаИзменения;//Дата изменения
	}
}
