﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VariantyNastroekFinAnaliza
	[Маршрут("Справочники/ВариантыНастроекФинАнализа","")]
	public class ВариантыНастроекФинАнализаЗапрос: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаЗапрос>
	{
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ПоСсылке","{Ссылка}")]
	public class ВариантыНастроекФинАнализаНайтиПоСсылке: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ПоКоду","{Код}")]
	public class ВариантыНастроекФинАнализаНайтиПоКоду: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ПоНаименованию","{Наименование}")]
	public class ВариантыНастроекФинАнализаНайтиПоНаименованию: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВариантыНастроекФинАнализаВыбратьПоСсылке: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВариантыНастроекФинАнализаВыбратьПоКоду: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВариантыНастроекФинАнализаВыбратьПоНаименованию: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВариантыНастроекФинАнализаСтраницаПоСсылке: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВариантыНастроекФинАнализаСтраницаПоКоду: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВариантыНастроекФинАнализа/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВариантыНастроекФинАнализаСтраницаПоНаименованию: V82.СправочникиСсылка.ВариантыНастроекФинАнализа,IReturn<ВариантыНастроекФинАнализаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВариантыНастроекФинАнализаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВариантыНастроекФинАнализаСервис : Service
	{
		
		public object Get(ВариантыНастроекФинАнализаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВариантыНастроекФинАнализаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВариантыНастроекФинАнализа.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВариантыНастроекФинАнализаОтвет() { Ответ = "ВариантыНастроекФинАнализа c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВариантыНастроекФинАнализаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВариантыНастроекФинАнализа.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВариантыНастроекФинАнализаОтвет() {Ответ = "ВариантыНастроекФинАнализа c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВариантыНастроекФинАнализаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВариантыНастроекФинАнализаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВариантыНастроекФинАнализа.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВариантыНастроекФинАнализаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВариантыНастроекФинАнализаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВариантыНастроекФинАнализаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВариантыНастроекФинАнализаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВариантыНастроекФинАнализаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВариантыНастроекФинАнализаЗапрос Запрос)
		{
			return new ВариантыНастроекФинАнализаОтвет {Ответ = "ВариантыНастроекФинАнализа, "};
		}

		public object Post(ВариантыНастроекФинАнализаЗапрос ЗапросВариантыНастроекФинАнализа)
		{
			var Ссылка = (СправочникиСсылка.ВариантыНастроекФинАнализа)ЗапросВариантыНастроекФинАнализа;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}