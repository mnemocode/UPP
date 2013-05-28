﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NematerialnyeAktivy
	[Маршрут("Справочники/НематериальныеАктивы","")]
	public class НематериальныеАктивыЗапрос: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыЗапрос>
	{
	}
	[Маршрут("Справочники/НематериальныеАктивы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НематериальныеАктивы/ПоСсылке","{Ссылка}")]
	public class НематериальныеАктивыНайтиПоСсылке: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НематериальныеАктивы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/НематериальныеАктивы/ПоКоду","{Код}")]
	public class НематериальныеАктивыНайтиПоКоду: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/НематериальныеАктивы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НематериальныеАктивы/ПоНаименованию","{Наименование}")]
	public class НематериальныеАктивыНайтиПоНаименованию: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НематериальныеАктивыВыбратьПоСсылке: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class НематериальныеАктивыВыбратьПоКоду: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НематериальныеАктивы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НематериальныеАктивыВыбратьПоНаименованию: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НематериальныеАктивы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НематериальныеАктивыСтраницаПоСсылке: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НематериальныеАктивы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class НематериальныеАктивыСтраницаПоКоду: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НематериальныеАктивы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НематериальныеАктивыСтраницаПоНаименованию: V82.СправочникиСсылка.НематериальныеАктивы,IReturn<НематериальныеАктивыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НематериальныеАктивыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НематериальныеАктивыСервис : Service
	{
		
		public object Get(НематериальныеАктивыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НематериальныеАктивыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.НематериальныеАктивы.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НематериальныеАктивыОтвет() { Ответ = "НематериальныеАктивы c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НематериальныеАктивыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.НематериальныеАктивы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new НематериальныеАктивыОтвет() {Ответ = "НематериальныеАктивы c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НематериальныеАктивыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НематериальныеАктивыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.НематериальныеАктивы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НематериальныеАктивыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НематериальныеАктивыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НематериальныеАктивыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НематериальныеАктивыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НематериальныеАктивыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НематериальныеАктивыЗапрос Запрос)
		{
			return new НематериальныеАктивыОтвет {Ответ = "НематериальныеАктивы, "};
		}

		public object Post(НематериальныеАктивыЗапрос ЗапросНематериальныеАктивы)
		{
			var Ссылка = (СправочникиСсылка.НематериальныеАктивы)ЗапросНематериальныеАктивы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}