﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VlozheniyaEHlektronnykhPisem
	[Маршрут("Справочники/ВложенияЭлектронныхПисем","")]
	public class ВложенияЭлектронныхПисемЗапрос: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемЗапрос>
	{
	}
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ПоСсылке","{Ссылка}")]
	public class ВложенияЭлектронныхПисемНайтиПоСсылке: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ПоНаименованию","{Наименование}")]
	public class ВложенияЭлектронныхПисемНайтиПоНаименованию: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВложенияЭлектронныхПисемВыбратьПоСсылке: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВложенияЭлектронныхПисемВыбратьПоНаименованию: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВложенияЭлектронныхПисемСтраницаПоСсылке: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВложенияЭлектронныхПисем/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВложенияЭлектронныхПисемСтраницаПоНаименованию: V82.СправочникиСсылка.ВложенияЭлектронныхПисем,IReturn<ВложенияЭлектронныхПисемСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВложенияЭлектронныхПисемОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВложенияЭлектронныхПисемСервис : Service
	{
		
		public object Get(ВложенияЭлектронныхПисемЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВложенияЭлектронныхПисемНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВложенияЭлектронныхПисем.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВложенияЭлектронныхПисемОтвет() { Ответ = "ВложенияЭлектронныхПисем c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВложенияЭлектронныхПисемНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВложенияЭлектронныхПисемВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВложенияЭлектронныхПисем.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВложенияЭлектронныхПисемВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВложенияЭлектронныхПисемСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВложенияЭлектронныхПисемСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВложенияЭлектронныхПисемЗапрос Запрос)
		{
			return new ВложенияЭлектронныхПисемОтвет {Ответ = "ВложенияЭлектронныхПисем, "};
		}

		public object Post(ВложенияЭлектронныхПисемЗапрос ЗапросВложенияЭлектронныхПисем)
		{
			var Ссылка = (СправочникиСсылка.ВложенияЭлектронныхПисем)ЗапросВложенияЭлектронныхПисем;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}