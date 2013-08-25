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
	///<summary>
	///Настройки формирования документов отработанного времени
	///</summary>
	public partial class НастройкиФормированияДокументовОтработанногоВремени:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
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
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени Выбрать()
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка;
			Объект.ПодразделениеОрганизации = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиФормированияДокументовОтработанногоВремени();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка;
			Объект.ПодразделениеОрганизации = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			return Объект;
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Fld23629 [ГраницаОбработки]
					,_Fld23630RRef [ПериодДетализации]
					,_Fld23631RRef [Организация]
					,_Fld23632RRef [СпособВводаДанных]
					,_Fld23633RRef [ПодразделениеОрганизации]
					,_Fld23634 [ФормироватьДокументыАвтоматически]
					,_Fld23635 [РегламентноеЗадание]
					,_Fld23636 [НеОбрабатыватьВсеДокументы]
					,_Fld23637 [Комментарий]
					,_Fld23638 [Задержка]
					From _Reference23113(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиФормированияДокументовОтработанногоВремени();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НастройкиФормированияДокументовОтработанногоВремени.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.ГраницаОбработки = Читалка.GetDateTime(7);
								Ссылка.ПериодДетализации = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
								Ссылка.Организация = V82.СправочникиСсылка.Организации.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.СпособВводаДанных = V82.Перечисления/*Ссылка*/.СпособыВводаДанныхОВремени.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
								Ссылка.ПодразделениеОрганизации = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(12))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(13);
								Ссылка.НеОбрабатыватьВсеДокументы = ((byte[])Читалка.GetValue(14))[0]==1;
								Ссылка.Комментарий = Читалка.GetString(15);
								Ссылка.Задержка = Читалка.GetDecimal(16);
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