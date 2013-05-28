﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//IstochnikiInformaciiPriObrashheniiPokupatelejj
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей","")]
	public class ИсточникиИнформацииПриОбращенииПокупателейЗапрос: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейЗапрос>
	{
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ПоСсылке","{Ссылка}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейНайтиПоСсылке: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ПоКоду","{Код}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейНайтиПоКоду: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ПоНаименованию","{Наименование}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейНайтиПоНаименованию: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоСсылке: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоКоду: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоНаименованию: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоСсылке: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоКоду: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ИсточникиИнформацииПриОбращенииПокупателей/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоНаименованию: V82.СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей,IReturn<ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ИсточникиИнформацииПриОбращенииПокупателейОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ИсточникиИнформацииПриОбращенииПокупателейСервис : Service
	{
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ИсточникиИнформацииПриОбращенииПокупателей.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ИсточникиИнформацииПриОбращенииПокупателейОтвет() { Ответ = "ИсточникиИнформацииПриОбращенииПокупателей c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ИсточникиИнформацииПриОбращенииПокупателей.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ИсточникиИнформацииПриОбращенииПокупателейОтвет() {Ответ = "ИсточникиИнформацииПриОбращенииПокупателей c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ИсточникиИнформацииПриОбращенииПокупателей.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ИсточникиИнформацииПриОбращенииПокупателейСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ИсточникиИнформацииПриОбращенииПокупателейЗапрос Запрос)
		{
			return new ИсточникиИнформацииПриОбращенииПокупателейОтвет {Ответ = "ИсточникиИнформацииПриОбращенииПокупателей, "};
		}

		public object Post(ИсточникиИнформацииПриОбращенииПокупателейЗапрос ЗапросИсточникиИнформацииПриОбращенииПокупателей)
		{
			var Ссылка = (СправочникиСсылка.ИсточникиИнформацииПриОбращенииПокупателей)ЗапросИсточникиИнформацииПриОбращенииПокупателей;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}