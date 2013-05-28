﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//GruppyZayavokKandidatov
	[Маршрут("Справочники/ГруппыЗаявокКандидатов","")]
	public class ГруппыЗаявокКандидатовЗапрос: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовЗапрос>
	{
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ПоСсылке","{Ссылка}")]
	public class ГруппыЗаявокКандидатовНайтиПоСсылке: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ПоКоду","{Код}")]
	public class ГруппыЗаявокКандидатовНайтиПоКоду: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ПоНаименованию","{Наименование}")]
	public class ГруппыЗаявокКандидатовНайтиПоНаименованию: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ГруппыЗаявокКандидатовВыбратьПоСсылке: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ГруппыЗаявокКандидатовВыбратьПоКоду: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ГруппыЗаявокКандидатовВыбратьПоНаименованию: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ГруппыЗаявокКандидатовСтраницаПоСсылке: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ГруппыЗаявокКандидатовСтраницаПоКоду: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ГруппыЗаявокКандидатов/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ГруппыЗаявокКандидатовСтраницаПоНаименованию: V82.СправочникиСсылка.ГруппыЗаявокКандидатов,IReturn<ГруппыЗаявокКандидатовСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ГруппыЗаявокКандидатовОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ГруппыЗаявокКандидатовСервис : Service
	{
		
		public object Get(ГруппыЗаявокКандидатовЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ГруппыЗаявокКандидатовНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ГруппыЗаявокКандидатов.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ГруппыЗаявокКандидатовОтвет() { Ответ = "ГруппыЗаявокКандидатов c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ГруппыЗаявокКандидатовНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ГруппыЗаявокКандидатов.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ГруппыЗаявокКандидатовОтвет() {Ответ = "ГруппыЗаявокКандидатов c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ГруппыЗаявокКандидатовНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ГруппыЗаявокКандидатовВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ГруппыЗаявокКандидатов.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ГруппыЗаявокКандидатовВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ГруппыЗаявокКандидатовВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ГруппыЗаявокКандидатовСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ГруппыЗаявокКандидатовСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ГруппыЗаявокКандидатовСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ГруппыЗаявокКандидатовЗапрос Запрос)
		{
			return new ГруппыЗаявокКандидатовОтвет {Ответ = "ГруппыЗаявокКандидатов, "};
		}

		public object Post(ГруппыЗаявокКандидатовЗапрос ЗапросГруппыЗаявокКандидатов)
		{
			var Ссылка = (СправочникиСсылка.ГруппыЗаявокКандидатов)ЗапросГруппыЗаявокКандидатов;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}