﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ШаблонЗаполненияГрафикаРаботы
	{
		ПустаяСсылка = - 1,
		Пятидневка40 = 0,//Пятидневка 40 часов
		Шестидневка40 = 1,//Шестидневка 40 часов
		СуткиЧерезДвое = 2,//Сутки через двое
		СуткиЧерезТрое = 3,//Сутки через трое
		КалендарныеДни = 4,//Календарные дни
	}
	public static partial class ШаблонЗаполненияГрафикаРаботы_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Пятидневка40 = new Guid("f89c62b3-4055-5b7f-43f3-362e194f999e");//Пятидневка 40 часов
		public static readonly Guid Шестидневка40 = new Guid("4b111db6-a913-d2f8-4434-0965abd9272e");//Шестидневка 40 часов
		public static readonly Guid СуткиЧерезДвое = new Guid("0557f9a5-f1cc-7468-42d6-737eb8b0bf6d");//Сутки через двое
		public static readonly Guid СуткиЧерезТрое = new Guid("145262a1-6598-3d1e-4bdd-5eaf174f7a63");//Сутки через трое
		public static readonly Guid КалендарныеДни = new Guid("ee506585-ff70-71d5-4ed6-b11354721a77");//Календарные дни
		public static ШаблонЗаполненияГрафикаРаботы Получить(this ШаблонЗаполненияГрафикаРаботы Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ШаблонЗаполненияГрафикаРаботы Получить(this ШаблонЗаполненияГрафикаРаботы Значение, Guid Ссылка)
		{
			if(Ссылка == Пятидневка40)
			{
				return ШаблонЗаполненияГрафикаРаботы.Пятидневка40;
			}
			else if(Ссылка == Шестидневка40)
			{
				return ШаблонЗаполненияГрафикаРаботы.Шестидневка40;
			}
			else if(Ссылка == СуткиЧерезДвое)
			{
				return ШаблонЗаполненияГрафикаРаботы.СуткиЧерезДвое;
			}
			else if(Ссылка == СуткиЧерезТрое)
			{
				return ШаблонЗаполненияГрафикаРаботы.СуткиЧерезТрое;
			}
			else if(Ссылка == КалендарныеДни)
			{
				return ШаблонЗаполненияГрафикаРаботы.КалендарныеДни;
			}
			return ШаблонЗаполненияГрафикаРаботы.ПустаяСсылка;
		}
		public static byte[] Ключ(this ШаблонЗаполненияГрафикаРаботы Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ШаблонЗаполненияГрафикаРаботы Значение)
		{
			switch (Значение)
			{
				case ШаблонЗаполненияГрафикаРаботы.Пятидневка40: return Пятидневка40;
				case ШаблонЗаполненияГрафикаРаботы.Шестидневка40: return Шестидневка40;
				case ШаблонЗаполненияГрафикаРаботы.СуткиЧерезДвое: return СуткиЧерезДвое;
				case ШаблонЗаполненияГрафикаРаботы.СуткиЧерезТрое: return СуткиЧерезТрое;
				case ШаблонЗаполненияГрафикаРаботы.КалендарныеДни: return КалендарныеДни;
			}
			return Guid.Empty;
		}
	}
}
