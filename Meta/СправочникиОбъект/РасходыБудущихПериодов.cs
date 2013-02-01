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
	public partial class РасходыБудущихПериодов:СправочникОбъект
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
		public string/*11*/ Код;
		public string/*100*/ Наименование;
		public V82.Перечисления/*Ссылка*/.ВидыРБП ВидРБП;//Вид РБП
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаНачалаСписания;//Дата начала списания
		///<summary>
		///(Общ)
		///</summary>
		public DateTime ДатаОкончанияСписания;//Дата окончания списания
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.НоменклатурныеГруппы НоменклатурнаяГруппа;//Номенклатурная группа
		public V82.СправочникиСсылка.ОбъектыСтроительства ОбъектСтроительства;//Объект строительства
		///<summary>
		///(Упр)
		///</summary>
		public V82.СправочникиСсылка.Подразделения Подразделение;
		///<summary>
		///(Регл)
		///</summary>
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Подразделение организации
		public V82.СправочникиСсылка.Номенклатура Продукция;
		public V82.СправочникиСсылка.СерииНоменклатуры СерияПродукции;//Серия продукции
		///<summary>
		///(Общ)
		///</summary>
		public V82.СправочникиСсылка.СтатьиЗатрат СтатьяЗатрат;//Статья затрат
		///<summary>
		///(Регл)
		///</summary>
		public object СчетБУ;//Счет БУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ1;//Субконто БУ 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ2;//Субконто БУ 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоБУ3;//Субконто БУ 3
		///<summary>
		///(Регл)
		///</summary>
		public object СчетНУ;//Счет НУ
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ1;//Субконто НУ 1
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ2;//Субконто НУ 2
		///<summary>
		///(Регл)
		///</summary>
		public object СубконтоНУ3;//Субконто НУ 3
		///<summary>
		///(Общ)
		///</summary>
		public decimal/*(15.2)*/ Сумма;
		public V82.СправочникиСсылка.ХарактеристикиНоменклатуры ХарактеристикаПродукции;//Характеристика продукции
		public V82.Перечисления/*Ссылка*/.СпособыПризнанияРасходов СпособПризнанияРасходов;//Способ признания расходов
		public V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск СпособРаспределенияЗатратНаВыпуск;//Способ распределения затрат на выпуск
		public V82.Перечисления/*Ссылка*/.СпособыСтроительства СпособСтроительства;//Способ строительства
		public V82.Перечисления/*Ссылка*/.ВидыАктивовДляРБП ВидАктива;//Вид актива
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
						Insert Into _Reference216(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3333RRef
						,_Fld3334
						,_Fld3335
						,_Fld3336RRef
						,_Fld3337RRef
						,_Fld3338RRef
						,_Fld3339RRef
						,_Fld3340RRef
						,_Fld3341RRef
						,_Fld3342RRef
						,_Fld3343RRef
						,_Fld3344RRef
						,_Fld3345RRef
						,_Fld3346RRef
						,_Fld3347RRef
						,_Fld3348RRef
						,_Fld3349RRef
						,_Fld3350RRef
						,_Fld3351
						,_Fld3352RRef
						,_Fld3353RRef
						,_Fld3354RRef
						,_Fld3355RRef
						,_Fld3356RRef)
						Values (
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@ВидРБП
						,@ДатаНачалаСписания
						,@ДатаОкончанияСписания
						,@НоменклатурнаяГруппа
						,@ОбъектСтроительства
						,@Подразделение
						,@ПодразделениеОрганизации
						,@Продукция
						,@СерияПродукции
						,@СтатьяЗатрат
						,@СчетБУ
						,@СубконтоБУ1
						,@СубконтоБУ2
						,@СубконтоБУ3
						,@СчетНУ
						,@СубконтоНУ1
						,@СубконтоНУ2
						,@СубконтоНУ3
						,@Сумма
						,@ХарактеристикаПродукции
						,@СпособПризнанияРасходов
						,@СпособРаспределенияЗатратНаВыпуск
						,@СпособСтроительства
						,@ВидАктива)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference216
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3333RRef	= @ВидРБП
						,_Fld3334	= @ДатаНачалаСписания
						,_Fld3335	= @ДатаОкончанияСписания
						,_Fld3336RRef	= @НоменклатурнаяГруппа
						,_Fld3337RRef	= @ОбъектСтроительства
						,_Fld3338RRef	= @Подразделение
						,_Fld3339RRef	= @ПодразделениеОрганизации
						,_Fld3340RRef	= @Продукция
						,_Fld3341RRef	= @СерияПродукции
						,_Fld3342RRef	= @СтатьяЗатрат
						,_Fld3343RRef	= @СчетБУ
						,_Fld3344RRef	= @СубконтоБУ1
						,_Fld3345RRef	= @СубконтоБУ2
						,_Fld3346RRef	= @СубконтоБУ3
						,_Fld3347RRef	= @СчетНУ
						,_Fld3348RRef	= @СубконтоНУ1
						,_Fld3349RRef	= @СубконтоНУ2
						,_Fld3350RRef	= @СубконтоНУ3
						,_Fld3351	= @Сумма
						,_Fld3352RRef	= @ХарактеристикаПродукции
						,_Fld3353RRef	= @СпособПризнанияРасходов
						,_Fld3354RRef	= @СпособРаспределенияЗатратНаВыпуск
						,_Fld3355RRef	= @СпособСтроительства
						,_Fld3356RRef	= @ВидАктива
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
					Команда.Parameters.AddWithValue("ВидРБП", ВидРБП.Ключ());
					Команда.Parameters.AddWithValue("ДатаНачалаСписания", ДатаНачалаСписания);
					Команда.Parameters.AddWithValue("ДатаОкончанияСписания", ДатаОкончанияСписания);
					Команда.Parameters.AddWithValue("НоменклатурнаяГруппа", НоменклатурнаяГруппа.Ссылка);
					Команда.Parameters.AddWithValue("ОбъектСтроительства", ОбъектСтроительства.Ссылка);
					Команда.Parameters.AddWithValue("Подразделение", Подразделение.Ссылка);
					Команда.Parameters.AddWithValue("ПодразделениеОрганизации", ПодразделениеОрганизации.Ссылка);
					Команда.Parameters.AddWithValue("Продукция", Продукция.Ссылка);
					Команда.Parameters.AddWithValue("СерияПродукции", СерияПродукции.Ссылка);
					Команда.Parameters.AddWithValue("СтатьяЗатрат", СтатьяЗатрат.Ссылка);
					Команда.Parameters.AddWithValue("Сумма", Сумма);
					Команда.Parameters.AddWithValue("ХарактеристикаПродукции", ХарактеристикаПродукции.Ссылка);
					Команда.Parameters.AddWithValue("СпособПризнанияРасходов", СпособПризнанияРасходов.Ключ());
					Команда.Parameters.AddWithValue("СпособРаспределенияЗатратНаВыпуск", СпособРаспределенияЗатратНаВыпуск.Ссылка);
					Команда.Parameters.AddWithValue("СпособСтроительства", СпособСтроительства.Ключ());
					Команда.Parameters.AddWithValue("ВидАктива", ВидАктива.Ключ());
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
					Команда.CommandText = @"Delete _Reference216
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}
