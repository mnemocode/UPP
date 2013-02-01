﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/ProizvolnyeOtchety")]
	[Route("/Catalogs/ProizvolnyeOtchety/{Code}")]
	public class ProizvolnyeOtchetyRequest/*ПроизвольныеОтчетыЗапрос*/: V82.СправочникиСсылка.ПроизвольныеОтчеты,IReturn<ProizvolnyeOtchetyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ProizvolnyeOtchetyResponse//ПроизвольныеОтчетыОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ProizvolnyeOtchetys")]
	[Route("/Catalogs/ProizvolnyeOtchetys/{Codes}")]
	public class ProizvolnyeOtchetysRequest/*ПроизвольныеОтчетыЗапрос*/: IReturn<List<ProizvolnyeOtchetyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ProizvolnyeOtchetysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ProizvolnyeOtchetysResponse//ПроизвольныеОтчетыОтвет
	{
		public string Result {get;set;}
	}


	public class ProizvolnyeOtchetyService /*ПроизвольныеОтчетыСервис*/ : Service
	{
		public object Any(ProizvolnyeOtchetyRequest request)
		{
			return new ProizvolnyeOtchetyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ProizvolnyeOtchetyRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.ПроизвольныеОтчеты.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new ProizvolnyeOtchetyResponse() {Result = "ПроизвольныеОтчеты c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.ПроизвольныеОтчеты.НайтиПоКоду(1);
			}
		}

		public object Get(ProizvolnyeOtchetysRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ПроизвольныеОтчеты>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.ПроизвольныеОтчеты.НайтиПоКоду(СтрокаКод);
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
