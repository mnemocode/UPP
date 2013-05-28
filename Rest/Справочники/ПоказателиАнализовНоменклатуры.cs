﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//PokazateliAnalizovNomenklatury
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры","")]
	public class ПоказателиАнализовНоменклатурыЗапрос: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыЗапрос>
	{
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ПоСсылке","{Ссылка}")]
	public class ПоказателиАнализовНоменклатурыНайтиПоСсылке: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ПоКоду","{Код}")]
	public class ПоказателиАнализовНоменклатурыНайтиПоКоду: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ПоНаименованию","{Наименование}")]
	public class ПоказателиАнализовНоменклатурыНайтиПоНаименованию: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоказателиАнализовНоменклатурыВыбратьПоСсылке: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоказателиАнализовНоменклатурыВыбратьПоКоду: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПоказателиАнализовНоменклатурыВыбратьПоНаименованию: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПоказателиАнализовНоменклатурыСтраницаПоСсылке: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПоказателиАнализовНоменклатурыСтраницаПоКоду: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПоказателиАнализовНоменклатуры/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПоказателиАнализовНоменклатурыСтраницаПоНаименованию: V82.СправочникиСсылка.ПоказателиАнализовНоменклатуры,IReturn<ПоказателиАнализовНоменклатурыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПоказателиАнализовНоменклатурыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПоказателиАнализовНоменклатурыСервис : Service
	{
		
		public object Get(ПоказателиАнализовНоменклатурыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ПоказателиАнализовНоменклатуры.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПоказателиАнализовНоменклатурыОтвет() { Ответ = "ПоказателиАнализовНоменклатуры c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПоказателиАнализовНоменклатурыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПоказателиАнализовНоменклатуры.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПоказателиАнализовНоменклатурыОтвет() {Ответ = "ПоказателиАнализовНоменклатуры c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПоказателиАнализовНоменклатурыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ПоказателиАнализовНоменклатуры.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПоказателиАнализовНоменклатурыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПоказателиАнализовНоменклатурыЗапрос Запрос)
		{
			return new ПоказателиАнализовНоменклатурыОтвет {Ответ = "ПоказателиАнализовНоменклатуры, "};
		}

		public object Post(ПоказателиАнализовНоменклатурыЗапрос ЗапросПоказателиАнализовНоменклатуры)
		{
			var Ссылка = (СправочникиСсылка.ПоказателиАнализовНоменклатуры)ЗапросПоказателиАнализовНоменклатуры;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}