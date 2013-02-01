﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Упр)
		///</summary>
	public enum ВидыРаспределенияЗначенийБюджетирования
	{
		ПустаяСсылка = - 1,
		ПоПериодамРавномерно = 0,//По периодам равномерно
		ПоПериодамСИзменением = 1,//По периодам с изменением
	}
	public static partial class ВидыРаспределенияЗначенийБюджетирования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПоПериодамРавномерно = new Guid("90ca1b88-4d3a-c919-443f-309b3b41ff0c");//По периодам равномерно
		public static readonly Guid ПоПериодамСИзменением = new Guid("fb9cfdbd-0113-b764-4777-05ea50e346aa");//По периодам с изменением
		public static ВидыРаспределенияЗначенийБюджетирования Получить(this ВидыРаспределенияЗначенийБюджетирования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыРаспределенияЗначенийБюджетирования Получить(this ВидыРаспределенияЗначенийБюджетирования Значение, Guid Ссылка)
		{
			if(Ссылка == ПоПериодамРавномерно)
			{
				return ВидыРаспределенияЗначенийБюджетирования.ПоПериодамРавномерно;
			}
			else if(Ссылка == ПоПериодамСИзменением)
			{
				return ВидыРаспределенияЗначенийБюджетирования.ПоПериодамСИзменением;
			}
			return ВидыРаспределенияЗначенийБюджетирования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыРаспределенияЗначенийБюджетирования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыРаспределенияЗначенийБюджетирования Значение)
		{
			switch (Значение)
			{
				case ВидыРаспределенияЗначенийБюджетирования.ПоПериодамРавномерно: return ПоПериодамРавномерно;
				case ВидыРаспределенияЗначенийБюджетирования.ПоПериодамСИзменением: return ПоПериодамСИзменением;
			}
			return Guid.Empty;
		}
	}
}
