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
	public partial class ПрофилиПолномочийПользователей:СправочникОбъект
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
		public string/*100*/ Наименование;
		public string/*(100)*/ ОсновнойИнтерфейс;//Основной интерфейс
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
						Insert Into _Reference209(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld3298)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Наименование
						,@ОсновнойИнтерфейс)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference209
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Description	= @Наименование
						,_Fld3298	= @ОсновнойИнтерфейс
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ОсновнойИнтерфейс", ОсновнойИнтерфейс);
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
					Команда.CommandText = @"Delete _Reference209
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// МЕХАНИЗМ ОБНОВЛЕНИЯ ДАННЫХ ПОЛЬЗОВАТЕЛЕЙ ИБ

		public object СоставРолейИзменен(/*СтарыйСоставРолей*/)
		{
			if(true/*СтарыйСоставРолей.Количество() <> СоставРолей.Количество()*/)
			{
			}
			/*СоставРолейКопия = СоставРолей.Выгрузить(,"ИмяРоли");*/
			/*СоставРолейКопия.Сортировать("ИмяРоли");*/
			/*СтарыйСоставРолей.Сортировать("ИмяРоли");*/
			/*// Сортируем здесь, чтобы был одинаковый алгоритм сортировки
*/
			/*ИндексСтроки = 0;*/
		}
		// СоставРолейИзменен
		// Функция возвращает структуру содержащую изменения этого профиля
		//

		public object ПолучитьСтуктуруИзменений(/**/)
		{
			/*СтруктураИзменений = Новый Структура;*/
			if(true/*ЭтоНовый()*/)
			{
			}
			if(true/*СоставРолейИзменен(Ссылка.СоставРолей.Выгрузить())*/)
			{
				/*СтруктураИзменений.Вставить("СоставРолей");*/
			}
			if(true/*Ссылка.ОсновнойИнтерфейс <> ОсновнойИнтерфейс*/)
			{
				/*СтруктураИзменений.Вставить("ОсновнойИнтерфейс");*/
			}
		}
		// ПолучитьСтуктуруИзменений
		// Процедура обновляет даные пользователей ИБ, имеющих данный профиль
		//

		public void ОбновитьДанныеПользователейИБ(/*Отказ*/)
		{
			if(true/*ЭтоГруппа*/)
			{
			}
			/*СтруктураИзменений = ПолучитьСтуктуруИзменений();*/
			if(true/*СтруктураИзменений.Количество() = 0*/)
			{
			}
			/*СтруктураДанных = Новый Структура;*/
			if(true/*СтруктураИзменений.Свойство("СоставРолей")*/)
			{
				/*МассивРолей = СоставРолей.ВыгрузитьКолонку("ИмяРоли");*/
				/*СтруктураДанных.Вставить("СоставРолей", МассивРолей);*/
			}
			if(true/*СтруктураИзменений.Свойство("ОсновнойИнтерфейс")*/)
			{
				/*СтруктураДанных.Вставить("ОсновнойИнтерфейс", ОсновнойИнтерфейс);*/
			}
			/*Запрос = Новый Запрос;*/
			/*Запрос.УстановитьПараметр("ПрофильПолномочий", Ссылка);*/
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	Пользователи.Код КАК ИмяПользователя
	|ИЗ
	|	Справочник.Пользователи КАК Пользователи
	|ГДЕ
	|	Пользователи.ПрофильПолномочийПользователя = &ПрофильПолномочий";*/
			/*Запрос.Текст = ТекстЗапроса;*/
			/*Результат = Запрос.Выполнить();*/
			/*Выборка = Результат.Выбрать();*/
			while(true/*Выборка.Следующий()*/)
			{
				/*УправлениеПользователями.ИзменитьДанныеПользователяИБ(Выборка.ИмяПользователя, СтруктураДанных);*/
			}
			/*;;*/
		}
		// ОбновитьРолиПользователейИБ
		////////////////////////////////////////////////////////////////////////////////
		// СОБЫТИЯ ОБЪЕКТА

		public void ПередЗаписью(/*Отказ*/)
		{
			/*ОбновитьДанныеПользователейИБ(Отказ);*/
		}
	}
}
