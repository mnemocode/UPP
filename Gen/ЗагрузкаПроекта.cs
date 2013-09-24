﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;

using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Gen
{
    internal class ЗагрузкаПроекта
    {
        public readonly Ожидания Ожидания = new Ожидания();
        public delegate void ОбработатьФайл(string Проект, string Каталог, string Файл, string Содержание);

        public void ВыполнитьЗапрос(ОбработатьФайл ОбработатьФайл)
        {
            using (var Подключение = new SqlConnection(ConfigurationManager.ConnectionStrings["БазаДанныхПроекта"].ConnectionString))
            {
                Подключение.Open();
                using (var Команда = Подключение.CreateCommand())
                {
                    Команда.CommandTimeout = 300;
                    Команда.CommandText = "Select Проект, Каталог, Вид, Код from dbo.V82КлассыNet(@ИдентификаторБазы)"; //Where Проект = 'ExtJs'"; 
                    Команда.Parameters.Add("ИдентификаторБазы",Настройки.ИдентификаторБазы);
                    using (var РезультатЗапроса = Команда.ExecuteReader())
                    {
                        while (РезультатЗапроса.Read())
                        {
                            var Строка = new object[РезультатЗапроса.FieldCount];
                            РезультатЗапроса.GetValues(Строка);
                            //ОбработатьФайл((string)Строка[0], (string)Строка[1], (string)Строка[2], (string)Строка[3]);
                            var МаркерВызоваДелегата = ОбработатьФайл.BeginInvoke((string)Строка[0], (string)Строка[1], (string)Строка[2], (string)Строка[3], null, null);
                            Ожидания.Add(МаркерВызоваДелегата.AsyncWaitHandle);
                        }
                    }
                }
            }
        }
        //
        public void ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл ОбработатьФайл,string ТекстЗапроса)
        {
            //Console.WriteLine(ТекстЗапроса);
            using (var Подключение = new SqlConnection(ConfigurationManager.ConnectionStrings["БазаДанныхПроекта"].ConnectionString))
            {
                Подключение.Open();
                using (var Команда = Подключение.CreateCommand())
                {
                    Команда.CommandTimeout = 300;
                    Команда.CommandText = ТекстЗапроса; 
                    Команда.Parameters.Add("ИдентификаторБазы", Настройки.ИдентификаторБазы);
                    using (var РезультатЗапроса = Команда.ExecuteReader())
                    {
                        while (РезультатЗапроса.Read())
                        {
                            var Строка = new object[РезультатЗапроса.FieldCount];
                            РезультатЗапроса.GetValues(Строка);
                            if ((Строка[3] as string)==null)
                            {
                                continue;
                            }
                            //ОбработатьФайл((string)Строка[0], (string)Строка[1], (string)Строка[2], (string)Строка[3]);
                            var ИмяФайла = (string) Строка[2];
                            var Код = (string) Строка[3];
                            if (ИмяФайла.Length > 4 && string.Compare(ИмяФайла, ИмяФайла.Length-4, ".Xml", 0, 4, StringComparison.OrdinalIgnoreCase)==0)
                            {
                                Код=XElement.Parse(Код).ToString();
                            }
                            var МаркерВызоваДелегата = ОбработатьФайл.BeginInvoke((string)Строка[0], (string)Строка[1], ИмяФайла, Код, null, null);
                            Ожидания.Add(МаркерВызоваДелегата.AsyncWaitHandle);
                        }
                    }
                }
            }
        }

        public void ПолучитьМодулиОбъектов(ОбработатьФайл ОбработатьФайл)
        {
            const string МодульОбычногоПриложения = @"Select '1С' Проект, '' Каталог,'МодульОбычногоПриложения.txt' Вид,МодульОбычногоПриложения Код 
            from dbo.v82Конфигурация(@ИдентификаторБазы)
            Where МодульОбычногоПриложения!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОбычногоПриложения);

            const string РазмерыОбъектов = @"Select '1С' Проект, '' Каталог,'РазмерыОбъектов.txt' Вид, replace(cast((select * from v82ТаблицыSQL(@ИдентификаторБазы,'') order by Данные desc for xml raw) as varchar(max)),'><','>'+char(13)+char(10)+'<') Код";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, РазмерыОбъектов);

            const string ИндексыОбъектов = @"Select '1С' Проект, '' Каталог,'ИндексыОбъектов.txt' Вид, replace(cast((select * from V82ИндексыSql(@ИдентификаторБазы,'') order by 1 desc for xml raw) as varchar(max)),'><','>'+char(13)+char(10)+'<') Код";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ИндексыОбъектов);

            const string БлокировкиОбъектов = @"Select '1С' Проект, '' Каталог,'БлокировкиОбъектов.txt' Вид, replace(cast((select * from V82БлокировкиSql(@ИдентификаторБазы) order by 1 desc for xml raw) as varchar(max)),'><','>'+char(13)+char(10)+'<') Код";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, БлокировкиОбъектов);

            const string МодульВнешнегоСоединения = @"Select '1С' Проект, '' Каталог,'МодульВнешнегоСоединения.txt' Вид,МодульВнешнегоСоединения Код 
            from dbo.v82Конфигурация(@ИдентификаторБазы)
            Where МодульВнешнегоСоединения!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульВнешнегоСоединения);

            const string МодульУправляемогоПриложения = @"Select '1С' Проект, '' Каталог,'МодульУправляемогоПриложения.txt' Вид,МодульУправляемогоПриложения Код 
            from dbo.v82Конфигурация(@ИдентификаторБазы)
            Where МодульУправляемогоПриложения!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульУправляемогоПриложения);

            const string МодульСеанса = @"Select '1С' Проект, '' Каталог,'МодульСеанса.txt' Вид,МодульСеанса Код 
            from dbo.v82Конфигурация(@ИдентификаторБазы)
            Where МодульСеанса!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульСеанса);

            const string ФормыXmlОписание= @"Select '1С' Проект, ВладелецТип+'\\'+ВладелецИмя+'\\'+Имя Каталог,'Форма.xml' Вид,ФормаXML Код 
            from dbo.v82Формы(@ИдентификаторБазы)";

            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ФормыXmlОписание);

            const string ФормыМодули = @"Select '1С' Проект, ВладелецТип+'\\'+ВладелецИмя+'\\'+Имя Каталог,'Модуль.txt' Вид,Модуль Код 
            from dbo.v82Формы(@ИдентификаторБазы)";

            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ФормыМодули);



            const string ОбщиеМодули = @"Select '1С' Проект, 'ОбщиеМодули' Каталог,Имя+'.txt' Вид,Модуль Код 
            from dbo.V82ОбщиеМодули(@ИдентификаторБазы)
            Where Модуль!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ОбщиеМодули);

            const string ПаспортОбъектаСправочники = @"Select '1С' Проект, 'Справочники\\'+Имя Каталог,'Паспорт.xml' Вид,Паспорт Код 
            from dbo.v82Справочники(@ИдентификаторБазы)";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ПаспортОбъектаСправочники);

            const string МодульОбъектаСправочники = @"Select '1С' Проект, 'Справочники\\'+Имя Каталог,'МодульОбъекта.txt' Вид,МодульОбъекта Код 
            from dbo.v82Справочники(@ИдентификаторБазы)
            Where МодульОбъекта!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОбъектаСправочники);

            const string МодульМенеджераСправочники = @"Select '1С' Проект, 'Справочники\\'+Имя Каталог,'МодульМенеджера.txt' Вид,МодульМенеджера Код 
            from dbo.v82Справочники(@ИдентификаторБазы)
            Where МодульМенеджера!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульМенеджераСправочники);

            const string МодульОсновнойФормыОбъектаСправочники = @"Select '1С' Проект, 'Справочники\\'+Имя Каталог,'МодульОсновнойФормыОбъекта.txt' Вид,МодульОсновнойФормыОбъекта Код 
            from dbo.v82Справочники(@ИдентификаторБазы)
            Where МодульОсновнойФормыОбъекта!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОсновнойФормыОбъектаСправочники);

            const string МодульОсновнойФормыСпискаСправочники = @"Select '1С' Проект, 'Справочники\\'+Имя Каталог,'МодульОсновнойФормыСписка.txt' Вид,МодульОсновнойФормыСписка Код 
            from dbo.v82Справочники(@ИдентификаторБазы)
            Where МодульОсновнойФормыСписка!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОсновнойФормыСпискаСправочники);

//            const string ФормыСправочники = @"Select '1С' Проект, 'Справочники\\'+o.Имя+'\\'+f.Имя Каталог,'Форма.xml' Вид,
//            dbo.V82FormToXml(f.Гуид,@ИдентификаторБазы) Код 
//            from dbo.v82Справочники(@ИдентификаторБазы) o
//	            join dbo.v82Формы(@ИдентификаторБазы) f on o.Гуид=f.Владелец";

//            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ФормыСправочники);

            const string ПаспортОбъектаДокументы = @"Select '1С' Проект, 'Документы\\'+Имя Каталог,'Паспорт.xml' Вид,Паспорт Код 
            from dbo.v82Документы(@ИдентификаторБазы)";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ПаспортОбъектаДокументы);

            const string МодульОбъектаДокументы = @"Select '1С' Проект, 'Документы\\'+Имя Каталог,'МодульОбъекта.txt' Вид,МодульОбъекта Код 
            from dbo.v82Документы(@ИдентификаторБазы)
            Where МодульОбъекта!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОбъектаДокументы);

            const string МодульМенеджераДокументы = @"Select '1С' Проект, 'Документы\\'+Имя Каталог,'МодульМенеджера.txt' Вид,МодульМенеджера Код 
            from dbo.v82Документы(@ИдентификаторБазы)
            Where МодульМенеджера!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульМенеджераДокументы);

            const string МодульОсновнойФормыОбъектаДокументы = @"Select '1С' Проект, 'Документы\\'+Имя Каталог,'МодульОсновнойФормыОбъекта.txt' Вид,МодульОсновнойФормыОбъекта Код 
            from dbo.v82Документы(@ИдентификаторБазы)
            Where МодульОсновнойФормыОбъекта!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОсновнойФормыОбъектаДокументы);

            const string МодульОсновнойФормыСпискаДокументы = @"Select '1С' Проект, 'Документы\\'+Имя Каталог,'МодульОсновнойФормыСписка.txt' Вид,МодульОсновнойФормыСписка Код 
            from dbo.v82Документы(@ИдентификаторБазы)
            Where МодульОсновнойФормыСписка!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОсновнойФормыСпискаДокументы);

//            const string ФормыДокументов = @"Select '1С' Проект, 'Документы\\'+o.Имя+'\\'+f.Имя Каталог,'Форма.xml' Вид,
//            dbo.V82FormToXml(f.Гуид,@ИдентификаторБазы) Код 
//            from dbo.v82Документы(@ИдентификаторБазы) o
//	            join dbo.v82Формы(@ИдентификаторБазы) f on o.Гуид=f.Владелец";

//            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, ФормыДокументов);

            const string МодульОбъектаОтчеты = @"Select '1С' Проект, 'Отчеты\\'+Имя Каталог,'МодульОбъекта.txt' Вид,МодульОбъекта Код 
            from dbo.v82Отчеты(@ИдентификаторБазы)
            Where МодульОбъекта!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОбъектаОтчеты);

            const string МодульОсновнойФормыОтчеты = @"Select '1С' Проект, 'Отчеты\\'+Имя Каталог,'МодульОсновнойФормы.txt' Вид,МодульОсновнойФормы Код 
            from dbo.v82Отчеты(@ИдентификаторБазы)
            Where МодульОсновнойФормы!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОсновнойФормыОтчеты);

            const string МодульОбъектаОбработки = @"Select '1С' Проект, 'Обработки\\'+Имя Каталог,'МодульОбъекта.txt' Вид,МодульОбъекта Код 
            from dbo.v82Обработки(@ИдентификаторБазы)
            Where МодульОбъекта!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОбъектаОбработки);

            const string МодульОсновнойФормыОбработки = @"Select '1С' Проект, 'Обработки\\'+Имя Каталог,'МодульОсновнойФормы.txt' Вид,МодульОсновнойФормы Код 
            from dbo.v82Обработки(@ИдентификаторБазы)
            Where МодульОсновнойФормы!=''";
            ПолучитьМодулиОбъектовПоЗапросу(ОбработатьФайл, МодульОсновнойФормыОбработки);

        }

        private readonly static Regex ОбработкаЮникодПоследовательности = new Regex(@"\\[uU]([0-9A-F]{4})");

        public void ПолучитьДанныеОбъектовПоЗапросу(ОбработатьФайл ОбработатьФайл, string ТекстЗапроса)
        {
            //Console.WriteLine(ТекстЗапроса);
            using (var Подключение = new SqlConnection(ConfigurationManager.ConnectionStrings["БазаДанныхПроекта"].ConnectionString))
            {
                Подключение.Open();
                using (var Команда = Подключение.CreateCommand())
                {
                    Команда.CommandTimeout = 300;
                    Команда.CommandText = ТекстЗапроса;
                    Команда.Parameters.Add("ИдентификаторБазы", Настройки.ИдентификаторБазы);
                    using (var РезультатЗапроса = Команда.ExecuteReader())
                    {
                        while (РезультатЗапроса.Read())
                        {
                            var Имя = РезультатЗапроса.GetString(0);
                            var Запрос = @"https://localhost:1337/Справочники/" + Имя + @"/ВыбратьПоСсылке/100?format=json";
                            try
                            {
                                var Request = WebRequest.Create(Запрос) as HttpWebRequest;
                                {
                                    using (var response = Request.GetResponse() as HttpWebResponse)
                                    {
                                        if (response.StatusCode != HttpStatusCode.OK)
                                        {
                                            throw new Exception(String.Format(
                                                "Server error (HTTP {0}: {1}).",
                                                response.StatusCode,
                                                response.StatusDescription));
                                        }
                                        var receiveStream = response.GetResponseStream();
                                        var encode = Encoding.GetEncoding("utf-8");
                                        // Pipes the stream to a higher level stream reader with the required encoding format. 
                                        var readStream = new StreamReader(receiveStream, encode);
                                        var поток = new StringBuilder("");
                                        while (!readStream.EndOfStream)
                                        {
                                            поток.Append(readStream.ReadLine());
                                        }
                                        var ответ = поток.ToString().Trim('{').Trim('}');


                                        ответ = ОбработкаЮникодПоследовательности.Replace(ответ, Match => ((char)Int32.Parse(Match.Value.Substring(2), NumberStyles.HexNumber)).ToString(CultureInfo.InvariantCulture));

                                        ответ = string.Format(@"
                                    Ext.define('Данные.Справочники.{0}',
                                    {{
                                        data:
                                        {1}
                                    }});
                                    ", Имя, ответ);


                                        ОбработатьФайл("Данные", "Справочники", Имя + ".js", ответ);
                                    }
                                }
                            }
                            catch 
                            {
                            }

                            //var Строка = new object[РезультатЗапроса.FieldCount];
                            //РезультатЗапроса.GetValues(Строка);
                            ////ОбработатьФайл((string)Строка[0], (string)Строка[1], (string)Строка[2], (string)Строка[3]);
                            //var ИмяФайла = (string)Строка[2];
                            //var Код = (string)Строка[3];
                            //if (ИмяФайла.Length > 4 && string.Compare(ИмяФайла, ИмяФайла.Length - 4, ".Xml", 0, 4, StringComparison.OrdinalIgnoreCase) == 0)
                            //{
                            //    Код = XElement.Parse(Код).ToString();
                            //}
                            //var МаркерВызоваДелегата = ОбработатьФайл.BeginInvoke((string)Строка[0], (string)Строка[1], ИмяФайла, Код, null, null);
                            //Ожидания.Add(МаркерВызоваДелегата.AsyncWaitHandle);
                        }
                    }
                }
            }
        }

        public void ПолучитьЗаглушкуОбъектовПоЗапросу(ОбработатьФайл ОбработатьФайл,string ТипМетаданных, string ТекстЗапроса)
        {
            //Console.WriteLine(ТекстЗапроса);
            using (var Подключение = new SqlConnection(ConfigurationManager.ConnectionStrings["БазаДанныхПроекта"].ConnectionString))
            {
                Подключение.Open();
                using (var Команда = Подключение.CreateCommand())
                {
                    Команда.CommandTimeout = 300;
                    Команда.CommandText = ТекстЗапроса;
                    Команда.Parameters.Add("ИдентификаторБазы", Настройки.ИдентификаторБазы);
                    using (var РезультатЗапроса = Команда.ExecuteReader())
                    {
                        while (РезультатЗапроса.Read())
                        {
                            var Имя = РезультатЗапроса.GetString(0);
                            try
                            {
                                
                                     var  ответ = string.Format(@"
                                    Ext.define('Данные.{0}.{1}',
                                    {{
                                        data:
                                        {2}
                                    }});
                                    ",ТипМетаданных, Имя, "0");


                                     ОбработатьФайл("Данные", ТипМетаданных, Имя + ".js", ответ);
                            }
                            catch
                            {
                            }
                        }
                    }
                }
            }
        }

        public void ПолучитьДанныеОбъектов(ОбработатьФайл ОбработатьФайл)
        {

            const string данныеСправочников = @"Select Имя from dbo.v82Справочники(@ИдентификаторБазы)";
            ПолучитьДанныеОбъектовПоЗапросу(ОбработатьФайл, данныеСправочников);

            const string данныеДокументов = @"Select Имя from dbo.v82Документы(@ИдентификаторБазы)";
            ПолучитьЗаглушкуОбъектовПоЗапросу(ОбработатьФайл, "Документы", данныеДокументов);

            const string данныеОтчетов = @"Select Имя from dbo.v82Отчеты(@ИдентификаторБазы)";
            ПолучитьЗаглушкуОбъектовПоЗапросу(ОбработатьФайл, "Отчеты", данныеОтчетов);

            const string данныеОбработок = @"Select Имя from dbo.v82Обработки(@ИдентификаторБазы)";
            ПолучитьЗаглушкуОбъектовПоЗапросу(ОбработатьФайл, "Обработки", данныеОбработок);
        }
    }

}