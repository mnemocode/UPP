﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//ProchieDokhodyIRaskhody
	[Маршрут("Справочники/ПрочиеДоходыИРасходы","")]
	public class ПрочиеДоходыИРасходыЗапрос: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыЗапрос>
	{
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ПоСсылке","{Ссылка}")]
	public class ПрочиеДоходыИРасходыНайтиПоСсылке: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ПоКоду","{Код}")]
	public class ПрочиеДоходыИРасходыНайтиПоКоду: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ПоНаименованию","{Наименование}")]
	public class ПрочиеДоходыИРасходыНайтиПоНаименованию: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрочиеДоходыИРасходыВыбратьПоСсылке: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрочиеДоходыИРасходыВыбратьПоКоду: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ПрочиеДоходыИРасходыВыбратьПоНаименованию: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ПрочиеДоходыИРасходыСтраницаПоСсылке: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ПрочиеДоходыИРасходыСтраницаПоКоду: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ПрочиеДоходыИРасходы/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ПрочиеДоходыИРасходыСтраницаПоНаименованию: V82.СправочникиСсылка.ПрочиеДоходыИРасходы,IReturn<ПрочиеДоходыИРасходыСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ПрочиеДоходыИРасходыОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ПрочиеДоходыИРасходыСервис : Service
	{
		
		public object Get(ПрочиеДоходыИРасходыЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ПрочиеДоходыИРасходыНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ПрочиеДоходыИРасходы.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ПрочиеДоходыИРасходыОтвет() { Ответ = "ПрочиеДоходыИРасходы c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПрочиеДоходыИРасходыНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ПрочиеДоходыИРасходы.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ПрочиеДоходыИРасходыОтвет() {Ответ = "ПрочиеДоходыИРасходы c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ПрочиеДоходыИРасходыНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрочиеДоходыИРасходыВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ПрочиеДоходыИРасходы.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ПрочиеДоходыИРасходыВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрочиеДоходыИРасходыВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ПрочиеДоходыИРасходыСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ПрочиеДоходыИРасходыСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ПрочиеДоходыИРасходыСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ПрочиеДоходыИРасходыЗапрос Запрос)
		{
			return new ПрочиеДоходыИРасходыОтвет {Ответ = "ПрочиеДоходыИРасходы, "};
		}

		public object Post(ПрочиеДоходыИРасходыЗапрос ЗапросПрочиеДоходыИРасходы)
		{
			var Ссылка = (СправочникиСсылка.ПрочиеДоходыИРасходы)ЗапросПрочиеДоходыИРасходы;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}