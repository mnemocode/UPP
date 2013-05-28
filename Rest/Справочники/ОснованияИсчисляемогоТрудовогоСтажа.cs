﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OsnovaniyaIschislyaemogoTrudovogoStazha
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа","")]
	public class ОснованияИсчисляемогоТрудовогоСтажаЗапрос: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаЗапрос>
	{
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ПоСсылке","{Ссылка}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаНайтиПоСсылке: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ПоКоду","{Код}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаНайтиПоКоду: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ПоНаименованию","{Наименование}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаНайтиПоНаименованию: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоСсылке: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоКоду: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоНаименованию: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоСсылке: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоКоду: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОснованияИсчисляемогоТрудовогоСтажа/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоНаименованию: V82.СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа,IReturn<ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОснованияИсчисляемогоТрудовогоСтажаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОснованияИсчисляемогоТрудовогоСтажаСервис : Service
	{
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ОснованияИсчисляемогоТрудовогоСтажа.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОснованияИсчисляемогоТрудовогоСтажаОтвет() { Ответ = "ОснованияИсчисляемогоТрудовогоСтажа c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОснованияИсчисляемогоТрудовогоСтажа.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОснованияИсчисляемогоТрудовогоСтажаОтвет() {Ответ = "ОснованияИсчисляемогоТрудовогоСтажа c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОснованияИсчисляемогоТрудовогоСтажа.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОснованияИсчисляемогоТрудовогоСтажаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОснованияИсчисляемогоТрудовогоСтажаЗапрос Запрос)
		{
			return new ОснованияИсчисляемогоТрудовогоСтажаОтвет {Ответ = "ОснованияИсчисляемогоТрудовогоСтажа, "};
		}

		public object Post(ОснованияИсчисляемогоТрудовогоСтажаЗапрос ЗапросОснованияИсчисляемогоТрудовогоСтажа)
		{
			var Ссылка = (СправочникиСсылка.ОснованияИсчисляемогоТрудовогоСтажа)ЗапросОснованияИсчисляемогоТрудовогоСтажа;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}