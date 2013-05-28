﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ProfiliIzmeneniyaPlanovPoIzmereniyam
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям","")]
	public class ПрофилиИзмененияПлановПоИзмерениямЗапрос: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямЗапрос>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ПоСсылке","{Ссылка}")]
	public class ПрофилиИзмененияПлановПоИзмерениямНайтиПоСсылке: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ПоКоду","{Код}")]
	public class ПрофилиИзмененияПлановПоИзмерениямНайтиПоКоду: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ПоНаименованию","{Наименование}")]
	public class ПрофилиИзмененияПлановПоИзмерениямНайтиПоНаименованию: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиИзмененияПлановПоИзмерениямВыбратьПоСсылке: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиИзмененияПлановПоИзмерениямВыбратьПоКоду: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрофилиИзмененияПлановПоИзмерениямВыбратьПоНаименованию: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПрофилиИзмененияПлановПоИзмерениямСтраницаПоСсылке: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПрофилиИзмененияПлановПоИзмерениямСтраницаПоКоду: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрофилиИзмененияПлановПоИзмерениям/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПрофилиИзмененияПлановПоИзмерениямСтраницаПоНаименованию: V82.СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям,IReturn<ПрофилиИзмененияПлановПоИзмерениямСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПрофилиИзмененияПлановПоИзмерениямОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПрофилиИзмененияПлановПоИзмерениямСервис : Service
	{
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ПрофилиИзмененияПлановПоИзмерениям.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПрофилиИзмененияПлановПоИзмерениямОтвет() { Ответ = "ПрофилиИзмененияПлановПоИзмерениям c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПрофилиИзмененияПлановПоИзмерениям.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПрофилиИзмененияПлановПоИзмерениямОтвет() {Ответ = "ПрофилиИзмененияПлановПоИзмерениям c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ПрофилиИзмененияПлановПоИзмерениям.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрофилиИзмененияПлановПоИзмерениямСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПрофилиИзмененияПлановПоИзмерениямЗапрос Запрос)
		{
			return new ПрофилиИзмененияПлановПоИзмерениямОтвет {Ответ = "ПрофилиИзмененияПлановПоИзмерениям, "};
		}

		public object Post(ПрофилиИзмененияПлановПоИзмерениямЗапрос ЗапросПрофилиИзмененияПлановПоИзмерениям)
		{
			var Ссылка = (СправочникиСсылка.ПрофилиИзмененияПлановПоИзмерениям)ЗапросПрофилиИзмененияПлановПоИзмерениям;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}