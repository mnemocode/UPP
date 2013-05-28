﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OstatkiOtpuskovOrganizacijj
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций","")]
	public class ОстаткиОтпусковОрганизацийЗапрос: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийЗапрос>
	{
	}
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ПоСсылке","{Ссылка}")]
	public class ОстаткиОтпусковОрганизацийНайтиПоСсылке: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ПоНаименованию","{Наименование}")]
	public class ОстаткиОтпусковОрганизацийНайтиПоНаименованию: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОстаткиОтпусковОрганизацийВыбратьПоСсылке: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОстаткиОтпусковОрганизацийВыбратьПоНаименованию: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОстаткиОтпусковОрганизацийСтраницаПоСсылке: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОстаткиОтпусковОрганизаций/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОстаткиОтпусковОрганизацийСтраницаПоНаименованию: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<ОстаткиОтпусковОрганизацийСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОстаткиОтпусковОрганизацийОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОстаткиОтпусковОрганизацийСервис : Service
	{
		
		public object Get(ОстаткиОтпусковОрганизацийЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковОрганизацийНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ОстаткиОтпусковОрганизаций.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОстаткиОтпусковОрганизацийОтвет() { Ответ = "ОстаткиОтпусковОрганизаций c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОстаткиОтпусковОрганизацийНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковОрганизацийВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОстаткиОтпусковОрганизаций.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОстаткиОтпусковОрганизацийВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковОрганизацийСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОстаткиОтпусковОрганизацийСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОстаткиОтпусковОрганизацийЗапрос Запрос)
		{
			return new ОстаткиОтпусковОрганизацийОтвет {Ответ = "ОстаткиОтпусковОрганизаций, "};
		}

		public object Post(ОстаткиОтпусковОрганизацийЗапрос ЗапросОстаткиОтпусковОрганизаций)
		{
			var Ссылка = (СправочникиСсылка.ОстаткиОтпусковОрганизаций)ЗапросОстаткиОтпусковОрганизаций;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}