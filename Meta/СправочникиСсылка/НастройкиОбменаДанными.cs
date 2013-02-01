﻿
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class НастройкиОбменаДанными:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("974e44aa-e7aa-46dd-9ff5-b3aff627f21f");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191715.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(3)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public string/*3*/ Код {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*150*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public ПланОбменаСсылка УзелИнформационнойБазы {get;set;}//Узел информационной базы
		[DataMember]
		[ProtoMember(8)]
		public V82.Перечисления/*Ссылка*/.ТипыАвтоматическогоОбменаДанными ТипНастройки {get;set;}//Тип настройки
		[DataMember]
		[ProtoMember(9)]
		public bool ПроизводитьПриемСообщений {get;set;}//Производить прием сообщений
		[DataMember]
		[ProtoMember(10)]
		public bool ПроизводитьОтправкуСообщений {get;set;}//Производить отправку сообщений
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаВыгрузкуДанных {get;set;}//Количество элементов в транзакции на выгрузку данных
		[DataMember]
		[ProtoMember(12)]
		public decimal/*(10)*/ КоличествоЭлементовВТранзакцииНаЗагрузкуДанных {get;set;}//Количество элементов в транзакции на загрузку данных
		[DataMember]
		[ProtoMember(13)]
		public bool ВыполнятьАрхивациюФайловОбмена {get;set;}//Выполнять архивацию файлов обмена
		[DataMember]
		[ProtoMember(14)]
		public string/*(0)*/ ПарольНаОтправку {get;set;}//Пароль на отправку
		[DataMember]
		[ProtoMember(15)]
		public string/*(0)*/ ПарольНаПрием {get;set;}//Пароль на прием
		[DataMember]
		[ProtoMember(16)]
		public string/*(0)*/ КаталогОбменаИнформацией {get;set;}//Каталог обмена информацией
		[DataMember]
		[ProtoMember(17)]
		public string/*(0)*/ FTPАдресОбмена {get;set;}//FTP адрес обмена
		[DataMember]
		[ProtoMember(18)]
		public decimal/*(10)*/ ПортFTPСоединения {get;set;}//Порт FTP соединения
		[DataMember]
		[ProtoMember(19)]
		public string/*(50)*/ ПользовательFTPСоединения {get;set;}//Пользователь FTP соединения
		[DataMember]
		[ProtoMember(20)]
		public string/*(50)*/ ПарольFTPСоединения {get;set;}//Пароль FTP соединения
		[DataMember]
		[ProtoMember(21)]
		public string/*(0)*/ Комментарий {get;set;}
		[DataMember]
		[ProtoMember(22)]
		public decimal/*(10)*/ МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP {get;set;}//Максимальный размер отправляемого получаемого пакета через FTP
		[DataMember]
		[ProtoMember(23)]
		public bool ПассивноеFTPСоединение {get;set;}//Пассивное FTPСоединение
		[DataMember]
		[ProtoMember(24)]
		public string/*(0)*/ ПочтовыйАдресПолучателя {get;set;}//Почтовый адрес получателя
		[DataMember]
		[ProtoMember(25)]
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьПриемаОтправкиСообщений {get;set;}//Учетная запись приема отправки сообщений
		[DataMember]
		[ProtoMember(26)]
		public bool АвтоматическиЗакачиватьПочтуПриОбмене {get;set;}//Автоматически закачивать почту при обмене
		[DataMember]
		[ProtoMember(27)]
		public decimal/*(10)*/ МаксимальныйРазмерОтправляемогоПакетаЧерезПочту {get;set;}//Максимальный размер отправляемого пакета через почту
		[DataMember]
		[ProtoMember(28)]
		public ПланОбменаСсылка УзелФоновогоОбмена {get;set;}//Узел фонового обмена
		[DataMember]
		[ProtoMember(29)]
		public ХранилищеЗначения ПравилаОбмена {get;set;}//Правила обмена
		[DataMember]
		[ProtoMember(30)]
		public ХранилищеЗначения ПравилаОбменаДляПриемника {get;set;}//Правила обмена для приемника
		[DataMember]
		[ProtoMember(31)]
		public decimal/*(10)*/ ДобавлениеОбъектовИзФоновогоОбмена {get;set;}//Добавление объектов из фонового обмена
		[DataMember]
		[ProtoMember(32)]
		public decimal/*(10)*/ КоличествоОбъектовДляФоновогоОбмена {get;set;}//Количество объектов для фонового обмена
		[DataMember]
		[ProtoMember(33)]
		public bool OnLineОбмен {get;set;}//On line обмен
		[DataMember]
		[ProtoMember(34)]
		public bool ТипИнформационнойБазыДляПодключения {get;set;}//Тип информационной базы для подключения
		[DataMember]
		[ProtoMember(35)]
		public string/*(0)*/ КаталогИнформационнойБазыДляПодключения {get;set;}//Каталог информационной базы для подключения
		[DataMember]
		[ProtoMember(36)]
		public string/*(0)*/ ИмяСервераИнформационнойБазыДляПодключения {get;set;}//Имя сервера информационной базы для подключения
		[DataMember]
		[ProtoMember(37)]
		public string/*(0)*/ ИмяИнформационнойБазыНаСервереДляПодключения {get;set;}//Имя информационной базы на сервере для подключения
		[DataMember]
		[ProtoMember(38)]
		public bool АутентификацияWindowsИнформационнойБазыДляПодключения {get;set;}//Аутентификация windows информационной базы для подключения
		[DataMember]
		[ProtoMember(39)]
		public string/*(0)*/ ПользовательИнформационнойБазыДляПодключения {get;set;}//Пользователь информационной базы для подключения
		[DataMember]
		[ProtoMember(40)]
		public string/*(0)*/ ПарольИнформационнойБазыДляПодключения {get;set;}//Пароль информационной базы для подключения
		[DataMember]
		[ProtoMember(41)]
		public string/*(5)*/ ВерсияПлатформыИнформационнойБазыДляПодключения {get;set;}//Версия платформы информационной базы для подключения
		[DataMember]
		[ProtoMember(42)]
		public bool РежимОтладкиOnLineОбмена {get;set;}//Режим отладки on line обмена
		[DataMember]
		[ProtoMember(43)]
		public string/*(255)*/ ИмяФайлаПротоколаОбменаOnLineОбмен {get;set;}//Имя файла протокола обмена on line обмен
		[DataMember]
		[ProtoMember(44)]
		public ПланОбменаСсылка ТипУзлаИнформационнойБазы {get;set;}//Тип узла информационной базы
		[DataMember]
		[ProtoMember(45)]
		public V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты УчетнаяЗаписьОтправкиСообщенияОбОшибке {get;set;}//Учетная запись отправки сообщения об ошибке
		[DataMember]
		[ProtoMember(46)]
		public string/*(100)*/ АдресДляОтправкиСообщенийОбОшибке {get;set;}//Адрес для отправки сообщений об ошибке
		[DataMember]
		[ProtoMember(47)]
		public bool ПослеОшибкиОтложенногоПроведенияПрекратитьОперации {get;set;}//После ошибки отложенного проведения прекратить операции
		[DataMember]
		[ProtoMember(48)]
		public decimal/*(10)*/ КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации {get;set;}//Количество ошибок отложенного проведения для прекращения операции
		[DataMember]
		[ProtoMember(49)]
		public bool ВыполнятьДействияПодПолнымиПравами {get;set;}//Выполнять действия под полными правами
		[DataMember]
		[ProtoMember(50)]
		public bool ПроизводитьОтправкуТолькоПриУспешномПриеме {get;set;}//Производить отправку только при успешном приеме
		[DataMember]
		[ProtoMember(51)]
		public bool ВыполнитьОтложенноеПроведениеДокументовПоРасписанию {get;set;}//Выполнить отложенное проведение документов по расписанию
		[DataMember]
		[ProtoMember(52)]
		public string/*(50)*/ ПользовательПроксиFTP {get;set;}//Пользователь прокси FTP
		[DataMember]
		[ProtoMember(53)]
		public string/*(50)*/ ПарольПроксиFTP {get;set;}//Пароль прокси FTP
		[DataMember]
		[ProtoMember(54)]
		public string/*(50)*/ СерверПроксиFTP {get;set;}//Сервер прокси FTP
		[DataMember]
		[ProtoMember(55)]
		public decimal/*(10)*/ ПортПроксиFTP {get;set;}//Порт прокси FTP
		[DataMember]
		[ProtoMember(56)]
		public string/*(50)*/ ПротоколПроксиFTP {get;set;}//Протокол прокси FTP

		public V82.СправочникиОбъект.НастройкиОбменаДанными  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиОбменаДанными();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.УзелИнформационнойБазы = УзелИнформационнойБазы;
			Объект.ТипНастройки = ТипНастройки;
			Объект.ПроизводитьПриемСообщений = ПроизводитьПриемСообщений;
			Объект.ПроизводитьОтправкуСообщений = ПроизводитьОтправкуСообщений;
			Объект.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = КоличествоЭлементовВТранзакцииНаВыгрузкуДанных;
			Объект.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = КоличествоЭлементовВТранзакцииНаЗагрузкуДанных;
			Объект.ВыполнятьАрхивациюФайловОбмена = ВыполнятьАрхивациюФайловОбмена;
			Объект.ПарольНаОтправку = ПарольНаОтправку;
			Объект.ПарольНаПрием = ПарольНаПрием;
			Объект.КаталогОбменаИнформацией = КаталогОбменаИнформацией;
			Объект.FTPАдресОбмена = FTPАдресОбмена;
			Объект.ПортFTPСоединения = ПортFTPСоединения;
			Объект.ПользовательFTPСоединения = ПользовательFTPСоединения;
			Объект.ПарольFTPСоединения = ПарольFTPСоединения;
			Объект.Комментарий = Комментарий;
			Объект.МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP = МаксимальныйРазмерОтправляемогоПолучаемогоПакетаЧерезFTP;
			Объект.ПассивноеFTPСоединение = ПассивноеFTPСоединение;
			Объект.ПочтовыйАдресПолучателя = ПочтовыйАдресПолучателя;
			Объект.УчетнаяЗаписьПриемаОтправкиСообщений = УчетнаяЗаписьПриемаОтправкиСообщений;
			Объект.АвтоматическиЗакачиватьПочтуПриОбмене = АвтоматическиЗакачиватьПочтуПриОбмене;
			Объект.МаксимальныйРазмерОтправляемогоПакетаЧерезПочту = МаксимальныйРазмерОтправляемогоПакетаЧерезПочту;
			Объект.УзелФоновогоОбмена = УзелФоновогоОбмена;
			Объект.ПравилаОбмена = ПравилаОбмена;
			Объект.ПравилаОбменаДляПриемника = ПравилаОбменаДляПриемника;
			Объект.ДобавлениеОбъектовИзФоновогоОбмена = ДобавлениеОбъектовИзФоновогоОбмена;
			Объект.КоличествоОбъектовДляФоновогоОбмена = КоличествоОбъектовДляФоновогоОбмена;
			Объект.OnLineОбмен = OnLineОбмен;
			Объект.ТипИнформационнойБазыДляПодключения = ТипИнформационнойБазыДляПодключения;
			Объект.КаталогИнформационнойБазыДляПодключения = КаталогИнформационнойБазыДляПодключения;
			Объект.ИмяСервераИнформационнойБазыДляПодключения = ИмяСервераИнформационнойБазыДляПодключения;
			Объект.ИмяИнформационнойБазыНаСервереДляПодключения = ИмяИнформационнойБазыНаСервереДляПодключения;
			Объект.АутентификацияWindowsИнформационнойБазыДляПодключения = АутентификацияWindowsИнформационнойБазыДляПодключения;
			Объект.ПользовательИнформационнойБазыДляПодключения = ПользовательИнформационнойБазыДляПодключения;
			Объект.ПарольИнформационнойБазыДляПодключения = ПарольИнформационнойБазыДляПодключения;
			Объект.ВерсияПлатформыИнформационнойБазыДляПодключения = ВерсияПлатформыИнформационнойБазыДляПодключения;
			Объект.РежимОтладкиOnLineОбмена = РежимОтладкиOnLineОбмена;
			Объект.ИмяФайлаПротоколаОбменаOnLineОбмен = ИмяФайлаПротоколаОбменаOnLineОбмен;
			Объект.ТипУзлаИнформационнойБазы = ТипУзлаИнформационнойБазы;
			Объект.УчетнаяЗаписьОтправкиСообщенияОбОшибке = УчетнаяЗаписьОтправкиСообщенияОбОшибке;
			Объект.АдресДляОтправкиСообщенийОбОшибке = АдресДляОтправкиСообщенийОбОшибке;
			Объект.ПослеОшибкиОтложенногоПроведенияПрекратитьОперации = ПослеОшибкиОтложенногоПроведенияПрекратитьОперации;
			Объект.КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации = КоличествоОшибокОтложенногоПроведенияДляПрекращенияОперации;
			Объект.ВыполнятьДействияПодПолнымиПравами = ВыполнятьДействияПодПолнымиПравами;
			Объект.ПроизводитьОтправкуТолькоПриУспешномПриеме = ПроизводитьОтправкуТолькоПриУспешномПриеме;
			Объект.ВыполнитьОтложенноеПроведениеДокументовПоРасписанию = ВыполнитьОтложенноеПроведениеДокументовПоРасписанию;
			Объект.ПользовательПроксиFTP = ПользовательПроксиFTP;
			Объект.ПарольПроксиFTP = ПарольПроксиFTP;
			Объект.СерверПроксиFTP = СерверПроксиFTP;
			Объект.ПортПроксиFTP = ПортПроксиFTP;
			Объект.ПротоколПроксиFTP = ПротоколПроксиFTP;
			return Объект;
		}

		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}
