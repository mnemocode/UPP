﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ParametryVyrabotkiOS
	[Маршрут("Справочники/ПараметрыВыработкиОС","")]
	public class ПараметрыВыработкиОСЗапрос: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСЗапрос>
	{
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ПоСсылке","{Ссылка}")]
	public class ПараметрыВыработкиОСНайтиПоСсылке: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ПоКоду","{Код}")]
	public class ПараметрыВыработкиОСНайтиПоКоду: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ПоНаименованию","{Наименование}")]
	public class ПараметрыВыработкиОСНайтиПоНаименованию: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПараметрыВыработкиОСВыбратьПоСсылке: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПараметрыВыработкиОСВыбратьПоКоду: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПараметрыВыработкиОС/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПараметрыВыработкиОСВыбратьПоНаименованию: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОСВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПараметрыВыработкиОССтраницаПоСсылке: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПараметрыВыработкиОССтраницаПоКоду: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОССтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПараметрыВыработкиОС/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПараметрыВыработкиОССтраницаПоНаименованию: V82.СправочникиСсылка.ПараметрыВыработкиОС,IReturn<ПараметрыВыработкиОССтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПараметрыВыработкиОСОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПараметрыВыработкиОССервис : Service
	{
		
		public object Get(ПараметрыВыработкиОСЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыработкиОСНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ПараметрыВыработкиОС.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПараметрыВыработкиОСОтвет() { Ответ = "ПараметрыВыработкиОС c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПараметрыВыработкиОСНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПараметрыВыработкиОС.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПараметрыВыработкиОСОтвет() {Ответ = "ПараметрыВыработкиОС c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПараметрыВыработкиОСНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыработкиОСВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ПараметрыВыработкиОС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПараметрыВыработкиОСВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыработкиОСВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыработкиОССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыработкиОССтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПараметрыВыработкиОССтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПараметрыВыработкиОСЗапрос Запрос)
		{
			return new ПараметрыВыработкиОСОтвет {Ответ = "ПараметрыВыработкиОС, "};
		}

		public object Post(ПараметрыВыработкиОСЗапрос ЗапросПараметрыВыработкиОС)
		{
			var Ссылка = (СправочникиСсылка.ПараметрыВыработкиОС)ЗапросПараметрыВыработкиОС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}