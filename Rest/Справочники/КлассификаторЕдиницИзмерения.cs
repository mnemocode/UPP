﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KlassifikatorEdinicIzmereniya
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения","")]
	public class КлассификаторЕдиницИзмеренияЗапрос: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияЗапрос>
	{
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ПоСсылке","{Ссылка}")]
	public class КлассификаторЕдиницИзмеренияНайтиПоСсылке: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ПоКоду","{Код}")]
	public class КлассификаторЕдиницИзмеренияНайтиПоКоду: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ПоНаименованию","{Наименование}")]
	public class КлассификаторЕдиницИзмеренияНайтиПоНаименованию: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторЕдиницИзмеренияВыбратьПоСсылке: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторЕдиницИзмеренияВыбратьПоКоду: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class КлассификаторЕдиницИзмеренияВыбратьПоНаименованию: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КлассификаторЕдиницИзмеренияСтраницаПоСсылке: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class КлассификаторЕдиницИзмеренияСтраницаПоКоду: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КлассификаторЕдиницИзмерения/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class КлассификаторЕдиницИзмеренияСтраницаПоНаименованию: V82.СправочникиСсылка.КлассификаторЕдиницИзмерения,IReturn<КлассификаторЕдиницИзмеренияСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КлассификаторЕдиницИзмеренияОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КлассификаторЕдиницИзмеренияСервис : Service
	{
		
		public object Get(КлассификаторЕдиницИзмеренияЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.КлассификаторЕдиницИзмерения.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КлассификаторЕдиницИзмеренияОтвет() { Ответ = "КлассификаторЕдиницИзмерения c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КлассификаторЕдиницИзмеренияНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.КлассификаторЕдиницИзмерения.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new КлассификаторЕдиницИзмеренияОтвет() {Ответ = "КлассификаторЕдиницИзмерения c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КлассификаторЕдиницИзмеренияНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.КлассификаторЕдиницИзмерения.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КлассификаторЕдиницИзмеренияСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(КлассификаторЕдиницИзмеренияЗапрос Запрос)
		{
			return new КлассификаторЕдиницИзмеренияОтвет {Ответ = "КлассификаторЕдиницИзмерения, "};
		}

		public object Post(КлассификаторЕдиницИзмеренияЗапрос ЗапросКлассификаторЕдиницИзмерения)
		{
			var Ссылка = (СправочникиСсылка.КлассификаторЕдиницИзмерения)ЗапросКлассификаторЕдиницИзмерения;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}