﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/Voenkomaty")]
	[Route("/Catalogs/Voenkomaty/{Code}")]
	public class VoenkomatyRequest/*ВоенкоматыЗапрос*/: V82.СправочникиСсылка.Военкоматы,IReturn<VoenkomatyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VoenkomatyResponse//ВоенкоматыОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Voenkomatys")]
	[Route("/Catalogs/Voenkomatys/{Codes}")]
	public class VoenkomatysRequest/*ВоенкоматыЗапрос*/: IReturn<List<VoenkomatyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VoenkomatysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VoenkomatysResponse//ВоенкоматыОтвет
	{
		public string Result {get;set;}
	}


	public class VoenkomatyService /*ВоенкоматыСервис*/ : Service
	{
		public object Any(VoenkomatyRequest request)
		{
			return new VoenkomatyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VoenkomatyRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.Военкоматы.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new VoenkomatyResponse() {Result = "Военкоматы c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.Военкоматы.НайтиПоКоду(1);
			}
		}

		public object Get(VoenkomatysRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.Военкоматы>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.Военкоматы.НайтиПоКоду(СтрокаКод);
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
