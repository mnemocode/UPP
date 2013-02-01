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
	///<summary>
	///Данный справочник содержит обработки обслуживания торгового оборудования.
	///</summary>
	public partial class ОбработкиОбслуживанияТО:СправочникОбъект
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
		public string/*50*/ Наименование;
		///<summary>
		///Реквизит содержит описание обработки обслуживания.
		///</summary>
		public string/*(0)*/ Описание;//Описание обработки обслуживания
		///<summary>
		///Вид торгового оборудования, обслуживаемый настоящей обработкой обслуживания.
		///</summary>
		public V82.Перечисления/*Ссылка*/.ВидыТорговогоОборудования Вид;//Вид торгового оборудования
		///<summary>
		///Имя файла обработки обслуживания.
		///</summary>
		public string/*(256)*/ ИмяФайла;//Имя файла
		///<summary>
		///Обработка обслуживания торгового оборудования.
		///</summary>
		public ХранилищеЗначения Обработка;//Обработка обслуживания
		///<summary>
		///Версия обработки обслуживания.
		///</summary>
		public decimal/*(10.2)*/ Версия;
		///<summary>
		///Уникальный идентификатор обработки обслуживания.
		///</summary>
		public string/*(36)*/ Идентификатор;
		///<summary>
		///Версия API механизма торгового, поддерживаемого обработкой обслуживания.
		///</summary>
		public decimal/*(10.2)*/ ВерсияAPI;//Версия API
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
						Insert Into _Reference168(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2990
						,_Fld2991RRef
						,_Fld2992
						,_Fld2993
						,_Fld2994
						,_Fld2995
						,_Fld2996)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@Описание
						,@Вид
						,@ИмяФайла
						,@Обработка
						,@Версия
						,@Идентификатор
						,@ВерсияAPI)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference168
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2990	= @Описание
						,_Fld2991RRef	= @Вид
						,_Fld2992	= @ИмяФайла
						,_Fld2993	= @Обработка
						,_Fld2994	= @Версия
						,_Fld2995	= @Идентификатор
						,_Fld2996	= @ВерсияAPI
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Описание", Описание);
					Команда.Parameters.AddWithValue("Вид", Вид.Ключ());
					Команда.Parameters.AddWithValue("ИмяФайла", ИмяФайла);
					Команда.Parameters.AddWithValue("Версия", Версия);
					Команда.Parameters.AddWithValue("Идентификатор", Идентификатор);
					Команда.Parameters.AddWithValue("ВерсияAPI", ВерсияAPI);
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
					Команда.CommandText = @"Delete _Reference168
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		///////////////////////////////////////////////////////////////////////////////
		//// ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура - обработчик события "Перед записью".
		//
		// Параметры:
		//  Отказ - <Булево>
		//        - Признак отказа от записи элемента. Если в теле
		//          процедуры-обработчика установить данному параметру
		//          значение Истина, запись элемента выполнена не будет.
		//          Значение по умолчанию: Ложь.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*Не ОбменДанными.Загрузка*/)
			{
				if(true/*ПустаяСтрока(Идентификатор)*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке("Не указан идентификатор обработки обслуживания!");*/
					/*Отказ = Истина;*/
				}
			}
		}
	}
}
