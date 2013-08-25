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
	///(Общ)
	///</summary>
	public partial class Склады:СправочникМенеджер
	{
		
		public static СправочникиСсылка.Склады НайтиПоСсылке(Guid _Ссылка)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
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
		
		public static СправочникиСсылка.Склады НайтиПоКоду(string Код)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
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
		
		public static СправочникиВыборка.Склады Выбрать()
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады СтраницаПоСсылке(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады СтраницаПоКоду(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.Склады СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.Склады();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.Подразделение = new V82.СправочникиСсылка.Подразделения();
			Объект.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка;
			return Объект;
		}
		
		public static V82.СправочникиОбъект.Склады СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.Склады();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.Комментарий = "";
			Объект.ТипЦенРозничнойТорговли = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.Подразделение = new V82.СправочникиСсылка.Подразделения();
			Объект.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка;
			return Объект;
		}
		
		public static СправочникиВыборка.Склады ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.Склады ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1744 [Комментарий]
					,_Fld1745RRef [ТипЦенРозничнойТорговли]
					,_Fld1746RRef [Подразделение]
					,_Fld1747RRef [ВидСклада]
					,_Fld1748 [НомерСекции]
					,_Fld1749 [РасчетРозничныхЦенПоТорговойНаценке]
					From _Reference147(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Склады();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Склады();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.Склады.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Код = Читалка.GetString(6);
							Ссылка.Наименование = Читалка.GetString(7);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.Комментарий = Читалка.GetString(8);
								Ссылка.ТипЦенРозничнойТорговли = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(9));
								Ссылка.Подразделение = V82.СправочникиСсылка.Подразделения.ВзятьИзКэша((byte[])Читалка.GetValue(10));
								Ссылка.ВидСклада = V82.Перечисления/*Ссылка*/.ВидыСкладов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(11));
								Ссылка.НомерСекции = Читалка.GetDecimal(12);
								Ссылка.РасчетРозничныхЦенПоТорговойНаценке = ((byte[])Читалка.GetValue(13))[0]==1;
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