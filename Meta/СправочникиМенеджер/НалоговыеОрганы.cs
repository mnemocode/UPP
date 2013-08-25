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
	public partial class НалоговыеОрганы:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НалоговыеОрганы НайтиПоСсылке(Guid _Ссылка)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
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
		
		public static СправочникиСсылка.НалоговыеОрганы НайтиПоКоду(string Код)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
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
		
		public static СправочникиВыборка.НалоговыеОрганы Выбрать()
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ВыбратьПоКоду(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы СтраницаПоСсылке(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы СтраницаПоКоду(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НалоговыеОрганы СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НалоговыеОрганы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ПолноеНаименование = "";
			Объект.ИНН = "";
			Объект.КПП = "";
			Объект.Адрес = "";
			Объект.Телефон = "";
			Объект.АдресЭлектроннойПочты = "";
			Объект.АдресСайта = "";
			Объект.Комментарий = "";
			Объект.УдалитьСертификат = "";
			Объект.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = "";
			Объект.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов();
			return Объект;
		}
		
		public static V82.СправочникиОбъект.НалоговыеОрганы СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.НалоговыеОрганы();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ПолноеНаименование = "";
			Объект.ИНН = "";
			Объект.КПП = "";
			Объект.Адрес = "";
			Объект.Телефон = "";
			Объект.АдресЭлектроннойПочты = "";
			Объект.АдресСайта = "";
			Объект.Комментарий = "";
			Объект.УдалитьСертификат = "";
			Объект.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = "";
			Объект.Вид = new V82.СправочникиСсылка.ВидыНалоговыхОрганов();
			return Объект;
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НалоговыеОрганы ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Code [Код]
					,_Description [Наименование]
					,_Fld23549RRef [Вид]
					,_Fld23550 [ПолноеНаименование]
					,_Fld23551 [УчетНалогоплательщиков]
					,_Fld23552 [ПриемНалоговойОтчетности]
					,_Fld23553 [ИНН]
					,_Fld23554 [КПП]
					,_Fld23555 [Адрес]
					,_Fld23556 [Телефон]
					,_Fld23557 [АдресЭлектроннойПочты]
					,_Fld23558 [АдресСайта]
					,_Fld23559 [Комментарий]
					,_Fld23560 [УдалитьСертификат]
					,_Fld23561 [АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками]
					From _Reference23107(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НалоговыеОрганы();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НалоговыеОрганы();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.НалоговыеОрганы.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.Код = Читалка.GetString(5);
							Ссылка.Наименование = Читалка.GetString(6);
								Ссылка.Вид = V82.СправочникиСсылка.ВидыНалоговыхОрганов.ВзятьИзКэша((byte[])Читалка.GetValue(7));
								Ссылка.ПолноеНаименование = Читалка.GetString(8);
								Ссылка.УчетНалогоплательщиков = ((byte[])Читалка.GetValue(9))[0]==1;
								Ссылка.ПриемНалоговойОтчетности = ((byte[])Читалка.GetValue(10))[0]==1;
								Ссылка.ИНН = Читалка.GetString(11);
								Ссылка.КПП = Читалка.GetString(12);
								Ссылка.Адрес = Читалка.GetString(13);
								Ссылка.Телефон = Читалка.GetString(14);
								Ссылка.АдресЭлектроннойПочты = Читалка.GetString(15);
								Ссылка.АдресСайта = Читалка.GetString(16);
								Ссылка.Комментарий = Читалка.GetString(17);
								Ссылка.УдалитьСертификат = Читалка.GetString(18);
								Ссылка.АдресЭлектроннойПочтыДляЦелейДокументооборотаСНалогоплательщиками = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}