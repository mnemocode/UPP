﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum СпособыОценки
	{
		ПустаяСсылка = - 1,
		ПоСредней = 0,//По средней
	///<summary>
	///First input, first output (первым пришел, первым обработан)
	///</summary>
		ФИФО = 1,
	///<summary>
	///Last input, first output (последним пришел, первым обработан)
	///</summary>
		ЛИФО = 2,
	}
	public static partial class СпособыОценки_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоСредней = new Guid("d9620884-3a94-13d3-47ee-822491b64739");//По средней
		///<summary>
		///First input, first output (первым пришел, первым обработан)
		///</summary>
		public static readonly Guid ФИФО = new Guid("65c6a5af-8de2-6b2a-462e-70888faf6ff7");
		///<summary>
		///Last input, first output (последним пришел, первым обработан)
		///</summary>
		public static readonly Guid ЛИФО = new Guid("595d1695-3c6f-74e7-46f4-5909f411d078");
		public static СпособыОценки Получить(this СпособыОценки Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыОценки Получить(this СпособыОценки Значение, Guid Ссылка)
		{
			if(Ссылка == ПоСредней)
			{
				return СпособыОценки.ПоСредней;
			}
			else if(Ссылка == ФИФО)
			{
				return СпособыОценки.ФИФО;
			}
			else if(Ссылка == ЛИФО)
			{
				return СпособыОценки.ЛИФО;
			}
			return СпособыОценки.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыОценки Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыОценки Значение)
		{
			switch (Значение)
			{
				case СпособыОценки.ПоСредней: return ПоСредней;
				case СпособыОценки.ФИФО: return ФИФО;
				case СпособыОценки.ЛИФО: return ЛИФО;
			}
			return Guid.Empty;
		}
	}
}
