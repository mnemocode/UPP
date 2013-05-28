﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//VidyEzhegodnykhOtpuskov
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков","")]
	public class ВидыЕжегодныхОтпусковЗапрос: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковЗапрос>
	{
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ПоСсылке","{Ссылка}")]
	public class ВидыЕжегодныхОтпусковНайтиПоСсылке: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ПоКоду","{Код}")]
	public class ВидыЕжегодныхОтпусковНайтиПоКоду: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/НайтиПоНаименованию","{Наименование}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ПоНаименованию","{Наименование}")]
	public class ВидыЕжегодныхОтпусковНайтиПоНаименованию: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковНайтиПоНаименованию>
	{
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЕжегодныхОтпусковВыбратьПоСсылке: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЕжегодныхОтпусковВыбратьПоКоду: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоНаименованию","{___Первые}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоНаименованию","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/ВыбратьПоНаименованию","{___Первые}/{___Мин}/{___Макс}")]
	public class ВидыЕжегодныхОтпусковВыбратьПоНаименованию: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковВыбратьПоНаименованию>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class ВидыЕжегодныхОтпусковСтраницаПоСсылке: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class ВидыЕжегодныхОтпусковСтраницаПоКоду: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/ВидыЕжегодныхОтпусков/СтраницаПоНаименованию","{___Размер}/{___Номер}")]
	public class ВидыЕжегодныхОтпусковСтраницаПоНаименованию: V82.СправочникиСсылка.ВидыЕжегодныхОтпусков,IReturn<ВидыЕжегодныхОтпусковСтраницаПоНаименованию>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class ВидыЕжегодныхОтпусковОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class ВидыЕжегодныхОтпусковСервис : Service
	{
		
		public object Get(ВидыЕжегодныхОтпусковЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЕжегодныхОтпусковНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.ВидыЕжегодныхОтпусков.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new ВидыЕжегодныхОтпусковОтвет() { Ответ = "ВидыЕжегодныхОтпусков c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыЕжегодныхОтпусковНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.ВидыЕжегодныхОтпусков.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new ВидыЕжегодныхОтпусковОтвет() {Ответ = "ВидыЕжегодныхОтпусков c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(ВидыЕжегодныхОтпусковНайтиПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЕжегодныхОтпусковВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.ВидыЕжегодныхОтпусков.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(ВидыЕжегодныхОтпусковВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЕжегодныхОтпусковВыбратьПоНаименованию Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЕжегодныхОтпусковСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЕжегодныхОтпусковСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(ВидыЕжегодныхОтпусковСтраницаПоНаименованию Запрос)
		{
			return null;
		}

		public object Any(ВидыЕжегодныхОтпусковЗапрос Запрос)
		{
			return new ВидыЕжегодныхОтпусковОтвет {Ответ = "ВидыЕжегодныхОтпусков, "};
		}

		public object Post(ВидыЕжегодныхОтпусковЗапрос ЗапросВидыЕжегодныхОтпусков)
		{
			var Ссылка = (СправочникиСсылка.ВидыЕжегодныхОтпусков)ЗапросВидыЕжегодныхОтпусков;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}