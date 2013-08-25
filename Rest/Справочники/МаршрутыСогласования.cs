﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//MarshrutySoglasovaniya
	[Маршрут("Справочники/МаршрутыСогласования","")]
	public class МаршрутыСогласованияЗапрос: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияЗапрос>
	{
	}
	[Маршрут("Справочники/МаршрутыСогласования/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/МаршрутыСогласования/ПоСсылке","{Ссылка}")]
	public class МаршрутыСогласованияНайтиПоСсылке: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/МаршрутыСогласования/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/МаршрутыСогласования/ПоНаименованию","{Наименование}")]
	public class МаршрутыСогласованияНайтиПоНаименованию: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/МаршрутыСогласования/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/МаршрутыСогласования/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/МаршрутыСогласования/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class МаршрутыСогласованияВыбратьПоСсылке: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/МаршрутыСогласования/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/МаршрутыСогласования/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/МаршрутыСогласования/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class МаршрутыСогласованияВыбратьПоНаименованию: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/МаршрутыСогласования/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class МаршрутыСогласованияСтраницаПоСсылке: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/МаршрутыСогласования/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class МаршрутыСогласованияСтраницаПоНаименованию: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/МаршрутыСогласования/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/МаршрутыСогласования/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/МаршрутыСогласования/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class МаршрутыСогласованияИерархияВыбратьПоСсылке: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/МаршрутыСогласования/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class МаршрутыСогласованияИерархияСтраницаПоСсылке: V82.СправочникиСсылка.МаршрутыСогласования,IReturn<МаршрутыСогласованияИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class МаршрутыСогласованияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class МаршрутыСогласованияСервис : Service
	{
		
		public object Get(МаршрутыСогласованияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(МаршрутыСогласованияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.МаршрутыСогласования.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new МаршрутыСогласованияОтвет() { Ответ = "МаршрутыСогласования c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(МаршрутыСогласованияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(МаршрутыСогласованияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.МаршрутыСогласования.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(МаршрутыСогласованияВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(МаршрутыСогласованияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(МаршрутыСогласованияСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(МаршрутыСогласованияИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.МаршрутыСогласования.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(МаршрутыСогласованияИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(МаршрутыСогласованияЗапрос Запрос)
		{
			return new МаршрутыСогласованияОтвет {Ответ = "МаршрутыСогласования, "};
		}

		public object Post(МаршрутыСогласованияЗапрос ЗапросМаршрутыСогласования)
		{
			var Ссылка = (СправочникиСсылка.МаршрутыСогласования)ЗапросМаршрутыСогласования;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}