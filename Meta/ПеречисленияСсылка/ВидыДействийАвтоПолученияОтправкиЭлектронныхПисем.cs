﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем
	{
		ПустаяСсылка = - 1,
		Получение = 0,
		Отправка = 1,
		ПолучениеИОтправка = 2,//Получение и отправка
	}
	public static partial class ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Получение = new Guid("800622a6-96de-e04a-4e21-ba00e857914b");
		public static readonly Guid Отправка = new Guid("dca06b99-31e4-f0e6-43ee-cad371a3dd39");
		public static readonly Guid ПолучениеИОтправка = new Guid("6cd4a2ac-b567-3c21-4b31-6b1368b3b97d");//Получение и отправка
		public static ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем Получить(this ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем Получить(this ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем Значение, Guid Ссылка)
		{
			if(Ссылка == Получение)
			{
				return ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.Получение;
			}
			else if(Ссылка == Отправка)
			{
				return ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.Отправка;
			}
			else if(Ссылка == ПолучениеИОтправка)
			{
				return ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.ПолучениеИОтправка;
			}
			return ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем Значение)
		{
			switch (Значение)
			{
				case ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.Получение: return Получение;
				case ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.Отправка: return Отправка;
				case ВидыДействийАвтоПолученияОтправкиЭлектронныхПисем.ПолучениеИОтправка: return ПолучениеИОтправка;
			}
			return Guid.Empty;
		}
	}
}
