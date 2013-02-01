﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/OstatkiOtpuskovOrganizacijj")]
	[Route("/Catalogs/OstatkiOtpuskovOrganizacijj/{Code}")]
	public class OstatkiOtpuskovOrganizacijjRequest/*ОстаткиОтпусковОрганизацийЗапрос*/: V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций,IReturn<OstatkiOtpuskovOrganizacijjRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OstatkiOtpuskovOrganizacijjResponse//ОстаткиОтпусковОрганизацийОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OstatkiOtpuskovOrganizacijjs")]
	[Route("/Catalogs/OstatkiOtpuskovOrganizacijjs/{Codes}")]
	public class OstatkiOtpuskovOrganizacijjsRequest/*ОстаткиОтпусковОрганизацийЗапрос*/: IReturn<List<OstatkiOtpuskovOrganizacijjRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OstatkiOtpuskovOrganizacijjsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OstatkiOtpuskovOrganizacijjsResponse//ОстаткиОтпусковОрганизацийОтвет
	{
		public string Result {get;set;}
	}


	public class OstatkiOtpuskovOrganizacijjService /*ОстаткиОтпусковОрганизацийСервис*/ : Service
	{
		public object Any(OstatkiOtpuskovOrganizacijjRequest request)
		{
			return new OstatkiOtpuskovOrganizacijjResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OstatkiOtpuskovOrganizacijjRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.ОстаткиОтпусковОрганизаций.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new OstatkiOtpuskovOrganizacijjResponse() {Result = "ОстаткиОтпусковОрганизаций c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.ОстаткиОтпусковОрганизаций.НайтиПоКоду(1);
			}
		}

		public object Get(OstatkiOtpuskovOrganizacijjsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ОстаткиОтпусковОрганизаций>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.ОстаткиОтпусковОрганизаций.НайтиПоКоду(СтрокаКод);
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
