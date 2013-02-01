﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ДиректКостингСпособыСписания
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		НаСебестоимостьПродаж = 0,//На себестоимость продаж
	///<summary>
	///(Общ)
	///</summary>
		НаУправленческиеРасходы = 1,//На управленческие расходы
	}
	public static partial class ДиректКостингСпособыСписания_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid НаСебестоимостьПродаж = new Guid("5ae9b383-06b5-b6e9-49cc-38b9d7646114");//На себестоимость продаж
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid НаУправленческиеРасходы = new Guid("520a65bb-6bf4-aa3e-452b-cf0ea9f1083e");//На управленческие расходы
		public static ДиректКостингСпособыСписания Получить(this ДиректКостингСпособыСписания Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ДиректКостингСпособыСписания Получить(this ДиректКостингСпособыСписания Значение, Guid Ссылка)
		{
			if(Ссылка == НаСебестоимостьПродаж)
			{
				return ДиректКостингСпособыСписания.НаСебестоимостьПродаж;
			}
			else if(Ссылка == НаУправленческиеРасходы)
			{
				return ДиректКостингСпособыСписания.НаУправленческиеРасходы;
			}
			return ДиректКостингСпособыСписания.ПустаяСсылка;
		}
		public static byte[] Ключ(this ДиректКостингСпособыСписания Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ДиректКостингСпособыСписания Значение)
		{
			switch (Значение)
			{
				case ДиректКостингСпособыСписания.НаСебестоимостьПродаж: return НаСебестоимостьПродаж;
				case ДиректКостингСпособыСписания.НаУправленческиеРасходы: return НаУправленческиеРасходы;
			}
			return Guid.Empty;
		}
	}
}
