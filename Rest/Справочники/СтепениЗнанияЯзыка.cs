﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StepeniZnaniyaYAzyka
	[Маршрут("Справочники/СтепениЗнанияЯзыка","")]
	public class СтепениЗнанияЯзыкаЗапрос: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаЗапрос>
	{
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ПоСсылке","{Ссылка}")]
	public class СтепениЗнанияЯзыкаНайтиПоСсылке: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ПоКоду","{Код}")]
	public class СтепениЗнанияЯзыкаНайтиПоКоду: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ПоНаименованию","{Наименование}")]
	public class СтепениЗнанияЯзыкаНайтиПоНаименованию: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтепениЗнанияЯзыкаВыбратьПоСсылке: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтепениЗнанияЯзыкаВыбратьПоКоду: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтепениЗнанияЯзыка/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтепениЗнанияЯзыкаВыбратьПоНаименованию: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СтепениЗнанияЯзыкаСтраницаПоСсылке: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СтепениЗнанияЯзыкаСтраницаПоКоду: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтепениЗнанияЯзыка/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СтепениЗнанияЯзыкаСтраницаПоНаименованию: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<СтепениЗнанияЯзыкаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СтепениЗнанияЯзыкаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СтепениЗнанияЯзыкаСервис : Service
	{
		
		public object Get(СтепениЗнанияЯзыкаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СтепениЗнанияЯзыкаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СтепениЗнанияЯзыка.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СтепениЗнанияЯзыкаОтвет() { Ответ = "СтепениЗнанияЯзыка c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СтепениЗнанияЯзыкаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтепениЗнанияЯзыка.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтепениЗнанияЯзыкаОтвет() {Ответ = "СтепениЗнанияЯзыка c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СтепениЗнанияЯзыкаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтепениЗнанияЯзыкаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СтепениЗнанияЯзыка.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СтепениЗнанияЯзыкаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтепениЗнанияЯзыкаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтепениЗнанияЯзыкаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтепениЗнанияЯзыкаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтепениЗнанияЯзыкаСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СтепениЗнанияЯзыкаЗапрос Запрос)
		{
			return new СтепениЗнанияЯзыкаОтвет {Ответ = "СтепениЗнанияЯзыка, "};
		}

		public object Post(СтепениЗнанияЯзыкаЗапрос ЗапросСтепениЗнанияЯзыка)
		{
			var Ссылка = (СправочникиСсылка.СтепениЗнанияЯзыка)ЗапросСтепениЗнанияЯзыка;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}