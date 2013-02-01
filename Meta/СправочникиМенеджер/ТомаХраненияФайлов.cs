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
	///<summary>
	///Каталоги на диске для хранения файлов
	///</summary>
	public partial class ТомаХраненияФайлов:СправочникМенеджер
	{

		public static СправочникиСсылка.ТомаХраненияФайлов НайтиПоКоду(decimal Код)
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
					,_Fld3985 [Комментарий]
					,_Fld3986 [МаксимальныйРазмер]
					,_Fld3987 [ПолныйПутьLinux]
					,_Fld3988 [ПолныйПутьWindows]
					,_Fld3989 [ПорядокЗаполнения]
					From _Reference271(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТомаХраненияФайлов();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.МаксимальныйРазмер = Читалка.GetDecimal(7);
							Ссылка.ПолныйПутьLinux = Читалка.GetString(8);
							Ссылка.ПолныйПутьWindows = Читалка.GetString(9);
							Ссылка.ПорядокЗаполнения = Читалка.GetDecimal(10);
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

		public static СправочникиВыборка.ТомаХраненияФайлов Выбрать()
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
					,_Description [Наименование],_Fld3985 [Комментарий],_Fld3986 [МаксимальныйРазмер],_Fld3987 [ПолныйПутьLinux],_Fld3988 [ПолныйПутьWindows],_Fld3989 [ПорядокЗаполнения]
		 From _Reference271(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТомаХраненияФайлов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТомаХраненияФайлов();
		
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.МаксимальныйРазмер = Читалка.GetDecimal(7);
							Ссылка.ПолныйПутьLinux = Читалка.GetString(8);
							Ссылка.ПолныйПутьWindows = Читалка.GetString(9);
							Ссылка.ПорядокЗаполнения = Читалка.GetDecimal(10);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ТомаХраненияФайлов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ТомаХраненияФайлов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.ПолныйПутьLinux = "";
			Объект.ПолныйПутьWindows = "";
			return Объект;
		}
	}
}
