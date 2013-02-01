﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeni")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeni/{Code}")]
	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest/*НастройкиФормированияДокументовОтработанногоВремениЗапрос*/: V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени,IReturn<NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniResponse//НастройкиФормированияДокументовОтработанногоВремениОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenis")]
	[Route("/Catalogs/NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenis/{Codes}")]
	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisRequest/*НастройкиФормированияДокументовОтработанногоВремениЗапрос*/: IReturn<List<NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisResponse//НастройкиФормированияДокументовОтработанногоВремениОтвет
	{
		public string Result {get;set;}
	}


	public class NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniService /*НастройкиФормированияДокументовОтработанногоВремениСервис*/ : Service
	{
		public object Any(NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest request)
		{
			return new NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.НастройкиФормированияДокументовОтработанногоВремени.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremeniResponse() {Result = "НастройкиФормированияДокументовОтработанногоВремени c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.НастройкиФормированияДокументовОтработанногоВремени.НайтиПоКоду(1);
			}
		}

		public object Get(NastrojjkiFormirovaniyaDokumentovOtrabotannogoVremenisRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.НастройкиФормированияДокументовОтработанногоВремени.НайтиПоКоду(СтрокаКод);
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
