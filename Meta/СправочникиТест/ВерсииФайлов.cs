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
	public partial class ВерсииФайлов: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника ВерсииФайлов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.ВерсииФайлов.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.Следующий(999);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 150);//"Наименование " + НомерЭлемента.ToString();

				Объект.Автор = V82.Справочники/*Менеджер*/.Пользователи.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.Пользователи();
				Объект.ДатаМодификацииУниверсальная = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.ДатаСоздания = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.Зашифрован = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИндексКартинки = ГенераторСлучайныхЧисел.Следующий(99999999);
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.НомерВерсии = ГенераторСлучайныхЧисел.Следующий(9999);
				Объект.ПодписанЭЦП = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ПолноеНаименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 256);
				Объект.ПутьКФайлу = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 255);
				Объект.Размер = ГенераторСлучайныхЧисел.Следующий(99999999);
				Объект.Расширение = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3, 10);
				Объект.РодительскаяВерсия = V82.Справочники/*Менеджер*/.ВерсииФайлов.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ВерсииФайлов();
				Объект.СтатусИзвлеченияТекста = (V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СтатусыИзвлеченияТекстаФайлов));
				Объект.ТипХраненияФайла = (V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ТипыХраненияФайлов));
				Объект.Том = V82.Справочники/*Менеджер*/.ТомаХраненияФайлов.НайтиПоКоду(ГенераторСлучайныхЧисел.Следующий(999)) ?? new V82.СправочникиСсылка.ТомаХраненияФайлов();

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.ВерсииФайлов.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника ВерсииФайлов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.ВерсииФайлов.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника ВерсииФайлов. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.ВерсииФайлов.Выбрать())
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
