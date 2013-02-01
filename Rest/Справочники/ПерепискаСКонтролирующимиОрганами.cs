﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganami")]
	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganami/{Code}")]
	public class PerepiskaSKontroliruyushhimiOrganamiRequest/*ПерепискаСКонтролирующимиОрганамиЗапрос*/: V82.СправочникиСсылка.ПерепискаСКонтролирующимиОрганами,IReturn<PerepiskaSKontroliruyushhimiOrganamiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class PerepiskaSKontroliruyushhimiOrganamiResponse//ПерепискаСКонтролирующимиОрганамиОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganamis")]
	[Route("/Catalogs/PerepiskaSKontroliruyushhimiOrganamis/{Codes}")]
	public class PerepiskaSKontroliruyushhimiOrganamisRequest/*ПерепискаСКонтролирующимиОрганамиЗапрос*/: IReturn<List<PerepiskaSKontroliruyushhimiOrganamiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public PerepiskaSKontroliruyushhimiOrganamisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class PerepiskaSKontroliruyushhimiOrganamisResponse//ПерепискаСКонтролирующимиОрганамиОтвет
	{
		public string Result {get;set;}
	}


	public class PerepiskaSKontroliruyushhimiOrganamiService /*ПерепискаСКонтролирующимиОрганамиСервис*/ : Service
	{
		public object Any(PerepiskaSKontroliruyushhimiOrganamiRequest request)
		{
			return new PerepiskaSKontroliruyushhimiOrganamiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(PerepiskaSKontroliruyushhimiOrganamiRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.ПерепискаСКонтролирующимиОрганами.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new PerepiskaSKontroliruyushhimiOrganamiResponse() {Result = "ПерепискаСКонтролирующимиОрганами c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.ПерепискаСКонтролирующимиОрганами.НайтиПоКоду(1);
			}
		}

		public object Get(PerepiskaSKontroliruyushhimiOrganamisRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ПерепискаСКонтролирующимиОрганами>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.ПерепискаСКонтролирующимиОрганами.НайтиПоКоду(СтрокаКод);
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
