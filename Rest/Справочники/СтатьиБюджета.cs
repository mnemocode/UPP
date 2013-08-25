﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//StatiByudzheta
	[Маршрут("Справочники/СтатьиБюджета","")]
	public class СтатьиБюджетаЗапрос: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаЗапрос>
	{
	}
	[Маршрут("Справочники/СтатьиБюджета/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СтатьиБюджета/ПоСсылке","{Ссылка}")]
	public class СтатьиБюджетаНайтиПоСсылке: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СтатьиБюджета/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СтатьиБюджета/ПоКоду","{Код}")]
	public class СтатьиБюджетаНайтиПоКоду: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СтатьиБюджета/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СтатьиБюджета/ПоНаименованию","{Наименование}")]
	public class СтатьиБюджетаНайтиПоНаименованию: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиБюджетаВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиБюджетаВыбратьПоКоду: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиБюджета/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиБюджетаВыбратьПоНаименованию: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СтатьиБюджетаСтраницаПоСсылке: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СтатьиБюджетаСтраницаПоКоду: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СтатьиБюджетаСтраницаПоНаименованию: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/СтатьиБюджета/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СтатьиБюджета/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class СтатьиБюджетаИерархияВыбратьПоСсылке: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СтатьиБюджета/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class СтатьиБюджетаИерархияСтраницаПоСсылке: V82.СправочникиСсылка.СтатьиБюджета,IReturn<СтатьиБюджетаИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СтатьиБюджетаОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СтатьиБюджетаСервис : Service
	{
		
		public object Get(СтатьиБюджетаЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СтатьиБюджета.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СтатьиБюджетаОтвет() { Ответ = "СтатьиБюджета c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СтатьиБюджетаНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СтатьиБюджета.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СтатьиБюджетаОтвет() {Ответ = "СтатьиБюджета c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СтатьиБюджетаНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СтатьиБюджета.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СтатьиБюджетаВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаСтраницаПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СтатьиБюджетаИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СтатьиБюджета.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СтатьиБюджетаИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(СтатьиБюджетаЗапрос Запрос)
		{
			return new СтатьиБюджетаОтвет {Ответ = "СтатьиБюджета, "};
		}

		public object Post(СтатьиБюджетаЗапрос ЗапросСтатьиБюджета)
		{
			var Ссылка = (СправочникиСсылка.СтатьиБюджета)ЗапросСтатьиБюджета;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}