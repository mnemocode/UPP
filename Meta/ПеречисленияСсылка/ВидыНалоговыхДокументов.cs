﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВидыНалоговыхДокументов
	{
		ПустаяСсылка = - 1,
		РешениеОПриостановленииПроведенияВыезднойНалоговойПроверки = 0,//Решение о приостановлении проведения выездной налоговой проверки
		РешениеОВозобновленииПроведенияВыезднойНалоговойПроверки = 1,//Решение о возобновлении проведения выездной налоговой проверки
		РешениеОПродленииИлиОтказеВПродленииСроковПредставленияДокументов = 2,//Решение о продлении или об отказе в продлении сроков представления документов
		РешениеОбОтложенииРассмотренияМатериаловНалоговойПроверкиВСвязиСНеявкойЛица = 3,//Решение об отложении рассмотрения материалов налоговой проверки в связи с неявкой лица (лиц), участие которого (которых) необходимо для их рассмотрения
		СправкаОПроведеннойВыезднойНалоговойПроверке = 4,//Справка о проведенной выездной налоговой проверке
		ПоручениеОбИстребованииДокументов = 5,//Поручение об истребовании документов (информации)
		УведомлениеОВызовеНалогоплательщика = 6,//Уведомление о вызове налогоплательщика (плательщика сбора, налогового агента)
		ТребованиеОПредставленииДокументов = 7,//Требование о представлении документов (информации)
		РешениеОПроведенииДополнительныхМероприятийНалоговогоКонтроля = 8,//Решение о проведении дополнительных мероприятий налогового контроля
		РешениеОПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения = 9,//Решение о привлечении к ответственности за совершение налогового правонарушения
		РешениеОбОтказеВПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения = 10,//Решение об отказе в привлечении к ответственности за совершение налогового правонарушения
		РешениеОПривлеченииКОтветственностиЗаНалоговоеПравонарушение = 11,//Решение о привлечении лица к ответственности за налоговое правонарушение
		РешениеОбОтказеВПривлеченииКОтветственностиЛицаЗаНалоговоеПравонарушение = 12,//Решение об отказе в привлечении лица к ответственности за налоговое правонарушение
		РешениеОПриостановленииИсполненияРешенийФизЛицо = 13,//Решения о приостановлении исполнения решений налогового органа, принятых в отношении физического лица
		РешениеОВозобновленииИсполненияРешенийФизЛицо = 14,//Решения о возобновлении исполнения решений налогового органа, принятых в отношении физического лица
		РешениеОбОтменеРешенияОПривлеченииКОтветственностиФизЛица = 15,//Решения об отмене решения о привлечении к ответственности за совершение налогового правонарушения в части привлечения физического лица к ответственности за совершение налогового правонарушения
		ТребованиеОбУплатеНалогаСбораПениШтрафа = 16,//Требование об уплате налога, сбора, пени, штрафа
		ТребованиеОбУплатеНалогаСбораПениШтрафаФизЛицу = 17,//Требование об уплате налога, сбора, пени, штрафа физическому лицу
		ПлатежныйДокумент = 18,//Платежный документ
		РешениеОВозмещенииНДС = 19,//Решение о возмещении (полностью или частично) суммы налога на добавленную стоимость, заявленной к возмещению
		РешениеОбОтказеВВозмещенииНДС = 20,//Решение об отказе в возмещении (полностью или частично) суммы налога на добавленную стоимость, заявленной к возмещению
		РешениеОВозмещенииНДСЗаявительныйПорядок = 21,//Решение о возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке
		РешениеОбОтказеВВозмещенииНДСЗаявительныйПорядок = 22,//Решение об отказе в возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке
		РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядок = 23,//Решение об отмене решения о возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке
		РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядокУточненнаяДекларация = 24,//Решение об отмене решения о возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке в связи с представлением уточненной налоговой декларации по налогу на добавленную стоимость
		РешениеОВозмещенииСуммыАкциза = 25,//Решение о возмещении суммы акциза, заявленной к возмещению
		РешениеОбОтказеВВозмещенииСуммыАкциза = 26,//Решение об отказе (полностью или частично) в возмещении суммы акциза, заявленной к возмещению
		МотивированноеЗаключение = 27,//Мотивированное заключение
		СвидетельствоОПостановкеНаУчетРоссийскойОрганизации = 28,//Свидетельство о постановке на учет российской организации в налоговом органе по месту нахождения на территории Российской Федерации
		УведомлениеОПостановкеНаУчетРоссийскойОрганизации = 29,//Уведомление о постановке на учет российской организации в налоговом органе на территории Российской Федерации
		УведомлениеОСнятииСУчетаРоссийскойОрганизации = 30,//Уведомление о снятии с учета российской организации в налоговом органе на территории Российской Федерации
		СвидетельствоОПостановкеНаУчетФизЛица = 31,//Свидетельство о постановке на учет физического лица в налоговом органе на территории Российской Федерации
		УведомлениеОПостановкеНаУчетФизЛица = 32,//Уведомление о постановке на учет физического лица в налоговом органе на территории Российской Федерации
		УведомлениеОСнятииСУчетаФизЛица = 33,//Уведомление о снятии с учета физического лица в налоговом органе на территории Российской Федерации
	}
	public static partial class ВидыНалоговыхДокументов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid РешениеОПриостановленииПроведенияВыезднойНалоговойПроверки = new Guid("876ac1a0-732f-92ae-45b1-ee24622a645b");//Решение о приостановлении проведения выездной налоговой проверки
		public static readonly Guid РешениеОВозобновленииПроведенияВыезднойНалоговойПроверки = new Guid("4f33de93-5dd9-030f-4cc9-371f25008602");//Решение о возобновлении проведения выездной налоговой проверки
		public static readonly Guid РешениеОПродленииИлиОтказеВПродленииСроковПредставленияДокументов = new Guid("d41a99bd-64ea-56a7-45fc-3736a33b7ace");//Решение о продлении или об отказе в продлении сроков представления документов
		public static readonly Guid РешениеОбОтложенииРассмотренияМатериаловНалоговойПроверкиВСвязиСНеявкойЛица = new Guid("83124ba4-c969-64f1-4f9a-72415839f57a");//Решение об отложении рассмотрения материалов налоговой проверки в связи с неявкой лица (лиц), участие которого (которых) необходимо для их рассмотрения
		public static readonly Guid СправкаОПроведеннойВыезднойНалоговойПроверке = new Guid("3c24308f-a009-601e-49a8-5a47c9e69703");//Справка о проведенной выездной налоговой проверке
		public static readonly Guid ПоручениеОбИстребованииДокументов = new Guid("a12f42af-99c1-33ad-46a5-2da34db00535");//Поручение об истребовании документов (информации)
		public static readonly Guid УведомлениеОВызовеНалогоплательщика = new Guid("244162a6-9545-7e2c-4fb1-adf3d2784faf");//Уведомление о вызове налогоплательщика (плательщика сбора, налогового агента)
		public static readonly Guid ТребованиеОПредставленииДокументов = new Guid("238706bf-2ad1-9ad1-4d99-bd2080c30290");//Требование о представлении документов (информации)
		public static readonly Guid РешениеОПроведенииДополнительныхМероприятийНалоговогоКонтроля = new Guid("ec634ba8-1759-45f7-4d68-d48353e506e1");//Решение о проведении дополнительных мероприятий налогового контроля
		public static readonly Guid РешениеОПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения = new Guid("c7a0339b-cedb-38b3-46b3-19e7767244ef");//Решение о привлечении к ответственности за совершение налогового правонарушения
		public static readonly Guid РешениеОбОтказеВПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения = new Guid("b6a69aa3-1481-50e1-4789-808ba7b84bc5");//Решение об отказе в привлечении к ответственности за совершение налогового правонарушения
		public static readonly Guid РешениеОПривлеченииКОтветственностиЗаНалоговоеПравонарушение = new Guid("8d9322b3-30c2-526a-45f1-e580ca6d3856");//Решение о привлечении лица к ответственности за налоговое правонарушение
		public static readonly Guid РешениеОбОтказеВПривлеченииКОтветственностиЛицаЗаНалоговоеПравонарушение = new Guid("3dde96b4-55ca-6abb-4b6a-2ca566a84258");//Решение об отказе в привлечении лица к ответственности за налоговое правонарушение
		public static readonly Guid РешениеОПриостановленииИсполненияРешенийФизЛицо = new Guid("e086718f-20c0-f87a-4b34-3874af0467a0");//Решения о приостановлении исполнения решений налогового органа, принятых в отношении физического лица
		public static readonly Guid РешениеОВозобновленииИсполненияРешенийФизЛицо = new Guid("976416a6-8aca-7ad3-4f81-717c33012dd6");//Решения о возобновлении исполнения решений налогового органа, принятых в отношении физического лица
		public static readonly Guid РешениеОбОтменеРешенияОПривлеченииКОтветственностиФизЛица = new Guid("8b7ed19c-62a0-21f2-4551-a6d8d7a05c44");//Решения об отмене решения о привлечении к ответственности за совершение налогового правонарушения в части привлечения физического лица к ответственности за совершение налогового правонарушения
		public static readonly Guid ТребованиеОбУплатеНалогаСбораПениШтрафа = new Guid("730c86be-edba-8511-4c28-6d06b54f9b52");//Требование об уплате налога, сбора, пени, штрафа
		public static readonly Guid ТребованиеОбУплатеНалогаСбораПениШтрафаФизЛицу = new Guid("6eec7cbe-6af0-f341-4f45-68cd3c714d5f");//Требование об уплате налога, сбора, пени, штрафа физическому лицу
		public static readonly Guid ПлатежныйДокумент = new Guid("1b491eb4-bfc0-4b02-4383-5e75983c1e87");//Платежный документ
		public static readonly Guid РешениеОВозмещенииНДС = new Guid("30674da0-2fd9-03d4-4b57-6e50c9c09efd");//Решение о возмещении (полностью или частично) суммы налога на добавленную стоимость, заявленной к возмещению
		public static readonly Guid РешениеОбОтказеВВозмещенииНДС = new Guid("5ec6e58e-48c5-29da-4cd4-fa0540492fc2");//Решение об отказе в возмещении (полностью или частично) суммы налога на добавленную стоимость, заявленной к возмещению
		public static readonly Guid РешениеОВозмещенииНДСЗаявительныйПорядок = new Guid("f374289c-10c2-1172-41e5-3e3b53454267");//Решение о возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке
		public static readonly Guid РешениеОбОтказеВВозмещенииНДСЗаявительныйПорядок = new Guid("5356e9b4-cb4d-88aa-478e-688e5507a3f3");//Решение об отказе в возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке
		public static readonly Guid РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядок = new Guid("9e72b48f-ccbd-e48a-4c60-fe91231291a1");//Решение об отмене решения о возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке
		public static readonly Guid РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядокУточненнаяДекларация = new Guid("141c25a2-a0f4-c5f2-489c-de6e5cfd9b64");//Решение об отмене решения о возмещении суммы налога на добавленную стоимость, заявленной к возмещению, в заявительном порядке в связи с представлением уточненной налоговой декларации по налогу на добавленную стоимость
		public static readonly Guid РешениеОВозмещенииСуммыАкциза = new Guid("832ba491-f668-48da-4fb0-a6657ed7f588");//Решение о возмещении суммы акциза, заявленной к возмещению
		public static readonly Guid РешениеОбОтказеВВозмещенииСуммыАкциза = new Guid("571b6db1-4df3-cc1b-4326-4f875433eabe");//Решение об отказе (полностью или частично) в возмещении суммы акциза, заявленной к возмещению
		public static readonly Guid МотивированноеЗаключение = new Guid("a3ab3ba8-3057-b394-4f98-73b239bfd7c2");//Мотивированное заключение
		public static readonly Guid СвидетельствоОПостановкеНаУчетРоссийскойОрганизации = new Guid("6d74ec95-71dd-d310-4fdb-8e5119d402ec");//Свидетельство о постановке на учет российской организации в налоговом органе по месту нахождения на территории Российской Федерации
		public static readonly Guid УведомлениеОПостановкеНаУчетРоссийскойОрганизации = new Guid("2bedbab7-6b89-6fc8-4160-95e79450bc96");//Уведомление о постановке на учет российской организации в налоговом органе на территории Российской Федерации
		public static readonly Guid УведомлениеОСнятииСУчетаРоссийскойОрганизации = new Guid("9ed45490-63ce-7c1a-43e6-c417951a3abf");//Уведомление о снятии с учета российской организации в налоговом органе на территории Российской Федерации
		public static readonly Guid СвидетельствоОПостановкеНаУчетФизЛица = new Guid("51a9a499-5dbe-bfbe-49f2-8d1fe3c526bc");//Свидетельство о постановке на учет физического лица в налоговом органе на территории Российской Федерации
		public static readonly Guid УведомлениеОПостановкеНаУчетФизЛица = new Guid("00a6248d-0efa-f50b-4328-d64cd38f3d35");//Уведомление о постановке на учет физического лица в налоговом органе на территории Российской Федерации
		public static readonly Guid УведомлениеОСнятииСУчетаФизЛица = new Guid("8424aea1-695b-920f-4bcb-1ba1414693d6");//Уведомление о снятии с учета физического лица в налоговом органе на территории Российской Федерации
		public static ВидыНалоговыхДокументов Получить(this ВидыНалоговыхДокументов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыНалоговыхДокументов Получить(this ВидыНалоговыхДокументов Значение, Guid Ссылка)
		{
			if(Ссылка == РешениеОПриостановленииПроведенияВыезднойНалоговойПроверки)
			{
				return ВидыНалоговыхДокументов.РешениеОПриостановленииПроведенияВыезднойНалоговойПроверки;
			}
			else if(Ссылка == РешениеОВозобновленииПроведенияВыезднойНалоговойПроверки)
			{
				return ВидыНалоговыхДокументов.РешениеОВозобновленииПроведенияВыезднойНалоговойПроверки;
			}
			else if(Ссылка == РешениеОПродленииИлиОтказеВПродленииСроковПредставленияДокументов)
			{
				return ВидыНалоговыхДокументов.РешениеОПродленииИлиОтказеВПродленииСроковПредставленияДокументов;
			}
			else if(Ссылка == РешениеОбОтложенииРассмотренияМатериаловНалоговойПроверкиВСвязиСНеявкойЛица)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтложенииРассмотренияМатериаловНалоговойПроверкиВСвязиСНеявкойЛица;
			}
			else if(Ссылка == СправкаОПроведеннойВыезднойНалоговойПроверке)
			{
				return ВидыНалоговыхДокументов.СправкаОПроведеннойВыезднойНалоговойПроверке;
			}
			else if(Ссылка == ПоручениеОбИстребованииДокументов)
			{
				return ВидыНалоговыхДокументов.ПоручениеОбИстребованииДокументов;
			}
			else if(Ссылка == УведомлениеОВызовеНалогоплательщика)
			{
				return ВидыНалоговыхДокументов.УведомлениеОВызовеНалогоплательщика;
			}
			else if(Ссылка == ТребованиеОПредставленииДокументов)
			{
				return ВидыНалоговыхДокументов.ТребованиеОПредставленииДокументов;
			}
			else if(Ссылка == РешениеОПроведенииДополнительныхМероприятийНалоговогоКонтроля)
			{
				return ВидыНалоговыхДокументов.РешениеОПроведенииДополнительныхМероприятийНалоговогоКонтроля;
			}
			else if(Ссылка == РешениеОПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения)
			{
				return ВидыНалоговыхДокументов.РешениеОПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения;
			}
			else if(Ссылка == РешениеОбОтказеВПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтказеВПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения;
			}
			else if(Ссылка == РешениеОПривлеченииКОтветственностиЗаНалоговоеПравонарушение)
			{
				return ВидыНалоговыхДокументов.РешениеОПривлеченииКОтветственностиЗаНалоговоеПравонарушение;
			}
			else if(Ссылка == РешениеОбОтказеВПривлеченииКОтветственностиЛицаЗаНалоговоеПравонарушение)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтказеВПривлеченииКОтветственностиЛицаЗаНалоговоеПравонарушение;
			}
			else if(Ссылка == РешениеОПриостановленииИсполненияРешенийФизЛицо)
			{
				return ВидыНалоговыхДокументов.РешениеОПриостановленииИсполненияРешенийФизЛицо;
			}
			else if(Ссылка == РешениеОВозобновленииИсполненияРешенийФизЛицо)
			{
				return ВидыНалоговыхДокументов.РешениеОВозобновленииИсполненияРешенийФизЛицо;
			}
			else if(Ссылка == РешениеОбОтменеРешенияОПривлеченииКОтветственностиФизЛица)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтменеРешенияОПривлеченииКОтветственностиФизЛица;
			}
			else if(Ссылка == ТребованиеОбУплатеНалогаСбораПениШтрафа)
			{
				return ВидыНалоговыхДокументов.ТребованиеОбУплатеНалогаСбораПениШтрафа;
			}
			else if(Ссылка == ТребованиеОбУплатеНалогаСбораПениШтрафаФизЛицу)
			{
				return ВидыНалоговыхДокументов.ТребованиеОбУплатеНалогаСбораПениШтрафаФизЛицу;
			}
			else if(Ссылка == ПлатежныйДокумент)
			{
				return ВидыНалоговыхДокументов.ПлатежныйДокумент;
			}
			else if(Ссылка == РешениеОВозмещенииНДС)
			{
				return ВидыНалоговыхДокументов.РешениеОВозмещенииНДС;
			}
			else if(Ссылка == РешениеОбОтказеВВозмещенииНДС)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтказеВВозмещенииНДС;
			}
			else if(Ссылка == РешениеОВозмещенииНДСЗаявительныйПорядок)
			{
				return ВидыНалоговыхДокументов.РешениеОВозмещенииНДСЗаявительныйПорядок;
			}
			else if(Ссылка == РешениеОбОтказеВВозмещенииНДСЗаявительныйПорядок)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтказеВВозмещенииНДСЗаявительныйПорядок;
			}
			else if(Ссылка == РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядок)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядок;
			}
			else if(Ссылка == РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядокУточненнаяДекларация)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядокУточненнаяДекларация;
			}
			else if(Ссылка == РешениеОВозмещенииСуммыАкциза)
			{
				return ВидыНалоговыхДокументов.РешениеОВозмещенииСуммыАкциза;
			}
			else if(Ссылка == РешениеОбОтказеВВозмещенииСуммыАкциза)
			{
				return ВидыНалоговыхДокументов.РешениеОбОтказеВВозмещенииСуммыАкциза;
			}
			else if(Ссылка == МотивированноеЗаключение)
			{
				return ВидыНалоговыхДокументов.МотивированноеЗаключение;
			}
			else if(Ссылка == СвидетельствоОПостановкеНаУчетРоссийскойОрганизации)
			{
				return ВидыНалоговыхДокументов.СвидетельствоОПостановкеНаУчетРоссийскойОрганизации;
			}
			else if(Ссылка == УведомлениеОПостановкеНаУчетРоссийскойОрганизации)
			{
				return ВидыНалоговыхДокументов.УведомлениеОПостановкеНаУчетРоссийскойОрганизации;
			}
			else if(Ссылка == УведомлениеОСнятииСУчетаРоссийскойОрганизации)
			{
				return ВидыНалоговыхДокументов.УведомлениеОСнятииСУчетаРоссийскойОрганизации;
			}
			else if(Ссылка == СвидетельствоОПостановкеНаУчетФизЛица)
			{
				return ВидыНалоговыхДокументов.СвидетельствоОПостановкеНаУчетФизЛица;
			}
			else if(Ссылка == УведомлениеОПостановкеНаУчетФизЛица)
			{
				return ВидыНалоговыхДокументов.УведомлениеОПостановкеНаУчетФизЛица;
			}
			else if(Ссылка == УведомлениеОСнятииСУчетаФизЛица)
			{
				return ВидыНалоговыхДокументов.УведомлениеОСнятииСУчетаФизЛица;
			}
			return ВидыНалоговыхДокументов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыНалоговыхДокументов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыНалоговыхДокументов Значение)
		{
			switch (Значение)
			{
				case ВидыНалоговыхДокументов.РешениеОПриостановленииПроведенияВыезднойНалоговойПроверки: return РешениеОПриостановленииПроведенияВыезднойНалоговойПроверки;
				case ВидыНалоговыхДокументов.РешениеОВозобновленииПроведенияВыезднойНалоговойПроверки: return РешениеОВозобновленииПроведенияВыезднойНалоговойПроверки;
				case ВидыНалоговыхДокументов.РешениеОПродленииИлиОтказеВПродленииСроковПредставленияДокументов: return РешениеОПродленииИлиОтказеВПродленииСроковПредставленияДокументов;
				case ВидыНалоговыхДокументов.РешениеОбОтложенииРассмотренияМатериаловНалоговойПроверкиВСвязиСНеявкойЛица: return РешениеОбОтложенииРассмотренияМатериаловНалоговойПроверкиВСвязиСНеявкойЛица;
				case ВидыНалоговыхДокументов.СправкаОПроведеннойВыезднойНалоговойПроверке: return СправкаОПроведеннойВыезднойНалоговойПроверке;
				case ВидыНалоговыхДокументов.ПоручениеОбИстребованииДокументов: return ПоручениеОбИстребованииДокументов;
				case ВидыНалоговыхДокументов.УведомлениеОВызовеНалогоплательщика: return УведомлениеОВызовеНалогоплательщика;
				case ВидыНалоговыхДокументов.ТребованиеОПредставленииДокументов: return ТребованиеОПредставленииДокументов;
				case ВидыНалоговыхДокументов.РешениеОПроведенииДополнительныхМероприятийНалоговогоКонтроля: return РешениеОПроведенииДополнительныхМероприятийНалоговогоКонтроля;
				case ВидыНалоговыхДокументов.РешениеОПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения: return РешениеОПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения;
				case ВидыНалоговыхДокументов.РешениеОбОтказеВПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения: return РешениеОбОтказеВПривлеченииКОтветственностиЗаСовершениеНалоговогоПравонарушения;
				case ВидыНалоговыхДокументов.РешениеОПривлеченииКОтветственностиЗаНалоговоеПравонарушение: return РешениеОПривлеченииКОтветственностиЗаНалоговоеПравонарушение;
				case ВидыНалоговыхДокументов.РешениеОбОтказеВПривлеченииКОтветственностиЛицаЗаНалоговоеПравонарушение: return РешениеОбОтказеВПривлеченииКОтветственностиЛицаЗаНалоговоеПравонарушение;
				case ВидыНалоговыхДокументов.РешениеОПриостановленииИсполненияРешенийФизЛицо: return РешениеОПриостановленииИсполненияРешенийФизЛицо;
				case ВидыНалоговыхДокументов.РешениеОВозобновленииИсполненияРешенийФизЛицо: return РешениеОВозобновленииИсполненияРешенийФизЛицо;
				case ВидыНалоговыхДокументов.РешениеОбОтменеРешенияОПривлеченииКОтветственностиФизЛица: return РешениеОбОтменеРешенияОПривлеченииКОтветственностиФизЛица;
				case ВидыНалоговыхДокументов.ТребованиеОбУплатеНалогаСбораПениШтрафа: return ТребованиеОбУплатеНалогаСбораПениШтрафа;
				case ВидыНалоговыхДокументов.ТребованиеОбУплатеНалогаСбораПениШтрафаФизЛицу: return ТребованиеОбУплатеНалогаСбораПениШтрафаФизЛицу;
				case ВидыНалоговыхДокументов.ПлатежныйДокумент: return ПлатежныйДокумент;
				case ВидыНалоговыхДокументов.РешениеОВозмещенииНДС: return РешениеОВозмещенииНДС;
				case ВидыНалоговыхДокументов.РешениеОбОтказеВВозмещенииНДС: return РешениеОбОтказеВВозмещенииНДС;
				case ВидыНалоговыхДокументов.РешениеОВозмещенииНДСЗаявительныйПорядок: return РешениеОВозмещенииНДСЗаявительныйПорядок;
				case ВидыНалоговыхДокументов.РешениеОбОтказеВВозмещенииНДСЗаявительныйПорядок: return РешениеОбОтказеВВозмещенииНДСЗаявительныйПорядок;
				case ВидыНалоговыхДокументов.РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядок: return РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядок;
				case ВидыНалоговыхДокументов.РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядокУточненнаяДекларация: return РешениеОбОтменеРешенияОВозмещенииНДСЗаявительныйПорядокУточненнаяДекларация;
				case ВидыНалоговыхДокументов.РешениеОВозмещенииСуммыАкциза: return РешениеОВозмещенииСуммыАкциза;
				case ВидыНалоговыхДокументов.РешениеОбОтказеВВозмещенииСуммыАкциза: return РешениеОбОтказеВВозмещенииСуммыАкциза;
				case ВидыНалоговыхДокументов.МотивированноеЗаключение: return МотивированноеЗаключение;
				case ВидыНалоговыхДокументов.СвидетельствоОПостановкеНаУчетРоссийскойОрганизации: return СвидетельствоОПостановкеНаУчетРоссийскойОрганизации;
				case ВидыНалоговыхДокументов.УведомлениеОПостановкеНаУчетРоссийскойОрганизации: return УведомлениеОПостановкеНаУчетРоссийскойОрганизации;
				case ВидыНалоговыхДокументов.УведомлениеОСнятииСУчетаРоссийскойОрганизации: return УведомлениеОСнятииСУчетаРоссийскойОрганизации;
				case ВидыНалоговыхДокументов.СвидетельствоОПостановкеНаУчетФизЛица: return СвидетельствоОПостановкеНаУчетФизЛица;
				case ВидыНалоговыхДокументов.УведомлениеОПостановкеНаУчетФизЛица: return УведомлениеОПостановкеНаУчетФизЛица;
				case ВидыНалоговыхДокументов.УведомлениеОСнятииСУчетаФизЛица: return УведомлениеОСнятииСУчетаФизЛица;
			}
			return Guid.Empty;
		}
	}
}
