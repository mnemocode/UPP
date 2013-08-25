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
	public partial class НастройкиДопроведенияДокументов:СправочникМенеджер
	{
		
		public static СправочникиСсылка.НастройкиДопроведенияДокументов НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
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
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов Выбрать()
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK) ";
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов ВыбратьПоНаименованию(int Первые,string Мин,string Макс)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)
					Where _Description between @Мин and @Макс
					Order by _Description", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов СтраницаПоНаименованию(int Размер,int Номер)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.СправочникиОбъект.НастройкиДопроведенияДокументов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиДопроведенияДокументов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			Объект.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка;
			return Объект;
		}
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов ИерархияВыбратьПоСсылке(Guid Родитель,int Режим,int Первые,Guid Мин,Guid Макс)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)
					Where _IDRRef between @Мин and @Макс 
					AND _ParentIDRRef = @Родитель
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static СправочникиВыборка.НастройкиДопроведенияДокументов ИерархияСтраницаПоСсылке(Guid Родитель,int Режим,int Размер,int Номер)
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
					,_Fld23582 [ФормироватьДокументыАвтоматически]
					,_Fld23583 [РегламентноеЗадание]
					,_Fld23584 [Комментарий]
					,_Fld23585 [ДопроводитьВсеДокументы]
					,_Fld23586 [НомерДняКонецЗапуска]
					,_Fld23587 [НомерДняНачалоЗапуска]
					,_Fld23588 [НачалоИнтервалаДопроведения]
					,_Fld23589 [КонецИнтервалаДопроведения]
					,_Fld23590 [КоличествоПериодовОтставанияКонецИнтервала]
					,_Fld23591 [КоличествоПериодовОтставанияНачалоИнтервала]
					,_Fld23592RRef [ПериодичностьОтставанияКонецИнтервала]
					,_Fld23593RRef [ПериодичностьОтставанияНачалоИнтервала]
					,_Fld23594 [РассчитыватьКонецИнтервала]
					,_Fld23595 [РассчитыватьНачалоИнтервала]
					From _Reference23108(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиДопроведенияДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиДопроведенияДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Ссылка.Наименование = Читалка.GetString(4);
								Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(5))[0]==1;
								Ссылка.РегламентноеЗадание = Читалка.GetString(6);
								Ссылка.Комментарий = Читалка.GetString(7);
								Ссылка.ДопроводитьВсеДокументы = ((byte[])Читалка.GetValue(8))[0]==1;
								Ссылка.НомерДняКонецЗапуска = Читалка.GetDecimal(9);
								Ссылка.НомерДняНачалоЗапуска = Читалка.GetDecimal(10);
								Ссылка.НачалоИнтервалаДопроведения = Читалка.GetDateTime(11);
								Ссылка.КонецИнтервалаДопроведения = Читалка.GetDateTime(12);
								Ссылка.КоличествоПериодовОтставанияКонецИнтервала = Читалка.GetDecimal(13);
								Ссылка.КоличествоПериодовОтставанияНачалоИнтервала = Читалка.GetDecimal(14);
								Ссылка.ПериодичностьОтставанияКонецИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
								Ссылка.ПериодичностьОтставанияНачалоИнтервала = V82.Перечисления/*Ссылка*/.Периодичность.ПустаяСсылка.Получить((byte[])Читалка.GetValue(16));
								Ссылка.РассчитыватьКонецИнтервала = ((byte[])Читалка.GetValue(17))[0]==1;
								Ссылка.РассчитыватьНачалоИнтервала = ((byte[])Читалка.GetValue(18))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
	}
}