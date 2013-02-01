﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыДенежныхДокументов
	{
		ПустаяСсылка = - 1,
		Билеты = 0,
		Путевки = 1,
		ПочтовыеМарки = 2,//Почтовые марки
		ТалоныНаГСМ = 3,//Талоны на ГСМ
		Прочее = 4,
	}
	public static partial class ВидыДенежныхДокументов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Билеты = new Guid("d595bca2-3b42-294d-4faf-26b1ed0a65c3");
		public static readonly Guid Путевки = new Guid("21425caf-231f-f702-48e7-fb5e59221c90");
		public static readonly Guid ПочтовыеМарки = new Guid("4ce0e7bb-0280-1a56-4825-cbc38b113ee1");//Почтовые марки
		public static readonly Guid ТалоныНаГСМ = new Guid("e9d38b84-7d4f-ea1a-47a0-dd94689411e7");//Талоны на ГСМ
		public static readonly Guid Прочее = new Guid("7754aea1-310a-024f-49e6-7cb1d67f01d1");
		public static ВидыДенежныхДокументов Получить(this ВидыДенежныхДокументов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДенежныхДокументов Получить(this ВидыДенежныхДокументов Значение, Guid Ссылка)
		{
			if(Ссылка == Билеты)
			{
				return ВидыДенежныхДокументов.Билеты;
			}
			else if(Ссылка == Путевки)
			{
				return ВидыДенежныхДокументов.Путевки;
			}
			else if(Ссылка == ПочтовыеМарки)
			{
				return ВидыДенежныхДокументов.ПочтовыеМарки;
			}
			else if(Ссылка == ТалоныНаГСМ)
			{
				return ВидыДенежныхДокументов.ТалоныНаГСМ;
			}
			else if(Ссылка == Прочее)
			{
				return ВидыДенежныхДокументов.Прочее;
			}
			return ВидыДенежныхДокументов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДенежныхДокументов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДенежныхДокументов Значение)
		{
			switch (Значение)
			{
				case ВидыДенежныхДокументов.Билеты: return Билеты;
				case ВидыДенежныхДокументов.Путевки: return Путевки;
				case ВидыДенежныхДокументов.ПочтовыеМарки: return ПочтовыеМарки;
				case ВидыДенежныхДокументов.ТалоныНаГСМ: return ТалоныНаГСМ;
				case ВидыДенежныхДокументов.Прочее: return Прочее;
			}
			return Guid.Empty;
		}
	}
}
