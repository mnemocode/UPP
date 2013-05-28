﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Dolzhnosti
	[Маршрут("Справочники/Должности","")]
	public class ДолжностиЗапрос: V82.СправочникиСсылка.Должности,IReturn<ДолжностиЗапрос>
	{
	}
	[Маршрут("Справочники/Должности/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Должности/ПоСсылке","{Ссылка}")]
	public class ДолжностиНайтиПоСсылке: V82.СправочникиСсылка.Должности,IReturn<ДолжностиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Должности/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/Должности/ПоКоду","{Код}")]
	public class ДолжностиНайтиПоКоду: V82.СправочникиСсылка.Должности,IReturn<ДолжностиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/Должности/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Должности/ПоНаименованию","{Наименование}")]
	public class ДолжностиНайтиПоНаименованию: V82.СправочникиСсылка.Должности,IReturn<ДолжностиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Должности/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Должности/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Должности/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ДолжностиВыбратьПоСсылке: V82.СправочникиСсылка.Должности,IReturn<ДолжностиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Должности/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/Должности/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Должности/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ДолжностиВыбратьПоКоду: V82.СправочникиСсылка.Должности,IReturn<ДолжностиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Должности/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Должности/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Должности/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ДолжностиВыбратьПоНаименованию: V82.СправочникиСсылка.Должности,IReturn<ДолжностиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Должности/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ДолжностиСтраницаПоСсылке: V82.СправочникиСсылка.Должности,IReturn<ДолжностиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Должности/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ДолжностиСтраницаПоКоду: V82.СправочникиСсылка.Должности,IReturn<ДолжностиСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Должности/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ДолжностиСтраницаПоНаименованию: V82.СправочникиСсылка.Должности,IReturn<ДолжностиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ДолжностиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ДолжностиСервис : Service
	{
		
		public object Get(ДолжностиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ДолжностиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.Должности.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ДолжностиОтвет() { Ответ = "Должности c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ДолжностиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.Должности.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ДолжностиОтвет() {Ответ = "Должности c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ДолжностиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДолжностиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Должности.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ДолжностиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДолжностиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ДолжностиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ДолжностиСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ДолжностиСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ДолжностиЗапрос Запрос)
		{
			return new ДолжностиОтвет {Ответ = "Должности, "};
		}

		public object Post(ДолжностиЗапрос ЗапросДолжности)
		{
			var Ссылка = (СправочникиСсылка.Должности)ЗапросДолжности;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}