﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum ВидыОперацийВозвратТоваров
	{
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		ИзПереработки = 0,//материалы из переработки
	///<summary>
	///(Общ)
	///</summary>
		ОтЗаказчика = 1,//продукция от заказчика
	}
	public static partial class ВидыОперацийВозвратТоваров_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ИзПереработки = new Guid("a75aebb8-deb4-1253-4182-ca7280ae7e41");//материалы из переработки
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ОтЗаказчика = new Guid("23435683-f705-5b89-4282-bedee790c6a0");//продукция от заказчика
		public static ВидыОперацийВозвратТоваров Получить(this ВидыОперацийВозвратТоваров Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийВозвратТоваров Получить(this ВидыОперацийВозвратТоваров Значение, Guid Ссылка)
		{
			if(Ссылка == ИзПереработки)
			{
				return ВидыОперацийВозвратТоваров.ИзПереработки;
			}
			else if(Ссылка == ОтЗаказчика)
			{
				return ВидыОперацийВозвратТоваров.ОтЗаказчика;
			}
			return ВидыОперацийВозвратТоваров.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийВозвратТоваров Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийВозвратТоваров Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийВозвратТоваров.ИзПереработки: return ИзПереработки;
				case ВидыОперацийВозвратТоваров.ОтЗаказчика: return ОтЗаказчика;
			}
			return Guid.Empty;
		}
	}
}
