﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VneshnieObrabotki
	[Маршрут("Справочники/ВнешниеОбработки","")]
	public class ВнешниеОбработкиЗапрос: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиЗапрос>
	{
	}
	[Маршрут("Справочники/ВнешниеОбработки/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВнешниеОбработки/ПоСсылке","{Ссылка}")]
	public class ВнешниеОбработкиНайтиПоСсылке: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВнешниеОбработки/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВнешниеОбработки/ПоКоду","{Код}")]
	public class ВнешниеОбработкиНайтиПоКоду: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВнешниеОбработки/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВнешниеОбработки/ПоНаименованию","{Наименование}")]
	public class ВнешниеОбработкиНайтиПоНаименованию: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВнешниеОбработкиВыбратьПоСсылке: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВнешниеОбработкиВыбратьПоКоду: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВнешниеОбработки/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВнешниеОбработкиВыбратьПоНаименованию: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВнешниеОбработки/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВнешниеОбработкиСтраницаПоСсылке: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВнешниеОбработки/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВнешниеОбработкиСтраницаПоКоду: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВнешниеОбработки/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВнешниеОбработкиСтраницаПоНаименованию: V82.СправочникиСсылка.ВнешниеОбработки,IReturn<ВнешниеОбработкиСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВнешниеОбработкиОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВнешниеОбработкиСервис : Service
	{
		
		public object Get(ВнешниеОбработкиЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВнешниеОбработкиНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВнешниеОбработки.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВнешниеОбработкиОтвет() { Ответ = "ВнешниеОбработки c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВнешниеОбработкиНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВнешниеОбработки.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВнешниеОбработкиОтвет() {Ответ = "ВнешниеОбработки c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВнешниеОбработкиНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВнешниеОбработкиВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВнешниеОбработки.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВнешниеОбработкиВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВнешниеОбработкиВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВнешниеОбработкиСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВнешниеОбработкиСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВнешниеОбработкиСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВнешниеОбработкиЗапрос Запрос)
		{
			return new ВнешниеОбработкиОтвет {Ответ = "ВнешниеОбработки, "};
		}

		public object Post(ВнешниеОбработкиЗапрос ЗапросВнешниеОбработки)
		{
			var Ссылка = (СправочникиСсылка.ВнешниеОбработки)ЗапросВнешниеОбработки;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}