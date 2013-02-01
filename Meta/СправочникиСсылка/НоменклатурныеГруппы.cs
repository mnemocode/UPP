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
	///<summary>
	///(Упр)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class НоменклатурныеГруппы:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("0e66aa46-e255-4a72-b7b4-75efd0bbb3ef");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191453.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public bool ЭтоГруппа {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public Guid Родитель {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*9*/ Код {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*100*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.СправочникиСсылка.ЕдиницыИзмерения ЕдиницаХраненияОстатков {get;set;}//Единица хранения остатков
		[DataMember]
		[ProtoMember(10)]
		public V82.СправочникиСсылка.КлассификаторЕдиницИзмерения БазоваяЕдиницаИзмерения {get;set;}//Базовая единица измерения
		///<summary>
		///Ставка НДС по умолчанию для оформления документов
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.Перечисления/*Ссылка*/.СтавкиНДС СтавкаНДС {get;set;}//Ставка НДС

		public V82.СправочникиОбъект.НоменклатурныеГруппы  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.НоменклатурныеГруппы();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.ЭтоГруппа = ЭтоГруппа;
			Объект.Родитель = Родитель;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.ЕдиницаХраненияОстатков = ЕдиницаХраненияОстатков;
			Объект.БазоваяЕдиницаИзмерения = БазоваяЕдиницаИзмерения;
			Объект.СтавкаНДС = СтавкаНДС;
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
