﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ОтнесениеРасходовКДеятельностиЕНВД
	{
		ПустаяСсылка = - 1,
		РасходыОтносятсяКнеЕНВД = 0,//Не ЕНВД (Расходы относятся к деятельности, не облагаемой ЕНВД)
		РасходыОтносятсяКЕНВД = 1,//ЕНВД (Расходы относятся к деятельности, облагаемой ЕНВД)
		РасходыРаспределяются = 2,//Расходы распределяются
	}
	public static partial class ОтнесениеРасходовКДеятельностиЕНВД_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid РасходыОтносятсяКнеЕНВД = new Guid("dbc1cbbb-538a-9890-46f9-50ec431244da");//Не ЕНВД (Расходы относятся к деятельности, не облагаемой ЕНВД)
		public static readonly Guid РасходыОтносятсяКЕНВД = new Guid("b8957995-df9b-71b7-4e38-7dfe62704c76");//ЕНВД (Расходы относятся к деятельности, облагаемой ЕНВД)
		public static readonly Guid РасходыРаспределяются = new Guid("4aec77ad-f25a-56ef-4cba-efb9f934d397");//Расходы распределяются
		public static ОтнесениеРасходовКДеятельностиЕНВД Получить(this ОтнесениеРасходовКДеятельностиЕНВД Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ОтнесениеРасходовКДеятельностиЕНВД Получить(this ОтнесениеРасходовКДеятельностиЕНВД Значение, Guid Ссылка)
		{
			if(Ссылка == РасходыОтносятсяКнеЕНВД)
			{
				return ОтнесениеРасходовКДеятельностиЕНВД.РасходыОтносятсяКнеЕНВД;
			}
			else if(Ссылка == РасходыОтносятсяКЕНВД)
			{
				return ОтнесениеРасходовКДеятельностиЕНВД.РасходыОтносятсяКЕНВД;
			}
			else if(Ссылка == РасходыРаспределяются)
			{
				return ОтнесениеРасходовКДеятельностиЕНВД.РасходыРаспределяются;
			}
			return ОтнесениеРасходовКДеятельностиЕНВД.ПустаяСсылка;
		}
		public static byte[] Ключ(this ОтнесениеРасходовКДеятельностиЕНВД Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ОтнесениеРасходовКДеятельностиЕНВД Значение)
		{
			switch (Значение)
			{
				case ОтнесениеРасходовКДеятельностиЕНВД.РасходыОтносятсяКнеЕНВД: return РасходыОтносятсяКнеЕНВД;
				case ОтнесениеРасходовКДеятельностиЕНВД.РасходыОтносятсяКЕНВД: return РасходыОтносятсяКЕНВД;
				case ОтнесениеРасходовКДеятельностиЕНВД.РасходыРаспределяются: return РасходыРаспределяются;
			}
			return Guid.Empty;
		}
	}
}
