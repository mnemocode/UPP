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
	public partial class Должности:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("9c95fa50-177e-49ac-9169-d2b7960ad200");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191336.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public string/*(0)*/ Требования {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public string/*(0)*/ Обязанности {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public string/*(0)*/ Условия {get;set;}
		///<summary>
		///Название вакансии в средствах массовой информации
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(200)*/ УдалитьНазваниеВакансииВСМИ {get;set;}//Название вакансии в СМИ
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.ТиповыеАнкеты АнкетаРезюмеКандидата {get;set;}//Анкета резюме кандидата

		public V82.СправочникиОбъект.Должности  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.Должности();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.Требования = Требования;
			Объект.Обязанности = Обязанности;
			Объект.Условия = Условия;
			Объект.УдалитьНазваниеВакансииВСМИ = УдалитьНазваниеВакансииВСМИ;
			Объект.АнкетаРезюмеКандидата = АнкетаРезюмеКандидата;
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
