﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum СпособыВводаДанныхОВремени
	{
		ПустаяСсылка = - 1,
		ПоДням = 0,//Ввод данных по дням
		ВЦеломЗаПериод = 1,//Ввод данных в целом за период
		ЗаДень = 2,//Ввод данных за день
	}
	public static partial class СпособыВводаДанныхОВремени_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоДням = new Guid("956a5483-98bb-aade-4e94-4d154412649d");//Ввод данных по дням
		public static readonly Guid ВЦеломЗаПериод = new Guid("dfd08198-1a0f-89db-45ad-b69a18f38bb7");//Ввод данных в целом за период
		public static readonly Guid ЗаДень = new Guid("954c6ba1-7a20-51b8-4c28-c4d4c3053038");//Ввод данных за день
		public static СпособыВводаДанныхОВремени Получить(this СпособыВводаДанныхОВремени Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыВводаДанныхОВремени Получить(this СпособыВводаДанныхОВремени Значение, Guid Ссылка)
		{
			if(Ссылка == ПоДням)
			{
				return СпособыВводаДанныхОВремени.ПоДням;
			}
			else if(Ссылка == ВЦеломЗаПериод)
			{
				return СпособыВводаДанныхОВремени.ВЦеломЗаПериод;
			}
			else if(Ссылка == ЗаДень)
			{
				return СпособыВводаДанныхОВремени.ЗаДень;
			}
			return СпособыВводаДанныхОВремени.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыВводаДанныхОВремени Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыВводаДанныхОВремени Значение)
		{
			switch (Значение)
			{
				case СпособыВводаДанныхОВремени.ПоДням: return ПоДням;
				case СпособыВводаДанныхОВремени.ВЦеломЗаПериод: return ВЦеломЗаПериод;
				case СпособыВводаДанныхОВремени.ЗаДень: return ЗаДень;
			}
			return Guid.Empty;
		}
	}
}
