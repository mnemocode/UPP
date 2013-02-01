﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/AdresnyeSokrashheniya")]
	[Route("/Catalogs/AdresnyeSokrashheniya/{Code}")]
	public class AdresnyeSokrashheniyaRequest/*АдресныеСокращенияЗапрос*/: V82.СправочникиСсылка.АдресныеСокращения,IReturn<AdresnyeSokrashheniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class AdresnyeSokrashheniyaResponse//АдресныеСокращенияОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/AdresnyeSokrashheniyas")]
	[Route("/Catalogs/AdresnyeSokrashheniyas/{Codes}")]
	public class AdresnyeSokrashheniyasRequest/*АдресныеСокращенияЗапрос*/: IReturn<List<AdresnyeSokrashheniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public AdresnyeSokrashheniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class AdresnyeSokrashheniyasResponse//АдресныеСокращенияОтвет
	{
		public string Result {get;set;}
	}


	public class AdresnyeSokrashheniyaService /*АдресныеСокращенияСервис*/ : Service
	{
		public object Any(AdresnyeSokrashheniyaRequest request)
		{
			return new AdresnyeSokrashheniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(AdresnyeSokrashheniyaRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.АдресныеСокращения.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new AdresnyeSokrashheniyaResponse() {Result = "АдресныеСокращения c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.АдресныеСокращения.НайтиПоКоду(1);
			}
		}

		public object Get(AdresnyeSokrashheniyasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.АдресныеСокращения>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.АдресныеСокращения.НайтиПоКоду(СтрокаКод);
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
