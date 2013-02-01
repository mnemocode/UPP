﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum МетодыПланированияУчетаЗатратНаПерсонал
	{
		ПустаяСсылка = - 1,
		МетодНачисленийБезВыделенияНалогов = 0,//Метод начислений без выделения страховых взносов (ЕСН)
		МетодНачисленийСВыделениемНалогов = 1,//Метод начислений с выделением страховых взносов (ЕСН)
		КассовыйМетодБезВыделенияНалогов = 2,//Кассовый метод без выделения страховых взносов (ЕСН) и НДФЛ
		КассовыйМетодСВыделениемНалогов = 3,//Кассовый метод с выделением страховых взносов (ЕСН) и НДФЛ
	}
	public static partial class МетодыПланированияУчетаЗатратНаПерсонал_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid МетодНачисленийБезВыделенияНалогов = new Guid("46a73ca8-035b-92e1-4de7-2b592ff8b332");//Метод начислений без выделения страховых взносов (ЕСН)
		public static readonly Guid МетодНачисленийСВыделениемНалогов = new Guid("1449f8af-58ba-9ef0-4879-098e1948b4a5");//Метод начислений с выделением страховых взносов (ЕСН)
		public static readonly Guid КассовыйМетодБезВыделенияНалогов = new Guid("b25c6caf-2ac7-34ab-4b9b-87e5f261825d");//Кассовый метод без выделения страховых взносов (ЕСН) и НДФЛ
		public static readonly Guid КассовыйМетодСВыделениемНалогов = new Guid("3231ab8c-c203-111f-4d21-58ef14a83bab");//Кассовый метод с выделением страховых взносов (ЕСН) и НДФЛ
		public static МетодыПланированияУчетаЗатратНаПерсонал Получить(this МетодыПланированияУчетаЗатратНаПерсонал Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static МетодыПланированияУчетаЗатратНаПерсонал Получить(this МетодыПланированияУчетаЗатратНаПерсонал Значение, Guid Ссылка)
		{
			if(Ссылка == МетодНачисленийБезВыделенияНалогов)
			{
				return МетодыПланированияУчетаЗатратНаПерсонал.МетодНачисленийБезВыделенияНалогов;
			}
			else if(Ссылка == МетодНачисленийСВыделениемНалогов)
			{
				return МетодыПланированияУчетаЗатратНаПерсонал.МетодНачисленийСВыделениемНалогов;
			}
			else if(Ссылка == КассовыйМетодБезВыделенияНалогов)
			{
				return МетодыПланированияУчетаЗатратНаПерсонал.КассовыйМетодБезВыделенияНалогов;
			}
			else if(Ссылка == КассовыйМетодСВыделениемНалогов)
			{
				return МетодыПланированияУчетаЗатратНаПерсонал.КассовыйМетодСВыделениемНалогов;
			}
			return МетодыПланированияУчетаЗатратНаПерсонал.ПустаяСсылка;
		}
		public static byte[] Ключ(this МетодыПланированияУчетаЗатратНаПерсонал Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this МетодыПланированияУчетаЗатратНаПерсонал Значение)
		{
			switch (Значение)
			{
				case МетодыПланированияУчетаЗатратНаПерсонал.МетодНачисленийБезВыделенияНалогов: return МетодНачисленийБезВыделенияНалогов;
				case МетодыПланированияУчетаЗатратНаПерсонал.МетодНачисленийСВыделениемНалогов: return МетодНачисленийСВыделениемНалогов;
				case МетодыПланированияУчетаЗатратНаПерсонал.КассовыйМетодБезВыделенияНалогов: return КассовыйМетодБезВыделенияНалогов;
				case МетодыПланированияУчетаЗатратНаПерсонал.КассовыйМетодСВыделениемНалогов: return КассовыйМетодСВыделениемНалогов;
			}
			return Guid.Empty;
		}
	}
}
