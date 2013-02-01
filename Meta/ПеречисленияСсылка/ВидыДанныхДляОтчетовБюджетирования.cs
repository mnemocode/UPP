﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыДанныхДляОтчетовБюджетирования
	{
		ПустаяСсылка = - 1,
		Сценарий = 0,//Данные сценария
		ФактическиеДанные = 1,//Фактические данные
	}
	public static partial class ВидыДанныхДляОтчетовБюджетирования_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Сценарий = new Guid("1e5638ad-95fa-35ff-4542-deac2d804590");//Данные сценария
		public static readonly Guid ФактическиеДанные = new Guid("7b4f8f9d-a0e3-1328-4afb-52af856f8669");//Фактические данные
		public static ВидыДанныхДляОтчетовБюджетирования Получить(this ВидыДанныхДляОтчетовБюджетирования Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДанныхДляОтчетовБюджетирования Получить(this ВидыДанныхДляОтчетовБюджетирования Значение, Guid Ссылка)
		{
			if(Ссылка == Сценарий)
			{
				return ВидыДанныхДляОтчетовБюджетирования.Сценарий;
			}
			else if(Ссылка == ФактическиеДанные)
			{
				return ВидыДанныхДляОтчетовБюджетирования.ФактическиеДанные;
			}
			return ВидыДанныхДляОтчетовБюджетирования.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДанныхДляОтчетовБюджетирования Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДанныхДляОтчетовБюджетирования Значение)
		{
			switch (Значение)
			{
				case ВидыДанныхДляОтчетовБюджетирования.Сценарий: return Сценарий;
				case ВидыДанныхДляОтчетовБюджетирования.ФактическиеДанные: return ФактическиеДанные;
			}
			return Guid.Empty;
		}
	}
}
