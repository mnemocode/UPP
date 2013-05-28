﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//SemejjnoePolozhenieFizLic
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц","")]
	public class СемейноеПоложениеФизЛицЗапрос: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицЗапрос>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ПоСсылке","{Ссылка}")]
	public class СемейноеПоложениеФизЛицНайтиПоСсылке: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ПоКоду","{Код}")]
	public class СемейноеПоложениеФизЛицНайтиПоКоду: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ПоНаименованию","{Наименование}")]
	public class СемейноеПоложениеФизЛицНайтиПоНаименованию: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class СемейноеПоложениеФизЛицВыбратьПоСсылке: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class СемейноеПоложениеФизЛицВыбратьПоКоду: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class СемейноеПоложениеФизЛицВыбратьПоНаименованию: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class СемейноеПоложениеФизЛицСтраницаПоСсылке: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class СемейноеПоложениеФизЛицСтраницаПоКоду: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/СемейноеПоложениеФизЛиц/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class СемейноеПоложениеФизЛицСтраницаПоНаименованию: V82.СправочникиСсылка.СемейноеПоложениеФизЛиц,IReturn<СемейноеПоложениеФизЛицСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class СемейноеПоложениеФизЛицОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class СемейноеПоложениеФизЛицСервис : Service
	{
		
		public object Get(СемейноеПоложениеФизЛицЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.СемейноеПоложениеФизЛиц.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new СемейноеПоложениеФизЛицОтвет() { Ответ = "СемейноеПоложениеФизЛиц c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СемейноеПоложениеФизЛицНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.СемейноеПоложениеФизЛиц.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new СемейноеПоложениеФизЛицОтвет() {Ответ = "СемейноеПоложениеФизЛиц c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(СемейноеПоложениеФизЛицНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.СемейноеПоложениеФизЛиц.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(СемейноеПоложениеФизЛицВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(СемейноеПоложениеФизЛицСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(СемейноеПоложениеФизЛицЗапрос Запрос)
		{
			return new СемейноеПоложениеФизЛицОтвет {Ответ = "СемейноеПоложениеФизЛиц, "};
		}

		public object Post(СемейноеПоложениеФизЛицЗапрос ЗапросСемейноеПоложениеФизЛиц)
		{
			var Ссылка = (СправочникиСсылка.СемейноеПоложениеФизЛиц)ЗапросСемейноеПоложениеФизЛиц;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}