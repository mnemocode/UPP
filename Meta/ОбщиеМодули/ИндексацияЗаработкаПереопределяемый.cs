﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ИндексацияЗаработкаПереопределяемый
	{
		// Процедура устанавливыет нужную страницу панели ПанельВыбораИндексирования обработки индексации заработка
		//
		// Параметры
		//  ЭлементыФормы  - Коллекция ллементов формы обработки
		//

		public void УстановитьСтраницуОсновнойПанели(/*ЭлементыФормы*/)
		{
			/*ЭлементыФормы.ПанельВыбораИндексирования.ТекущаяСтраница = ЭлементыФормы.ПанельВыбораИндексирования.Страницы.Страница1;*/
			/*Запрос = Новый Запрос;*/
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	Организации.ПометкаУдаления КАК ПометкаУдаления
	|ИЗ
	|	Справочник.Организации КАК Организации";*/
			/*Выборка = Запрос.Выполнить().Выбрать();*/
			/*ЭлементыФормы.ПанельИсторияОднаОрганизация.Видимость = (Выборка.Количество() = 1);*/
			if(true/*Выборка.Количество() = 1*/)
			{
				/*ЭлементыФормы.Страница1ВыбранноеДействие2.Заголовок = "Отмена последнего повышения окладов";*/
			}
		}
		// УстановитьСтраницуПанельВыбораИндексирования()
		// Функция определяет вид договора сотрудников для индексации окладов
		//

		public object ПолучитьВидДоговораПоДействиюИндексации(/*ФормаОбработки*/)
		{
			return null;
		}
		// ИндексацияЗаработкаПереопределяемый.ПолучитьВидДоговораПоДействиюИндексации()

		public object ПолучитьОписаниеИндексацииДолжностныеОклады(/*ВидДоговора = Неопределено*/)
		{
			/*ТекстЗаголовка = "Повышение должностных окладов сотрудников";*/
			return null;
		}
		// ПолучитьОписаниеИндексацииДолжностныеОклады()

		public object ПолучитьОписаниеИндексацииПоСтрокеИстории(/*ДанныеСтроки*/)
		{
			/*Период = ДанныеСтроки.ДатаПовышения;*/
			/*ТекстСообщения = "На дату: " + Формат(Период, "ДФ=dd.MM.yyyy") + " зарегистрировано повышение:";*/
			if(true/*ДанныеСтроки.ДолжностныеОклады*/)
			{
				/*ТекстСообщения = ТекстСообщения + Символы.ПС + " - должностных окладов";*/
			}
			if(true/*ДанныеСтроки.ШтатноеРасписание*/)
			{
				/*ТекстСообщения = ТекстСообщения + Символы.ПС + " - окладов штатного расписания";*/
			}
			if(true/*ДанныеСтроки.ТарифныеРазряды*/)
			{
				/*ТекстСообщения = ТекстСообщения + Символы.ПС + " - окладов по тарифным разрядам";*/
			}
			return null;
		}
		// ПолучитьОписаниеИндексацииПоСтрокеИстории()

		public void УстановитьКолонкиТаблицыШтатноеРасписание(/*ЭлементыФормыШтатноеРасписание*/)
		{
			/*ЭлементыФормыШтатноеРасписание.Колонки.МесячнаяСтавка1.ТекстШапки = "Минимальная тарифная ставка";*/
			/*ЭлементыФормыШтатноеРасписание.Колонки.МесячнаяСтавка2.ТекстШапки = "Максимальная тарифная ставка";*/
			/*ЭлементыФормыШтатноеРасписание.Колонки.НоваяМесячнаяСтавка1.ТекстШапки = "Новая минимальная тарифная ставка";*/
			/*ЭлементыФормыШтатноеРасписание.Колонки.НоваяМесячнаяСтавка2.ТекстШапки = "Новая максимальная тарифная ставка";*/
		}

		public void ОформитьТабличноеПолеДопТарифныеРазряды(/*ТабличноеПолеДопТарифныеРазряды*/)
		{
			/*//
*/
		}
		// ОформитьТабличноеПолеДопТарифныеРазряды()

		public object ОписаниеДопРазряда(/**/)
		{
			return null;
		}
		// ОписаниеДопРазряда()
		//////////////////////////////////////////////////////////
		// Штатное расписание

		public object ПолучитьТекстЗапросаДляШтатногоРасписания(/**/)
		{
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	ШтатноеРасписаниеСрезПоследних.Период,
	|	ШтатноеРасписаниеСрезПоследних.ПодразделениеОрганизации КАК ПодразделениеОрганизации,
	|	ШтатноеРасписаниеСрезПоследних.Должность,
	|	ШтатноеРасписаниеСрезПоследних.КоличествоСтавок,
	|	ШтатноеРасписаниеСрезПоследних.ВидТарифнойСтавки,
	|	ШтатноеРасписаниеСрезПоследних.ГрафикРаботы,
	|	ШтатноеРасписаниеСрезПоследних.ВалютаТарифнойСтавки,
	|	ШтатноеРасписаниеСрезПоследних.ОсобыеУсловияТруда,
	|	ШтатноеРасписаниеСрезПоследних.МинимальнаяТарифнаяСтавка КАК МесячнаяСтавка1,
	|	0 КАК НоваяМесячнаяСтавка1,
	|	ШтатноеРасписаниеСрезПоследних.МаксимальнаяТарифнаяСтавка КАК МесячнаяСтавка2,
	|	0 КАК НоваяМесячнаяСтавка2,
	|	ВЫБОР
	|		КОГДА ШтатноеРасписаниеСрезПоследних.Период = &ДатаПовышения
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ЕстьОшибки,
	|	ШтатноеРасписаниеСрезПоследних.ПодразделениеОрганизации.Наименование КАК ПодразделениеОрганизацииНаименование,
	|	ШтатноеРасписаниеСрезПоследних.Должность.Наименование КАК ДолжностьНаименование
	|ИЗ
	|	РегистрСведений.ШтатноеРасписаниеОрганизаций.СрезПоследних(&ДатаПовышения, ПодразделениеОрганизации.Владелец = &Организация) КАК ШтатноеРасписаниеСрезПоследних
	|
	|УПОРЯДОЧИТЬ ПО
	|	ПодразделениеОрганизацииНаименование,
	|	ДолжностьНаименование";*/
			return null;
		}
		// ПолучитьТекстЗапросаДляШтатногоРасписания()

		public object ПолучитьТекстЗапросаДляСравненияШтатногоРасписания(/**/)
		{
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	ШтатноеРасписаниеСрезПоследних.Период,
	|	ШтатноеРасписаниеСрезПоследних.ПодразделениеОрганизации КАК ПодразделениеОрганизации,
	|	ШтатноеРасписаниеСрезПоследних.Должность КАК Должность,
	|	ВЫБОР
	|		КОГДА (НЕ ШтатноеРасписаниеНовое.Период ЕСТЬ NULL )
	|			ТОГДА ШтатноеРасписаниеНовое.НоваяМесячнаяСтавка1
	|		ИНАЧЕ ШтатноеРасписаниеСрезПоследних.МинимальнаяТарифнаяСтавка
	|	КОНЕЦ КАК МесячнаяСтавка1,
	|	ВЫБОР
	|		КОГДА (НЕ ШтатноеРасписаниеНовое.Период ЕСТЬ NULL )
	|			ТОГДА ШтатноеРасписаниеНовое.НоваяМесячнаяСтавка2
	|		ИНАЧЕ ШтатноеРасписаниеСрезПоследних.МаксимальнаяТарифнаяСтавка
	|	КОНЕЦ КАК МесячнаяСтавка2,
	|	ИСТИНА КАК УчитыватьСтавку2
	|ПОМЕСТИТЬ ВТШтатноеРасписание
	|ИЗ
	|	РегистрСведений.ШтатноеРасписаниеОрганизаций.СрезПоследних(&ДатаПовышения, ПодразделениеОрганизации.Владелец = &Организация) КАК ШтатноеРасписаниеСрезПоследних
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТШтатноеРасписаниеНовое КАК ШтатноеРасписаниеНовое
	|		ПО ШтатноеРасписаниеСрезПоследних.ПодразделениеОрганизации = ШтатноеРасписаниеНовое.ПодразделениеОрганизации
	|			И ШтатноеРасписаниеСрезПоследних.Должность = ШтатноеРасписаниеНовое.Должность";*/
			return null;
		}
		// ПолучитьТекстЗапросаДляСравненияШтатногоРасписания()

		public object ПолучитьТекстЗапросаДляИсторииШтатногоРасписания(/**/)
		{
			/*ТекстЗапроса =
	"ВЫБРАТЬ
	|	ШтатноеРасписаниеОрганизаций.Период КАК Период,
	|	ШтатноеРасписаниеОрганизаций.ПодразделениеОрганизации КАК ПодразделениеОрганизации,
	|	ШтатноеРасписаниеОрганизаций.Должность КАК Должность,
	|	ШтатноеРасписаниеОрганизаций.МинимальнаяТарифнаяСтавка КАК МесячнаяСтавка1,
	|	ШтатноеРасписаниеОрганизаций.МаксимальнаяТарифнаяСтавка КАК МесячнаяСтавка2
	|ПОМЕСТИТЬ ВТШтатноеРасписание
	|ИЗ
	|	РегистрСведений.ШтатноеРасписаниеОрганизаций КАК ШтатноеРасписаниеОрганизаций
	|ГДЕ
	|	ШтатноеРасписаниеОрганизаций.ПодразделениеОрганизации.Владелец = &Организация
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ПодразделениеОрганизации,
	|	Должность";*/
			return null;
		}
		// ПолучитьТекстЗапросаДляИсторииШтатногоРасписания()

		public object ПолучитьТаблицуДляЗаписиШтаногоРасписания(/*ОбработкаОбъект*/)
		{
			/*ТаблицаШтатногоРасписания = ОбработкаОбъект.ШтатноеРасписание.Выгрузить();*/
			/*ТаблицаШтатногоРасписания.Колонки.НоваяМесячнаяСтавка1.Имя = "МинимальнаяТарифнаяСтавка";*/
			/*ТаблицаШтатногоРасписания.Колонки.НоваяМесячнаяСтавка2.Имя = "МаксимальнаяТарифнаяСтавка";*/
			return null;
		}
		// ПолучитьТаблицуДляЗаписиШтаногоРасписания()
		//////////////////////////////////////////////////////////
		// Тарифные и пр. разряды

		public object ПолучитьТекстЗапросаДляТарифныхРазрядов(/**/)
		{
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	РазмерТарифныхСтавокСрезПоследних.ТарифныйРазряд,
	|	РазмерТарифныхСтавокСрезПоследних.Размер,
	|	РазмерТарифныхСтавокСрезПоследних.Валюта,
	|	ВЫБОР
	|		КОГДА РазмерТарифныхСтавокСрезПоследних.Период = &ДатаПовышения
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ЕстьОшибки,
	|	0 КАК НовыйРазмер,
	|	РазмерТарифныхСтавокСрезПоследних.ТарифныйРазряд.Наименование КАК ТарифныйРазрядНаименование
	|ИЗ
	|	РегистрСведений.РазмерТарифныхСтавок.СрезПоследних(&ДатаПовышения, ) КАК РазмерТарифныхСтавокСрезПоследних
	|
	|УПОРЯДОЧИТЬ ПО
	|	ТарифныйРазрядНаименование";*/
			return null;
		}
		// ПолучитьТекстЗапросаДляШтатногоРасписания()

		public object ПолучитьТаблицуИсторииДопТарифныхРазрядов(/*ДатаПовышения = Неопределено, Период = Неопределено, ВернутьСписокТарифныхРазрядов = Ложь*/)
		{
			return null;
		}
		// ПолучитьТаблицуИсторииДопТарифныхРазрядов()

		public object ПолучитьТекстЗапросаКоличествоПовышенийТарифнойСетки(/**/)
		{
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	КОЛИЧЕСТВО(РазмерТарифныхСтавок.Период) КАК Количество
	|ПОМЕСТИТЬ ВТКоличествоТарифныхСтавок
	|ИЗ
	|	РегистрСведений.РазмерТарифныхСтавок.СрезПоследних(&ДатаПовышения, ) КАК РазмерТарифныхСтавок
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ПериодыТарифныхРазрядов.Период,
	|	КОЛИЧЕСТВО(ПериодыТарифныхРазрядов.ТарифныйРазряд) КАК Количество
	|ПОМЕСТИТЬ ВТПериодыПовышения
	|ИЗ
	|	ВТПериодыТарифныхРазрядов КАК ПериодыТарифныхРазрядов
	|
	|СГРУППИРОВАТЬ ПО
	|	ПериодыТарифныхРазрядов.Период
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ВТПериодыПовышения.Период КАК ДатаПовышения
	|ИЗ
	|	ВТПериодыПовышения КАК ВТПериодыПовышения
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТКоличествоТарифныхСтавок КАК КоличествоТарифныхСтавок
	|		ПО (ИСТИНА)
	|ГДЕ
	|	ВТПериодыПовышения.Количество >= КоличествоТарифныхСтавок.Количество / 2";*/
			return null;
		}
		// ПолучитьТекстЗапросаКоличествоПовышенийТарифнойСетки()

		public object ПолучитьПолеВладелецЗапросаПериодыТарифныхРазрядов(/**/)
		{
			return null;
		}
		// ПолучитьПолеВладелецЗапросаПериодыТарифныхРазрядов()

		public object ПолучитьУсловиеЗапросаПериодыТарифныхРазрядов(/**/)
		{
			return null;
		}
		// ПолучитьУсловиеЗапросаПериодыТарифныхРазрядов()

		public object ПолучитьТекстЗапросаДляДопТарифныхРазрядов(/**/)
		{
			return null;
		}

		public object ЗарегистрироватьИзмененияДопТарифныхРазрядов(/*ДопТарифныеРазряды, ДатаПовышения*/)
		{
			return null;
		}
		// ЗарегистрироватьИзмененияДопТарифныхРазрядов()

		public object ОтменитьПовышениеДопТарифныхРазрядов(/*ДатаОтмены*/)
		{
			return null;
		}
	}
}

