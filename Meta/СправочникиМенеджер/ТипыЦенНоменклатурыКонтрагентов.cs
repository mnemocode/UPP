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
	///(Упр)
	///</summary>
	public partial class ТипыЦенНоменклатурыКонтрагентов:СправочникМенеджер
	{
		
		public static СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
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
		
		public static СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов НайтиПоКоду(string Код)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
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
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов Выбрать()
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов СтраницаПоКоду(int Размер,int Номер)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.ТипыЦенНоменклатурыКонтрагентов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ТипыЦенНоменклатурыКонтрагентов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ОписаниеТипаЦеныНоменклатурыКонтрагента = "";
			Объект.Комментарий = "";
			Объект.ВалютаЦены = new V82.СправочникиСсылка.Валюты();
			Объект.ТипЦеныНоменклатуры = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			return Объект;
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Fld2119RRef [ВалютаЦены]
					,_Fld2120 [ЦенаВключаетНДС]
					,_Fld2121RRef [ТипЦеныНоменклатуры]
					,_Fld2122 [ОписаниеТипаЦеныНоменклатурыКонтрагента]
					,_Fld2123 [Комментарий]
					From _Reference182(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыЦенНоменклатурыКонтрагентов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыЦенНоменклатурыКонтрагентов();
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
								Ссылка.ВалютаЦены = V82.СправочникиСсылка.Валюты.ВзятьИзКэша((byte[])Читалка.GetValue(6));
								Ссылка.ЦенаВключаетНДС = ((byte[])Читалка.GetValue(7))[0]==1;
								Ссылка.ТипЦеныНоменклатуры = V82.СправочникиСсылка.ТипыЦенНоменклатуры.ВзятьИзКэша((byte[])Читалка.GetValue(8));
								Ссылка.ОписаниеТипаЦеныНоменклатурыКонтрагента = Читалка.GetString(9);
								Ссылка.Комментарий = Читалка.GetString(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}