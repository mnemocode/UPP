﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ТипыПериодическихЗадачРаботника
	{
		ПустаяСсылка = - 1,
		ОтпускЕжегодный = 0,//Отпуск ежегодный
		Отсутствие = 1,
		Мероприятие = 2,
		ВстречаСКандидатом = 3,//Встреча с кандидатом
		Свободен = 4,
		Встреча = 5,
	}
	public static partial class ТипыПериодическихЗадачРаботника_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОтпускЕжегодный = new Guid("3eefe0bf-407c-37dd-4c47-ab4eedf6440a");//Отпуск ежегодный
		public static readonly Guid Отсутствие = new Guid("d5ddff97-36b7-6561-4c81-78ca7bc81655");
		public static readonly Guid Мероприятие = new Guid("a908a8b3-3191-8cd3-4676-5909fef5e804");
		public static readonly Guid ВстречаСКандидатом = new Guid("67969c92-4856-8172-4795-051debf763c0");//Встреча с кандидатом
		public static readonly Guid Свободен = new Guid("5a03a5b4-c749-e1d0-4818-254e4ee98f7b");
		public static readonly Guid Встреча = new Guid("823b8e8e-8762-bd5f-4d8f-322042953210");
		public static ТипыПериодическихЗадачРаботника Получить(this ТипыПериодическихЗадачРаботника Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ТипыПериодическихЗадачРаботника Получить(this ТипыПериодическихЗадачРаботника Значение, Guid Ссылка)
		{
			if(Ссылка == ОтпускЕжегодный)
			{
				return ТипыПериодическихЗадачРаботника.ОтпускЕжегодный;
			}
			else if(Ссылка == Отсутствие)
			{
				return ТипыПериодическихЗадачРаботника.Отсутствие;
			}
			else if(Ссылка == Мероприятие)
			{
				return ТипыПериодическихЗадачРаботника.Мероприятие;
			}
			else if(Ссылка == ВстречаСКандидатом)
			{
				return ТипыПериодическихЗадачРаботника.ВстречаСКандидатом;
			}
			else if(Ссылка == Свободен)
			{
				return ТипыПериодическихЗадачРаботника.Свободен;
			}
			else if(Ссылка == Встреча)
			{
				return ТипыПериодическихЗадачРаботника.Встреча;
			}
			return ТипыПериодическихЗадачРаботника.ПустаяСсылка;
		}
		public static byte[] Ключ(this ТипыПериодическихЗадачРаботника Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ТипыПериодическихЗадачРаботника Значение)
		{
			switch (Значение)
			{
				case ТипыПериодическихЗадачРаботника.ОтпускЕжегодный: return ОтпускЕжегодный;
				case ТипыПериодическихЗадачРаботника.Отсутствие: return Отсутствие;
				case ТипыПериодическихЗадачРаботника.Мероприятие: return Мероприятие;
				case ТипыПериодическихЗадачРаботника.ВстречаСКандидатом: return ВстречаСКандидатом;
				case ТипыПериодическихЗадачРаботника.Свободен: return Свободен;
				case ТипыПериодическихЗадачРаботника.Встреча: return Встреча;
			}
			return Guid.Empty;
		}
	}
}
