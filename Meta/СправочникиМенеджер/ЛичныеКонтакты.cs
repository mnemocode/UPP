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
	public partial class ЛичныеКонтакты:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ЛичныеКонтакты НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
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
		
		public static СправочникиСсылка.ЛичныеКонтакты НайтиПоКоду(string Код)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
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
		
		public static СправочникиВыборка.ЛичныеКонтакты Выбрать()
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ЛичныеКонтакты СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ЛичныеКонтакты();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Фамилия = "";
			Объект.Имя = "";
			Объект.Отчество = "";
			Объект.Описание = "";
			Объект.ПользовательДляОграниченияПравДоступа = new V82.СправочникиСсылка.Пользователи();
			return Объект;
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ЛичныеКонтакты ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Fld1312 [Фамилия]
					,_Fld1313 [Имя]
					,_Fld1314 [Отчество]
					,_Fld1315 [ДатаРождения]
					,_Fld1316 [Описание]
					,_Fld1317 [НапоминатьОДнеРождения]
					,_Fld1318 [КоличествоДнейДоНапоминания]
					,_Fld1319RRef [ПользовательДляОграниченияПравДоступа]
					From _Reference82(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ЛичныеКонтакты();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ЛичныеКонтакты();
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
								Ссылка.Отчество = Читалка.GetString(8);
								Ссылка.ДатаРождения = Читалка.GetDateTime(9);
								Ссылка.Описание = Читалка.GetString(10);
								Ссылка.НапоминатьОДнеРождения = ((byte[])Читалка.GetValue(11))[0]==1;
								Ссылка.КоличествоДнейДоНапоминания = Читалка.GetDecimal(12);
								Ссылка.ПользовательДляОграниченияПравДоступа = V82.СправочникиСсылка.Пользователи.ВзятьИзКэша((byte[])Читалка.GetValue(13));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}