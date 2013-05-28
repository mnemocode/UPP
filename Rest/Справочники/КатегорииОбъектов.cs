﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KategoriiObektov
	[Маршрут("Справочники/КатегорииОбъектов","")]
	public class КатегорииОбъектовЗапрос: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовЗапрос>
	{
	}
	[Маршрут("Справочники/КатегорииОбъектов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КатегорииОбъектов/ПоСсылке","{Ссылка}")]
	public class КатегорииОбъектовНайтиПоСсылке: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КатегорииОбъектов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/КатегорииОбъектов/ПоКоду","{Код}")]
	public class КатегорииОбъектовНайтиПоКоду: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/КатегорииОбъектов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КатегорииОбъектов/ПоНаименованию","{Наименование}")]
	public class КатегорииОбъектовНайтиПоНаименованию: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КатегорииОбъектовВыбратьПоСсылке: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class КатегорииОбъектовВыбратьПоКоду: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КатегорииОбъектов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КатегорииОбъектовВыбратьПоНаименованию: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КатегорииОбъектов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КатегорииОбъектовСтраницаПоСсылке: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КатегорииОбъектов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class КатегорииОбъектовСтраницаПоКоду: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КатегорииОбъектов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КатегорииОбъектовСтраницаПоНаименованию: V82.СправочникиСсылка.КатегорииОбъектов,IReturn<КатегорииОбъектовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КатегорииОбъектовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КатегорииОбъектовСервис : Service
	{
		
		public object Get(КатегорииОбъектовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КатегорииОбъектовНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.КатегорииОбъектов.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КатегорииОбъектовОтвет() { Ответ = "КатегорииОбъектов c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КатегорииОбъектовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.КатегорииОбъектов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new КатегорииОбъектовОтвет() {Ответ = "КатегорииОбъектов c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КатегорииОбъектовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КатегорииОбъектовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.КатегорииОбъектов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КатегорииОбъектовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КатегорииОбъектовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КатегорииОбъектовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КатегорииОбъектовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КатегорииОбъектовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КатегорииОбъектовЗапрос Запрос)
		{
			return new КатегорииОбъектовОтвет {Ответ = "КатегорииОбъектов, "};
		}

		public object Post(КатегорииОбъектовЗапрос ЗапросКатегорииОбъектов)
		{
			var Ссылка = (СправочникиСсылка.КатегорииОбъектов)ЗапросКатегорииОбъектов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}