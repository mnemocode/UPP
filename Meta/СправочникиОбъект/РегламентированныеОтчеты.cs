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
	public partial class РегламентированныеОтчеты:СправочникОбъект
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
		public string/*6*/ Код;
		public string/*100*/ Наименование;
		public string/*(255)*/ ИсточникОтчета;//Источник отчета
		public bool НеПоказыватьВСписке;//Не показывать в списке
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Описание;
		public bool ВнешнийОтчетИспользовать;//Использовать внешний отчет
		public ХранилищеЗначения ВнешнийОтчетХранилище;//Хранилище с внешним отчетом
		public ХранилищеЗначения Периоды;
		public string/*(32)*/ ВнешнийОтчетВерсия;//Версия внешнего отчета
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
						Insert Into _Reference220(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3373
						,_Fld3374
						,_Fld3375
						,_Fld3376
						,_Fld3377
						,_Fld3378
						,_Fld3379)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@ИсточникОтчета
						,@НеПоказыватьВСписке
						,@Описание
						,@ВнешнийОтчетИспользовать
						,@ВнешнийОтчетХранилище
						,@Периоды
						,@ВнешнийОтчетВерсия)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference220
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3373	= @ИсточникОтчета
						,_Fld3374	= @НеПоказыватьВСписке
						,_Fld3375	= @Описание
						,_Fld3376	= @ВнешнийОтчетИспользовать
						,_Fld3377	= @ВнешнийОтчетХранилище
						,_Fld3378	= @Периоды
						,_Fld3379	= @ВнешнийОтчетВерсия
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
					Команда.Parameters.AddWithValue("ИсточникОтчета", ИсточникОтчета);
					Команда.Parameters.AddWithValue("НеПоказыватьВСписке", НеПоказыватьВСписке);
					Команда.Parameters.AddWithValue("Описание", Описание);
					Команда.Parameters.AddWithValue("ВнешнийОтчетИспользовать", ВнешнийОтчетИспользовать);
					Команда.Parameters.AddWithValue("ВнешнийОтчетВерсия", ВнешнийОтчетВерсия);
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
					Команда.CommandText = @"Delete _Reference220
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОБЩЕГО НАЗНАЧЕНИЯ
		// Функция определяет тип указанного в реквизите ИсточникОтчета
		// элемента справочника регламентированного отчета (обработки).
		//
		// Параметры
		//  ФайлВнешнегоОтчета - строка - имя файла, указанное в реквизите элемента;
		//  Расширение         - строка - расширение файла;
		//
		// Возвращаемое значение:
		// - число, принимает значения:
		//      - 1 - в реквизите указано наименование
		//            встроенного в конфигурацию отчета;
		//      - 2 - в реквизите указано полное наименование файла.
		//      - 0 - в иных случаях.
		//

		public object ОпределитьТипОтчета(/*ФайлВнешнегоОтчета, Расширение = "", НеВыводитьСообщения = Ложь*/)
		{
			/*ТипОтчета = 0;*/
			if(true/*Не ПустаяСтрока(ФайлВнешнегоОтчета)*/)
			{
				/*ФайлВнешОтчета = Новый Файл(ФайлВнешнегоОтчета);*/
				if(true/*ФайлВнешОтчета.Существует()*/)
				{
					/*ТипОтчета  = 1;*/
					/*Расширение = ФайлВнешОтчета.Расширение;*/
				}
				if(true/*ТипОтчета = 0*/)
				{
					if(true/*НЕ НеВыводитьСообщения*/)
					{
						/*Сообщить("Не найден отчет """ + ФайлВнешнегоОтчета + """!", СтатусСообщения.Внимание);*/
					}
				}
			}
		}
		// ОпределитьТипОтчета()
		// Формирует код нового элемента (группы) справочника
		// в соответствии с иерархической структурой последнего.
		//

		public void ГенерироватьНовыйКод(/**/)
		{
			/*// Код элемента имеет представление:
*/
			/*//  ГГГЭЭЭ, где
*/
			/*//    ГГГ - порядковый номер группы или элементов верхнего уровня;
*/
			/*//    ЭЭЭ - порядковый номер элемента внутри группы.
*/
			/*//
*/
			/*// Порядковые номера определяются с лидирующими нулями.
*/
			if(true/*ЭтоГруппа ИЛИ Уровень() = 0*/)
			{
				if(true/*ЭтоНовый()*/)
				{
					/*УстановитьНовыйКод();*/
				}
				/*ТекКод      = Код;*/
				/*КодГруппы   = Число(Лев(ТекКод, 3)) + 1;*/
				/*Код         = Формат(КодГруппы, "ЧЦ=3; ЧВН=;") + "000";*/
			}
		}
		// ГенерироватьНовыйКод()
		// Процедура генерирует код перемещаемого элемента (группы) справочника,
		// а также код расположенного рядом элемента при интерактивном перемещении
		// элемента в форме списка справочника.
		// Записывает переставляемые элементы с измененными кодами.
		// В случае сдвига группы элементов также изменяет коды вложенных в группу
		// элементов.
		//
		// Параметры
		//  Направление  – число – напрвление сдвига элемента,
		//                 принимает значения:
		//                      1 - при сдвиге вниз;
		//                     -1 - при сдвиге вверх.
		//

		public void ИзменитьКод(/*Направление*/)
		{
			/*ТекущийКод    = Код;*/
			/*СписокКодов   = Новый СписокЗначений;*/
			/*РегламОтчеты  = Справочники.РегламентированныеОтчеты;*/
			/*ВыборкаОтчеты = РегламОтчеты.Выбрать(Родитель, Владелец, , "Код Убыв");*/
			while(true/*ВыборкаОтчеты.Следующий()*/)
			{
				/*СписокКодов.Добавить(ВыборкаОтчеты.Код);*/
			}
			if(true/*СписокКодов.Количество() < 2*/)
			{
				/*// На данном уровне имеется только один элемент или группа справочника.
*/
				/*// Игнорируем действие пользователя.
*/
			}
			/*// Открываем транзакцию
*/
			/*НачатьТранзакцию();*/
			/*ПорядковыйНомер = СписокКодов.Индекс(СписокКодов.НайтиПоЗначению(ТекущийКод));*/
			if(true/*(ПорядковыйНомер = 0) И (Направление < 0)*/)
			{
				/*// Попытка перемещения первого по порядку элемента вверх.
*/
				/*ИндексЭлементаЗамены = СписокКодов.Количество() - 1;*/
			}
			/*КодЭлементаЗамены     = СписокКодов.Получить(ИндексЭлементаЗамены).Значение;*/
			/*ЭлементЗаменыСсылка   = РегламОтчеты.НайтиПоКоду(КодЭлементаЗамены,,Родитель, Владелец);*/
			if(true/*ЭлементЗаменыСсылка <> РегламОтчеты.ПустаяСсылка()*/)
			{
				/*ЭлементЗамены     = ЭлементЗаменыСсылка.ПолучитьОбъект();*/
				/*ТекущийКод        = ЭлементЗамены.Код;*/
				/*ЭлементЗамены.Код = Код;*/
				/*Попытка
			
			ЭлементЗамены.Заблокировать();*/
				/*// записываем соседний элемент с новым кодом
*/
				/*ЭлементЗамены.Записать();*/
				/*Исключение
				
				ОбщегоНазначения.СообщитьОбОшибке("Не удалось записать элемент справочника:
				|" + ОписаниеОшибки());*/
				/*ОтменитьТранзакцию();*/
				/*КонецПопытки;*/
				/*ЭлементЗамены.Разблокировать();*/
				/*// Нельзя модифицировать данные объекта
*/
				/*ОбщегоНазначения.СообщитьОбОшибке("Не удалось записать элемент справочника:
			|" + ОписаниеОшибки());*/
				/*ОтменитьТранзакцию();*/
				/*КонецПопытки;*/
				if(true/*ЭлементЗамены.ЭтоГруппа*/)
				{
					/*// Переписываем коды вложенных в группу элементов.
*/
					/*ВыборкаОтчеты = РегламОтчеты.Выбрать(ЭлементЗаменыСсылка, ЭлементЗамены.Владелец, , "Код Убыв");*/
					while(true/*ВыборкаОтчеты.Следующий()*/)
					{
						/*ЭлементЗамены2     = ВыборкаОтчеты.ПолучитьОбъект();*/
						/*ЭлементЗамены2.Код = Лев(ЭлементЗамены.Код, 3) + Прав(ЭлементЗамены2.Код, 3);*/
						/*Попытка
					
					ЭлементЗамены2.Заблокировать();*/
						/*// записываем новый код вложенного в группу элемента
*/
						/*ЭлементЗамены2.Записать();*/
						/*Исключение
						
						ОбщегоНазначения.СообщитьОбОшибке("Не удалось записать элемент справочника:
						|" + ОписаниеОшибки());*/
						/*ОтменитьТранзакцию();*/
						/*КонецПопытки;*/
						/*ЭлементЗамены2.Разблокировать();*/
						/*// Нельзя модифицировать данные объекта
*/
						/*ОбщегоНазначения.СообщитьОбОшибке("Не удалось записать элемент справочника:
					|" + ОписаниеОшибки());*/
						/*ОтменитьТранзакцию();*/
						/*КонецПопытки;*/
					}
					/*;;*/
				}
			}
			/*// записываем перемещаемый элемент с новым кодом
*/
			/*Код = ТекущийКод;*/
			/*Записать();*/
			if(true/*ЭтоГруппа*/)
			{
				/*// Переписываем коды вложенных в группу элементов.
*/
				/*ВыборкаОтчеты = РегламОтчеты.Выбрать(ЭтотОбъект.Ссылка, Владелец, , "Код Убыв");*/
				while(true/*ВыборкаОтчеты.Следующий()*/)
				{
					/*ЭлементЗамены2     = ВыборкаОтчеты.ПолучитьОбъект();*/
					/*ЭлементЗамены2.Код = Лев(ЭлементЗамены.Код, 3) + Прав(ЭлементЗамены2.Код, 3);*/
					/*Попытка
					
					ЭлементЗамены2.Заблокировать();*/
					/*// записываем новый код вложенного в группу элемента
*/
					/*ЭлементЗамены2.Записать();*/
					/*Исключение
						
						ОбщегоНазначения.СообщитьОбОшибке("Не удалось записать элемент справочника:
						|" + ОписаниеОшибки());*/
					/*ОтменитьТранзакцию();*/
					/*КонецПопытки;*/
					/*ЭлементЗамены2.Разблокировать();*/
					/*// Нельзя модифицировать данные объекта
*/
					/*ОбщегоНазначения.СообщитьОбОшибке("Не удалось записать элемент справочника:
					|" + ОписаниеОшибки());*/
					/*ОтменитьТранзакцию();*/
					/*КонецПопытки;*/
				}
				/*;;*/
			}
			/*// Завершаем транзакцию
*/
			/*ЗафиксироватьТранзакцию();*/
		}
		// ИзменитьКод()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ - ОБРАБОТЧИКИ СОБЫТИЙ ОБЪЕКТА
		// Процедура - обработчик события "ПередЗаписью" формы.
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			if(true/*Не ЭтоНовый()*/)
			{
				/*ПрежнийРодитель = Ссылка.Родитель;*/
				if(true/*ПрежнийРодитель <> Родитель*/)
				{
					/*// В случае, когда объект сменил родителя (переместили элемент
*/
					/*// из одной группы в другую), для обеспечения настроенного порядка
*/
					/*// следования элементов переопределяем код объекта в соответствии
*/
					/*// с порядком следования элементов текущего уровня иерархии.
*/
					/*//
*/
					/*// Принимаем следующие правила:
*/
					/*// при перемещении объекта из одной группы в другую
*/
					/*// размещаем его в конец списка вложенных в группу элементов.
*/
					/*//
*/
					/*// В соответствии спинятыми правилами формируем новый код объекта:
*/
					/*СписокКодов    = Новый СписокЗначений;*/
					/*РегламОтчеты   = Справочники.РегламентированныеОтчеты;*/
					/*ВыборкаОтчеты  = РегламОтчеты.Выбрать(Родитель, Владелец, , "Код Возр");*/
					while(true/*ВыборкаОтчеты.Следующий()*/)
					{
						/*СписокКодов.Добавить(ВыборкаОтчеты.Код);*/
					}
					if(true/*СписокКодов.Количество() = 0*/)
					{
						/*// На данном уровне не имеется элементов справочника.
*/
						/*// Объекту присваиваем самый первый код.
*/
						/*НовыйКодГруппы   = "001";*/
						/*НовыйКодЭлемента = "001";*/
					}
					if(true/*Уровень() > 0*/)
					{
						/*// В случае, когда объект был перемещен в группу.
*/
						/*НовыйКодГруппы   = Лев(Родитель.Код, 3);*/
					}
					/*// В соответствии с принятыми обозначениями код объекта формируется из порядкового
*/
					/*// кода группы и порядкового кода элемента внутри группы.
*/
					/*Код = НовыйКодГруппы + НовыйКодЭлемента;*/
				}
			}
			if(true/*НЕ ЭтоГруппа И ВнешнийОтчетХранилище.Получить() = Неопределено*/)
			{
				/*ВнешнийОтчетВерсия = Неопределено;*/
			}
		}
	}
}
