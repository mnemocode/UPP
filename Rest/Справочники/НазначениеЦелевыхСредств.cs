﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NaznachenieCelevykhSredstv
	[Маршрут("Справочники/НазначениеЦелевыхСредств","")]
	public class НазначениеЦелевыхСредствЗапрос: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствЗапрос>
	{
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ПоСсылке","{Ссылка}")]
	public class НазначениеЦелевыхСредствНайтиПоСсылке: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ПоКоду","{Код}")]
	public class НазначениеЦелевыхСредствНайтиПоКоду: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ПоНаименованию","{Наименование}")]
	public class НазначениеЦелевыхСредствНайтиПоНаименованию: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НазначениеЦелевыхСредствВыбратьПоСсылке: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class НазначениеЦелевыхСредствВыбратьПоКоду: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НазначениеЦелевыхСредств/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НазначениеЦелевыхСредствВыбратьПоНаименованию: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НазначениеЦелевыхСредствСтраницаПоСсылке: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class НазначениеЦелевыхСредствСтраницаПоКоду: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НазначениеЦелевыхСредств/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НазначениеЦелевыхСредствСтраницаПоНаименованию: V82.СправочникиСсылка.НазначениеЦелевыхСредств,IReturn<НазначениеЦелевыхСредствСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НазначениеЦелевыхСредствОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НазначениеЦелевыхСредствСервис : Service
	{
		
		public object Get(НазначениеЦелевыхСредствЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НазначениеЦелевыхСредствНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.НазначениеЦелевыхСредств.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НазначениеЦелевыхСредствОтвет() { Ответ = "НазначениеЦелевыхСредств c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НазначениеЦелевыхСредствНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.НазначениеЦелевыхСредств.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new НазначениеЦелевыхСредствОтвет() {Ответ = "НазначениеЦелевыхСредств c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НазначениеЦелевыхСредствНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НазначениеЦелевыхСредствВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.НазначениеЦелевыхСредств.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НазначениеЦелевыхСредствВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НазначениеЦелевыхСредствВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НазначениеЦелевыхСредствСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НазначениеЦелевыхСредствСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НазначениеЦелевыхСредствСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НазначениеЦелевыхСредствЗапрос Запрос)
		{
			return new НазначениеЦелевыхСредствОтвет {Ответ = "НазначениеЦелевыхСредств, "};
		}

		public object Post(НазначениеЦелевыхСредствЗапрос ЗапросНазначениеЦелевыхСредств)
		{
			var Ссылка = (СправочникиСсылка.НазначениеЦелевыхСредств)ЗапросНазначениеЦелевыхСредств;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}