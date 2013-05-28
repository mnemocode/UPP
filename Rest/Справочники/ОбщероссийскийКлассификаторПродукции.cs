﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ObshherossijjskijjKlassifikatorProdukcii
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции","")]
	public class ОбщероссийскийКлассификаторПродукцииЗапрос: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииЗапрос>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ПоСсылке","{Ссылка}")]
	public class ОбщероссийскийКлассификаторПродукцииНайтиПоСсылке: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ПоКоду","{Код}")]
	public class ОбщероссийскийКлассификаторПродукцииНайтиПоКоду: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ПоНаименованию","{Наименование}")]
	public class ОбщероссийскийКлассификаторПродукцииНайтиПоНаименованию: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбщероссийскийКлассификаторПродукцииВыбратьПоСсылке: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбщероссийскийКлассификаторПродукцииВыбратьПоКоду: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОбщероссийскийКлассификаторПродукцииВыбратьПоНаименованию: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОбщероссийскийКлассификаторПродукцииСтраницаПоСсылке: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОбщероссийскийКлассификаторПродукцииСтраницаПоКоду: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОбщероссийскийКлассификаторПродукции/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОбщероссийскийКлассификаторПродукцииСтраницаПоНаименованию: V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции,IReturn<ОбщероссийскийКлассификаторПродукцииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОбщероссийскийКлассификаторПродукцииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОбщероссийскийКлассификаторПродукцииСервис : Service
	{
		
		public object Get(ОбщероссийскийКлассификаторПродукцииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ОбщероссийскийКлассификаторПродукции.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОбщероссийскийКлассификаторПродукцииОтвет() { Ответ = "ОбщероссийскийКлассификаторПродукции c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОбщероссийскийКлассификаторПродукции.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОбщероссийскийКлассификаторПродукцииОтвет() {Ответ = "ОбщероссийскийКлассификаторПродукции c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОбщероссийскийКлассификаторПродукции.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОбщероссийскийКлассификаторПродукцииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОбщероссийскийКлассификаторПродукцииЗапрос Запрос)
		{
			return new ОбщероссийскийКлассификаторПродукцииОтвет {Ответ = "ОбщероссийскийКлассификаторПродукции, "};
		}

		public object Post(ОбщероссийскийКлассификаторПродукцииЗапрос ЗапросОбщероссийскийКлассификаторПродукции)
		{
			var Ссылка = (СправочникиСсылка.ОбщероссийскийКлассификаторПродукции)ЗапросОбщероссийскийКлассификаторПродукции;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}