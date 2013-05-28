﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyVzaimoraschetov
	[Маршрут("Справочники/ВидыВзаиморасчетов","")]
	public class ВидыВзаиморасчетовЗапрос: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ПоСсылке","{Ссылка}")]
	public class ВидыВзаиморасчетовНайтиПоСсылке: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ПоКоду","{Код}")]
	public class ВидыВзаиморасчетовНайтиПоКоду: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ПоНаименованию","{Наименование}")]
	public class ВидыВзаиморасчетовНайтиПоНаименованию: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыВзаиморасчетовВыбратьПоСсылке: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыВзаиморасчетовВыбратьПоКоду: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыВзаиморасчетов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыВзаиморасчетовВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыВзаиморасчетовСтраницаПоСсылке: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыВзаиморасчетовСтраницаПоКоду: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыВзаиморасчетов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыВзаиморасчетовСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыВзаиморасчетов,IReturn<ВидыВзаиморасчетовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыВзаиморасчетовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВидыВзаиморасчетовСервис : Service
	{
		
		public object Get(ВидыВзаиморасчетовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВидыВзаиморасчетовНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВидыВзаиморасчетов.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВидыВзаиморасчетовОтвет() { Ответ = "ВидыВзаиморасчетов c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыВзаиморасчетовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыВзаиморасчетов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыВзаиморасчетовОтвет() {Ответ = "ВидыВзаиморасчетов c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыВзаиморасчетовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыВзаиморасчетовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВидыВзаиморасчетов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВидыВзаиморасчетовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыВзаиморасчетовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыВзаиморасчетовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыВзаиморасчетовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыВзаиморасчетовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыВзаиморасчетовЗапрос Запрос)
		{
			return new ВидыВзаиморасчетовОтвет {Ответ = "ВидыВзаиморасчетов, "};
		}

		public object Post(ВидыВзаиморасчетовЗапрос ЗапросВидыВзаиморасчетов)
		{
			var Ссылка = (СправочникиСсылка.ВидыВзаиморасчетов)ЗапросВидыВзаиморасчетов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}