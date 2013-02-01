﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/VersiiFajjlov")]
	[Route("/Catalogs/VersiiFajjlov/{Code}")]
	public class VersiiFajjlovRequest/*ВерсииФайловЗапрос*/: V82.СправочникиСсылка.ВерсииФайлов,IReturn<VersiiFajjlovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class VersiiFajjlovResponse//ВерсииФайловОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/VersiiFajjlovs")]
	[Route("/Catalogs/VersiiFajjlovs/{Codes}")]
	public class VersiiFajjlovsRequest/*ВерсииФайловЗапрос*/: IReturn<List<VersiiFajjlovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public VersiiFajjlovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class VersiiFajjlovsResponse//ВерсииФайловОтвет
	{
		public string Result {get;set;}
	}


	public class VersiiFajjlovService /*ВерсииФайловСервис*/ : Service
	{
		public object Any(VersiiFajjlovRequest request)
		{
			return new VersiiFajjlovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(VersiiFajjlovRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.ВерсииФайлов.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new VersiiFajjlovResponse() {Result = "ВерсииФайлов c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.ВерсииФайлов.НайтиПоКоду(1);
			}
		}

		public object Get(VersiiFajjlovsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ВерсииФайлов>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.ВерсииФайлов.НайтиПоКоду(СтрокаКод);
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
