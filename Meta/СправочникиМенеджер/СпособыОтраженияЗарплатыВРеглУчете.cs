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
	public partial class СпособыОтраженияЗарплатыВРеглУчете:СправочникМенеджер
	{
		
		public static СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
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
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете Выбрать()
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)  Where _Folder = 0x01 ";
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.СпособыОтраженияЗарплатыВРеглУчете СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СпособыОтраженияЗарплатыВРеглУчете();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.СпособРаспределенияЗатрат = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
			Объект.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка;
			Объект.ПодразделениеДт = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			Объект.ПодразделениеКт = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			Объект.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка;
			return Объект;
		}
		
		public static V82.СправочникиОбъект.СпособыОтраженияЗарплатыВРеглУчете СоздатьГруппу()
		{
			var Объект = new V82.СправочникиОбъект.СпособыОтраженияЗарплатыВРеглУчете();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = true;
			Объект.СпособРаспределенияЗатрат = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
			Объект.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка;
			Объект.ПодразделениеДт = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			Объект.ПодразделениеКт = new V82.СправочникиСсылка.ПодразделенияОрганизаций();
			Объект.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка;
			return Объект;
		}
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)
					Where _IDRRef between @Мин and @Макс  -- and _Folder = 0x01 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							}
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Fld1876RRef [СчетДт]
					,_Fld1877RRef [СубконтоДт1]
					,_Fld1878RRef [СубконтоДт2]
					,_Fld1879RRef [СубконтоДт3]
					,_Fld1880RRef [СпособРаспределенияЗатрат]
					,_Fld1881RRef [СчетКт]
					,_Fld1882RRef [СубконтоКт1]
					,_Fld1883RRef [СубконтоКт2]
					,_Fld1884RRef [СубконтоКт3]
					,_Fld1885RRef [СчетДтНУ]
					,_Fld1886RRef [СубконтоДтНУ1]
					,_Fld1887RRef [СубконтоДтНУ2]
					,_Fld1888RRef [СубконтоДтНУ3]
					,_Fld1889RRef [СчетКтНУ]
					,_Fld1890RRef [СубконтоКтНУ1]
					,_Fld1891RRef [СубконтоКтНУ2]
					,_Fld1892RRef [СубконтоКтНУ3]
					,_Fld1893RRef [ОтражениеВУСН]
					,_Fld26611RRef [ПодразделениеДт]
					,_Fld26612RRef [ПодразделениеКт]
					,_Fld26613RRef [ВидНачисленийОплатыТрудаПоСтатье255НК]
					From _Reference155(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СпособыОтраженияЗарплатыВРеглУчете();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Родитель = V82.СправочникиСсылка.СпособыОтраженияЗарплатыВРеглУчете.ВзятьИзКэша((byte[])Читалка.GetValue(4));
							Ссылка.ЭтоГруппа = ((byte[])Читалка.GetValue(5))[0]==0;
							Ссылка.Наименование = Читалка.GetString(6);
							if(!Ссылка.ЭтоГруппа)
							{
								Ссылка.СпособРаспределенияЗатрат = V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск.ВзятьИзКэша((byte[])Читалка.GetValue(11));
								Ссылка.ОтражениеВУСН = V82.Перечисления/*Ссылка*/.ОтражениеВУСН.ПустаяСсылка.Получить((byte[])Читалка.GetValue(24));
								Ссылка.ПодразделениеДт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(25));
								Ссылка.ПодразделениеКт = V82.СправочникиСсылка.ПодразделенияОрганизаций.ВзятьИзКэша((byte[])Читалка.GetValue(26));
								Ссылка.ВидНачисленийОплатыТрудаПоСтатье255НК = V82.Перечисления/*Ссылка*/.ВидыНачисленийОплатыТрудаПоСт255НК.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
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