﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/VidyStazha")]
	[Route("/Catalogs/VidyStazha/{Code}")]
	public class VidyStazhaRequest/*ВидыСтажаЗапрос*/: V82.СправочникиСсылка.ВидыСтажа,IReturn<VidyStazhaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VidyStazhaResponse//ВидыСтажаОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VidyStazhas")]
	[Route("/Catalogs/VidyStazhas/{Codes}")]
	public class VidyStazhasRequest/*ВидыСтажаЗапрос*/: IReturn<List<VidyStazhaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VidyStazhasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VidyStazhasResponse//ВидыСтажаОтвет
	{
		public string Result {get;set;}
	}


	public class VidyStazhaService /*ВидыСтажаСервис*/ : Service
	{
		public object Any(VidyStazhaRequest request)
		{
			return new VidyStazhaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VidyStazhaRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.ВидыСтажа.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new VidyStazhaResponse() {Result = "ВидыСтажа c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.ВидыСтажа.НайтиПоКоду(1);
			}
		}

		public object Get(VidyStazhasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ВидыСтажа>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.ВидыСтажа.НайтиПоКоду(СтрокаКод);
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
