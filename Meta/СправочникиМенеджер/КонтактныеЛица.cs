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
	public partial class КонтактныеЛица:СправочникМенеджер
	{
		
		public static СправочникиСсылка.КонтактныеЛица НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
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
		
		public static СправочникиСсылка.КонтактныеЛица НайтиПоКоду(string Код)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
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
		
		public static СправочникиВыборка.КонтактныеЛица Выбрать()
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.КонтактныеЛица СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.КонтактныеЛица();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Фамилия = "";
			Объект.Имя = "";
			Объект.Отчество = "";
			Объект.Описание = "";
			Объект.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка;
			return Объект;
		}
		
		public static СправочникиВыборка.КонтактныеЛица ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.КонтактныеЛица ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Fld1243 [Фамилия]
					,_Fld1232 [Имя]
					,_Fld1233 [КоличествоДнейДоНапоминания]
					,_Fld1235 [НапоминатьОДнеРождения]
					,_Fld1237 [Отчество]
					,_Fld1231 [ДатаРождения]
					,_Fld1236 [Описание]
					,_Fld1244RRef [Пол]
					From _Reference76(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.КонтактныеЛица();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.КонтактныеЛица();
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
								Ссылка.Фамилия = Читалка.GetString(6);
								Ссылка.Имя = Читалка.GetString(7);
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(8);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.Отчество = Читалка.GetString(10);
								Ссылка.ДатаРождения = Читалка.GetDateTime(11);
								Ссылка.Описание = Читалка.GetString(12);
								Ссылка.Пол = V82.Перечисления/*Ссылка*/.ПолФизическихЛиц.ПустаяСсылка.Получить((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}