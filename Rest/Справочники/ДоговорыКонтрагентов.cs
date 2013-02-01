﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/DogovoryKontragentov")]
	[Route("/Catalogs/DogovoryKontragentov/{Code}")]
	public class DogovoryKontragentovRequest/*ДоговорыКонтрагентовЗапрос*/: V82.СправочникиСсылка.ДоговорыКонтрагентов,IReturn<DogovoryKontragentovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DogovoryKontragentovResponse//ДоговорыКонтрагентовОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DogovoryKontragentovs")]
	[Route("/Catalogs/DogovoryKontragentovs/{Codes}")]
	public class DogovoryKontragentovsRequest/*ДоговорыКонтрагентовЗапрос*/: IReturn<List<DogovoryKontragentovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DogovoryKontragentovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DogovoryKontragentovsResponse//ДоговорыКонтрагентовОтвет
	{
		public string Result {get;set;}
	}


	public class DogovoryKontragentovService /*ДоговорыКонтрагентовСервис*/ : Service
	{
		public object Any(DogovoryKontragentovRequest request)
		{
			return new DogovoryKontragentovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DogovoryKontragentovRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.ДоговорыКонтрагентов.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new DogovoryKontragentovResponse() {Result = "ДоговорыКонтрагентов c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.ДоговорыКонтрагентов.НайтиПоКоду(1);
			}
		}

		public object Get(DogovoryKontragentovsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ДоговорыКонтрагентов>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.ДоговорыКонтрагентов.НайтиПоКоду(СтрокаКод);
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
