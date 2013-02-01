﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыДанныхДляОтчетовБюджетированияИсточники
	{
		ПустаяСсылка = - 1,
		Сценарий = 0,//Данные сценария
		ФактическиеДанныеБюджетирование = 1,//Фактические данные (бюджетирование)
		ФактическиеДанныеИсточники = 2,//Фактические данные (источники данных для расчетов)
	}
	public static partial class ВидыДанныхДляОтчетовБюджетированияИсточники_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Сценарий = new Guid("2119f5a7-438c-8ed9-4fc0-cdb9b89afb1e");//Данные сценария
		public static readonly Guid ФактическиеДанныеБюджетирование = new Guid("5e778399-002b-cbc4-44af-906608f41669");//Фактические данные (бюджетирование)
		public static readonly Guid ФактическиеДанныеИсточники = new Guid("c5772c90-8985-6c27-4c32-3b09379e5d0d");//Фактические данные (источники данных для расчетов)
		public static ВидыДанныхДляОтчетовБюджетированияИсточники Получить(this ВидыДанныхДляОтчетовБюджетированияИсточники Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыДанныхДляОтчетовБюджетированияИсточники Получить(this ВидыДанныхДляОтчетовБюджетированияИсточники Значение, Guid Ссылка)
		{
			if(Ссылка == Сценарий)
			{
				return ВидыДанныхДляОтчетовБюджетированияИсточники.Сценарий;
			}
			else if(Ссылка == ФактическиеДанныеБюджетирование)
			{
				return ВидыДанныхДляОтчетовБюджетированияИсточники.ФактическиеДанныеБюджетирование;
			}
			else if(Ссылка == ФактическиеДанныеИсточники)
			{
				return ВидыДанныхДляОтчетовБюджетированияИсточники.ФактическиеДанныеИсточники;
			}
			return ВидыДанныхДляОтчетовБюджетированияИсточники.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыДанныхДляОтчетовБюджетированияИсточники Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыДанныхДляОтчетовБюджетированияИсточники Значение)
		{
			switch (Значение)
			{
				case ВидыДанныхДляОтчетовБюджетированияИсточники.Сценарий: return Сценарий;
				case ВидыДанныхДляОтчетовБюджетированияИсточники.ФактическиеДанныеБюджетирование: return ФактическиеДанныеБюджетирование;
				case ВидыДанныхДляОтчетовБюджетированияИсточники.ФактическиеДанныеИсточники: return ФактическиеДанныеИсточники;
			}
			return Guid.Empty;
		}
	}
}
