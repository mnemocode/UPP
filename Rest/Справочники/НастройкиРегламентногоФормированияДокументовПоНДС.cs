﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDS")]
	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDS/{Code}")]
	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest/*НастройкиРегламентногоФормированияДокументовПоНДСЗапрос*/: V82.СправочникиСсылка.НастройкиРегламентногоФормированияДокументовПоНДС,IReturn<NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSResponse//НастройкиРегламентногоФормированияДокументовПоНДСОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSs")]
	[Route("/Catalogs/NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSs/{Codes}")]
	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsRequest/*НастройкиРегламентногоФормированияДокументовПоНДСЗапрос*/: IReturn<List<NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsResponse//НастройкиРегламентногоФормированияДокументовПоНДСОтвет
	{
		public string Result {get;set;}
	}


	public class NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSService /*НастройкиРегламентногоФормированияДокументовПоНДССервис*/ : Service
	{
		public object Any(NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest request)
		{
			return new NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.НастройкиРегламентногоФормированияДокументовПоНДС.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSResponse() {Result = "НастройкиРегламентногоФормированияДокументовПоНДС c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.НастройкиРегламентногоФормированияДокументовПоНДС.НайтиПоКоду(1);
			}
		}

		public object Get(NastrojjkiReglamentnogoFormirovaniyaDokumentovPoNDSsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.НастройкиРегламентногоФормированияДокументовПоНДС>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.НастройкиРегламентногоФормированияДокументовПоНДС.НайтиПоКоду(СтрокаКод);
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
