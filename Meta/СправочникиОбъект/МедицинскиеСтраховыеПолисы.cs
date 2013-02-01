﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	public partial class МедицинскиеСтраховыеПолисы:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		public Guid Ссылка;
		public long Версия;
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления;
		public bool Предопределенный;
		public Guid Владелец;
		public bool ЭтоГруппа;
		public Guid Родитель;
		public string/*9*/ Код;
		public string/*25*/ Наименование;
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо;
		public V82.СправочникиСсылка.Организации Организация;
		public V82.Перечисления/*Ссылка*/.ВидыМедицинскогоСтрахования ВидСтрахования;//Вид страхования
		public DateTime ДатаВыдачиПолиса;//Дата выдачи полиса
		public DateTime ДатаОкончанияПолиса;//Дата окончания полиса
		public V82.СправочникиСсылка.ПрограммыМедицинскогоСтрахования ПрограммаСтрахования;//Программа страхования
		public bool СтрахованиеРодственника;//Страхование родственника
		public string/*(50)*/ Родственник;
		public V82.Перечисления/*Ссылка*/.ПолФизическихЛиц Пол;
		public DateTime ДатаРождения;//Дата рождения
		public string/*(300)*/ УдостоверениеЛичности;//Удостоверение личности
		public string/*(100)*/ АдресФактический;//Адрес фактический
		public string/*(100)*/ ТелефонДомашний;//Телефон домашний
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.ДокументыУдостоверяющиеЛичность ДокументВид;//Вид документа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(14)*/ ДокументСерия;//Серия документа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(14)*/ ДокументНомер;//Номер документа
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДокументДатаВыдачи;//Дата выдачи документа
		///<summary>
		///(Общ)
		///</summary>
		public string/*(0)*/ ДокументКемВыдан;//Кем выдан документ
		///<summary>
		///(Регл)
		///</summary>
		public string/*(15)*/ ДокументКодПодразделения;//Код подразделения в документе
		public string/*(0)*/ Комментарий;
		public void Записать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference136(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2539RRef
						,_Fld2540RRef
						,_Fld2541RRef
						,_Fld2542
						,_Fld2543
						,_Fld2544RRef
						,_Fld2545
						,_Fld2546
						,_Fld2547RRef
						,_Fld2548
						,_Fld2549
						,_Fld2550
						,_Fld2551
						,_Fld2552RRef
						,_Fld2553
						,_Fld2554
						,_Fld2555
						,_Fld2556
						,_Fld2557
						,_Fld2558)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@Физлицо
						,@Организация
						,@ВидСтрахования
						,@ДатаВыдачиПолиса
						,@ДатаОкончанияПолиса
						,@ПрограммаСтрахования
						,@СтрахованиеРодственника
						,@Родственник
						,@Пол
						,@ДатаРождения
						,@УдостоверениеЛичности
						,@АдресФактический
						,@ТелефонДомашний
						,@ДокументВид
						,@ДокументСерия
						,@ДокументНомер
						,@ДокументДатаВыдачи
						,@ДокументКемВыдан
						,@ДокументКодПодразделения
						,@Комментарий)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference136
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2539RRef	= @Физлицо
						,_Fld2540RRef	= @Организация
						,_Fld2541RRef	= @ВидСтрахования
						,_Fld2542	= @ДатаВыдачиПолиса
						,_Fld2543	= @ДатаОкончанияПолиса
						,_Fld2544RRef	= @ПрограммаСтрахования
						,_Fld2545	= @СтрахованиеРодственника
						,_Fld2546	= @Родственник
						,_Fld2547RRef	= @Пол
						,_Fld2548	= @ДатаРождения
						,_Fld2549	= @УдостоверениеЛичности
						,_Fld2550	= @АдресФактический
						,_Fld2551	= @ТелефонДомашний
						,_Fld2552RRef	= @ДокументВид
						,_Fld2553	= @ДокументСерия
						,_Fld2554	= @ДокументНомер
						,_Fld2555	= @ДокументДатаВыдачи
						,_Fld2556	= @ДокументКемВыдан
						,_Fld2557	= @ДокументКодПодразделения
						,_Fld2558	= @Комментарий
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Физлицо", Физлицо.Ссылка);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("ВидСтрахования", ВидСтрахования.Ключ());
					Команда.Parameters.AddWithValue("ДатаВыдачиПолиса", ДатаВыдачиПолиса);
					Команда.Parameters.AddWithValue("ДатаОкончанияПолиса", ДатаОкончанияПолиса);
					Команда.Parameters.AddWithValue("ПрограммаСтрахования", ПрограммаСтрахования.Ссылка);
					Команда.Parameters.AddWithValue("СтрахованиеРодственника", СтрахованиеРодственника);
					Команда.Parameters.AddWithValue("Родственник", Родственник);
					Команда.Parameters.AddWithValue("Пол", Пол.Ключ());
					Команда.Parameters.AddWithValue("ДатаРождения", ДатаРождения);
					Команда.Parameters.AddWithValue("УдостоверениеЛичности", УдостоверениеЛичности);
					Команда.Parameters.AddWithValue("АдресФактический", АдресФактический);
					Команда.Parameters.AddWithValue("ТелефонДомашний", ТелефонДомашний);
					Команда.Parameters.AddWithValue("ДокументВид", ДокументВид.Ссылка);
					Команда.Parameters.AddWithValue("ДокументСерия", ДокументСерия);
					Команда.Parameters.AddWithValue("ДокументНомер", ДокументНомер);
					Команда.Parameters.AddWithValue("ДокументДатаВыдачи", ДокументДатаВыдачи);
					Команда.Parameters.AddWithValue("ДокументКемВыдан", ДокументКемВыдан);
					Команда.Parameters.AddWithValue("ДокументКодПодразделения", ДокументКодПодразделения);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Reference136
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}
