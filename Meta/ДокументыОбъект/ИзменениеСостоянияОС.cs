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
	public partial class ИзменениеСостоянияОС:ДокументОбъект
	{
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Пользователи Ответственный;
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ВремяНапоминания;//Время напоминания
		///<summary>
		///(Общ)
		///</summary>
		public bool ВлияетНаНачислениеАмортизации;//Влияет на начисление амортизации
		///<summary>
		///(Общ)
		///</summary>
		public bool НапомнитьОСобытии;//Напомнить о событии
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Упр)
		///</summary>
		public bool НачислятьАмортизациюВТекущемМесяце;//Начислять амортизацию в текущем месяце
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.Организации Организация;
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		///<summary>
		///(Общ)
		///</summary>
		public bool НачислятьАмортизацию;//Начислять амортизацию
		///<summary>
		///(Общ)
		///</summary>
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СобытияОС Событие;
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СобытияОС СобытиеРегл;//Событие (регл)
	}
}
