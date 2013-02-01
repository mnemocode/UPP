﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///Данное перечисление не используется. 
		///</summary>
	public enum ВидыДоговоровГПХСФизЛицами
	{
		ПустаяСсылка = - 1,
		Подряда = 0,//Подряда (выполнение работ, оказание услуг)
		Авторский = 1,
		Лицензионный = 2,
	}
	public static partial class ВидыДоговоровГПХСФизЛицами_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Подряда = new Guid("6944beb9-e204-2c32-47c2-6b7c55605e5e");//Подряда (выполнение работ, оказание услуг)
		public static readonly Guid Авторский = new Guid("771f4b8c-c6ed-3a67-47a5-e27d43ae8049");
		public static readonly Guid Лицензионный = new Guid("b9ce2b97-c325-d200-4936-332453873a9f");
		public static ВидыДоговоровГПХСФизЛицами Получить(this ВидыДоговоровГПХСФизЛицами Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДоговоровГПХСФизЛицами Получить(this ВидыДоговоровГПХСФизЛицами Значение, Guid Ссылка)
		{
			if(Ссылка == Подряда)
			{
				return ВидыДоговоровГПХСФизЛицами.Подряда;
			}
			else if(Ссылка == Авторский)
			{
				return ВидыДоговоровГПХСФизЛицами.Авторский;
			}
			else if(Ссылка == Лицензионный)
			{
				return ВидыДоговоровГПХСФизЛицами.Лицензионный;
			}
			return ВидыДоговоровГПХСФизЛицами.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДоговоровГПХСФизЛицами Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДоговоровГПХСФизЛицами Значение)
		{
			switch (Значение)
			{
				case ВидыДоговоровГПХСФизЛицами.Подряда: return Подряда;
				case ВидыДоговоровГПХСФизЛицами.Авторский: return Авторский;
				case ВидыДоговоровГПХСФизЛицами.Лицензионный: return Лицензионный;
			}
			return Guid.Empty;
		}
	}
}
