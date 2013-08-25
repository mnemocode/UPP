﻿
using System;
using Rest;
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	//KodyOKPD
	[Маршрут("Справочники/КодыОКПД","")]
	public class КодыОКПДЗапрос: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДЗапрос>
	{
	}
	[Маршрут("Справочники/КодыОКПД/НайтиПоСсылке","{Ссылка}")]
	[Маршрут("Справочники/КодыОКПД/ПоСсылке","{Ссылка}")]
	public class КодыОКПДНайтиПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДНайтиПоСсылке>
	{
	}
	[Маршрут("Справочники/КодыОКПД/НайтиПоКоду","{Код}")]
	[Маршрут("Справочники/КодыОКПД/ПоКоду","{Код}")]
	public class КодыОКПДНайтиПоКоду: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДНайтиПоКоду>
	{
	}
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоСсылке","{___Первые}")]
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоСсылке","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоСсылке","{___Первые}/{___Мин}/{___Макс}")]
	public class КодыОКПДВыбратьПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДВыбратьПоСсылке>
	{
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоКоду","{___Первые}")]
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоКоду","{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КодыОКПД/ВыбратьПоКоду","{___Первые}/{___Мин}/{___Макс}")]
	public class КодыОКПДВыбратьПоКоду: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДВыбратьПоКоду>
	{
		public int ___Первые {get; set;}
		public string ___Мин {get; set;}
		public string ___Макс {get; set;}
	}
	[Маршрут("Справочники/КодыОКПД/СтраницаПоСсылке","{___Размер}/{___Номер}")]
	public class КодыОКПДСтраницаПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДСтраницаПоСсылке>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КодыОКПД/СтраницаПоКоду","{___Размер}/{___Номер}")]
	public class КодыОКПДСтраницаПоКоду: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДСтраницаПоКоду>
	{
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}
	[Маршрут("Справочники/КодыОКПД/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}")]
	[Маршрут("Справочники/КодыОКПД/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}")]
	[Маршрут("Справочники/КодыОКПД/ИерархияВыбратьПоСсылке","{___Родитель}/{___Режим}/{___Первые}/{___Мин}/{___Макс}")]
	public class КодыОКПДИерархияВыбратьПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДИерархияВыбратьПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Первые {get; set;}
		public Guid ___Мин {get; set;}
		public Guid ___Макс {get; set;}
	}
	[Маршрут("Справочники/КодыОКПД/ИерархияСтраницаПоСсылке","{___Родитель}/{___Режим}/{___Размер}/{___Номер}")]
	public class КодыОКПДИерархияСтраницаПоСсылке: V82.СправочникиСсылка.КодыОКПД,IReturn<КодыОКПДИерархияСтраницаПоСсылке>
	{
		public Guid ___Родитель {get; set;}
		public int ___Режим {get; set;}
		public int ___Размер {get; set;}
		public int ___Номер {get; set;}
	}

	public class КодыОКПДОтвет
	{
		public string Ответ {get;set;}
	}

	public partial class КодыОКПДСервис : Service
	{
		
		public object Get(КодыОКПДЗапрос Запрос)
		{
			return null;
		}
		
		public object Get(КодыОКПДНайтиПоСсылке Запрос)
		{
			if (Запрос.Ссылка == null)
			{
				return null;
			}
			var Ссылка = V82.Справочники.КодыОКПД.НайтиПоСсылке(Запрос.Ссылка);
			if (Ссылка == null)
			{
				return new КодыОКПДОтвет() { Ответ = "КодыОКПД c ссылкой '" + Запрос.Ссылка + "' не найден." };
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КодыОКПДНайтиПоКоду Запрос)
		{
			if(Запрос.Код == null)
			{
				return null;
			}
			var СтрокаКод = System.Uri.UnescapeDataString(Запрос.Код);
			var Ссылка = V82.Справочники.КодыОКПД.НайтиПоКоду(СтрокаКод);
			if (Ссылка == null)
			{
				return new КодыОКПДОтвет() {Ответ = "КодыОКПД c кодом '" + Запрос.Код + "' не найдено."};
			}
			return Ссылка.ПолучитьОбъект();
		}
		
		public object Get(КодыОКПДВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.КодыОКПД.ВыбратьПоСсылке(Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КодыОКПДВыбратьПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КодыОКПДСтраницаПоСсылке Запрос)
		{
			return null;
		}
		
		public object Get(КодыОКПДСтраницаПоКоду Запрос)
		{
			return null;
		}
		
		public object Get(КодыОКПДИерархияВыбратьПоСсылке Запрос)
		{
			if (Запрос.___Макс == Guid.Empty)
			{
				Запрос.___Макс = Guid.Parse("ffffffff-ffff-ffff-ffff-ffffffffffff");
			}
			var Коллекция = new List<object>();
			foreach (var Ссылка in V82.Справочники.КодыОКПД.ИерархияВыбратьПоСсылке(Запрос.___Родитель,Запрос.___Режим,Запрос.___Первые, Запрос.___Мин, Запрос.___Макс))
			{
				Коллекция.Add(Ссылка.ПолучитьОбъект());
			}
			return Коллекция;
		}
		
		public object Get(КодыОКПДИерархияСтраницаПоСсылке Запрос)
		{
			return null;
		}

		public object Any(КодыОКПДЗапрос Запрос)
		{
			return new КодыОКПДОтвет {Ответ = "КодыОКПД, "};
		}

		public object Post(КодыОКПДЗапрос ЗапросКодыОКПД)
		{
			var Ссылка = (СправочникиСсылка.КодыОКПД)ЗапросКодыОКПД;
			var Объект = Ссылка.ПолучитьОбъект();
			Объект.Записать();
			return null;
		}


	}
}