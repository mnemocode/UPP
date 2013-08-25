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
	public partial class КурсыОбучения:СправочникМенеджер
	{
		
		public static СправочникиСсылка.КурсыОбучения НайтиПоСсылке(Guid _Ссылка)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
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
		
		public static СправочникиВыборка.КурсыОбучения Выбрать()
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КурсыОбучения ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КурсыОбучения ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КурсыОбучения СтраницаПоСсылке(int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КурсыОбучения СтраницаПоНаименованию(int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.КурсыОбучения СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.КурсыОбучения();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ОписаниеКурса = "";
			Объект.ВидДокументаОбОбразовании = new V82.СправочникиСсылка.ДокументыОбОбразовании();
			Объект.Валюта = new V82.СправочникиСсылка.Валюты();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.КурсыОбучения СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.КурсыОбучения();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.ОписаниеКурса = "";
			Объект.ВидДокументаОбОбразовании = new V82.СправочникиСсылка.ДокументыОбОбразовании();
			Объект.Валюта = new V82.СправочникиСсылка.Валюты();
			return Объект;
		}
		
		public static СправочникиВыборка.КурсыОбучения ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КурсыОбучения ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_ParentIDRRef [Родитель]
					,_Folder [ЭтоГруппа]
					,_Description [Наименование]
					,_Fld1298 [ОписаниеКурса]
					,_Fld1299 [ДлительностьКурса]
					,_Fld1300 [ЗатратыНаОдногоОбучающегося]
					,_Fld1301RRef [ВидДокументаОбОбразовании]
					,_Fld1302RRef [Валюта]
					,_Fld1303 [ОтражатьВРегУчете]
					From _Reference81(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КурсыОбучения();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КурсыОбучения();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.КурсыОбучения.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ОписаниеКурса = Читалка.GetString(7);
								Ссылка.ДлительностьКурса = Читалка.GetDecimal(8);
								Ссылка.ЗатратыНаОдногоОбучающегося = Читалка.GetDecimal(9);
								Ссылка.ВидДокументаОбОбразовании = V82.СправочникиСсылка.ДокументыОбОбразовании.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.Валюта = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражатьВРегУчете = ((byte[])Читалка.GetValue(12))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}