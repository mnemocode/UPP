﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности
	{
		ПустаяСсылка = - 1,
		ЗаМесяц = 0,//За месяц
		НарастающимИтогомСНачалаГода = 1,//Нарастающим итогом с начала года
	}
	public static partial class МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ЗаМесяц = new Guid("5691758c-ad76-2cbe-4ff4-39f090217c54");//За месяц
		public static readonly Guid НарастающимИтогомСНачалаГода = new Guid("1c9d09bd-d833-0b21-4cf9-493ab0218520");//Нарастающим итогом с начала года
		public static МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности Получить(this МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности Получить(this МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности Значение, Guid Ссылка)
		{
			if(Ссылка == ЗаМесяц)
			{
				return МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности.ЗаМесяц;
			}
			else if(Ссылка == НарастающимИтогомСНачалаГода)
			{
				return МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности.НарастающимИтогомСНачалаГода;
			}
			return МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности.ПустаяСсылка;
		}
		public static byte[] Ключ(this МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности Значение)
		{
			switch (Значение)
			{
				case МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности.ЗаМесяц: return ЗаМесяц;
				case МетодыРаспределенияКосвенныхРасходовПоВидамДеятельности.НарастающимИтогомСНачалаГода: return НарастающимИтогомСНачалаГода;
			}
			return Guid.Empty;
		}
	}
}
