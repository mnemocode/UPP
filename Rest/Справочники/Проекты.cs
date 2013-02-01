﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/Proekty")]
	[Route("/Catalogs/Proekty/{Code}")]
	public class ProektyRequest/*ПроектыЗапрос*/: V82.СправочникиСсылка.Проекты,IReturn<ProektyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProektyResponse//ПроектыОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Proektys")]
	[Route("/Catalogs/Proektys/{Codes}")]
	public class ProektysRequest/*ПроектыЗапрос*/: IReturn<List<ProektyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProektysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProektysResponse//ПроектыОтвет
	{
		public string Result {get;set;}
	}


	public class ProektyService /*ПроектыСервис*/ : Service
	{
		public object Any(ProektyRequest request)
		{
			return new ProektyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProektyRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.Проекты.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new ProektyResponse() {Result = "Проекты c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.Проекты.НайтиПоКоду(1);
			}
		}

		public object Get(ProektysRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.Проекты>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.Проекты.НайтиПоКоду(СтрокаКод);
					if (Ссылка != null)
					{
						Коллекция.Add(Ссылка);
					}
				}
			}
			return Коллекция;
		}

	}
}
