﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыТорговогоОборудования
	{
		ПустаяСсылка = - 1,
		СканерШтрихКода = 0,//Сканер штрихкода
		ФискальныйРегистратор = 1,//Фискальный регистратор
		ТерминалСбораДанных = 2,//Терминал сбора данных
		ДисплейПокупателя = 3,//Дисплей покупателя
		СчитывательМагнитныхКарт = 4,//Считыватель магнитных карт
		ЭлектронныеВесы = 5,//Электронные весы
		ВесыСПечатьюЭтикеток = 6,//Весы с печатью этикеток
		ККМOffLine = 7,//ККМ Offline
		ККМOnLine = 8,//ККМ Online
		ЭквайринговаяСистема = 9,//Эквайринговая система
		СчитывательRFIDМеток = 10,//Считыватель RFID меток
	}
	public static partial class ВидыТорговогоОборудования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid СканерШтрихКода = new Guid("fa632ca9-d980-007c-4053-f69eb840ddea");//Сканер штрихкода
		public static readonly Guid ФискальныйРегистратор = new Guid("1ccc24a6-ebc1-c8b2-4346-a1342d0c92bd");//Фискальный регистратор
		public static readonly Guid ТерминалСбораДанных = new Guid("9b81079b-074e-04c0-4781-8b0ac6b00c4d");//Терминал сбора данных
		public static readonly Guid ДисплейПокупателя = new Guid("e2322881-591c-21a8-4b50-1fc4defad35f");//Дисплей покупателя
		public static readonly Guid СчитывательМагнитныхКарт = new Guid("e435369c-5320-f759-4125-43b14af80030");//Считыватель магнитных карт
		public static readonly Guid ЭлектронныеВесы = new Guid("0ab5b79f-e015-34c2-4d62-70ed669506a5");//Электронные весы
		public static readonly Guid ВесыСПечатьюЭтикеток = new Guid("98cf80a5-e5c4-bd1c-40cc-de69ad3507b8");//Весы с печатью этикеток
		public static readonly Guid ККМOffLine = new Guid("b87284a1-4ff7-05c0-4664-4d8987d37e5d");//ККМ Offline
		public static readonly Guid ККМOnLine = new Guid("6dbd3ea2-730c-097f-45ac-7c6aafce0a0c");//ККМ Online
		public static readonly Guid ЭквайринговаяСистема = new Guid("b16bd9b3-8f6f-6a72-4f67-f8827204fe26");//Эквайринговая система
		public static readonly Guid СчитывательRFIDМеток = new Guid("42401691-d0d7-4ecf-4121-8296543c7314");//Считыватель RFID меток
		public static ВидыТорговогоОборудования Получить(this ВидыТорговогоОборудования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыТорговогоОборудования Получить(this ВидыТорговогоОборудования Значение, Guid Ссылка)
		{
			if(Ссылка == СканерШтрихКода)
			{
				return ВидыТорговогоОборудования.СканерШтрихКода;
			}
			else if(Ссылка == ФискальныйРегистратор)
			{
				return ВидыТорговогоОборудования.ФискальныйРегистратор;
			}
			else if(Ссылка == ТерминалСбораДанных)
			{
				return ВидыТорговогоОборудования.ТерминалСбораДанных;
			}
			else if(Ссылка == ДисплейПокупателя)
			{
				return ВидыТорговогоОборудования.ДисплейПокупателя;
			}
			else if(Ссылка == СчитывательМагнитныхКарт)
			{
				return ВидыТорговогоОборудования.СчитывательМагнитныхКарт;
			}
			else if(Ссылка == ЭлектронныеВесы)
			{
				return ВидыТорговогоОборудования.ЭлектронныеВесы;
			}
			else if(Ссылка == ВесыСПечатьюЭтикеток)
			{
				return ВидыТорговогоОборудования.ВесыСПечатьюЭтикеток;
			}
			else if(Ссылка == ККМOffLine)
			{
				return ВидыТорговогоОборудования.ККМOffLine;
			}
			else if(Ссылка == ККМOnLine)
			{
				return ВидыТорговогоОборудования.ККМOnLine;
			}
			else if(Ссылка == ЭквайринговаяСистема)
			{
				return ВидыТорговогоОборудования.ЭквайринговаяСистема;
			}
			else if(Ссылка == СчитывательRFIDМеток)
			{
				return ВидыТорговогоОборудования.СчитывательRFIDМеток;
			}
			return ВидыТорговогоОборудования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыТорговогоОборудования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыТорговогоОборудования Значение)
		{
			switch (Значение)
			{
				case ВидыТорговогоОборудования.СканерШтрихКода: return СканерШтрихКода;
				case ВидыТорговогоОборудования.ФискальныйРегистратор: return ФискальныйРегистратор;
				case ВидыТорговогоОборудования.ТерминалСбораДанных: return ТерминалСбораДанных;
				case ВидыТорговогоОборудования.ДисплейПокупателя: return ДисплейПокупателя;
				case ВидыТорговогоОборудования.СчитывательМагнитныхКарт: return СчитывательМагнитныхКарт;
				case ВидыТорговогоОборудования.ЭлектронныеВесы: return ЭлектронныеВесы;
				case ВидыТорговогоОборудования.ВесыСПечатьюЭтикеток: return ВесыСПечатьюЭтикеток;
				case ВидыТорговогоОборудования.ККМOffLine: return ККМOffLine;
				case ВидыТорговогоОборудования.ККМOnLine: return ККМOnLine;
				case ВидыТорговогоОборудования.ЭквайринговаяСистема: return ЭквайринговаяСистема;
				case ВидыТорговогоОборудования.СчитывательRFIDМеток: return СчитывательRFIDМеток;
			}
			return Guid.Empty;
		}
	}
}
