﻿
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	public partial class НастройкиВыполненияОбмена: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника НастройкиВыполненияОбмена. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.НастройкиВыполненияОбмена.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.Следующий(999);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 150);//"Наименование " + НомерЭлемента.ToString();

				Объект.ВыполнятьДействияПодПолнымиПравами = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИспользоватьРегламентныеЗадания = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ДинамическиИзменятьИнтервалМеждуОбменами = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Ответственный = V82.Справочники/*Менеджер*/.Пользователи.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Пользователи();
				Объект.КаждыйЗапускПрограммы = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КаждоеЗавершениеРаботыСПрограммой = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.КаталогПроверкиДоступности = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.ВыполнятьОбменПриПоявленииФайла = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = ГенераторСлучайныхЧисел.Следующий(99999999);
				Объект.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = ГенераторСлучайныхЧисел.Следующий(99999999);
				Объект.УчетнаяЗаписьОтправкиСообщенияОбОшибке = V82.Справочники/*Менеджер*/.УчетныеЗаписиЭлектроннойПочты.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты();
				Объект.АдресДляОтправкиСообщенийОбОшибке = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 100);
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.РегламентноеЗадание = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 40);

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента.ToString() + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиВыполненияОбмена.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника НастройкиВыполненияОбмена. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиВыполненияОбмена.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента.ToString() + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника НастройкиВыполненияОбмена. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиВыполненияОбмена.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента.ToString() + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}
