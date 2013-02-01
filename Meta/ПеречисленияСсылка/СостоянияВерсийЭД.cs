﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum СостоянияВерсийЭД
	{
		ПустаяСсылка = - 1,
		ИзвещениеНаПодписи = 0,//Извещение на подписи
		НаПодписи = 1,//На подписи
		НаУтверждении = 2,//На утверждении
		НеПолучен = 3,//Не получен
		НеСформирован = 4,//Не сформирован
		ОжидаетсяИзвещение = 5,//Ожидается извещение
		ОжидаетсяИзвещениеОПолучении = 6,//Ожидается извещение о получении
		ОжидаетсяКорректировка = 7,//Ожидается корректировка
		ОжидаетсяОтправка = 8,//Ожидается отправка
		ОжидаетсяОтправкаИзвещения = 9,//Ожидается отправка извещения
		ОжидаетсяПодтверждение = 10,//Ожидается подтверждение
		ОжидаетсяПодтверждениеОператора = 11,//Ожидается подтверждение оператора
		Отклонен = 12,
		ОбменЗавершен = 13,//Обмен завершен
		ОшибкаПередачи = 14,//Ошибка передачи
		ТребуетсяУточнитьДокумент = 15,//Требуется уточнить документ
	}
	public static partial class СостоянияВерсийЭД_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ИзвещениеНаПодписи = new Guid("f8e1409f-1e2f-0d6d-4b70-d449eee092f7");//Извещение на подписи
		public static readonly Guid НаПодписи = new Guid("7610faa1-36fb-2015-4cd8-3cf468f91e5a");//На подписи
		public static readonly Guid НаУтверждении = new Guid("31da33aa-a3a2-d74f-4a29-2bd823f631a5");//На утверждении
		public static readonly Guid НеПолучен = new Guid("eabd2e87-9466-771b-4fa8-3370bf02e8fa");//Не получен
		public static readonly Guid НеСформирован = new Guid("623c0a9c-dc57-cec1-4a25-67a34d038624");//Не сформирован
		public static readonly Guid ОжидаетсяИзвещение = new Guid("ccde99ac-059c-c6e5-4208-c3c0ee0f3707");//Ожидается извещение
		public static readonly Guid ОжидаетсяИзвещениеОПолучении = new Guid("8b262e9a-c839-484e-4261-56536c803153");//Ожидается извещение о получении
		public static readonly Guid ОжидаетсяКорректировка = new Guid("d1a24ea7-a853-1dbe-4f64-467e90439737");//Ожидается корректировка
		public static readonly Guid ОжидаетсяОтправка = new Guid("bae9f09a-d4cb-1b1f-43eb-379438f0e68e");//Ожидается отправка
		public static readonly Guid ОжидаетсяОтправкаИзвещения = new Guid("b7c75f87-3d8d-3a3f-401f-2b6dbddc99ef");//Ожидается отправка извещения
		public static readonly Guid ОжидаетсяПодтверждение = new Guid("db4b13ac-6bdd-eab3-49c5-f254880db455");//Ожидается подтверждение
		public static readonly Guid ОжидаетсяПодтверждениеОператора = new Guid("0c7288b2-f163-715d-4df8-47250ad23277");//Ожидается подтверждение оператора
		public static readonly Guid Отклонен = new Guid("d9c85bb2-ad0e-9660-4799-023171fe3ccd");
		public static readonly Guid ОбменЗавершен = new Guid("89d2e5a1-7592-0d91-4030-61decc9b91b8");//Обмен завершен
		public static readonly Guid ОшибкаПередачи = new Guid("32732898-9450-ddf4-452e-d163fd39e0d6");//Ошибка передачи
		public static readonly Guid ТребуетсяУточнитьДокумент = new Guid("4e3446ae-516a-75eb-4bb6-6e12b97293f9");//Требуется уточнить документ
		public static СостоянияВерсийЭД Получить(this СостоянияВерсийЭД Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СостоянияВерсийЭД Получить(this СостоянияВерсийЭД Значение, Guid Ссылка)
		{
			if(Ссылка == ИзвещениеНаПодписи)
			{
				return СостоянияВерсийЭД.ИзвещениеНаПодписи;
			}
			else if(Ссылка == НаПодписи)
			{
				return СостоянияВерсийЭД.НаПодписи;
			}
			else if(Ссылка == НаУтверждении)
			{
				return СостоянияВерсийЭД.НаУтверждении;
			}
			else if(Ссылка == НеПолучен)
			{
				return СостоянияВерсийЭД.НеПолучен;
			}
			else if(Ссылка == НеСформирован)
			{
				return СостоянияВерсийЭД.НеСформирован;
			}
			else if(Ссылка == ОжидаетсяИзвещение)
			{
				return СостоянияВерсийЭД.ОжидаетсяИзвещение;
			}
			else if(Ссылка == ОжидаетсяИзвещениеОПолучении)
			{
				return СостоянияВерсийЭД.ОжидаетсяИзвещениеОПолучении;
			}
			else if(Ссылка == ОжидаетсяКорректировка)
			{
				return СостоянияВерсийЭД.ОжидаетсяКорректировка;
			}
			else if(Ссылка == ОжидаетсяОтправка)
			{
				return СостоянияВерсийЭД.ОжидаетсяОтправка;
			}
			else if(Ссылка == ОжидаетсяОтправкаИзвещения)
			{
				return СостоянияВерсийЭД.ОжидаетсяОтправкаИзвещения;
			}
			else if(Ссылка == ОжидаетсяПодтверждение)
			{
				return СостоянияВерсийЭД.ОжидаетсяПодтверждение;
			}
			else if(Ссылка == ОжидаетсяПодтверждениеОператора)
			{
				return СостоянияВерсийЭД.ОжидаетсяПодтверждениеОператора;
			}
			else if(Ссылка == Отклонен)
			{
				return СостоянияВерсийЭД.Отклонен;
			}
			else if(Ссылка == ОбменЗавершен)
			{
				return СостоянияВерсийЭД.ОбменЗавершен;
			}
			else if(Ссылка == ОшибкаПередачи)
			{
				return СостоянияВерсийЭД.ОшибкаПередачи;
			}
			else if(Ссылка == ТребуетсяУточнитьДокумент)
			{
				return СостоянияВерсийЭД.ТребуетсяУточнитьДокумент;
			}
			return СостоянияВерсийЭД.ПустаяСсылка;
		}
		public static byte[] Ключ(this СостоянияВерсийЭД Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СостоянияВерсийЭД Значение)
		{
			switch (Значение)
			{
				case СостоянияВерсийЭД.ИзвещениеНаПодписи: return ИзвещениеНаПодписи;
				case СостоянияВерсийЭД.НаПодписи: return НаПодписи;
				case СостоянияВерсийЭД.НаУтверждении: return НаУтверждении;
				case СостоянияВерсийЭД.НеПолучен: return НеПолучен;
				case СостоянияВерсийЭД.НеСформирован: return НеСформирован;
				case СостоянияВерсийЭД.ОжидаетсяИзвещение: return ОжидаетсяИзвещение;
				case СостоянияВерсийЭД.ОжидаетсяИзвещениеОПолучении: return ОжидаетсяИзвещениеОПолучении;
				case СостоянияВерсийЭД.ОжидаетсяКорректировка: return ОжидаетсяКорректировка;
				case СостоянияВерсийЭД.ОжидаетсяОтправка: return ОжидаетсяОтправка;
				case СостоянияВерсийЭД.ОжидаетсяОтправкаИзвещения: return ОжидаетсяОтправкаИзвещения;
				case СостоянияВерсийЭД.ОжидаетсяПодтверждение: return ОжидаетсяПодтверждение;
				case СостоянияВерсийЭД.ОжидаетсяПодтверждениеОператора: return ОжидаетсяПодтверждениеОператора;
				case СостоянияВерсийЭД.Отклонен: return Отклонен;
				case СостоянияВерсийЭД.ОбменЗавершен: return ОбменЗавершен;
				case СостоянияВерсийЭД.ОшибкаПередачи: return ОшибкаПередачи;
				case СостоянияВерсийЭД.ТребуетсяУточнитьДокумент: return ТребуетсяУточнитьДокумент;
			}
			return Guid.Empty;
		}
	}
}
