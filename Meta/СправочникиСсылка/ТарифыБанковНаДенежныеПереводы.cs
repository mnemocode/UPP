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
	public partial class ТарифыБанковНаДенежныеПереводы:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("ea416805-7dbd-450b-834d-f61b36d6225a");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191019.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*100*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public decimal/*(15.2)*/ МинимальныйТариф {get;set;}//Минимальный тариф
		[DataMember]
		[ProtoMember(8)]
		public decimal/*(15.2)*/ МаксимальныйТариф {get;set;}//Максимальный тариф
		[DataMember]
		[ProtoMember(9)]
		public decimal/*(5.2)*/ Процент {get;set;}

		public V82.СправочникиОбъект.ТарифыБанковНаДенежныеПереводы  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.ТарифыБанковНаДенежныеПереводы();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.МинимальныйТариф = МинимальныйТариф;
			Объект.МаксимальныйТариф = МаксимальныйТариф;
			Объект.Процент = Процент;
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
