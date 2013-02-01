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
	///Список настроек закрытия месяца
	///</summary>
	public partial class НастройкиЗакрытияМесяца:СправочникОбъект
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
		public string/*70*/ Наименование;
		public DateTime ДатаНачалаДействияНастройки;//Начало действия
		public bool ОтражатьВУправленческомУчете;//Отражать в управленческом учете
		public bool ОтражатьВБухгалтерскомУчете;//Отражать в бухгалтерском учете
		public bool ОтражатьВНалоговомУчете;//Отражать в налоговом учете
		public decimal/*(1)*/ ВариантНастройки;//Вариант настройки
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
						Insert Into _Reference151(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Description
						,_Fld2685
						,_Fld2686
						,_Fld2687
						,_Fld2688
						,_Fld2689)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Наименование
						,@ДатаНачалаДействияНастройки
						,@ОтражатьВУправленческомУчете
						,@ОтражатьВБухгалтерскомУчете
						,@ОтражатьВНалоговомУчете
						,@ВариантНастройки)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference151
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Description	= @Наименование
						,_Fld2685	= @ДатаНачалаДействияНастройки
						,_Fld2686	= @ОтражатьВУправленческомУчете
						,_Fld2687	= @ОтражатьВБухгалтерскомУчете
						,_Fld2688	= @ОтражатьВНалоговомУчете
						,_Fld2689	= @ВариантНастройки
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ДатаНачалаДействияНастройки", ДатаНачалаДействияНастройки);
					Команда.Parameters.AddWithValue("ОтражатьВУправленческомУчете", ОтражатьВУправленческомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВБухгалтерскомУчете", ОтражатьВБухгалтерскомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("ВариантНастройки", ВариантНастройки);
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
					Команда.CommandText = @"Delete _Reference151
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		//Процедура выполняет первоначальное заполнение настроек
		//- при вводе нового элемента справочника
		//- при изменении варианта настройки

		public void ЗаполнитьСписокРегламентныхОпераций(/*ОбъектКопирования = Неопределено, Использовать = Истина*/)
		{
			/*ТаблицаРеглОпераций = РегламентныеОперации.Выгрузить();*/
			/*ТаблицаРеглОпераций.Очистить();*/
			/*ТаблицаРеглОпераций.Колонки.Добавить("Порядок");*/
			/*ОбрабатываемыеБизнесПроцессы = Новый Массив();*/
			if(true/*БизнесПроцессЗакрытиеМесяца.ИспользоватьБизнесПроцессУСН(,ЭтотОбъект)*/)
			{
				/*ОбрабатываемыеБизнесПроцессы.Добавить("ЗакрытиеМесяцаУСНДоходыМинусРасходы");*/
			}
			/*ТочкиМаршрута = БизнесПроцессЗакрытиеМесяца.ПолучитьТочкиМаршрутаЗакрытияМесяцаИРасчетаНДС(ОбрабатываемыеБизнесПроцессы);*/
			/*Макет = ПолучитьМакет("МакетНастроекПоУмолчанию");*/
			/*ОбластьСписокНастроек = Макет.Области.Найти("Список");*/
			if(true/*ОбластьСписокНастроек <> Неопределено*/)
			{
				/*ОбластьСписокНастроек = Макет.ПолучитьОбласть("Список");*/
				/*ТаблицаРеглОпераций.Сортировать("Порядок");*/
				/*РегламентныеОперации.Очистить();*/
				/*РегламентныеОперации.Загрузить(ТаблицаРеглОпераций);*/
				/*ОтключитьНедоступныеРегламентныеОперации();*/
			}
		}
		//Процедура отключает регламентные операции, которые являются недоступными
		//

		public void ОтключитьНедоступныеРегламентныеОперации(/*МассивНедоступныхРегламентныхОпераций = Неопределено*/)
		{
			if(true/*МассивНедоступныхРегламентныхОпераций = Неопределено*/)
			{
				/*МассивНедоступныхРегламентныхОпераций = БизнесПроцессЗакрытиеМесяца.ЗаполнитьМассивНедоступныхРегламентныхОпераций(?(ЗначениеЗаполнено(ДатаНачалаДействияНастройки),ДатаНачалаДействияНастройки,ТекущаяДата()),,ВариантНастройки);*/
			}
			if(true/*МассивНедоступныхРегламентныхОпераций.Количество() = 0*/)
			{
			}
		}

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка ИЛИ ЭтоГруппа*/)
			{
			}
			if(true/*ДатаНачалаДействияНастройки = Дата('00010101000000')*/)
			{
				/*ОбщегоНазначения.СообщитьОбОшибке("Не указана дата начала действия настройки", Отказ);*/
			}
			if(true/*НЕ (ОтражатьВУправленческомУчете ИЛИ ОтражатьВБухгалтерскомУчете ИЛИ ОтражатьВНалоговомУчете)*/)
			{
				/*ОбщегоНазначения.СообщитьОбОшибке("Не установлены признаки отражения в учете", Отказ);*/
			}
			/*Строка = РегламентныеОперации.Найти(Истина, "Использовать");*/
			if(true/*Строка = Неопределено*/)
			{
				/*ОбщегоНазначения.СообщитьОбОшибке("Не включена ни одна регламентная операция", Отказ);*/
			}
		}
	}
}
