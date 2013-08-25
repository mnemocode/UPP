﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StatiDvizheniyaDenezhnykhSredstv
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств","")]
	public class СтатьиДвиженияДенежныхСредствЗапрос: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствЗапрос>
	{
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ПоСсылке","{Ссылка}")]
	public class СтатьиДвиженияДенежныхСредствНайтиПоСсылке: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ПоКоду","{Код}")]
	public class СтатьиДвиженияДенежныхСредствНайтиПоКоду: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ПоНаименованию","{Наименование}")]
	public class СтатьиДвиженияДенежныхСредствНайтиПоНаименованию: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиДвиженияДенежныхСредствВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиДвиженияДенежныхСредствВыбратьПоКоду: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиДвиженияДенежныхСредствВыбратьПоНаименованию: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СтатьиДвиженияДенежныхСредствСтраницаПоСсылке: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СтатьиДвиженияДенежныхСредствСтраницаПоКоду: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СтатьиДвиженияДенежныхСредствСтраницаПоНаименованию: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиДвиженияДенежныхСредствИерархияВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиДвиженияДенежныхСредств/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class СтатьиДвиженияДенежныхСредствИерархияСтраницаПоСсылке: V82.СправочникиСсылка.СтатьиДвиженияДенежныхСредств,IReturn<СтатьиДвиженияДенежныхСредствИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СтатьиДвиженияДенежныхСредствОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СтатьиДвиженияДенежныхСредствСервис : Service
	{
		
		public object Get(СтатьиДвиженияДенежныхСредствЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СтатьиДвиженияДенежныхСредств.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СтатьиДвиженияДенежныхСредствОтвет() { Ответ = "СтатьиДвиженияДенежныхСредств c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтатьиДвиженияДенежныхСредств.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтатьиДвиженияДенежныхСредствОтвет() {Ответ = "СтатьиДвиженияДенежныхСредств c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СтатьиДвиженияДенежныхСредств.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СтатьиДвиженияДенежныхСредств.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СтатьиДвиженияДенежныхСредствИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(СтатьиДвиженияДенежныхСредствЗапрос Запрос)
		{
			return new СтатьиДвиженияДенежныхСредствОтвет {Ответ = "СтатьиДвиженияДенежныхСредств, "};
		}

		public object Post(СтатьиДвиженияДенежныхСредствЗапрос ЗапросСтатьиДвиженияДенежныхСредств)
		{
			var Ссылка = (СправочникиСсылка.СтатьиДвиженияДенежныхСредств)ЗапросСтатьиДвиженияДенежныхСредств;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}