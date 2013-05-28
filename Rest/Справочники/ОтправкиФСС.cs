﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//OtpravkiFSS
	[Маршрут("Справочники/ОтправкиФСС","")]
	public class ОтправкиФССЗапрос: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССЗапрос>
	{
	}
	[Маршрут("Справочники/ОтправкиФСС/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ОтправкиФСС/ПоСсылке","{Ссылка}")]
	public class ОтправкиФССНайтиПоСсылке: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ОтправкиФСС/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ОтправкиФСС/ПоКоду","{Код}")]
	public class ОтправкиФССНайтиПоКоду: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ОтправкиФСС/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ОтправкиФСС/ПоНаименованию","{Наименование}")]
	public class ОтправкиФССНайтиПоНаименованию: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтправкиФССВыбратьПоСсылке: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтправкиФССВыбратьПоКоду: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ОтправкиФСС/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ОтправкиФССВыбратьПоНаименованию: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФССВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ОтправкиФСС/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ОтправкиФСССтраницаПоСсылке: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФСССтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОтправкиФСС/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ОтправкиФСССтраницаПоКоду: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФСССтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ОтправкиФСС/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ОтправкиФСССтраницаПоНаименованию: V82.СправочникиСсылка.ОтправкиФСС,IReturn<ОтправкиФСССтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ОтправкиФССОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ОтправкиФСССервис : Service
	{
		
		public object Get(ОтправкиФССЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ОтправкиФССНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ОтправкиФСС.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ОтправкиФССОтвет() { Ответ = "ОтправкиФСС c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОтправкиФССНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ОтправкиФСС.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ОтправкиФССОтвет() {Ответ = "ОтправкиФСС c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ОтправкиФССНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОтправкиФССВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ОтправкиФСС.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ОтправкиФССВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОтправкиФССВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ОтправкиФСССтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ОтправкиФСССтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ОтправкиФСССтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ОтправкиФССЗапрос Запрос)
		{
			return new ОтправкиФССОтвет {Ответ = "ОтправкиФСС, "};
		}

		public object Post(ОтправкиФССЗапрос ЗапросОтправкиФСС)
		{
			var Ссылка = (СправочникиСсылка.ОтправкиФСС)ЗапросОтправкиФСС;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}