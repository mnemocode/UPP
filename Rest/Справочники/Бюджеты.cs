﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//Byudzhety
	[Маршрут("Справочники/Бюджеты","")]
	public class БюджетыЗапрос: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыЗапрос>
	{
	}
	[Маршрут("Справочники/Бюджеты/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/Бюджеты/ПоСсылке","{Ссылка}")]
	public class БюджетыНайтиПоСсылке: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/Бюджеты/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/Бюджеты/ПоНаименованию","{Наименование}")]
	public class БюджетыНайтиПоНаименованию: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/Бюджеты/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/Бюджеты/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Бюджеты/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class БюджетыВыбратьПоСсылке: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Бюджеты/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/Бюджеты/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Бюджеты/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class БюджетыВыбратьПоНаименованию: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/Бюджеты/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class БюджетыСтраницаПоСсылке: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Бюджеты/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class БюджетыСтраницаПоНаименованию: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/Бюджеты/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/Бюджеты/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/Бюджеты/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class БюджетыИерархияВыбратьПоСсылке: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/Бюджеты/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class БюджетыИерархияСтраницаПоСсылке: V82.СправочникиСсылка.Бюджеты,IReturn<БюджетыИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class БюджетыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class БюджетыСервис : Service
	{
		
		public object Get(БюджетыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(БюджетыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.Бюджеты.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new БюджетыОтвет() { Ответ = "Бюджеты c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(БюджетыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(БюджетыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Бюджеты.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(БюджетыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(БюджетыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(БюджетыСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(БюджетыИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.Бюджеты.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(БюджетыИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(БюджетыЗапрос Запрос)
		{
			return new БюджетыОтвет {Ответ = "Бюджеты, "};
		}

		public object Post(БюджетыЗапрос ЗапросБюджеты)
		{
			var Ссылка = (СправочникиСсылка.Бюджеты)ЗапросБюджеты;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}