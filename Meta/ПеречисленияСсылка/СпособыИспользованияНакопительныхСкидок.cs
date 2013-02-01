﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum СпособыИспользованияНакопительныхСкидок
	{
		ПустаяСсылка = - 1,
		СкидкиНакапливаютсяПоДисконтнойКарте = 0,//Скидки накапливаются по дисконтной карте
		СкидкиНакапливаютсяПоВладельцуДисконтнойКарты = 1,//Скидки накапливаются по владельцу дисконтной карты
	}
	public static partial class СпособыИспользованияНакопительныхСкидок_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СкидкиНакапливаютсяПоДисконтнойКарте = new Guid("d0e9968e-d8f3-c9bc-499b-5981fb9df0cc");//Скидки накапливаются по дисконтной карте
		public static readonly Guid СкидкиНакапливаютсяПоВладельцуДисконтнойКарты = new Guid("093739a7-37b2-91a5-4971-047f88001e0e");//Скидки накапливаются по владельцу дисконтной карты
		public static СпособыИспользованияНакопительныхСкидок Получить(this СпособыИспользованияНакопительныхСкидок Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыИспользованияНакопительныхСкидок Получить(this СпособыИспользованияНакопительныхСкидок Значение, Guid Ссылка)
		{
			if(Ссылка == СкидкиНакапливаютсяПоДисконтнойКарте)
			{
				return СпособыИспользованияНакопительныхСкидок.СкидкиНакапливаютсяПоДисконтнойКарте;
			}
			else if(Ссылка == СкидкиНакапливаютсяПоВладельцуДисконтнойКарты)
			{
				return СпособыИспользованияНакопительныхСкидок.СкидкиНакапливаютсяПоВладельцуДисконтнойКарты;
			}
			return СпособыИспользованияНакопительныхСкидок.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыИспользованияНакопительныхСкидок Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыИспользованияНакопительныхСкидок Значение)
		{
			switch (Значение)
			{
				case СпособыИспользованияНакопительныхСкидок.СкидкиНакапливаютсяПоДисконтнойКарте: return СкидкиНакапливаютсяПоДисконтнойКарте;
				case СпособыИспользованияНакопительныхСкидок.СкидкиНакапливаютсяПоВладельцуДисконтнойКарты: return СкидкиНакапливаютсяПоВладельцуДисконтнойКарты;
			}
			return Guid.Empty;
		}
	}
}
