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
	public partial class ОтправкиФСС:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("caa8e55f-cd19-454a-a752-bbf7e879e24f");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221190832.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*25*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public object ОтчетСсылка {get;set;}//Ссылка на регламентированный отчет
		[DataMember]
		[ProtoMember(8)]
		public string/*(100)*/ ИдентификаторОтправкиНаСервере {get;set;}//Идентификатор отправки на сервере
		[DataMember]
		[ProtoMember(9)]
		public ХранилищеЗначения ЗашифрованныйПакет {get;set;}//Зашифрованный пакет выгрузки
		///<summary>
		///Имя файла зашифрованного пакета выгрузки
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(100)*/ ИмяФайлаПакета {get;set;}//Имя файла пакета
		[DataMember]
		[ProtoMember(11)]
		public V82.Перечисления/*Ссылка*/.СтатусыОтправки СтатусОтправки {get;set;}//Статус отправки
		///<summary>
		///Протокол обработки
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public ХранилищеЗначения Протокол {get;set;}//Протокол обработки
		[DataMember]
		[ProtoMember(13)]
		public DateTime ДатаОтправки {get;set;}//Дата отправки
		[DataMember]
		[ProtoMember(14)]
		public DateTime ДатаПолученияРезультата {get;set;}//Дата получения результата
		[DataMember]
		[ProtoMember(15)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		[DataMember]
		[ProtoMember(16)]
		public string/*(4)*/ КодОрганаФСС {get;set;}//Код органа ФСС
		///<summary>
		///Квитанция успеха
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public ХранилищеЗначения Квитанция {get;set;}

		public V82.СправочникиОбъект.ОтправкиФСС  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ОтправкиФСС();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.ОтчетСсылка = ОтчетСсылка;
			Объект.ИдентификаторОтправкиНаСервере = ИдентификаторОтправкиНаСервере;
			Объект.ЗашифрованныйПакет = ЗашифрованныйПакет;
			Объект.ИмяФайлаПакета = ИмяФайлаПакета;
			Объект.СтатусОтправки = СтатусОтправки;
			Объект.Протокол = Протокол;
			Объект.ДатаОтправки = ДатаОтправки;
			Объект.ДатаПолученияРезультата = ДатаПолученияРезультата;
			Объект.Организация = Организация;
			Объект.КодОрганаФСС = КодОрганаФСС;
			Объект.Квитанция = Квитанция;
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
