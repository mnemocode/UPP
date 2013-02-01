﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Общ)
		///</summary>
	public enum НаборПравПользователей
	{
		ПустаяСсылка = - 1,
		Бухгалтер = 0,
		БухгалтерМСФО = 1,//Бухгалтер МСФО
		Бюджетирование = 2,
		КадровикРегламентированныхДанных = 3,//Кадровик регламентированных данных
		КадровикУправленческихДанных = 4,//Кадровик управленческих данных
		Кладовщик = 5,
		МенеджерПоЗаказам = 6,//Менеджер по заказам
		МенеджерПоЗакупкам = 7,//Менеджер по закупкам
		МенеджерПоНаборуПерсонала = 8,//Менеджер по набору персонала
	///<summary>
	///(Общ)
	///</summary>
		МенеджерПоПродажам = 9,//Менеджер по продажам
		Планирование = 10,
		ПолныеПрава = 11,//Полные права
		Пользователь = 12,
		ПроведениеПоПартиям = 13,//Проведение по партиям
		ПроведениеПоПартиямРегл = 14,//Проведение по партиям регл
		РасчетчикРегламентированнойЗарплаты = 15,//Расчетчик регламентированной зарплаты
		РасчетчикУправленческойЗарплаты = 16,//Расчетчик управленческой зарплаты
		РозничныеПродажи = 17,//Розничные продажи
		Сертификация = 18,
		Технолог = 19,
		УчетОСиНМА = 20,//Учет ОС и НМА
		Финансист = 21,
		Ценообразование = 22,
		ЭкономистЦеха = 23,//Экономист цеха
	}
	public static partial class НаборПравПользователей_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Бухгалтер = new Guid("b46757aa-36d3-50d7-4b43-00e055c0e4e0");
		public static readonly Guid БухгалтерМСФО = new Guid("2fb13b89-e8a2-46ed-4ade-3a2029829d65");//Бухгалтер МСФО
		public static readonly Guid Бюджетирование = new Guid("1c4f0bbf-d974-4d15-43c7-f9a23aeaf9ae");
		public static readonly Guid КадровикРегламентированныхДанных = new Guid("f80b9c82-b733-77ce-4009-62ce142479b9");//Кадровик регламентированных данных
		public static readonly Guid КадровикУправленческихДанных = new Guid("ccefc190-7a4b-5f72-447b-59573523c0e0");//Кадровик управленческих данных
		public static readonly Guid Кладовщик = new Guid("8f117d99-ee52-4c48-4273-b7ec29e1407d");
		public static readonly Guid МенеджерПоЗаказам = new Guid("c8d91fb7-33fc-612c-4fa5-bddc35a49c0d");//Менеджер по заказам
		public static readonly Guid МенеджерПоЗакупкам = new Guid("ebacf994-6cd9-a8d6-4e9c-c7924e73ff6c");//Менеджер по закупкам
		public static readonly Guid МенеджерПоНаборуПерсонала = new Guid("241772a9-36a8-c059-4afe-f754ecfaf234");//Менеджер по набору персонала
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid МенеджерПоПродажам = new Guid("5c6493b5-187c-3359-41d2-293c56dce8c8");//Менеджер по продажам
		public static readonly Guid Планирование = new Guid("d0e83385-49f5-97b3-40ea-42d3fca2cc8d");
		public static readonly Guid ПолныеПрава = new Guid("6d142b83-29c6-81a0-4c30-7eab7b1367a5");//Полные права
		public static readonly Guid Пользователь = new Guid("0b3c7fb9-b6fb-584c-4017-e8d2ffb57601");
		public static readonly Guid ПроведениеПоПартиям = new Guid("c664459a-cfc0-90f5-4b38-324185842581");//Проведение по партиям
		public static readonly Guid ПроведениеПоПартиямРегл = new Guid("6662f0a2-f17e-df3d-400b-b8d0a000f580");//Проведение по партиям регл
		public static readonly Guid РасчетчикРегламентированнойЗарплаты = new Guid("35c3d19a-7f4a-8db6-4a9a-ee360c8141b0");//Расчетчик регламентированной зарплаты
		public static readonly Guid РасчетчикУправленческойЗарплаты = new Guid("455b4c84-c4e7-327a-4484-34c443460170");//Расчетчик управленческой зарплаты
		public static readonly Guid РозничныеПродажи = new Guid("348cb58b-5911-8b33-4eed-8240f1fab1cd");//Розничные продажи
		public static readonly Guid Сертификация = new Guid("806a1688-4a5a-1bfc-4b1f-843e838ec5ff");
		public static readonly Guid Технолог = new Guid("3ebb089f-4f81-b106-44f9-f05613857472");
		public static readonly Guid УчетОСиНМА = new Guid("caae5b82-ec5c-1b66-4712-4131a262a315");//Учет ОС и НМА
		public static readonly Guid Финансист = new Guid("025f23bd-2691-f9e1-4e7f-9fec0548d22c");
		public static readonly Guid Ценообразование = new Guid("a96e42a4-4f34-ec15-45d4-f610004e3c8c");
		public static readonly Guid ЭкономистЦеха = new Guid("7ad3d496-e1aa-df01-4cf0-aef7dd523b2e");//Экономист цеха
		public static НаборПравПользователей Получить(this НаборПравПользователей Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static НаборПравПользователей Получить(this НаборПравПользователей Значение, Guid Ссылка)
		{
			if(Ссылка == Бухгалтер)
			{
				return НаборПравПользователей.Бухгалтер;
			}
			else if(Ссылка == БухгалтерМСФО)
			{
				return НаборПравПользователей.БухгалтерМСФО;
			}
			else if(Ссылка == Бюджетирование)
			{
				return НаборПравПользователей.Бюджетирование;
			}
			else if(Ссылка == КадровикРегламентированныхДанных)
			{
				return НаборПравПользователей.КадровикРегламентированныхДанных;
			}
			else if(Ссылка == КадровикУправленческихДанных)
			{
				return НаборПравПользователей.КадровикУправленческихДанных;
			}
			else if(Ссылка == Кладовщик)
			{
				return НаборПравПользователей.Кладовщик;
			}
			else if(Ссылка == МенеджерПоЗаказам)
			{
				return НаборПравПользователей.МенеджерПоЗаказам;
			}
			else if(Ссылка == МенеджерПоЗакупкам)
			{
				return НаборПравПользователей.МенеджерПоЗакупкам;
			}
			else if(Ссылка == МенеджерПоНаборуПерсонала)
			{
				return НаборПравПользователей.МенеджерПоНаборуПерсонала;
			}
			else if(Ссылка == МенеджерПоПродажам)
			{
				return НаборПравПользователей.МенеджерПоПродажам;
			}
			else if(Ссылка == Планирование)
			{
				return НаборПравПользователей.Планирование;
			}
			else if(Ссылка == ПолныеПрава)
			{
				return НаборПравПользователей.ПолныеПрава;
			}
			else if(Ссылка == Пользователь)
			{
				return НаборПравПользователей.Пользователь;
			}
			else if(Ссылка == ПроведениеПоПартиям)
			{
				return НаборПравПользователей.ПроведениеПоПартиям;
			}
			else if(Ссылка == ПроведениеПоПартиямРегл)
			{
				return НаборПравПользователей.ПроведениеПоПартиямРегл;
			}
			else if(Ссылка == РасчетчикРегламентированнойЗарплаты)
			{
				return НаборПравПользователей.РасчетчикРегламентированнойЗарплаты;
			}
			else if(Ссылка == РасчетчикУправленческойЗарплаты)
			{
				return НаборПравПользователей.РасчетчикУправленческойЗарплаты;
			}
			else if(Ссылка == РозничныеПродажи)
			{
				return НаборПравПользователей.РозничныеПродажи;
			}
			else if(Ссылка == Сертификация)
			{
				return НаборПравПользователей.Сертификация;
			}
			else if(Ссылка == Технолог)
			{
				return НаборПравПользователей.Технолог;
			}
			else if(Ссылка == УчетОСиНМА)
			{
				return НаборПравПользователей.УчетОСиНМА;
			}
			else if(Ссылка == Финансист)
			{
				return НаборПравПользователей.Финансист;
			}
			else if(Ссылка == Ценообразование)
			{
				return НаборПравПользователей.Ценообразование;
			}
			else if(Ссылка == ЭкономистЦеха)
			{
				return НаборПравПользователей.ЭкономистЦеха;
			}
			return НаборПравПользователей.ПустаяСсылка;
		}
		public static byte[] Ключ(this НаборПравПользователей Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this НаборПравПользователей Значение)
		{
			switch (Значение)
			{
				case НаборПравПользователей.Бухгалтер: return Бухгалтер;
				case НаборПравПользователей.БухгалтерМСФО: return БухгалтерМСФО;
				case НаборПравПользователей.Бюджетирование: return Бюджетирование;
				case НаборПравПользователей.КадровикРегламентированныхДанных: return КадровикРегламентированныхДанных;
				case НаборПравПользователей.КадровикУправленческихДанных: return КадровикУправленческихДанных;
				case НаборПравПользователей.Кладовщик: return Кладовщик;
				case НаборПравПользователей.МенеджерПоЗаказам: return МенеджерПоЗаказам;
				case НаборПравПользователей.МенеджерПоЗакупкам: return МенеджерПоЗакупкам;
				case НаборПравПользователей.МенеджерПоНаборуПерсонала: return МенеджерПоНаборуПерсонала;
				case НаборПравПользователей.МенеджерПоПродажам: return МенеджерПоПродажам;
				case НаборПравПользователей.Планирование: return Планирование;
				case НаборПравПользователей.ПолныеПрава: return ПолныеПрава;
				case НаборПравПользователей.Пользователь: return Пользователь;
				case НаборПравПользователей.ПроведениеПоПартиям: return ПроведениеПоПартиям;
				case НаборПравПользователей.ПроведениеПоПартиямРегл: return ПроведениеПоПартиямРегл;
				case НаборПравПользователей.РасчетчикРегламентированнойЗарплаты: return РасчетчикРегламентированнойЗарплаты;
				case НаборПравПользователей.РасчетчикУправленческойЗарплаты: return РасчетчикУправленческойЗарплаты;
				case НаборПравПользователей.РозничныеПродажи: return РозничныеПродажи;
				case НаборПравПользователей.Сертификация: return Сертификация;
				case НаборПравПользователей.Технолог: return Технолог;
				case НаборПравПользователей.УчетОСиНМА: return УчетОСиНМА;
				case НаборПравПользователей.Финансист: return Финансист;
				case НаборПравПользователей.Ценообразование: return Ценообразование;
				case НаборПравПользователей.ЭкономистЦеха: return ЭкономистЦеха;
			}
			return Guid.Empty;
		}
	}
}
