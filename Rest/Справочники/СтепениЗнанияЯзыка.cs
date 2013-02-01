﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/StepeniZnaniyaYAzyka")]
	[Route("/Catalogs/StepeniZnaniyaYAzyka/{Code}")]
	public class StepeniZnaniyaYAzykaRequest/*СтепениЗнанияЯзыкаЗапрос*/: V82.СправочникиСсылка.СтепениЗнанияЯзыка,IReturn<StepeniZnaniyaYAzykaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class StepeniZnaniyaYAzykaResponse//СтепениЗнанияЯзыкаОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/StepeniZnaniyaYAzykas")]
	[Route("/Catalogs/StepeniZnaniyaYAzykas/{Codes}")]
	public class StepeniZnaniyaYAzykasRequest/*СтепениЗнанияЯзыкаЗапрос*/: IReturn<List<StepeniZnaniyaYAzykaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public StepeniZnaniyaYAzykasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class StepeniZnaniyaYAzykasResponse//СтепениЗнанияЯзыкаОтвет
	{
		public string Result {get;set;}
	}


	public class StepeniZnaniyaYAzykaService /*СтепениЗнанияЯзыкаСервис*/ : Service
	{
		public object Any(StepeniZnaniyaYAzykaRequest request)
		{
			return new StepeniZnaniyaYAzykaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(StepeniZnaniyaYAzykaRequest request)
		{
			decimal СтрокаКод = 0;
			if (decimal.TryParse(request.Code, out СтрокаКод))
			{
				var Ссылка = V82.Справочники.СтепениЗнанияЯзыка.НайтиПоКоду(СтрокаКод);
				if (Ссылка == null)
				{
					return new StepeniZnaniyaYAzykaResponse() {Result = "СтепениЗнанияЯзыка c кодом '" + request.Code+"' не найдено."};
				}
				return Ссылка;
			}
			else
			{
				return V82.Справочники.СтепениЗнанияЯзыка.НайтиПоКоду(1);
			}
		}

		public object Get(StepeniZnaniyaYAzykasRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.СтепениЗнанияЯзыка>();
			foreach (var Code in request.Codes)
			{
				decimal СтрокаКод = 0;
				if (decimal.TryParse(Code, out СтрокаКод))
				{
					var Ссылка = V82.Справочники.СтепениЗнанияЯзыка.НайтиПоКоду(СтрокаКод);
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
