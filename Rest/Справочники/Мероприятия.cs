﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Meropriyatiya
	[Маршрут("Справочники/Мероприятия","")]
	public class МероприятияЗапрос: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияЗапрос>
	{
	}
	[Маршрут("Справочники/Мероприятия/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Мероприятия/ПоСсылке","{Ссылка}")]
	public class МероприятияНайтиПоСсылке: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Мероприятия/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Мероприятия/ПоКоду","{Код}")]
	public class МероприятияНайтиПоКоду: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Мероприятия/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Мероприятия/ПоНаименованию","{Наименование}")]
	public class МероприятияНайтиПоНаименованию: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Мероприятия/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Мероприятия/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Мероприятия/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class МероприятияВыбратьПоСсылке: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Мероприятия/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Мероприятия/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Мероприятия/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class МероприятияВыбратьПоКоду: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Мероприятия/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Мероприятия/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Мероприятия/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class МероприятияВыбратьПоНаименованию: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Мероприятия/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class МероприятияСтраницаПоСсылке: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Мероприятия/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class МероприятияСтраницаПоКоду: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Мероприятия/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class МероприятияСтраницаПоНаименованию: V82.СправочникиСсылка.Мероприятия,IReturn<МероприятияСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class МероприятияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class МероприятияСервис : Service
	{
		
		public object Get(МероприятияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(МероприятияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.Мероприятия.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new МероприятияОтвет() { Ответ = "Мероприятия c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(МероприятияНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Мероприятия.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new МероприятияОтвет() {Ответ = "Мероприятия c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(МероприятияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(МероприятияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Мероприятия.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(МероприятияВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(МероприятияВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(МероприятияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(МероприятияСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(МероприятияСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(МероприятияЗапрос Запрос)
		{
			return new МероприятияОтвет {Ответ = "Мероприятия, "};
		}

		public object Post(МероприятияЗапрос ЗапросМероприятия)
		{
			var Ссылка = (СправочникиСсылка.Мероприятия)ЗапросМероприятия;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}