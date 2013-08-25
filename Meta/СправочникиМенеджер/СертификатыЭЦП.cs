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
	public partial class СертификатыЭЦП:СправочникМенеджер
	{
		
		public static СправочникиСсылка.СертификатыЭЦП НайтиПоСсылке(Guid _Ссылка)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
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
		
		public static СправочникиВыборка.СертификатыЭЦП Выбрать()
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СертификатыЭЦП ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СертификатыЭЦП ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СертификатыЭЦП СтраницаПоСсылке(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СертификатыЭЦП СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.СертификатыЭЦП СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СертификатыЭЦП();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ДолжностьПоСертификату = "";
			Объект.Назначение = "";
			Объект.Отпечаток = "";
			Объект.ПарольПользователя = "";
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.Пользователь = new V82.СправочникиСсылка.Пользователи();
			return Объект;
		}
		
		public static СправочникиВыборка.СертификатыЭЦП ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СертификатыЭЦП ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Description [Наименование]
					,_Fld23751 [ДолжностьПоСертификату]
					,_Fld23752 [ЗапомнитьПарольКСертификату]
					,_Fld23753 [Назначение]
					,_Fld23754 [ОграничитьДоступКСертификату]
					,_Fld23755RRef [Организация]
					,_Fld23756 [Отозван]
					,_Fld23757 [Отпечаток]
					,_Fld23758 [ПарольПользователя]
					,_Fld23759RRef [Пользователь]
					,_Fld23760 [ПроверятьСоставИсполнителей]
					,_Fld23761 [ФайлСертификата]
					From _Reference23127(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СертификатыЭЦП();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СертификатыЭЦП();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ДолжностьПоСертификату = Читалка.GetString(5);
								Ссылка.ЗапомнитьПарольКСертификату = ((byte[])Читалка.GetValue(6))[0]==1;
								Ссылка.Назначение = Читалка.GetString(7);
								Ссылка.ОграничитьДоступКСертификату = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Отозван = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.Отпечаток = Читалка.GetString(11);
								Ссылка.ПарольПользователя = Читалка.GetString(12);
								Ссылка.Пользователь = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
								Ссылка.ПроверятьСоставИсполнителей = ((byte[])Читалка.GetValue(14))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}