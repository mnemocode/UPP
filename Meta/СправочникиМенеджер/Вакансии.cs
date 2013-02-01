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
	public partial class Вакансии:СправочникМенеджер
	{

		public static СправочникиСсылка.Вакансии НайтиПоКоду(decimal Код)
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
					,_Fld1872 [Закрыта]
					,_Fld1873RRef [Должность]
					,_Fld1874RRef [Заявитель]
					,_Fld1875 [Обязанности]
					,_Fld1876RRef [Организация]
					,_Fld1877RRef [Ответственный]
					,_Fld1878 [ПлановаяДатаЗакрытия]
					,_Fld1879RRef [Подразделение]
					,_Fld1880 [Требования]
					,_Fld1881 [Условия]
					,_Fld1882 [ДатаОткрытия]
					,_Fld1883 [ДатаЗакрытия]
					From _Reference39(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Вакансии();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Закрыта = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							//Ссылка.Должность = new V82.СправочникиСсылка.Должности((byte[])Читалка.GetValue(7));
							//Ссылка.Заявитель = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(8));
							Ссылка.Обязанности = Читалка.GetString(9);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(10));
							//Ссылка.Ответственный = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(11));
							Ссылка.ПлановаяДатаЗакрытия = Читалка.GetDateTime(12);
							Ссылка.Требования = Читалка.GetString(14);
							Ссылка.Условия = Читалка.GetString(15);
							Ссылка.ДатаОткрытия = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
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

		public static СправочникиВыборка.Вакансии Выбрать()
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
					,_Description [Наименование],_Fld1872 [Закрыта],_Fld1873RRef [Должность],_Fld1874RRef [Заявитель],_Fld1875 [Обязанности],_Fld1876RRef [Организация],_Fld1877RRef [Ответственный],_Fld1878 [ПлановаяДатаЗакрытия],_Fld1879RRef [Подразделение],_Fld1880 [Требования],_Fld1881 [Условия],_Fld1882 [ДатаОткрытия],_Fld1883 [ДатаЗакрытия]
		 From _Reference39(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.Вакансии();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.Вакансии();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Закрыта = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							//Ссылка.Должность = new V82.СправочникиСсылка.Должности((byte[])Читалка.GetValue(7));
							//Ссылка.Заявитель = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(8));
							Ссылка.Обязанности = Читалка.GetString(9);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(10));
							//Ссылка.Ответственный = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(11));
							Ссылка.ПлановаяДатаЗакрытия = Читалка.GetDateTime(12);
							Ссылка.Требования = Читалка.GetString(14);
							Ссылка.Условия = Читалка.GetString(15);
							Ссылка.ДатаОткрытия = Читалка.GetDateTime(16);
							Ссылка.ДатаЗакрытия = Читалка.GetDateTime(17);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.Вакансии СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.Вакансии();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Обязанности = "";
			Объект.Требования = "";
			Объект.Условия = "";
			Объект.Должность = new V82.СправочникиСсылка.Должности();
			Объект.Заявитель = new V82.СправочникиСсылка.Пользователи();
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			Объект.Ответственный = new V82.СправочникиСсылка.Пользователи();
			return Объект;
		}
	}
}
