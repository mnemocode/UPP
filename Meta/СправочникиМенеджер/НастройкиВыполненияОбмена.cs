﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class НастройкиВыполненияОбмена:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НастройкиВыполненияОбмена НайтиПоСсылке(Guid _Ссылка)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиСсылка.НастройкиВыполненияОбмена НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена ВыбратьПоКоду(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена СтраницаПоСсылке(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена СтраницаПоКоду(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена СтраницаПоНаименованию(int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиВыполненияОбмена СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиВыполненияОбмена();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.КаталогПроверкиДоступности = "";
			Объект.ВыполнятьОбменПриПоявленииФайла = "";
			Объект.АдресДляОтправкиСообщенийОбОшибке = "";
			Объект.Комментарий = "";
			Объект.РегламентноеЗадание = "";
			Объект.Ответственный = new V82.СправочникиСсылка.Пользователи();
			Объект.УчетнаяЗаписьОтправкиСообщенияОбОшибке = new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты();
			return Объект;
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиВыполненияОбмена ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld22693 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld22694 [ИспользоватьРегламентныеЗадания]
					,_Fld22696 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld22697RRef [Ответственный]
					,_Fld22698 [КаждыйЗапускПрограммы]
					,_Fld22699 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld22700 [КаталогПроверкиДоступности]
					,_Fld22701 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld22702 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld22703 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld22704RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld22705 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld22706 [Комментарий]
					,_Fld22695 [РегламентноеЗадание]
					From _Reference22676(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
								Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Ответственный = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
								Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
								Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
								Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
								Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты.ВзятьИзКэша((byte[])Читалка.GetValue(16));
								Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
								Ссылка.Комментарий = Читалка.GetString(18);
								Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}