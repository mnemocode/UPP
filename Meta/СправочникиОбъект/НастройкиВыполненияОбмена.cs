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
	public partial class НастройкиВыполненияОбмена:СправочникОбъект
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
		public string/*150*/ Наименование;
		public bool ВыполнятьДействияПодПолнымиПравами;//Выполнять действия под полными правами
		public bool ИспользоватьРегламентныеЗадания;//Использовать регламентные задания
		public bool ДинамическиИзменятьИнтервалМеждуОбменами;//Динамически изменять интервал между обменами
		public V82.СправочникиСсылка.Пользователи Ответственный;//Пользователь
		public bool КаждыйЗапускПрограммы;//Каждый запуск программы
		public bool КаждоеЗавершениеРаботыСПрограммой;//Каждое завершение работы с программой
		public string/*(255)*/ КаталогПроверкиДоступности;//Каталог проверки доступности
		public string/*(255)*/ ВыполнятьОбменПриПоявленииФайла;//Выполнять обмен при появлении файла
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаВыгрузкуДанных;//Количество элементов в транзакции на выгрузку данных
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаЗагрузкуДанных;//Количество элементов в транзакции на загрузку данных
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьОтправкиСообщенияОбОшибке;//Учетная запись отправки сообщения об ошибке
		public string/*(100)*/ АдресДляОтправкиСообщенийОбОшибке;//Адрес для отправки сообщений об ошибке
		public string/*(0)*/ Комментарий;
		public string/*(40)*/ РегламентноеЗадание;//Регламентное задание
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
						Insert Into _Reference149(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld2647
						,_Fld2648
						,_Fld2649
						,_Fld2650RRef
						,_Fld2651
						,_Fld2652
						,_Fld2653
						,_Fld2654
						,_Fld2655
						,_Fld2656
						,_Fld2657RRef
						,_Fld2658
						,_Fld2659
						,_Fld2660)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ВыполнятьДействияПодПолнымиПравами
						,@ИспользоватьРегламентныеЗадания
						,@ДинамическиИзменятьИнтервалМеждуОбменами
						,@Ответственный
						,@КаждыйЗапускПрограммы
						,@КаждоеЗавершениеРаботыСПрограммой
						,@КаталогПроверкиДоступности
						,@ВыполнятьОбменПриПоявленииФайла
						,@КоличествоЭлементовВТранзакцииНаВыгрузкуДанных
						,@КоличествоЭлементовВТранзакцииНаЗагрузкуДанных
						,@УчетнаяЗаписьОтправкиСообщенияОбОшибке
						,@АдресДляОтправкиСообщенийОбОшибке
						,@Комментарий
						,@РегламентноеЗадание)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference149
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld2647	= @ВыполнятьДействияПодПолнымиПравами
						,_Fld2648	= @ИспользоватьРегламентныеЗадания
						,_Fld2649	= @ДинамическиИзменятьИнтервалМеждуОбменами
						,_Fld2650RRef	= @Ответственный
						,_Fld2651	= @КаждыйЗапускПрограммы
						,_Fld2652	= @КаждоеЗавершениеРаботыСПрограммой
						,_Fld2653	= @КаталогПроверкиДоступности
						,_Fld2654	= @ВыполнятьОбменПриПоявленииФайла
						,_Fld2655	= @КоличествоЭлементовВТранзакцииНаВыгрузкуДанных
						,_Fld2656	= @КоличествоЭлементовВТранзакцииНаЗагрузкуДанных
						,_Fld2657RRef	= @УчетнаяЗаписьОтправкиСообщенияОбОшибке
						,_Fld2658	= @АдресДляОтправкиСообщенийОбОшибке
						,_Fld2659	= @Комментарий
						,_Fld2660	= @РегламентноеЗадание
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ВыполнятьДействияПодПолнымиПравами", ВыполнятьДействияПодПолнымиПравами);
					Команда.Parameters.AddWithValue("ИспользоватьРегламентныеЗадания", ИспользоватьРегламентныеЗадания);
					Команда.Parameters.AddWithValue("ДинамическиИзменятьИнтервалМеждуОбменами", ДинамическиИзменятьИнтервалМеждуОбменами);
					Команда.Parameters.AddWithValue("Ответственный", Ответственный.Ссылка);
					Команда.Parameters.AddWithValue("КаждыйЗапускПрограммы", КаждыйЗапускПрограммы);
					Команда.Parameters.AddWithValue("КаждоеЗавершениеРаботыСПрограммой", КаждоеЗавершениеРаботыСПрограммой);
					Команда.Parameters.AddWithValue("КаталогПроверкиДоступности", КаталогПроверкиДоступности);
					Команда.Parameters.AddWithValue("ВыполнятьОбменПриПоявленииФайла", ВыполнятьОбменПриПоявленииФайла);
					Команда.Parameters.AddWithValue("КоличествоЭлементовВТранзакцииНаВыгрузкуДанных", КоличествоЭлементовВТранзакцииНаВыгрузкуДанных);
					Команда.Parameters.AddWithValue("КоличествоЭлементовВТранзакцииНаЗагрузкуДанных", КоличествоЭлементовВТранзакцииНаЗагрузкуДанных);
					Команда.Parameters.AddWithValue("УчетнаяЗаписьОтправкиСообщенияОбОшибке", УчетнаяЗаписьОтправкиСообщенияОбОшибке.Ссылка);
					Команда.Parameters.AddWithValue("АдресДляОтправкиСообщенийОбОшибке", АдресДляОтправкиСообщенийОбОшибке);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("РегламентноеЗадание", РегламентноеЗадание);
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
					Команда.CommandText = @"Delete _Reference149
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public object НайтиРеглЗаданиеПоПараметру(/*УникальныйНомерЗадания*/)
		{
			if(true/*НЕ ПустаяСтрока(УникальныйНомерЗадания)*/)
			{
				/*УникальныйИдентификаторЗадания = Новый УникальныйИдентификатор(УникальныйНомерЗадания);*/
				/*ТекущееРегламентноеЗадание = РегламентныеЗадания.НайтиПоУникальномуИдентификатору(УникальныйИдентификаторЗадания);*/
			}
			/*Исключение
		
		ТекущееРегламентноеЗадание = Неопределено;*/
			/*КонецПопытки;*/
		}

		public object НайтиРегламентноеЗаданиеПоНастройке(/**/)
		{
			/*ТекущееРегламентноеЗадание = НайтиРеглЗаданиеПоПараметру(РегламентноеЗадание);*/
		}

		public void УстановитьПараметрыРегламентногоЗадания(/*РеквизитЗадания, ПараметрЗадания, КлючРегламентногоЗадания = "", Постфикс = ""*/)
		{
			if(true/*ПараметрЗадания = Неопределено*/)
			{
				/*РеквизитЗадания = "";*/
			}
		}

		public void УстановитьЗначенияПеременныхРегламентныхНастроек(/**/)
		{
			if(true/*мРегламентноеЗадание = Неопределено*/)
			{
				/*мРегламентноеЗадание = НайтиРегламентноеЗаданиеПоНастройке();*/
			}
		}
		//Функция определяет есть ли для данной настройки Автоматический обмен данными

		public object ЭтоНастройкаАвтоматическогоОбменаДанными(/**/)
		{
		}
		//Функция по настройке определяет нужно ли для нее периодически определять необходимость обмена данными

		public object ОпределитьНеобходимостьПериодическогоОпределенияВыполненияОбменаДанными(/**/)
		{
			/*НужноПериодическиПроверятьНеобходимостьОбмена = Не ПустаяСтрока(КаталогПроверкиДоступности)
		ИЛИ НЕ ПустаяСтрока(ВыполнятьОбменПриПоявленииФайла);*/
		}

		public void ПередЗаписью(/*Отказ*/)
		{
			/*// работа с регламентными заданиями
*/
			/*УстановитьЗначенияПеременныхРегламентныхНастроек();*/
			if(true/*ЭтоНастройкаАвтоматическогоОбменаДанными()*/)
			{
				if(true/*НЕ ЗначениеЗаполнено(Ответственный)*/)
				{
					/*ОбщегоНазначения.СообщитьОбОшибке("Не заполнено поле ""Пользователь"". Автоматический обмен по такой настройке невозможен.", Отказ);*/
				}
			}
			/*НужноОтключитьРегЗаданияОбмена =  ПометкаУдаления
		ИЛИ НЕ ИспользоватьРегламентныеЗадания;*/
			if(true/*НужноОтключитьРегЗаданияОбмена*/)
			{
				if(true/*мРегламентноеЗадание <> Неопределено*/)
				{
					/*мРегламентноеЗадание.Использование = Ложь;*/
				}
			}
			/*УстановитьПараметрыРегламентногоЗадания(РегламентноеЗадание, мРегламентноеЗадание);*/
		}

		public void ПриКопировании(/*ОбъектКопирования*/)
		{
			/*РегламентноеЗадание = "";*/
			/*мРегламентноеЗадание = Неопределено;*/
		}

		public void ПередУдалением(/*Отказ*/)
		{
			/*УстановитьЗначенияПеременныхРегламентныхНастроек();*/
			if(true/*мРегламентноеЗадание <> Неопределено*/)
			{
				/*мРегламентноеЗадание.Удалить();*/
			}
		}

		public void ОбработкаЗаполнения(/*Основание*/)
		{
			if(true/*ТипЗнч(Основание) = Тип("СправочникСсылка.НастройкиОбменаДанными")*/)
			{
				/*Наименование = Основание.Наименование;*/
				/*СтрокаТЧ = НастройкиОбмена.Добавить();*/
				/*СтрокаТЧ.НастройкаОбмена = Основание;*/
				/*СтрокаТЧ.ВыполняемоеДействие = Перечисления.ДействиеПриОбмене.ЗагрузкаДанных;*/
				/*СтрокаТЧ = НастройкиОбмена.Добавить();*/
				/*СтрокаТЧ.НастройкаОбмена = Основание;*/
				/*СтрокаТЧ.ВыполняемоеДействие = Перечисления.ДействиеПриОбмене.ВыгрузкаДанных;*/
			}
		}
	}
}
