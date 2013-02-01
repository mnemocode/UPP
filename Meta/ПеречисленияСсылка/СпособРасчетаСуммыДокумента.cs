﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum СпособРасчетаСуммыДокумента
	{
		ПустаяСсылка = - 1,
		СУчетомВсехСкидок = 0,//С учетом всех скидок
		БезУчетаРучнойСкидки = 1,//Без учета ручной скидки
		БезУчетаСкидок = 2,//Без учета скидок
	}
	public static partial class СпособРасчетаСуммыДокумента_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СУчетомВсехСкидок = new Guid("0bc706a3-a36a-2b9b-4926-9b92dea26745");//С учетом всех скидок
		public static readonly Guid БезУчетаРучнойСкидки = new Guid("a24b92bb-64b9-37a6-40ab-775934f637a7");//Без учета ручной скидки
		public static readonly Guid БезУчетаСкидок = new Guid("6735bbae-1a8a-31c9-4466-1101c8fe2a21");//Без учета скидок
		public static СпособРасчетаСуммыДокумента Получить(this СпособРасчетаСуммыДокумента Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособРасчетаСуммыДокумента Получить(this СпособРасчетаСуммыДокумента Значение, Guid Ссылка)
		{
			if(Ссылка == СУчетомВсехСкидок)
			{
				return СпособРасчетаСуммыДокумента.СУчетомВсехСкидок;
			}
			else if(Ссылка == БезУчетаРучнойСкидки)
			{
				return СпособРасчетаСуммыДокумента.БезУчетаРучнойСкидки;
			}
			else if(Ссылка == БезУчетаСкидок)
			{
				return СпособРасчетаСуммыДокумента.БезУчетаСкидок;
			}
			return СпособРасчетаСуммыДокумента.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособРасчетаСуммыДокумента Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособРасчетаСуммыДокумента Значение)
		{
			switch (Значение)
			{
				case СпособРасчетаСуммыДокумента.СУчетомВсехСкидок: return СУчетомВсехСкидок;
				case СпособРасчетаСуммыДокумента.БезУчетаРучнойСкидки: return БезУчетаРучнойСкидки;
				case СпособРасчетаСуммыДокумента.БезУчетаСкидок: return БезУчетаСкидок;
			}
			return Guid.Empty;
		}
	}
}
