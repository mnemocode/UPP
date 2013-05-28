﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KlassifikatorIspolzovaniyaRabochegoVremeni
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени","")]
	public class КлассификаторИспользованияРабочегоВремениЗапрос: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениЗапрос>
	{
	}
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ПоСсылке","{Ссылка}")]
	public class КлассификаторИспользованияРабочегоВремениНайтиПоСсылке: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ПоНаименованию","{Наименование}")]
	public class КлассификаторИспользованияРабочегоВремениНайтиПоНаименованию: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторИспользованияРабочегоВремениВыбратьПоСсылке: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторИспользованияРабочегоВремениВыбратьПоНаименованию: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КлассификаторИспользованияРабочегоВремениСтраницаПоСсылке: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлассификаторИспользованияРабочегоВремени/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КлассификаторИспользованияРабочегоВремениСтраницаПоНаименованию: V82.СправочникиСсылка.КлассификаторИспользованияРабочегоВремени,IReturn<КлассификаторИспользованияРабочегоВремениСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КлассификаторИспользованияРабочегоВремениОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КлассификаторИспользованияРабочегоВремениСервис : Service
	{
		
		public object Get(КлассификаторИспользованияРабочегоВремениЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторИспользованияРабочегоВремениНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.КлассификаторИспользованияРабочегоВремени.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КлассификаторИспользованияРабочегоВремениОтвет() { Ответ = "КлассификаторИспользованияРабочегоВремени c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КлассификаторИспользованияРабочегоВремениНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторИспользованияРабочегоВремениВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.КлассификаторИспользованияРабочегоВремени.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КлассификаторИспользованияРабочегоВремениВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторИспользованияРабочегоВремениСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторИспользованияРабочегоВремениСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КлассификаторИспользованияРабочегоВремениЗапрос Запрос)
		{
			return new КлассификаторИспользованияРабочегоВремениОтвет {Ответ = "КлассификаторИспользованияРабочегоВремени, "};
		}

		public object Post(КлассификаторИспользованияРабочегоВремениЗапрос ЗапросКлассификаторИспользованияРабочегоВремени)
		{
			var Ссылка = (СправочникиСсылка.КлассификаторИспользованияРабочегоВремени)ЗапросКлассификаторИспользованияРабочегоВремени;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}