﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum СпособыРасчетаНезавершенногоПроизводства
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Регл)
	///</summary>
		ПереработкаСырья = 0,//Для производства, связанного с обработкой сырья
	///<summary>
	///(Регл)
	///</summary>
		ВыполнениеРаботУслуг = 1,//Для производства, связанного с оказ. услуг (выполн. работ)
	///<summary>
	///(Регл)
	///</summary>
		ПрочиеСлучаи = 2,//Для прочих видов производства
	}
	public static partial class СпособыРасчетаНезавершенногоПроизводства_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Регл)
		///</summary>
		public static readonly Guid ПереработкаСырья = new Guid("32db5cac-c895-ab81-488f-fc5c7be0456b");//Для производства, связанного с обработкой сырья
		///<summary>
		///(Регл)
		///</summary>
		public static readonly Guid ВыполнениеРаботУслуг = new Guid("b47021b3-54f3-6820-490d-f2a960de67cd");//Для производства, связанного с оказ. услуг (выполн. работ)
		///<summary>
		///(Регл)
		///</summary>
		public static readonly Guid ПрочиеСлучаи = new Guid("dd07b095-4eeb-b573-4b76-28366213c6be");//Для прочих видов производства
		public static СпособыРасчетаНезавершенногоПроизводства Получить(this СпособыРасчетаНезавершенногоПроизводства Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СпособыРасчетаНезавершенногоПроизводства Получить(this СпособыРасчетаНезавершенногоПроизводства Значение, Guid Ссылка)
		{
			if(Ссылка == ПереработкаСырья)
			{
				return СпособыРасчетаНезавершенногоПроизводства.ПереработкаСырья;
			}
			else if(Ссылка == ВыполнениеРаботУслуг)
			{
				return СпособыРасчетаНезавершенногоПроизводства.ВыполнениеРаботУслуг;
			}
			else if(Ссылка == ПрочиеСлучаи)
			{
				return СпособыРасчетаНезавершенногоПроизводства.ПрочиеСлучаи;
			}
			return СпособыРасчетаНезавершенногоПроизводства.ПустаяСсылка;
		}
		public static byte[] Ключ(this СпособыРасчетаНезавершенногоПроизводства Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СпособыРасчетаНезавершенногоПроизводства Значение)
		{
			switch (Значение)
			{
				case СпособыРасчетаНезавершенногоПроизводства.ПереработкаСырья: return ПереработкаСырья;
				case СпособыРасчетаНезавершенногоПроизводства.ВыполнениеРаботУслуг: return ВыполнениеРаботУслуг;
				case СпособыРасчетаНезавершенногоПроизводства.ПрочиеСлучаи: return ПрочиеСлучаи;
			}
			return Guid.Empty;
		}
	}
}
