﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВариантыВерсионированияОбъектов
	{
		ПустаяСсылка = - 1,
		ВерсионироватьВсегда = 0,//Версионировать
		ВерсионироватьПриПроведении = 1,//Версионировать при проведении
		НеВерсионировать = 2,//Не версионировать
	}
	public static partial class ВариантыВерсионированияОбъектов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ВерсионироватьВсегда = new Guid("7c4002b9-76e9-e917-4da6-320bde1b792d");//Версионировать
		public static readonly Guid ВерсионироватьПриПроведении = new Guid("d365cc98-4a70-1116-4c0a-89331ec1cf2d");//Версионировать при проведении
		public static readonly Guid НеВерсионировать = new Guid("3384d89c-3bd8-fdb1-4636-4d1ece81a111");//Не версионировать
		public static ВариантыВерсионированияОбъектов Получить(this ВариантыВерсионированияОбъектов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыВерсионированияОбъектов Получить(this ВариантыВерсионированияОбъектов Значение, Guid Ссылка)
		{
			if(Ссылка == ВерсионироватьВсегда)
			{
				return ВариантыВерсионированияОбъектов.ВерсионироватьВсегда;
			}
			else if(Ссылка == ВерсионироватьПриПроведении)
			{
				return ВариантыВерсионированияОбъектов.ВерсионироватьПриПроведении;
			}
			else if(Ссылка == НеВерсионировать)
			{
				return ВариантыВерсионированияОбъектов.НеВерсионировать;
			}
			return ВариантыВерсионированияОбъектов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыВерсионированияОбъектов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыВерсионированияОбъектов Значение)
		{
			switch (Значение)
			{
				case ВариантыВерсионированияОбъектов.ВерсионироватьВсегда: return ВерсионироватьВсегда;
				case ВариантыВерсионированияОбъектов.ВерсионироватьПриПроведении: return ВерсионироватьПриПроведении;
				case ВариантыВерсионированияОбъектов.НеВерсионировать: return НеВерсионировать;
			}
			return Guid.Empty;
		}
	}
}
