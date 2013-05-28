﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//NastrojjkiVypolneniyaObmena
	[Маршрут("Справочники/НастройкиВыполненияОбмена","")]
	public class НастройкиВыполненияОбменаЗапрос: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаЗапрос>
	{
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ПоСсылке","{Ссылка}")]
	public class НастройкиВыполненияОбменаНайтиПоСсылке: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ПоКоду","{Код}")]
	public class НастройкиВыполненияОбменаНайтиПоКоду: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ПоНаименованию","{Наименование}")]
	public class НастройкиВыполненияОбменаНайтиПоНаименованию: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиВыполненияОбменаВыбратьПоСсылке: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиВыполненияОбменаВыбратьПоКоду: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/НастройкиВыполненияОбмена/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class НастройкиВыполненияОбменаВыбратьПоНаименованию: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class НастройкиВыполненияОбменаСтраницаПоСсылке: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class НастройкиВыполненияОбменаСтраницаПоКоду: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/НастройкиВыполненияОбмена/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class НастройкиВыполненияОбменаСтраницаПоНаименованию: V82.СправочникиСсылка.НастройкиВыполненияОбмена,IReturn<НастройкиВыполненияОбменаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class НастройкиВыполненияОбменаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class НастройкиВыполненияОбменаСервис : Service
	{
		
		public object Get(НастройкиВыполненияОбменаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиВыполненияОбменаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.НастройкиВыполненияОбмена.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new НастройкиВыполненияОбменаОтвет() { Ответ = "НастройкиВыполненияОбмена c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НастройкиВыполненияОбменаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.НастройкиВыполненияОбмена.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new НастройкиВыполненияОбменаОтвет() {Ответ = "НастройкиВыполненияОбмена c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(НастройкиВыполненияОбменаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиВыполненияОбменаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.НастройкиВыполненияОбмена.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(НастройкиВыполненияОбменаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиВыполненияОбменаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиВыполненияОбменаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиВыполненияОбменаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(НастройкиВыполненияОбменаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(НастройкиВыполненияОбменаЗапрос Запрос)
		{
			return new НастройкиВыполненияОбменаОтвет {Ответ = "НастройкиВыполненияОбмена, "};
		}

		public object Post(НастройкиВыполненияОбменаЗапрос ЗапросНастройкиВыполненияОбмена)
		{
			var Ссылка = (СправочникиСсылка.НастройкиВыполненияОбмена)ЗапросНастройкиВыполненияОбмена;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}