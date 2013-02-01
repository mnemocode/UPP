﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/KompetenciiRabotnikov")]
	[Route("/Catalogs/KompetenciiRabotnikov/{Code}")]
	public class KompetenciiRabotnikovRequest/*КомпетенцииРаботниковЗапрос*/: V82.СправочникиСсылка.КомпетенцииРаботников,IReturn<KompetenciiRabotnikovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KompetenciiRabotnikovResponse//КомпетенцииРаботниковОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KompetenciiRabotnikovs")]
	[Route("/Catalogs/KompetenciiRabotnikovs/{Codes}")]
	public class KompetenciiRabotnikovsRequest/*КомпетенцииРаботниковЗапрос*/: IReturn<List<KompetenciiRabotnikovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KompetenciiRabotnikovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KompetenciiRabotnikovsResponse//КомпетенцииРаботниковОтвет
	{
		public string Result {get;set;}
	}


	public class KompetenciiRabotnikovService /*КомпетенцииРаботниковСервис*/ : Service
	{
		public object Any(KompetenciiRabotnikovRequest request)
		{
			return new KompetenciiRabotnikovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KompetenciiRabotnikovRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.КомпетенцииРаботников.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new KompetenciiRabotnikovResponse() {Result = "КомпетенцииРаботников c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.КомпетенцииРаботников.НайтиПоКоду(1);
			}
		}

		public object Get(KompetenciiRabotnikovsRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.КомпетенцииРаботников>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.КомпетенцииРаботников.НайтиПоКоду(СтрокаКод);
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
