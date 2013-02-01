﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class Номенклатура:СправочникМенеджер
	{

		public static СправочникиСсылка.Номенклатура НайтиПоКоду(decimal Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld2904 [Артикул]
					,_Fld2905 [НаименованиеПолное]
					,_Fld2906 [Весовой]
					,_Fld2907 [ВесовойКоэффициентВхождения]
					,_Fld2908 [ВестиОперативныйУчетОстатковНЗП]
					,_Fld2909 [ВестиПартионныйУчетПоСериям]
					,_Fld2910 [ВестиУчетПоСериям]
					,_Fld2911 [ВестиУчетПоСериямВНЗП]
					,_Fld2912 [ВестиУчетПоХарактеристикам]
					,_Fld2913RRef [ВидВоспроизводства]
					,_Fld2914RRef [ВидНоменклатуры]
					,_Fld2915RRef [ЕдиницаДляОтчетов]
					,_Fld2916RRef [ЕдиницаХраненияОстатков]
					,_Fld2917RRef [БазоваяЕдиницаИзмерения]
					,_Fld2918 [Набор]
					,_Fld2919RRef [НазначениеИспользования]
					,_Fld2920RRef [СтавкаНДС]
					,_Fld2921 [Комментарий]
					,_Fld2922RRef [НоменклатурнаяГруппаЗатрат]
					,_Fld2923 [Услуга]
					,_Fld2924RRef [ОсновноеИзображение]
					,_Fld2925RRef [ОсновнойПоставщик]
					,_Fld2926RRef [ОтветственныйМенеджерЗаПокупки]
					,_Fld2927RRef [НоменклатурнаяГруппа]
					,_Fld2928RRef [СтранаПроисхождения]
					,_Fld2929RRef [НомерГТД]
					,_Fld2930 [ТребуетсяВнешняяСертификация]
					,_Fld2931 [ТребуетсяВнутренняяСертификация]
					,_Fld2932RRef [СтатьяЗатрат]
					,_Fld2933 [ВестиСерийныеНомера]
					,_Fld2934 [Комплект]
					,_Fld2935RRef [НаправлениеВыпуска]
					,_Fld2936RRef [НаправлениеСписанияВыпущеннойПродукции]
					,_Fld2937RRef [ПорядокПрисвоенияСерийногоНомера]
					,_Fld2938RRef [ЦеноваяГруппа]
					,_Fld2939RRef [ОКП]
					,_Fld2940RRef [ЕдиницаИзмеренияМест]
					,_Fld2941 [ДополнительноеОписаниеНоменклатуры]
					,_Fld2942RRef [Производитель]
					,_Fld2943RRef [Импортер]
					From _Reference162(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Номенклатура();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Артикул = Читалка.GetString(6);
							Ссылка.НаименованиеПолное = Читалка.GetString(7);
							Ссылка.Весовой = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ВесовойКоэффициентВхождения = Читалка.GetDecimal(9);
							Ссылка.ВестиОперативныйУчетОстатковНЗП = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ВестиПартионныйУчетПоСериям = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ВестиУчетПоСериям = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.ВестиУчетПоСериямВНЗП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ВестиУчетПоХарактеристикам = ((byte[])Читалка.GetValue(14))[0]==1?true:false;
							Ссылка.ВидВоспроизводства = V82.Перечисления/*Ссылка*/.ВидыВоспроизводстваНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							//Ссылка.ВидНоменклатуры = new V82.СправочникиСсылка.ВидыНоменклатуры((byte[])Читалка.GetValue(16));
							//Ссылка.ЕдиницаДляОтчетов = new V82.СправочникиСсылка.ЕдиницыИзмерения((byte[])Читалка.GetValue(17));
							//Ссылка.ЕдиницаХраненияОстатков = new V82.СправочникиСсылка.ЕдиницыИзмерения((byte[])Читалка.GetValue(18));
							//Ссылка.БазоваяЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(19));
							Ссылка.Набор = ((byte[])Читалка.GetValue(20))[0]==1?true:false;
							//Ссылка.НазначениеИспользования = new V82.СправочникиСсылка.НазначенияИспользования((byte[])Читалка.GetValue(21));
							Ссылка.СтавкаНДС = V82.Перечисления/*Ссылка*/.СтавкиНДС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(22));
							Ссылка.Комментарий = Читалка.GetString(23);
							//Ссылка.НоменклатурнаяГруппаЗатрат = new V82.СправочникиСсылка.НоменклатурныеГруппы((byte[])Читалка.GetValue(24));
							Ссылка.Услуга = ((byte[])Читалка.GetValue(25))[0]==1?true:false;
							//Ссылка.ОсновноеИзображение = new V82.СправочникиСсылка.ХранилищеДополнительнойИнформации((byte[])Читалка.GetValue(26));
							//Ссылка.ОсновнойПоставщик = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(27));
							//Ссылка.ОтветственныйМенеджерЗаПокупки = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(28));
							//Ссылка.НоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы((byte[])Читалка.GetValue(29));
							//Ссылка.СтранаПроисхождения = new V82.СправочникиСсылка.КлассификаторСтранМира((byte[])Читалка.GetValue(30));
							//Ссылка.НомерГТД = new V82.СправочникиСсылка.НомераГТД((byte[])Читалка.GetValue(31));
							Ссылка.ТребуетсяВнешняяСертификация = ((byte[])Читалка.GetValue(32))[0]==1?true:false;
							Ссылка.ТребуетсяВнутренняяСертификация = ((byte[])Читалка.GetValue(33))[0]==1?true:false;
							//Ссылка.СтатьяЗатрат = new V82.СправочникиСсылка.СтатьиЗатрат((byte[])Читалка.GetValue(34));
							Ссылка.ВестиСерийныеНомера = ((byte[])Читалка.GetValue(35))[0]==1?true:false;
							Ссылка.Комплект = ((byte[])Читалка.GetValue(36))[0]==1?true:false;
							Ссылка.НаправлениеВыпуска = V82.Перечисления/*Ссылка*/.НаправленияВыпуска.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							//Ссылка.НаправлениеСписанияВыпущеннойПродукции = new V82.СправочникиСсылка.НаправленияСписанияВыпущеннойПродукции((byte[])Читалка.GetValue(38));
							//Ссылка.ПорядокПрисвоенияСерийногоНомера = new V82.СправочникиСсылка.ПорядокПрисвоенияСерийныхНомеров((byte[])Читалка.GetValue(39));
							//Ссылка.ЦеноваяГруппа = new V82.СправочникиСсылка.ЦеновыеГруппы((byte[])Читалка.GetValue(40));
							//Ссылка.ОКП = new V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции((byte[])Читалка.GetValue(41));
							//Ссылка.ЕдиницаИзмеренияМест = new V82.СправочникиСсылка.ЕдиницыИзмерения((byte[])Читалка.GetValue(42));
							Ссылка.ДополнительноеОписаниеНоменклатуры = Читалка.GetString(43);
							//Ссылка.Производитель = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(44));
							//Ссылка.Импортер = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(45));
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static СправочникиВыборка.Номенклатура Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование],_Fld2904 [Артикул],_Fld2905 [НаименованиеПолное],_Fld2906 [Весовой],_Fld2907 [ВесовойКоэффициентВхождения],_Fld2908 [ВестиОперативныйУчетОстатковНЗП],_Fld2909 [ВестиПартионныйУчетПоСериям],_Fld2910 [ВестиУчетПоСериям],_Fld2911 [ВестиУчетПоСериямВНЗП],_Fld2912 [ВестиУчетПоХарактеристикам],_Fld2913RRef [ВидВоспроизводства],_Fld2914RRef [ВидНоменклатуры],_Fld2915RRef [ЕдиницаДляОтчетов],_Fld2916RRef [ЕдиницаХраненияОстатков],_Fld2917RRef [БазоваяЕдиницаИзмерения],_Fld2918 [Набор],_Fld2919RRef [НазначениеИспользования],_Fld2920RRef [СтавкаНДС],_Fld2921 [Комментарий],_Fld2922RRef [НоменклатурнаяГруппаЗатрат],_Fld2923 [Услуга],_Fld2924RRef [ОсновноеИзображение],_Fld2925RRef [ОсновнойПоставщик],_Fld2926RRef [ОтветственныйМенеджерЗаПокупки],_Fld2927RRef [НоменклатурнаяГруппа],_Fld2928RRef [СтранаПроисхождения],_Fld2929RRef [НомерГТД],_Fld2930 [ТребуетсяВнешняяСертификация],_Fld2931 [ТребуетсяВнутренняяСертификация],_Fld2932RRef [СтатьяЗатрат],_Fld2933 [ВестиСерийныеНомера],_Fld2934 [Комплект],_Fld2935RRef [НаправлениеВыпуска],_Fld2936RRef [НаправлениеСписанияВыпущеннойПродукции],_Fld2937RRef [ПорядокПрисвоенияСерийногоНомера],_Fld2938RRef [ЦеноваяГруппа],_Fld2939RRef [ОКП],_Fld2940RRef [ЕдиницаИзмеренияМест],_Fld2941 [ДополнительноеОписаниеНоменклатуры],_Fld2942RRef [Производитель],_Fld2943RRef [Импортер]
		 From _Reference162(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Номенклатура();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Номенклатура();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Артикул = Читалка.GetString(6);
							Ссылка.НаименованиеПолное = Читалка.GetString(7);
							Ссылка.Весовой = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.ВесовойКоэффициентВхождения = Читалка.GetDecimal(9);
							Ссылка.ВестиОперативныйУчетОстатковНЗП = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.ВестиПартионныйУчетПоСериям = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.ВестиУчетПоСериям = ((byte[])Читалка.GetValue(12))[0]==1?true:false;
							Ссылка.ВестиУчетПоСериямВНЗП = ((byte[])Читалка.GetValue(13))[0]==1?true:false;
							Ссылка.ВестиУчетПоХарактеристикам = ((byte[])Читалка.GetValue(14))[0]==1?true:false;
							Ссылка.ВидВоспроизводства = V82.Перечисления/*Ссылка*/.ВидыВоспроизводстваНоменклатуры.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							//Ссылка.ВидНоменклатуры = new V82.СправочникиСсылка.ВидыНоменклатуры((byte[])Читалка.GetValue(16));
							//Ссылка.ЕдиницаДляОтчетов = new V82.СправочникиСсылка.ЕдиницыИзмерения((byte[])Читалка.GetValue(17));
							//Ссылка.ЕдиницаХраненияОстатков = new V82.СправочникиСсылка.ЕдиницыИзмерения((byte[])Читалка.GetValue(18));
							//Ссылка.БазоваяЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(19));
							Ссылка.Набор = ((byte[])Читалка.GetValue(20))[0]==1?true:false;
							//Ссылка.НазначениеИспользования = new V82.СправочникиСсылка.НазначенияИспользования((byte[])Читалка.GetValue(21));
							Ссылка.СтавкаНДС = V82.Перечисления/*Ссылка*/.СтавкиНДС.ПустаяСсылка.Получить((byte[])Читалка.GetValue(22));
							Ссылка.Комментарий = Читалка.GetString(23);
							//Ссылка.НоменклатурнаяГруппаЗатрат = new V82.СправочникиСсылка.НоменклатурныеГруппы((byte[])Читалка.GetValue(24));
							Ссылка.Услуга = ((byte[])Читалка.GetValue(25))[0]==1?true:false;
							//Ссылка.ОсновноеИзображение = new V82.СправочникиСсылка.ХранилищеДополнительнойИнформации((byte[])Читалка.GetValue(26));
							//Ссылка.ОсновнойПоставщик = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(27));
							//Ссылка.ОтветственныйМенеджерЗаПокупки = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(28));
							//Ссылка.НоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы((byte[])Читалка.GetValue(29));
							//Ссылка.СтранаПроисхождения = new V82.СправочникиСсылка.КлассификаторСтранМира((byte[])Читалка.GetValue(30));
							//Ссылка.НомерГТД = new V82.СправочникиСсылка.НомераГТД((byte[])Читалка.GetValue(31));
							Ссылка.ТребуетсяВнешняяСертификация = ((byte[])Читалка.GetValue(32))[0]==1?true:false;
							Ссылка.ТребуетсяВнутренняяСертификация = ((byte[])Читалка.GetValue(33))[0]==1?true:false;
							//Ссылка.СтатьяЗатрат = new V82.СправочникиСсылка.СтатьиЗатрат((byte[])Читалка.GetValue(34));
							Ссылка.ВестиСерийныеНомера = ((byte[])Читалка.GetValue(35))[0]==1?true:false;
							Ссылка.Комплект = ((byte[])Читалка.GetValue(36))[0]==1?true:false;
							Ссылка.НаправлениеВыпуска = V82.Перечисления/*Ссылка*/.НаправленияВыпуска.ПустаяСсылка.Получить((byte[])Читалка.GetValue(37));
							//Ссылка.НаправлениеСписанияВыпущеннойПродукции = new V82.СправочникиСсылка.НаправленияСписанияВыпущеннойПродукции((byte[])Читалка.GetValue(38));
							//Ссылка.ПорядокПрисвоенияСерийногоНомера = new V82.СправочникиСсылка.ПорядокПрисвоенияСерийныхНомеров((byte[])Читалка.GetValue(39));
							//Ссылка.ЦеноваяГруппа = new V82.СправочникиСсылка.ЦеновыеГруппы((byte[])Читалка.GetValue(40));
							//Ссылка.ОКП = new V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции((byte[])Читалка.GetValue(41));
							//Ссылка.ЕдиницаИзмеренияМест = new V82.СправочникиСсылка.ЕдиницыИзмерения((byte[])Читалка.GetValue(42));
							Ссылка.ДополнительноеОписаниеНоменклатуры = Читалка.GetString(43);
							//Ссылка.Производитель = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(44));
							//Ссылка.Импортер = new V82.СправочникиСсылка.Контрагенты((byte[])Читалка.GetValue(45));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.Номенклатура СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.Номенклатура();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Артикул = "";
			Объект.НаименованиеПолное = "";
			Объект.Комментарий = "";
			Объект.ДополнительноеОписаниеНоменклатуры = "";
			Объект.ВидВоспроизводства = V82.Перечисления/*Ссылка*/.ВидыВоспроизводстваНоменклатуры.ПустаяСсылка;
			Объект.ВидНоменклатуры = new V82.СправочникиСсылка.ВидыНоменклатуры();
			Объект.ЕдиницаДляОтчетов = new V82.СправочникиСсылка.ЕдиницыИзмерения();
			Объект.ЕдиницаХраненияОстатков = new V82.СправочникиСсылка.ЕдиницыИзмерения();
			Объект.БазоваяЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			Объект.НазначениеИспользования = new V82.СправочникиСсылка.НазначенияИспользования();
			Объект.СтавкаНДС = V82.Перечисления/*Ссылка*/.СтавкиНДС.ПустаяСсылка;
			Объект.НоменклатурнаяГруппаЗатрат = new V82.СправочникиСсылка.НоменклатурныеГруппы();
			Объект.ОсновноеИзображение = new V82.СправочникиСсылка.ХранилищеДополнительнойИнформации();
			Объект.ОсновнойПоставщик = new V82.СправочникиСсылка.Контрагенты();
			Объект.ОтветственныйМенеджерЗаПокупки = new V82.СправочникиСсылка.Пользователи();
			Объект.НоменклатурнаяГруппа = new V82.СправочникиСсылка.НоменклатурныеГруппы();
			Объект.СтранаПроисхождения = new V82.СправочникиСсылка.КлассификаторСтранМира();
			Объект.НомерГТД = new V82.СправочникиСсылка.НомераГТД();
			Объект.СтатьяЗатрат = new V82.СправочникиСсылка.СтатьиЗатрат();
			Объект.НаправлениеВыпуска = V82.Перечисления/*Ссылка*/.НаправленияВыпуска.ПустаяСсылка;
			Объект.НаправлениеСписанияВыпущеннойПродукции = new V82.СправочникиСсылка.НаправленияСписанияВыпущеннойПродукции();
			Объект.ПорядокПрисвоенияСерийногоНомера = new V82.СправочникиСсылка.ПорядокПрисвоенияСерийныхНомеров();
			Объект.ЦеноваяГруппа = new V82.СправочникиСсылка.ЦеновыеГруппы();
			Объект.ОКП = new V82.СправочникиСсылка.ОбщероссийскийКлассификаторПродукции();
			Объект.ЕдиницаИзмеренияМест = new V82.СправочникиСсылка.ЕдиницыИзмерения();
			Объект.Производитель = new V82.СправочникиСсылка.Контрагенты();
			Объект.Импортер = new V82.СправочникиСсылка.Контрагенты();
			return Объект;
		}
	}
}
