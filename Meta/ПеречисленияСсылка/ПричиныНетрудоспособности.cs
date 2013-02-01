﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(Регл)
		///</summary>
	public enum ПричиныНетрудоспособности
	{
		ПустаяСсылка = - 1,
		ОбщееЗаболевание = 0,//(01, 02, 10, 11) Заболевание или травма (кроме травм на производстве)
		ПоБеременностиИРодам = 1,//(05) Отпуск по беременности и родам
		ТравмаНаПроизводстве = 2,//(04, 07) Травма на производстве, профзаболевание
		ТравмаВБыту = 3,//Травма в быту
		ПособиеБезЗаболевания = 4,//При карантине, по уходу за взрослым членом семьи и др.
	///<summary>
	///Оплачивается по стажу весь б/л
	///</summary>
		ПоУходуДо3хЛет = 5,//По уходу до 3-х лет (или в стационаре)
	///<summary>
	///Оплачивается весь б/л, но через неделю - 50%
	///</summary>
		ПоУходуДо7миЛетДляСостоящихВБраке = 6,//По уходу за ребенком с 3-х до 7-ми лет (для состоящего в браке родителя)
	///<summary>
	///Оплачивается весь б/л, но через 10 дней - 50%
	///</summary>
		ПоУходуДо7миЛетДляНеСостоящихВБраке = 7,//По уходу за ребенком с 3-х до 7-ми лет (для не состоящего в браке родителя)
	///<summary>
	///Оплачивается две недели, вторая - 50%
	///</summary>
		ПоУходуДо15тиЛетДляСостоящихВБраке = 8,//По уходу за ребенком с 7-ми до 15-ти лет (для состоящего в браке родителя)
	///<summary>
	///Оплачивается две недели, с 11-го дня - 50%
	///</summary>
		ПоУходуДо15тиЛетДляНеСостоящихВБраке = 9,//По уходу за ребенком с 7-ми до 15-ти лет (для не состоящего в браке родителя)
		ПоУходуЗаРебенком = 10,//(09, 12, 13, 14, 15) Уход за больным ребенком
		ПоУходуЗаВзрослым = 11,//(09) Уход за больным взрослым членом семьи
		Карантин = 12,//(03) Карантин
		Протезирование = 13,//(06) Протезирование в стационаре
		ПособиеПриДолечивании = 14,//(08) Долечивание в санаторно-курортных учреждениях
	}
	public static partial class ПричиныНетрудоспособности_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ОбщееЗаболевание = new Guid("cfe1cca4-9ceb-ddc3-4fc2-9efe182989b6");//(01, 02, 10, 11) Заболевание или травма (кроме травм на производстве)
		public static readonly Guid ПоБеременностиИРодам = new Guid("745d3e88-b18f-46d9-4df9-26a39acc3d42");//(05) Отпуск по беременности и родам
		public static readonly Guid ТравмаНаПроизводстве = new Guid("81b8c8b2-bc82-afc8-4e8f-21ac60cc1a32");//(04, 07) Травма на производстве, профзаболевание
		public static readonly Guid ТравмаВБыту = new Guid("13f534b8-9f4b-4838-4459-8b1c5c3dd150");//Травма в быту
		public static readonly Guid ПособиеБезЗаболевания = new Guid("259b5888-0ed4-be57-43a3-243e962ca81d");//При карантине, по уходу за взрослым членом семьи и др.
		///<summary>
		///Оплачивается по стажу весь б/л
		///</summary>
		public static readonly Guid ПоУходуДо3хЛет = new Guid("04ddd6a1-f05c-a05b-4112-d5d4d3b5c0ce");//По уходу до 3-х лет (или в стационаре)
		///<summary>
		///Оплачивается весь б/л, но через неделю - 50%
		///</summary>
		public static readonly Guid ПоУходуДо7миЛетДляСостоящихВБраке = new Guid("275f749f-6078-17e9-4996-876d63e611bc");//По уходу за ребенком с 3-х до 7-ми лет (для состоящего в браке родителя)
		///<summary>
		///Оплачивается весь б/л, но через 10 дней - 50%
		///</summary>
		public static readonly Guid ПоУходуДо7миЛетДляНеСостоящихВБраке = new Guid("0c2c93b3-7393-1ab1-4683-2239734bffce");//По уходу за ребенком с 3-х до 7-ми лет (для не состоящего в браке родителя)
		///<summary>
		///Оплачивается две недели, вторая - 50%
		///</summary>
		public static readonly Guid ПоУходуДо15тиЛетДляСостоящихВБраке = new Guid("52bee6a4-8911-e759-4bec-9c22b5167df3");//По уходу за ребенком с 7-ми до 15-ти лет (для состоящего в браке родителя)
		///<summary>
		///Оплачивается две недели, с 11-го дня - 50%
		///</summary>
		public static readonly Guid ПоУходуДо15тиЛетДляНеСостоящихВБраке = new Guid("8806b59c-9d61-91cb-4ed7-e3effe80094a");//По уходу за ребенком с 7-ми до 15-ти лет (для не состоящего в браке родителя)
		public static readonly Guid ПоУходуЗаРебенком = new Guid("c1e924bf-8ed0-76c8-440d-19cce58a38af");//(09, 12, 13, 14, 15) Уход за больным ребенком
		public static readonly Guid ПоУходуЗаВзрослым = new Guid("e3747089-1b86-d872-45ef-4f74f420537c");//(09) Уход за больным взрослым членом семьи
		public static readonly Guid Карантин = new Guid("c0a0b0a4-6bfd-2cac-475d-fcbf642c9472");//(03) Карантин
		public static readonly Guid Протезирование = new Guid("4c8a1a8c-51ec-9d7a-4c2d-74f00d0074df");//(06) Протезирование в стационаре
		public static readonly Guid ПособиеПриДолечивании = new Guid("5b149aa8-1343-9e70-42cd-c938cb2af6e0");//(08) Долечивание в санаторно-курортных учреждениях
		public static ПричиныНетрудоспособности Получить(this ПричиныНетрудоспособности Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПричиныНетрудоспособности Получить(this ПричиныНетрудоспособности Значение, Guid Ссылка)
		{
			if(Ссылка == ОбщееЗаболевание)
			{
				return ПричиныНетрудоспособности.ОбщееЗаболевание;
			}
			else if(Ссылка == ПоБеременностиИРодам)
			{
				return ПричиныНетрудоспособности.ПоБеременностиИРодам;
			}
			else if(Ссылка == ТравмаНаПроизводстве)
			{
				return ПричиныНетрудоспособности.ТравмаНаПроизводстве;
			}
			else if(Ссылка == ТравмаВБыту)
			{
				return ПричиныНетрудоспособности.ТравмаВБыту;
			}
			else if(Ссылка == ПособиеБезЗаболевания)
			{
				return ПричиныНетрудоспособности.ПособиеБезЗаболевания;
			}
			else if(Ссылка == ПоУходуДо3хЛет)
			{
				return ПричиныНетрудоспособности.ПоУходуДо3хЛет;
			}
			else if(Ссылка == ПоУходуДо7миЛетДляСостоящихВБраке)
			{
				return ПричиныНетрудоспособности.ПоУходуДо7миЛетДляСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо7миЛетДляНеСостоящихВБраке)
			{
				return ПричиныНетрудоспособности.ПоУходуДо7миЛетДляНеСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо15тиЛетДляСостоящихВБраке)
			{
				return ПричиныНетрудоспособности.ПоУходуДо15тиЛетДляСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо15тиЛетДляНеСостоящихВБраке)
			{
				return ПричиныНетрудоспособности.ПоУходуДо15тиЛетДляНеСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуЗаРебенком)
			{
				return ПричиныНетрудоспособности.ПоУходуЗаРебенком;
			}
			else if(Ссылка == ПоУходуЗаВзрослым)
			{
				return ПричиныНетрудоспособности.ПоУходуЗаВзрослым;
			}
			else if(Ссылка == Карантин)
			{
				return ПричиныНетрудоспособности.Карантин;
			}
			else if(Ссылка == Протезирование)
			{
				return ПричиныНетрудоспособности.Протезирование;
			}
			else if(Ссылка == ПособиеПриДолечивании)
			{
				return ПричиныНетрудоспособности.ПособиеПриДолечивании;
			}
			return ПричиныНетрудоспособности.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПричиныНетрудоспособности Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПричиныНетрудоспособности Значение)
		{
			switch (Значение)
			{
				case ПричиныНетрудоспособности.ОбщееЗаболевание: return ОбщееЗаболевание;
				case ПричиныНетрудоспособности.ПоБеременностиИРодам: return ПоБеременностиИРодам;
				case ПричиныНетрудоспособности.ТравмаНаПроизводстве: return ТравмаНаПроизводстве;
				case ПричиныНетрудоспособности.ТравмаВБыту: return ТравмаВБыту;
				case ПричиныНетрудоспособности.ПособиеБезЗаболевания: return ПособиеБезЗаболевания;
				case ПричиныНетрудоспособности.ПоУходуДо3хЛет: return ПоУходуДо3хЛет;
				case ПричиныНетрудоспособности.ПоУходуДо7миЛетДляСостоящихВБраке: return ПоУходуДо7миЛетДляСостоящихВБраке;
				case ПричиныНетрудоспособности.ПоУходуДо7миЛетДляНеСостоящихВБраке: return ПоУходуДо7миЛетДляНеСостоящихВБраке;
				case ПричиныНетрудоспособности.ПоУходуДо15тиЛетДляСостоящихВБраке: return ПоУходуДо15тиЛетДляСостоящихВБраке;
				case ПричиныНетрудоспособности.ПоУходуДо15тиЛетДляНеСостоящихВБраке: return ПоУходуДо15тиЛетДляНеСостоящихВБраке;
				case ПричиныНетрудоспособности.ПоУходуЗаРебенком: return ПоУходуЗаРебенком;
				case ПричиныНетрудоспособности.ПоУходуЗаВзрослым: return ПоУходуЗаВзрослым;
				case ПричиныНетрудоспособности.Карантин: return Карантин;
				case ПричиныНетрудоспособности.Протезирование: return Протезирование;
				case ПричиныНетрудоспособности.ПособиеПриДолечивании: return ПособиеПриДолечивании;
			}
			return Guid.Empty;
		}
	}
}
