﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OsnovaniyaUvolneniyaIzOrganizacii
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации","")]
	public class ОснованияУвольненияИзОрганизацииЗапрос: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииЗапрос>
	{
	}
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ПоСсылке","{Ссылка}")]
	public class ОснованияУвольненияИзОрганизацииНайтиПоСсылке: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ПоНаименованию","{Наименование}")]
	public class ОснованияУвольненияИзОрганизацииНайтиПоНаименованию: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОснованияУвольненияИзОрганизацииВыбратьПоСсылке: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОснованияУвольненияИзОрганизацииВыбратьПоНаименованию: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОснованияУвольненияИзОрганизацииСтраницаПоСсылке: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОснованияУвольненияИзОрганизации/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОснованияУвольненияИзОрганизацииСтраницаПоНаименованию: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<ОснованияУвольненияИзОрганизацииСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОснованияУвольненияИзОрганизацииОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОснованияУвольненияИзОрганизацииСервис : Service
	{
		
		public object Get(ОснованияУвольненияИзОрганизацииЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияУвольненияИзОрганизацииНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ОснованияУвольненияИзОрганизации.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОснованияУвольненияИзОрганизацииОтвет() { Ответ = "ОснованияУвольненияИзОрганизации c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОснованияУвольненияИзОрганизацииНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияУвольненияИзОрганизацииВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОснованияУвольненияИзОрганизации.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОснованияУвольненияИзОрганизацииВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияУвольненияИзОрганизацииСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияУвольненияИзОрганизацииСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОснованияУвольненияИзОрганизацииЗапрос Запрос)
		{
			return new ОснованияУвольненияИзОрганизацииОтвет {Ответ = "ОснованияУвольненияИзОрганизации, "};
		}

		public object Post(ОснованияУвольненияИзОрганизацииЗапрос ЗапросОснованияУвольненияИзОрганизации)
		{
			var Ссылка = (СправочникиСсылка.ОснованияУвольненияИзОрганизации)ЗапросОснованияУвольненияИзОрганизации;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}