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
	///Регионы
	///</summary>
	public partial class Регионы:СправочникОбъект
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
		///<summary>
		///Комментарий
		///</summary>
		public string/*(0)*/ Комментарий;
		public string/*(5)*/ КодРегиона;//Код региона
		public decimal/*(25)*/ КодАдресногоЭлемента;//Код адресного элемента
		///<summary>
		///Железнодорожная станция назначения
		///</summary>
		public string/*(100)*/ ЖДСтанцияНазначения;//Ж/Д cтанция назначения
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
						Insert Into _Reference218(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3359
						,_Fld3360
						,_Fld3361
						,_Fld3362)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@Комментарий
						,@КодРегиона
						,@КодАдресногоЭлемента
						,@ЖДСтанцияНазначения)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference218
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3359	= @Комментарий
						,_Fld3360	= @КодРегиона
						,_Fld3361	= @КодАдресногоЭлемента
						,_Fld3362	= @ЖДСтанцияНазначения
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
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("КодРегиона", КодРегиона);
					Команда.Parameters.AddWithValue("КодАдресногоЭлемента", КодАдресногоЭлемента);
					Команда.Parameters.AddWithValue("ЖДСтанцияНазначения", ЖДСтанцияНазначения);
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
					Команда.CommandText = @"Delete _Reference218
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// флаг необходимости проверки соотвествия кода и кода региона

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*(НЕ ОбменДанными.Загрузка) и ПроверятьСоответствиеКодаИКодаРегиона*/)
			{
				/*// проверка правильности заполнения кода региона
*/
				/*КодСтраны = Цел(КодАдресногоЭлемента / 100000000000);*/
				if(true/*КодСтраны = 643*/)
				{
					/*КодРег = Цел((КодАдресногоЭлемента - КодСтраны * 100000000000) / 1000000000);*/
					/*// проверка соответствия кода и кода региона
*/
					if(true/*Строка(КодРег) <> КодРегиона*/)
					{
						/*Ответ = Вопрос("Код региона не соответствует коду адресного элемента. Установить код региона автоматически?",
								РежимДиалогаВопрос.ДаНет, , , "Проверка кода региона");*/
						if(true/*Ответ = КодВозвратаДиалога.Да*/)
						{
							/*КодРегиона = Строка(КодРег);*/
						}
					}
				}
			}
			/*#КонецЕсли;*/
		}
		// ТЕКСТ ОСНОВНОЙ ПРОГРАММЫ
		///////////////////////////////////////////////////////////////////////////////
	}
}
