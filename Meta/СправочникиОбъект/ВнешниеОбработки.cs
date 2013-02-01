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
	public partial class ВнешниеОбработки:СправочникОбъект
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
		public string/*150*/ Наименование;
		public ХранилищеЗначения ХранилищеВнешнейОбработки;//Хранилище внешней обработки
		public V82.Перечисления/*Ссылка*/.ВидыДополнительныхВнешнихОбработок ВидОбработки;//Вид обработки
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий;
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		public string/*(0)*/ КомментарийКФайлуИсточнику;//Комментарий к файлу источнику
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
						Insert Into _Reference68(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld1994
						,_Fld1995RRef
						,_Fld1996
						,_Fld1997)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@ХранилищеВнешнейОбработки
						,@ВидОбработки
						,@Комментарий
						,@КомментарийКФайлуИсточнику)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference68
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld1994	= @ХранилищеВнешнейОбработки
						,_Fld1995RRef	= @ВидОбработки
						,_Fld1996	= @Комментарий
						,_Fld1997	= @КомментарийКФайлуИсточнику
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВидОбработки", ВидОбработки.Ключ());
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("КомментарийКФайлуИсточнику", КомментарийКФайлуИсточнику);
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
					Команда.CommandText = @"Delete _Reference68
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*НЕ ОбменДанными.Загрузка*/)
			{
				/*ПрошлыйИзмененныйРодительОбъектаДоступа = ?(Не ЭтоНовый() и Не Ссылка.Родитель = Родитель, Ссылка.Родитель, Неопределено);*/
				/*НастройкаПравДоступа.ПередЗаписьюНовогоОбъектаСПравамиДоступаПользователей(ЭтотОбъект, Отказ, Родитель);*/
				if(true/*ВидОбработки = Перечисления.ВидыДополнительныхВнешнихОбработок.ЗаполнениеТабличныхЧастей*/)
				{
					/*// Сообщить о неуказанных табличных частей для заполнения.
*/
				}
				/*#КонецЕсли;*/
			}
		}

		public void ПриЗаписи(/*Отказ*/)
		{
			if(true/*ПометкаУдаления*/)
			{
			}
			if(true/*НЕ ОбменДанными.Загрузка*/)
			{
				/*НастройкаПравДоступа.ОбновитьПраваДоступаКИерархическимОбъектамПриНеобходимости(Ссылка,ПрошлыйИзмененныйРодительОбъектаДоступа, Отказ);*/
			}
		}
	}
}
