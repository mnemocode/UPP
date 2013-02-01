﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchete")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchete/{Code}")]
	public class SposobyOtrazheniyaZarplatyVUprUcheteRequest/*СпособыОтраженияЗарплатыВУпрУчетеЗапрос*/: V82.СправочникиСсылка.СпособыОтраженияЗарплатыВУпрУчете,IReturn<SposobyOtrazheniyaZarplatyVUprUcheteRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SposobyOtrazheniyaZarplatyVUprUcheteResponse//СпособыОтраженияЗарплатыВУпрУчетеОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchetes")]
	[Route("/Catalogs/SposobyOtrazheniyaZarplatyVUprUchetes/{Codes}")]
	public class SposobyOtrazheniyaZarplatyVUprUchetesRequest/*СпособыОтраженияЗарплатыВУпрУчетеЗапрос*/: IReturn<List<SposobyOtrazheniyaZarplatyVUprUcheteRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SposobyOtrazheniyaZarplatyVUprUchetesRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SposobyOtrazheniyaZarplatyVUprUchetesResponse//СпособыОтраженияЗарплатыВУпрУчетеОтвет
	{
		public string Result {get;set;}
	}


	public class SposobyOtrazheniyaZarplatyVUprUcheteService /*СпособыОтраженияЗарплатыВУпрУчетеСервис*/ : Service
	{
		public object Any(SposobyOtrazheniyaZarplatyVUprUcheteRequest request)
		{
			return new SposobyOtrazheniyaZarplatyVUprUcheteResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SposobyOtrazheniyaZarplatyVUprUcheteRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.СпособыОтраженияЗарплатыВУпрУчете.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new SposobyOtrazheniyaZarplatyVUprUcheteResponse() {Result = "СпособыОтраженияЗарплатыВУпрУчете c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.СпособыОтраженияЗарплатыВУпрУчете.НайтиПоКоду(1);
			}
		}

		public object Get(SposobyOtrazheniyaZarplatyVUprUchetesRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.СпособыОтраженияЗарплатыВУпрУчете>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.СпособыОтраженияЗарплатыВУпрУчете.НайтиПоКоду(СтрокаКод);
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
