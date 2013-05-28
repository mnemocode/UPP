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
	///(Регл)
	///</summary>
	public partial class ВычетыНДФЛ:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ВычетыНДФЛ НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
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
		
		public static СправочникиСсылка.ВычетыНДФЛ НайтиПоКоду(string Код)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
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
		
		public static СправочникиВыборка.ВычетыНДФЛ Выбрать()
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВычетыНДФЛ ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВычетыНДФЛ ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВычетыНДФЛ ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВычетыНДФЛ СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВычетыНДФЛ СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ВычетыНДФЛ СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2017 [КодДляОтчетности2007]
					,_Fld2018 [КодДляОтчетности2008]
					,_Fld2019 [КодДляОтчетности2009]
					,_Fld2020 [Наименование2007]
					,_Fld2021 [Наименование2008]
					,_Fld2022 [КодДляОтчетности2010]
					,_Fld2023 [НеПредоставляетсяНерезидентам]
					,_Fld2024 [НеОтражаетсяВОтчетности2010]
					,_Fld2025RRef [ГруппаВычета]
					,_Fld2026 [Наименование2010]
					,_Fld2027 [КодДляОтчетности2011]
					From _Reference70(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВычетыНДФЛ();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВычетыНДФЛ();
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
							Ссылка.КодДляОтчетности2007 = Читалка.GetString(6);
							Ссылка.КодДляОтчетности2008 = Читалка.GetString(7);
							Ссылка.КодДляОтчетности2009 = Читалка.GetString(8);
							Ссылка.Наименование2007 = Читалка.GetString(9);
							Ссылка.Наименование2008 = Читалка.GetString(10);
							Ссылка.КодДляОтчетности2010 = Читалка.GetString(11);
							Ссылка.НеПредоставляетсяНерезидентам = ((byte[])Читалка.GetValue(12))[0]==1;
							Ссылка.НеОтражаетсяВОтчетности2010 = ((byte[])Читалка.GetValue(13))[0]==1;
							Ссылка.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка.Получить((byte[])Читалка.GetValue(14));
							Ссылка.Наименование2010 = Читалка.GetString(15);
							Ссылка.КодДляОтчетности2011 = Читалка.GetString(16);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ВычетыНДФЛ СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ВычетыНДФЛ();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.КодДляОтчетности2007 = "";
			Объект.КодДляОтчетности2008 = "";
			Объект.КодДляОтчетности2009 = "";
			Объект.Наименование2007 = "";
			Объект.Наименование2008 = "";
			Объект.КодДляОтчетности2010 = "";
			Объект.Наименование2010 = "";
			Объект.КодДляОтчетности2011 = "";
			Объект.ГруппаВычета = V82.Перечисления/*Ссылка*/.ГруппыВычетовПоНДФЛ.ПустаяСсылка;
			return Объект;
		}
	}
}