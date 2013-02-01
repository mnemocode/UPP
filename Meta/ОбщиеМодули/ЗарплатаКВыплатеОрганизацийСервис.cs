﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ЗарплатаКВыплатеОрганизацийСервис
	{
		///////////////////////////////////////////////////////////////
		/// Методы для создания зарплаты к выплате

		public void СоздатьНаОсновании(/*ФормаВладелец, Основание, ПредварительныйУчетУдержаний = Неопределено*/)
		{
			if(true/*Основание = Неопределено*/)
			{
			}
			if(true/*НЕ Основание.Ссылка.Проведен*/)
			{
				/*Предупреждение("Создавать документы на выплату зарплаты можно только по проведенному документу!");*/
			}
			if(true/*ПравоДоступа("Добавление", Метаданные.Документы.ЗарплатаКВыплатеОрганизаций)*/)
			{
				/*ЗарплатаКВыплатеОрганизацийПереопределяемый.СоздатьПоОснованию(ФормаВладелец, Основание, ПредварительныйУчетУдержаний);*/
			}
		}
		///////////////////////////////////////////////////////////////
		/// Методы для представления зарплаты к выплате

		public object ХарактерВыплатыВРодительномПадеже(/*ХарактерВыплаты*/)
		{
			/*ХарактерВыплатыВРодительномПадежеДополнительно = ЗарплатаКВыплатеОрганизацийПереопределяемый.ХарактерВыплатыВРодительномПадежеДополнительно(ХарактерВыплаты);*/
			if(true/*ХарактерВыплатыВРодительномПадежеДополнительно <> Неопределено*/)
			{
			}
			return null;
		}

		public object ПолучитьПредставлениеНастройкиРасчета(/*Документ*/)
		{
			/*// Проконтролируем сомнительные настройки
*/
			if(true/*НЕ ЗначениеЗаполнено(Документ.ПроцентВыплаты) ИЛИ Документ.ПроцентВыплаты < 0*/)
			{
				/*ТекстОшибки = "ПроцентВыплаты "+ Документ.ПроцентВыплаты +"% ?";*/
			}
			if(true/*ЗначениеЗаполнено(ТекстОшибки)*/)
			{
				/*ПредставлениеНастройки = 
			"ВНИМАНИЕ! Установлены сомнительные настройки расчета: " + 
			ТекстОшибки +
			" Проверьте настройки расчета.";*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////
		/// Методы для работы с настройками расчета

		public object ИмяСтраницыНастройкиРасчета(/*ХарактерВыплаты*/)
		{
			/*ИмяСтраницыДополнительно = ЗарплатаКВыплатеОрганизацийПереопределяемый.ИмяСтраницыНастройкиРасчетаДополнительно(ХарактерВыплаты);*/
			if(true/*ИмяСтраницыДополнительно <> Неопределено*/)
			{
				/*ИмяСтраницы = ИмяСтраницыДополнительно;*/
			}
			return null;
		}

		public void СохранитьНастройки(/*Документ*/)
		{
			/*НастройкиРасчета = СоздатьНастройки(Документ);*/
			/*СохранитьЗначение("ЗарплатаКВыплатеОрганизаций_" + Документ.ХарактерВыплаты, НастройкиРасчета);*/
		}

		public void ЗаполнитьПоНастройкам(/*Документ*/)
		{
			if(true/*НЕ ЗначениеЗаполнено(ИмяСтраницыНастройкиРасчета(Документ.ХарактерВыплаты))*/)
			{
				/*НастройкиРасчета = СоздатьНастройки();*/
			}
			/*ЗаполнитьЗначенияСвойств(Документ, НастройкиРасчета);*/
		}

		public object СоздатьНастройки(/*Документ = Неопределено*/)
		{
			/*НастройкиРасчета = 
		Новый Структура(
			"ПроцентВыплаты,
			 |ПредварительныйУчетУдержаний,
			 |Округление",
			 100,
			 Ложь,
			 Перечисления.СпособыОкругленияЗарплатыКВыплате.ПустаяСсылка());*/
			if(true/*Документ <> Неопределено*/)
			{
				if(true/*ЗначениеЗаполнено(Документ.ПроцентВыплаты)*/)
				{
					/*НастройкиРасчета.ПроцентВыплаты = Документ.ПроцентВыплаты;*/
				}
				if(true/*ЗначениеЗаполнено(Документ.ПредварительныйУчетУдержаний)*/)
				{
					/*НастройкиРасчета.ПредварительныйУчетУдержаний = Документ.ПредварительныйУчетУдержаний;*/
				}
				if(true/*ЗначениеЗаполнено(Документ.Округление)*/)
				{
					/*НастройкиРасчета.Округление = Документ.Округление;*/
				}
			}
			return null;
		}
		///////////////////////////////////////////////////////////////
		/// Методы для расчета зарплаты к выплате
		// Функция осуществляет формирование таблицы значений с коэффициентами плановых удержаний физлиц
		//
		// Параметр:
		//   Документ - документ "Зарплата к выплате организаций"
		//

		public object ПолучитьКоэффициентыПлановыхУдержаний(/*ФизЛица, ПериодРегистрации, Организация*/)
		{
			/*Запрос = Новый Запрос();*/
			/*Запрос.УстановитьПараметр("Период",				НачалоМесяца(ПериодРегистрации));*/
			/*Запрос.УстановитьПараметр("ФизЛица", 			ФизЛица);*/
			/*Запрос.УстановитьПараметр("ГоловнаяОрганизация",ОбщегоНазначения.ГоловнаяОрганизация(Организация));*/
			/*МассивСпособовРасчета = Новый Массив;*/
			/*МассивСпособовРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ИсполнительныйЛистПроцентом);*/
			/*МассивСпособовРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ИсполнительныйЛистПроцентомДоПредела);*/
			/*МассивСпособовРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.Процентом);*/
			/*МассивСпособовРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПочтовыйСбор);*/
			/*МассивСпособовРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.ПроцентомОтОблагаемыхЕСННачислений);*/
			/*МассивСпособовРасчета.Добавить(Перечисления.СпособыРасчетаОплатыТруда.БанковскиеИздержки);*/
			/*Запрос.УстановитьПараметр("УдержанияПроцентом",	МассивСпособовРасчета);*/
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	ПлановыеУдержанияРаботниковОрганизацийСрезПоследних.ФизЛицо КАК ФизЛицо,
	|	СУММА(ВЫБОР
	|			КОГДА ПлановыеУдержанияРаботниковОрганизацийСрезПоследних.ПериодЗавершения <= &Период
	|					И ПлановыеУдержанияРаботниковОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|				ТОГДА ПлановыеУдержанияРаботниковОрганизацийСрезПоследних.Показатель1Завершения
	|			ИНАЧЕ ПлановыеУдержанияРаботниковОрганизацийСрезПоследних.Показатель1
	|		КОНЕЦ) КАК Процент
	|ИЗ
	|	РегистрСведений.ПлановыеУдержанияРаботниковОрганизаций.СрезПоследних(
	|			&Период,
	|			Организация = &ГоловнаяОрганизация
	|				И ВидРасчета.СпособРасчета В (&УдержанияПроцентом)
	|				И Физлицо В (&ФизЛица)) КАК ПлановыеУдержанияРаботниковОрганизацийСрезПоследних
	|
	|СГРУППИРОВАТЬ ПО
	|	ПлановыеУдержанияРаботниковОрганизацийСрезПоследних.ФизЛицо";*/
			return null;
		}
		// ПлановыеУдержания
		// Функция осуществляет формирование таблицы значений с коэффициентами НДФЛ физлиц
		//
		// Параметр:
		//   Документ - документ "Зарплата к выплате организаций"
		//

		public object ПолучитьКоэффициентыНДФЛ(/*ФизЛица, ПериодРегистрации*/)
		{
			/*Запрос = Новый Запрос();*/
			/*Запрос.УстановитьПараметр("Период",	КонецМесяца(ПериодРегистрации));*/
			/*Запрос.УстановитьПараметр("ФизЛица",ФизЛица);*/
			/*Запрос.Текст = 
	"ВЫБРАТЬ
	|	ФизическиеЛица.Ссылка КАК ФизЛицо,
	|	ВЫБОР
	|		КОГДА СтатусФизЛиц.Статус = ЗНАЧЕНИЕ(Перечисление.СтатусыНалогоплательщиковПоНДФЛ.НеРезидент)
	|			ТОГДА 30
	|		ИНАЧЕ 13
	|	КОНЕЦ КАК Ставка
	|ИЗ
	|	Справочник.ФизическиеЛица КАК ФизическиеЛица
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СтатусФизЛицКакНалогоплательщиковНДФЛ.СрезПоследних(&Период, Физлицо В (&ФизЛица)) КАК СтатусФизЛиц
	|		ПО ФизическиеЛица.Ссылка = СтатусФизЛиц.ФизЛицо
	|ГДЕ
	|	ФизическиеЛица.Ссылка В(&ФизЛица)";*/
			return null;
		}
		// Гражданство
		// Рассчитывает "усредненную" 1/300 часть ставки рефинансирования ЦБ
		//
		// Параметры
		//  нет
		//
		// Возвращаемое значение:
		//   число - коэффициент, на который следует умножать сумму выплаты
		//

		public object ОпределитьПроцентКомпенсации(/*ДатаДокумента, ДнейНеВыплаты*/)
		{
			if(true/*ДнейНеВыплаты = 0*/)
			{
			}
			/*Запрос = Новый Запрос;*/
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	ЕСТЬNULL(СУММА((РАЗНОСТЬДАТ(ПериодыИзмененияСтавки.ДатаC, ПериодыИзмененияСтавки.ДатаПо, ДЕНЬ) + 1) * ПериодыИзмененияСтавки.Размер / 300 / 100), 0) КАК ПроцентКомпенсации
	|ИЗ
	|	(ВЫБРАТЬ
	|		ВЫБОР
	|			КОГДА СтавкаРефинансированияЦБ.Период >= &ПервыйДеньЗадержки
	|				ТОГДА СтавкаРефинансированияЦБ.Период
	|			ИНАЧЕ &ПервыйДеньЗадержки
	|		КОНЕЦ КАК ДатаC,
	|		ЕСТЬNULL(ВЫБОР
	|				КОГДА МИНИМУМ(СледующаяДата.Период) > &ДеньВыплаты
	|					ТОГДА &ДеньВыплаты
	|				ИНАЧЕ МИНИМУМ(ДОБАВИТЬКДАТЕ(СледующаяДата.Период, ДЕНЬ, -1))
	|			КОНЕЦ, &ДеньВыплаты) КАК ДатаПо,
	|		СтавкаРефинансированияЦБ.Размер КАК Размер
	|	ИЗ
	|		РегистрСведений.СтавкаРефинансированияЦБ КАК СтавкаРефинансированияЦБ
	|			ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.СтавкаРефинансированияЦБ КАК СледующаяДата
	|			ПО СтавкаРефинансированияЦБ.Период < СледующаяДата.Период
	|	ГДЕ
	|		СтавкаРефинансированияЦБ.Период <= &ДеньВыплаты
	|	
	|	СГРУППИРОВАТЬ ПО
	|		СтавкаРефинансированияЦБ.Размер,
	|		СтавкаРефинансированияЦБ.Период
	|	
	|	ИМЕЮЩИЕ
	|		ЕСТЬNULL(ВЫБОР
	|				КОГДА МИНИМУМ(СледующаяДата.Период) > &ДеньВыплаты
	|					ТОГДА &ДеньВыплаты
	|				ИНАЧЕ МИНИМУМ(ДОБАВИТЬКДАТЕ(СледующаяДата.Период, ДЕНЬ, -1))
	|			КОНЕЦ, &ДеньВыплаты) >= &ПервыйДеньЗадержки) КАК ПериодыИзмененияСтавки";*/
			/*Запрос.УстановитьПараметр("ДеньВыплаты", ДатаДокумента);*/
			/*Запрос.УстановитьПараметр("ПервыйДеньЗадержки", ДатаДокумента - 86400 * (ДнейНеВыплаты - 1));*/
			/*Запрос.Текст = ТекстЗапроса;*/
			return null;
		}
		// РассчитатьПроцентКомпенсации()

		public object СпособОкругленияТочность(/*СпособОкругления*/)
		{
			if(true/*СпособОкругления = Перечисления.СпособыОкругленияЗарплатыКВыплате.ПятьКоп*/)
			{
			}
			return null;
		}
		///////////////////////////////////////////////////////////////
		/// Методы для проведения зарплаты к выплате

		public void ПровестиПоХарактеруВыплаты(/*Документ*/)
		{
			/*ХарактерВыплаты = Документ.ХарактерВыплаты;*/
			if(true/*ХарактерВыплаты = Перечисления.ХарактерВыплатыЗарплаты.ПлановыйАванс*/)
			{
				/*ЗарплатаКВыплатеОрганизацийПереопределяемый.ПровестиПлановыйАванс(Документ);*/
			}
		}

		public object ХарактерВыплатыОтложенного(/*ХарактерВыплаты*/)
		{
			/*ХарактерВыплатыДополнительно = ЗарплатаКВыплатеОрганизацийПереопределяемый.ХарактерВыплатыОтложенногоДополнительно(ХарактерВыплаты);*/
			if(true/*ХарактерВыплатыДополнительно <> Неопределено*/)
			{
				/*ХарактерВыплатыОтложенного = ХарактерВыплатыДополнительно;*/
			}
			return null;
		}
		//////////////////////////////////////////////////////////////////
		/// Методы для заполнения зарплаты к выплате по характеру выплаты
		// ПолучитьЗарплатуПоХарактеруВыплаты
		// по переданному объекту и списку физлиц возвращает таблицу значений для заполнения документа ЗарплатаКВыплатеОрганизаций
		// Параметры:
		//	Документ - документ-объект ЗарплатаКВыплатеОрганизаций
		//	ФизЛица - список физлиц по которым необходимо получить данные о зарплате
		// Возвращаемое значение:
		//	Таблица значений

		public object ПолучитьЗарплатуПоХарактеруВыплаты(/*Документ, ФизЛица = Неопределено*/)
		{
			/*ХарактерВыплаты 	= Документ.ХарактерВыплаты;*/
			/*Организация			= Документ.Организация;*/
			/*Подразделение		= Документ.ПодразделениеОрганизации;*/
			/*ПериодРегистрации	= НачалоМесяца(Документ.ПериодРегистрации);*/
			/*ДатаКадровая 	= КонецМесяца(ПериодРегистрации);*/
			/*// зарплата за первую половину месяца ("аванс")
*/
			if(true/*ХарактерВыплаты = Перечисления.ХарактерВыплатыЗарплаты.АвансЗаПервуюПоловинуМесяца*/)
			{
				if(true/*ЗначениеЗаполнено(Подразделение)*/)
				{
					/*ДатаКадровая = КонецДня(ПериодРегистрации + (Цел(День(КонецМесяца(ПериодРегистрации)) / 2) - 1) * 86400);*/
					/*ФизЛица = ПолучитьФизлицаРаботниковПодразделенияНаДатуБезУволенных(Организация, Подразделение, ДатаКадровая, ФизЛица);*/
				}
				/*ЗарплатаПоХарактеруВыплаты = 
			ЗарплатаКВыплатеОрганизацийПереопределяемый.ПолучитьОстаткиЗарплатыЗаПервуюПоловинуМесяца(Документ, ФизЛица);*/
			}
			return null;
		}

		public object ПолучитьФизлицаСотрудниковПодразделенияНаДату(/*Организация, ПодразделениеОрганизации = Неопределено, Дата, ФизЛица = Неопределено*/)
		{
			/*Запрос = Новый Запрос();*/
			/*Запрос.УстановитьПараметр("Организация",		Организация);*/
			/*Запрос.УстановитьПараметр("ГоловнаяОрганизация",		ОбщегоНазначения.ГоловнаяОрганизация(Организация));*/
			/*Запрос.УстановитьПараметр("ПодразделениеОрганизации",	ПодразделениеОрганизации);*/
			/*Запрос.УстановитьПараметр("Дата",						Дата);*/
			/*Запрос.УстановитьПараметр("ПоВсемФизлицам", Физлица = Неопределено);*/
			/*Запрос.УстановитьПараметр("Физлица", Физлица);*/
			/*Запрос.Текст = 
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	РаботникиОрганизацийСрезПоследних.Сотрудник.Физлицо КАК Физлицо,
	|	ВЫБОР
	|		КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
	|				И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|			ТОГДА РаботникиОрганизацийСрезПоследних.ПодразделениеОрганизацииЗавершения
	|		ИНАЧЕ РаботникиОрганизацийСрезПоследних.ПодразделениеОрганизации
	|	КОНЕЦ КАК Подразделение,
	|	ВЫБОР
	|		КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
	|				И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1)
	|			ТОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения
	|		ИНАЧЕ РаботникиОрганизацийСрезПоследних.Период
	|	КОНЕЦ КАК Период,
	|	ВЫБОР
	|		КОГДА ВЫБОР
	|				КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
	|						И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
	|					ТОГДА РаботникиОрганизацийСрезПоследних.ПричинаИзмененияСостоянияЗавершения
	|				ИНАЧЕ РаботникиОрганизацийСрезПоследних.ПричинаИзмененияСостояния
	|			КОНЕЦ <> ЗНАЧЕНИЕ(Перечисление.ПричиныИзмененияСостояния.Увольнение)
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК Работает
	|ПОМЕСТИТЬ ВТПодразделенияФизлицШтат
	|ИЗ
	|	РегистрСведений.РаботникиОрганизаций.СрезПоследних(
	|			&Дата,
	|			Сотрудник.ВидЗанятости <> ЗНАЧЕНИЕ(Перечисление.ВидыЗанятостиВОрганизации.ВнутреннееСовместительство)
	|				И Организация = &ГоловнаяОрганизация
	|				И (&ПоВсемФизлицам
	|					ИЛИ Сотрудник.Физлицо В (&Физлица))) КАК РаботникиОрганизацийСрезПоследних
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Физлицо
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ПодразделенияФизлиц.Физлицо КАК ФизЛицо,
	|	ПодразделенияФизлиц.Подразделение КАК Подразделение,
	|	ПодразделенияФизлиц.Работает КАК Работает,
	|	ДействующиеПериодыФизЛиц.Период КАК ДатаАктуальности
	|ПОМЕСТИТЬ ВТАктуальныеПодразделенияФизлицШтат
	|ИЗ
	|	ВТПодразделенияФизлицШтат КАК ПодразделенияФизлиц
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|			ПодразделенияФизлиц.Физлицо КАК Физлицо,
	|			МАКСИМУМ(ПодразделенияФизлиц.Период) КАК Период
	|		ИЗ
	|			ВТПодразделенияФизлицШтат КАК ПодразделенияФизлиц
	|		
	|		СГРУППИРОВАТЬ ПО
	|			ПодразделенияФизлиц.Физлицо) КАК ДействующиеПериодыФизЛиц
	|		ПО (ДействующиеПериодыФизЛиц.Физлицо = ПодразделенияФизлиц.Физлицо)
	|			И (ДействующиеПериодыФизЛиц.Период = ПодразделенияФизлиц.Период)
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ФизЛицо
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ДоговорНаВыполнениеРаботСФизЛицом.Сотрудник.Физлицо КАК Физлицо,
	|	ДоговорНаВыполнениеРаботСФизЛицом.ПодразделениеОрганизации КАК Подразделение,
	|	НАЧАЛОПЕРИОДА(ДоговорНаВыполнениеРаботСФизЛицом.ДатаНачала, ДЕНЬ) КАК ДатаНачала,
	|	КОНЕЦПЕРИОДА(ДоговорНаВыполнениеРаботСФизЛицом.ДатаОкончания, ДЕНЬ) КАК ДатаОкончания,
	|	ВЫБОР
	|		КОГДА КОНЕЦПЕРИОДА(ДоговорНаВыполнениеРаботСФизЛицом.ДатаОкончания, ДЕНЬ) >= &Дата
	|			ТОГДА ИСТИНА
	|		ИНАЧЕ ЛОЖЬ
	|	КОНЕЦ КАК ДоговорДействует
	|ПОМЕСТИТЬ ВТПодразделенияФизлицГПХ
	|ИЗ
	|	Документ.ДоговорНаВыполнениеРаботСФизЛицом КАК ДоговорНаВыполнениеРаботСФизЛицом
	|ГДЕ
	|	ДоговорНаВыполнениеРаботСФизЛицом.ДатаНачала <= &Дата
	|	И ДоговорНаВыполнениеРаботСФизЛицом.Проведен
	|	И ДоговорНаВыполнениеРаботСФизЛицом.Организация = &Организация
	|	И (&ПоВсемФизлицам
	|			ИЛИ ДоговорНаВыполнениеРаботСФизЛицом.Сотрудник.Физлицо В (&Физлица))
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	Физлицо
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ПодразделенияФизлицГПХ.Физлицо КАК ФизЛицо,
	|	МАКСИМУМ(ПодразделенияФизлицГПХ.Подразделение) КАК Подразделение,
	|	ПодразделенияФизлицГПХ.ДатаНачала КАК ДатаАктуальности
	|ПОМЕСТИТЬ ВТПодразделенияФизлицДействующихДоговоров
	|ИЗ
	|	ВТПодразделенияФизлицГПХ КАК ПодразделенияФизлицГПХ
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|			ПодразделенияФизлицГПХ.Физлицо КАК Физлицо,
	|			МАКСИМУМ(ПодразделенияФизлицГПХ.ДатаНачала) КАК ДатаНачала
	|		ИЗ
	|			ВТПодразделенияФизлицГПХ КАК ПодразделенияФизлицГПХ
	|		ГДЕ
	|			ПодразделенияФизлицГПХ.ДоговорДействует
	|		
	|		СГРУППИРОВАТЬ ПО
	|			ПодразделенияФизлицГПХ.Физлицо) КАК ПозднейшийДоговор
	|		ПО (ПозднейшийДоговор.Физлицо = ПодразделенияФизлицГПХ.Физлицо)
	|			И (ПозднейшийДоговор.ДатаНачала = ПодразделенияФизлицГПХ.ДатаНачала)
	|ГДЕ
	|	ПодразделенияФизлицГПХ.ДоговорДействует
	|
	|СГРУППИРОВАТЬ ПО
	|	ПодразделенияФизлицГПХ.Физлицо,
	|	ПодразделенияФизлицГПХ.ДатаНачала
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ФизЛицо
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ПодразделенияФизлицГПХ.Физлицо КАК ФизЛицо,
	|	МАКСИМУМ(ПодразделенияФизлицГПХ.Подразделение) КАК Подразделение,
	|	ПодразделенияФизлицГПХ.ДатаОкончания КАК ДатаАктуальности
	|ПОМЕСТИТЬ ВТПодразделенияФизлицЗавершившихсяДоговоров
	|ИЗ
	|	ВТПодразделенияФизлицГПХ КАК ПодразделенияФизлицГПХ
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
	|			ПодразделенияФизлицГПХ.Физлицо КАК Физлицо,
	|			МАКСИМУМ(ПодразделенияФизлицГПХ.ДатаОкончания) КАК ДатаОкончания
	|		ИЗ
	|			ВТПодразделенияФизлицГПХ КАК ПодразделенияФизлицГПХ
	|		ГДЕ
	|			(НЕ ПодразделенияФизлицГПХ.ДоговорДействует)
	|		
	|		СГРУППИРОВАТЬ ПО
	|			ПодразделенияФизлицГПХ.Физлицо) КАК ПозднейшийДоговор
	|		ПО (ПозднейшийДоговор.Физлицо = ПодразделенияФизлицГПХ.Физлицо)
	|			И (ПозднейшийДоговор.ДатаОкончания = ПодразделенияФизлицГПХ.ДатаОкончания)
	|ГДЕ
	|	(НЕ ПодразделенияФизлицГПХ.ДоговорДействует)
	|
	|СГРУППИРОВАТЬ ПО
	|	ПодразделенияФизлицГПХ.Физлицо,
	|	ПодразделенияФизлицГПХ.ДатаОкончания
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	ПодразделенияФизлицДействующихДоговоров.ФизЛицо КАК ФизЛицо,
	|	ПодразделенияФизлицДействующихДоговоров.Подразделение КАК Подразделение,
	|	ПодразделенияФизлицДействующихДоговоров.ДатаАктуальности КАК ДатаАктуальности,
	|	ИСТИНА КАК Работает
	|ПОМЕСТИТЬ ВТАктуальныеПодразделенияФизлицГПХ
	|ИЗ
	|	ВТПодразделенияФизлицДействующихДоговоров КАК ПодразделенияФизлицДействующихДоговоров
	|
	|ОБЪЕДИНИТЬ ВСЕ
	|
	|ВЫБРАТЬ
	|	ПодразделенияФизлицЗавершившихсяДоговоров.ФизЛицо,
	|	ПодразделенияФизлицЗавершившихсяДоговоров.Подразделение,
	|	ПодразделенияФизлицЗавершившихсяДоговоров.ДатаАктуальности,
	|	ЛОЖЬ
	|ИЗ
	|	ВТПодразделенияФизлицЗавершившихсяДоговоров КАК ПодразделенияФизлицЗавершившихсяДоговоров
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТПодразделенияФизлицДействующихДоговоров КАК ПодразделенияФизлицДействующихДоговоров
	|		ПО (ПодразделенияФизлицДействующихДоговоров.ФизЛицо = ПодразделенияФизлицЗавершившихсяДоговоров.ФизЛицо)
	|ГДЕ
	|	ПодразделенияФизлицДействующихДоговоров.ФизЛицо ЕСТЬ NULL 
	|
	|ИНДЕКСИРОВАТЬ ПО
	|	ФизЛицо
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ РАЗРЕШЕННЫЕ РАЗЛИЧНЫЕ
	|	ПодразделенияФизлиц.ФизЛицо КАК ФизЛицо
	|ПОМЕСТИТЬ ВТРаботники
	|ИЗ
	|	ВТАктуальныеПодразделенияФизлицШтат КАК ПодразделенияФизлиц
	|
	|ОБЪЕДИНИТЬ
	|
	|ВЫБРАТЬ
	|	ПодразделенияФизлиц.ФизЛицо
	|ИЗ
	|	ВТАктуальныеПодразделенияФизлицГПХ КАК ПодразделенияФизлиц
	|;
	|
	|////////////////////////////////////////////////////////////////////////////////
	|ВЫБРАТЬ
	|	Работники.ФизЛицо
	|ИЗ
	|	ВТРаботники КАК Работники
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТАктуальныеПодразделенияФизлицШтат КАК ПодразделенияФизлицШтат
	|		ПО (ПодразделенияФизлицШтат.ФизЛицо = Работники.ФизЛицо)
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТАктуальныеПодразделенияФизлицГПХ КАК ПодразделенияФизлицГПХ
	|		ПО (ПодразделенияФизлицГПХ.ФизЛицо = Работники.ФизЛицо)
	|ГДЕ
	|	ВЫБОР
	|			КОГДА ПодразделенияФизлицШтат.Работает ЕСТЬ NULL 
	|					И ПодразделенияФизлицГПХ.Работает ЕСТЬ NULL 
	|				ТОГДА ИСТИНА
	|			ИНАЧЕ ВЫБОР
	|					КОГДА ПодразделенияФизлицШтат.Работает ЕСТЬ NULL 
	|						ТОГДА ПодразделенияФизлицГПХ.Подразделение
	|					КОГДА ПодразделенияФизлицШтат.Работает
	|						ТОГДА ПодразделенияФизлицШтат.Подразделение
	|					КОГДА ПодразделенияФизлицГПХ.Работает
	|						ТОГДА ПодразделенияФизлицГПХ.Подразделение
	|					КОГДА ПодразделенияФизлицШтат.ДатаАктуальности < ПодразделенияФизлицГПХ.ДатаАктуальности
	|						ТОГДА ПодразделенияФизлицГПХ.Подразделение
	|					ИНАЧЕ ПодразделенияФизлицШтат.Подразделение
	|				КОНЕЦ В ИЕРАРХИИ (&ПодразделениеОрганизации)
	|		КОНЕЦ";*/
			return null;
		}

		public object ПолучитьФизлицаРаботниковПодразделенияНаДату(/*Организация, ПодразделениеОрганизации = Неопределено, Дата, ФизЛица = Неопределено*/)
		{
			/*Запрос = Новый Запрос();*/
			/*Запрос.УстановитьПараметр("Дата",						Дата);*/
			/*Запрос.УстановитьПараметр("ГоловнаяОрганизация",		ОбщегоНазначения.ГоловнаяОрганизация(Организация));*/
			/*Запрос.УстановитьПараметр("ПодразделениеОрганизации",	ПодразделениеОрганизации);*/
			/*Запрос.УстановитьПараметр("ПоВсемФизлицам", Физлица = Неопределено);*/
			/*Запрос.УстановитьПараметр("Физлица", Физлица);*/
			/*Запрос.Текст = 
				"ВЫБРАТЬ РАЗРЕШЕННЫЕ
		|	РаботникиОрганизацийСрезПоследних.Сотрудник.Физлицо КАК Физлицо,
		|	ВЫБОР
		|		КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
		|				И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1)
		|			ТОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения
		|		ИНАЧЕ РаботникиОрганизацийСрезПоследних.Период
		|	КОНЕЦ КАК Период,
		|	ВЫБОР
		|		КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
		|				И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
		|			ТОГДА РаботникиОрганизацийСрезПоследних.ПодразделениеОрганизацииЗавершения
		|		ИНАЧЕ РаботникиОрганизацийСрезПоследних.ПодразделениеОрганизации
		|	КОНЕЦ КАК Подразделение
		|ПОМЕСТИТЬ ВТПодразделенияФизлиц
		|ИЗ
		|	РегистрСведений.РаботникиОрганизаций.СрезПоследних(
		|			&Дата,
		|			Сотрудник.ВидЗанятости <> ЗНАЧЕНИЕ(Перечисление.ВидыЗанятостиВОрганизации.ВнутреннееСовместительство)
		|				И Организация = &ГоловнаяОрганизация
		|				И (&ПоВсемФизлицам
		|					ИЛИ Сотрудник.Физлицо В (&Физлица))) КАК РаботникиОрганизацийСрезПоследних
		|
		|ИНДЕКСИРОВАТЬ ПО
		|	Физлицо
		|;
		|
		|////////////////////////////////////////////////////////////////////////////////
		|ВЫБРАТЬ РАЗРЕШЕННЫЕ
		|	ПодразделенияФизлиц.Физлицо
		|ИЗ
		|	ВТПодразделенияФизлиц КАК ПодразделенияФизлиц
		|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ (ВЫБРАТЬ
		|			ПодразделенияФизлиц.Физлицо КАК Физлицо,
		|			МАКСИМУМ(ПодразделенияФизлиц.Период) КАК Период
		|		ИЗ
		|			ВТПодразделенияФизлиц КАК ПодразделенияФизлиц
		|		
		|		СГРУППИРОВАТЬ ПО
		|			ПодразделенияФизлиц.Физлицо) КАК ДействующиеПериодыФизЛиц
		|		ПО (ДействующиеПериодыФизЛиц.Физлицо = ПодразделенияФизлиц.Физлицо)
		|			И (ДействующиеПериодыФизЛиц.Период = ПодразделенияФизлиц.Период)
		|ГДЕ
		|	ПодразделенияФизлиц.Подразделение В ИЕРАРХИИ(&ПодразделениеОрганизации)";*/
			return null;
		}

		public object ПолучитьФизлицаРаботниковПодразделенияНаДатуБезУволенных(/*Организация, ПодразделениеОрганизации = Неопределено, Дата, ФизЛица = Неопределено*/)
		{
			/*Запрос = Новый Запрос();*/
			/*Запрос.УстановитьПараметр("Дата",						Дата);*/
			/*Запрос.УстановитьПараметр("ГоловнаяОрганизация",		ОбщегоНазначения.ГоловнаяОрганизация(Организация));*/
			/*Запрос.УстановитьПараметр("ПодразделениеОрганизации",	ПодразделениеОрганизации);*/
			/*Запрос.УстановитьПараметр("ПоВсемФизлицам", Физлица = Неопределено);*/
			/*Запрос.УстановитьПараметр("Физлица", Физлица);*/
			/*Запрос.Текст = Запрос.Текст + 
		"ВЫБРАТЬ РАЗРЕШЕННЫЕ
		|	РаботникиОрганизацийСрезПоследних.Сотрудник.Физлицо КАК Физлицо
		|ИЗ
		|	РегистрСведений.РаботникиОрганизаций.СрезПоследних(
		|			&Дата,
		|			Сотрудник.ВидЗанятости <> ЗНАЧЕНИЕ(Перечисление.ВидыЗанятостиВОрганизации.ВнутреннееСовместительство)
		|				И Организация = &ГоловнаяОрганизация
		|				И (&ПоВсемФизлицам
		|					ИЛИ Сотрудник.Физлицо В (&Физлица))) КАК РаботникиОрганизацийСрезПоследних
		|ГДЕ
		|	ВЫБОР
		|			КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
		|					И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
		|				ТОГДА РаботникиОрганизацийСрезПоследних.ПричинаИзмененияСостоянияЗавершения
		|			ИНАЧЕ РаботникиОрганизацийСрезПоследних.ПричинаИзмененияСостояния
		|		КОНЕЦ <> ЗНАЧЕНИЕ(Перечисление.ПричиныИзмененияСостояния.Увольнение)
		|	И ВЫБОР
		|			КОГДА РаботникиОрганизацийСрезПоследних.ПериодЗавершения <= &Дата
		|					И РаботникиОрганизацийСрезПоследних.ПериодЗавершения <> ДАТАВРЕМЯ(1, 1, 1, 0, 0, 0)
		|				ТОГДА РаботникиОрганизацийСрезПоследних.ПодразделениеОрганизацииЗавершения
		|			ИНАЧЕ РаботникиОрганизацийСрезПоследних.ПодразделениеОрганизации
		|		КОНЕЦ В ИЕРАРХИИ (&ПодразделениеОрганизации)";*/
			return null;
		}
		////////////////////////////////////////////////////////////////////////
		/// Методы заполнения документа ЗарплатаКВыплатеОрганизаций

		public object ПодготовитьТаблицуЗарплатДляДокумента(/*Документ, ИсходнаяТаблицаЗарплат*/)
		{
			/*ЗаполненныеСтроки = Новый Массив;*/
			/*ТаблицаЗарплат = ИсходнаяТаблицаЗарплат.Скопировать(ЗаполненныеСтроки);*/
			/*ТаблицаЗарплат.Колонки.Добавить("Сумма");*/
			/*ТаблицаЗарплат.Колонки.Добавить("Удержано");*/
			/*ТаблицаЗарплат.Колонки.Добавить("КомпенсацияЗаЗадержкуЗарплаты");*/
			/*Начислено = ТаблицаЗарплат.ВыгрузитьКолонку("Начислено");*/
			/*ТаблицаЗарплат.ЗагрузитьКолонку(Начислено, "Сумма");*/
			/*ТаблицаЗарплат.ЗаполнитьЗначения(0, "Удержано, КомпенсацияЗаЗадержкуЗарплаты");*/
			/*ТаблицаЗарплат.Сортировать("ФизЛицо");*/
			/*ТаблицаЗарплат.Индексы.Добавить("ФизЛицо");*/
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// МЕТОДЫ ПОЛУЧЕНИЯ СОСТОЯНИЯ ДОКУМЕНТОВ
		// Визуализирует состояние документа (проведен, удален, выплачивается)
		//
		// Параметры:
		//	СостояниеДокументов
		//	ОформленияСтрок
		//	ЯчейкаВыплаты
		//
		// Возвращаемое значение:
		//	Таблица значений
		//

		public void ПоказатьСостояние(/*СостояниеДокументов, ОформленияСтрок, ИмяЯчейкиВыплаты = "Выплачивается"*/)
		{
		}
		////////////////////////////////////////////////////////////////////////

		public void ОтобразитьЭУКомпенсацииЗаЗадержкуЗарплаты(/*ПоказыватьКомпенсацию, ЭтаФорма, ДействиеКнопки*/)
		{
			/*ЭтаФорма.ЭлементыФормы.Зарплата.Колонки.КомпенсацияЗаЗадержкуЗарплаты.Видимость = ПоказыватьКомпенсацию;*/
			/*Кнопки = ЭтаФорма.ЭлементыФормы.ДействияФормы.Кнопки.Подменю.Кнопки;*/
			if(true/*ПоказыватьКомпенсацию*/)
			{
				if(true/*Кнопки.Найти("ЗарегистрироватьДоходыПоКомпенсации") = Неопределено*/)
				{
					/*НоваяКнопка = Кнопки.Добавить("РазделительЗарегистрироватьДоходыПоКомпенсации", ТипКнопкиКоманднойПанели.Разделитель);*/
					/*НоваяКнопка = Кнопки.Добавить();*/
					/*НоваяКнопка.ТипКнопки	= ТипКнопкиКоманднойПанели.Действие;*/
					/*НоваяКнопка.Имя			= "ЗарегистрироватьДоходыПоКомпенсации";*/
					/*НоваяКнопка.Подсказка	= "Зарегистрировать доходы по компенсации в учете для целей исчисления страховых взносов";*/
					/*НоваяКнопка.Пояснение	= НоваяКнопка.Подсказка;*/
					/*НоваяКнопка.Текст		= "Зарегистрировать доходы по компенсации";*/
					/*НоваяКнопка.Действие	= ДействиеКнопки;*/
				}
			}
		}
	}
}

