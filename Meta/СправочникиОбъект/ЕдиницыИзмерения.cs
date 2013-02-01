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
	///(Общ)
	///</summary>
	public partial class ЕдиницыИзмерения:СправочникОбъект
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
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.КлассификаторЕдиницИзмерения ЕдиницаПоКлассификатору;//Единица по классификатору
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.3)*/ Вес;
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.3)*/ Объем;
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(10.3)*/ Коэффициент;
		public decimal/*(10)*/ ПорогОкругления;//Порог округления
		public bool ПредупреждатьОНецелыхМестах;//При округлении предупреждать о нецелых местах
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
						Insert Into _Reference97(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2307RRef
						,_Fld2308
						,_Fld2309
						,_Fld2310
						,_Fld2311
						,_Fld2312)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ЕдиницаПоКлассификатору
						,@Вес
						,@Объем
						,@Коэффициент
						,@ПорогОкругления
						,@ПредупреждатьОНецелыхМестах)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference97
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2307RRef	= @ЕдиницаПоКлассификатору
						,_Fld2308	= @Вес
						,_Fld2309	= @Объем
						,_Fld2310	= @Коэффициент
						,_Fld2311	= @ПорогОкругления
						,_Fld2312	= @ПредупреждатьОНецелыхМестах
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ЕдиницаПоКлассификатору", ЕдиницаПоКлассификатору.Ссылка);
					Команда.Parameters.AddWithValue("Вес", Вес);
					Команда.Parameters.AddWithValue("Объем", Объем);
					Команда.Parameters.AddWithValue("Коэффициент", Коэффициент);
					Команда.Parameters.AddWithValue("ПорогОкругления", ПорогОкругления);
					Команда.Parameters.AddWithValue("ПредупреждатьОНецелыхМестах", ПредупреждатьОНецелыхМестах);
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
					Команда.CommandText = @"Delete _Reference97
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// Обработчик события ПередЗаписью .
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			if(true/*НЕ ЭтоНовый()
		И ТипЗнч(Владелец) = Тип("СправочникСсылка.Номенклатура")
		И Владелец.ЕдиницаХраненияОстатков = Ссылка*/)
			{
				/*// Проверим, не изменился ли коэффициент
*/
				/*Запрос = Новый Запрос;*/
				/*Запрос.УстановитьПараметр("ТекущийЭлемент", ЭтотОбъект.Ссылка);*/
				/*Запрос.Текст =
			"ВЫБРАТЬ
			|	ЕдиницыИзмерения.Ссылка КАК Элемент,
			|	ЕдиницыИзмерения.Коэффициент КАК Коэффициент
			|ИЗ
			|	Справочник.ЕдиницыИзмерения КАК ЕдиницыИзмерения
			|
			|ГДЕ
			|	ЕдиницыИзмерения.Ссылка = &ТекущийЭлемент";*/
				/*Выборка = Запрос.Выполнить().Выбрать();*/
				if(true/*Выборка.Следующий()*/)
				{
					if(true/*Выборка.Коэффициент <> Коэффициент*/)
					{
						if(true/*ПолныеПрава.Номенклатура_СуществуютСсылки(Владелец, Неопределено)*/)
						{
							/*ОбщегоНазначения.СообщитьОбОшибке("Единица """ + Наименование + """ является единицей хранения остатков для """ + Владелец.Наименование + """ и уже участвует в товародвижении. Изменить коэффициент уже нельзя!", Отказ);*/
						}
					}
				}
			}
			if(true/*Не Отказ И Коэффициент = 0*/)
			{
				/*ОбщегоНазначения.СообщитьОбОшибке("Для "+СокрЛП(Владелец)+" у единицы измерения "+СокрЛП(Ссылка)+" не задан коэффициент! Он будет установлен равным 1.");*/
				/*Коэффициент = 1;*/
			}
		}
	}
}
