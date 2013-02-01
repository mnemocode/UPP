﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
		///<summary>
		///(регл)
		///</summary>
	public enum СлучаиУходаЗаБольнымиДетьми
	{
		ПустаяСсылка = - 1,
	///<summary>
	///Оплачивается по стажу весь б/л, до 31.12.2006 г.
	///</summary>
		ПоУходуДо3хЛет = 0,//До 3-х лет амбулаторно, до 15-ти лет в стационаре
	///<summary>
	///Оплачивается весь б/л, но через неделю - 50%
	///</summary>
		ПоУходуДо7миЛетДляСостоящихВБраке = 1,//От 3-х до 7-ми лет амбулаторно (для состоящего в браке родителя)
	///<summary>
	///Оплачивается весь б/л, но через 10 дней - 50%
	///</summary>
		ПоУходуДо7миЛетДляНеСостоящихВБраке = 2,//От 3-х до 7-ми лет амбулаторно (для не состоящего в браке родителя)
	///<summary>
	///Оплачивается две недели, вторая - 50%
	///</summary>
		ПоУходуДо15тиЛетДляСостоящихВБраке = 3,//От 7 до 15-ти лет амбулаторно (для состоящего в браке родителя)
	///<summary>
	///Оплачивается две недели, с 11-го дня - 50%
	///</summary>
		ПоУходуДо15тиЛетДляНеСостоящихВБраке = 4,//От 7 до 15-ти лет амбулаторно (для не состоящего в браке родителя)
	///<summary>
	///с 1.1.2007
	///</summary>
		ПоУходуДо7миЛетАмбулаторно = 5,//(09) До 7-ми лет, амбулаторно
	///<summary>
	///с 1.1.2007
	///</summary>
		ПоУходуДо7миЛетВСтационаре = 6,//(09) До 7-ми лет, в стационаре
		ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно = 7,//(12) До 7-ми лет, амбулаторно, заболевание включено в Перечень
		ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре = 8,//(12) До 7-ми лет, в стационаре, при заболевании, включенном в Перечень
		ПоУходуДо15тиЛетАмбулаторно = 9,//(09) От 7 до 15-ти лет, амбулаторно
		ПоУходуДо15тиЛетВСтационаре = 10,//(09) От 7 до 15-ти лет, в стационаре
		ПоУходуЗаРебенкомИнвалидомАмбулаторно = 11,//(13) Инвалидом до 15-ти лет, амбулаторно
		ПоУходуЗаРебенкомИнвалидомВСтационаре = 12,//(13) Инвалидом до 15-ти лет, в стационаре
		ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно = 13,//(14) До 15-ти лет при поствакцинальном осложнении, амбулаторно
		ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре = 14,//(14) До 15-ти лет при поствакцинальном осложнении, в стационаре
		ПоУходуДо15тиЛетПриВИЧ = 15,//(15) До 15-ти лет, ВИЧ-инфицированным, в стационаре
	}
	public static partial class СлучаиУходаЗаБольнымиДетьми_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///Оплачивается по стажу весь б/л, до 31.12.2006 г.
		///</summary>
		public static readonly Guid ПоУходуДо3хЛет = new Guid("7b5e3a97-4c18-5040-434b-c82556aa3ea4");//До 3-х лет амбулаторно, до 15-ти лет в стационаре
		///<summary>
		///Оплачивается весь б/л, но через неделю - 50%
		///</summary>
		public static readonly Guid ПоУходуДо7миЛетДляСостоящихВБраке = new Guid("a6e10c9a-5bf1-26d7-45c5-a6b7d7e9bb8e");//От 3-х до 7-ми лет амбулаторно (для состоящего в браке родителя)
		///<summary>
		///Оплачивается весь б/л, но через 10 дней - 50%
		///</summary>
		public static readonly Guid ПоУходуДо7миЛетДляНеСостоящихВБраке = new Guid("87c80993-4c9e-d112-4b1f-1b30b1b2cacb");//От 3-х до 7-ми лет амбулаторно (для не состоящего в браке родителя)
		///<summary>
		///Оплачивается две недели, вторая - 50%
		///</summary>
		public static readonly Guid ПоУходуДо15тиЛетДляСостоящихВБраке = new Guid("f514ec97-aad9-53d1-4ec5-557ea2304756");//От 7 до 15-ти лет амбулаторно (для состоящего в браке родителя)
		///<summary>
		///Оплачивается две недели, с 11-го дня - 50%
		///</summary>
		public static readonly Guid ПоУходуДо15тиЛетДляНеСостоящихВБраке = new Guid("4be76080-d508-0573-4493-021b1526a627");//От 7 до 15-ти лет амбулаторно (для не состоящего в браке родителя)
		///<summary>
		///с 1.1.2007
		///</summary>
		public static readonly Guid ПоУходуДо7миЛетАмбулаторно = new Guid("1ac061be-4c31-e304-46ac-2816cbf6cd8a");//(09) До 7-ми лет, амбулаторно
		///<summary>
		///с 1.1.2007
		///</summary>
		public static readonly Guid ПоУходуДо7миЛетВСтационаре = new Guid("ff56198d-d2f8-13b9-48ae-80d85c5639d2");//(09) До 7-ми лет, в стационаре
		public static readonly Guid ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно = new Guid("11cb4489-3b3b-4430-4d82-3692cc3ef87b");//(12) До 7-ми лет, амбулаторно, заболевание включено в Перечень
		public static readonly Guid ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре = new Guid("dd674b9f-9a77-eef1-4081-32bfc1666607");//(12) До 7-ми лет, в стационаре, при заболевании, включенном в Перечень
		public static readonly Guid ПоУходуДо15тиЛетАмбулаторно = new Guid("fc0b4288-2bcc-71e3-4a0f-ecfdc30bc644");//(09) От 7 до 15-ти лет, амбулаторно
		public static readonly Guid ПоУходуДо15тиЛетВСтационаре = new Guid("eccbb892-e57e-cf00-4890-2b0c1b70b261");//(09) От 7 до 15-ти лет, в стационаре
		public static readonly Guid ПоУходуЗаРебенкомИнвалидомАмбулаторно = new Guid("b80253b2-8c52-0108-4683-43afb3ceff46");//(13) Инвалидом до 15-ти лет, амбулаторно
		public static readonly Guid ПоУходуЗаРебенкомИнвалидомВСтационаре = new Guid("53dd1ba3-26f0-0e84-4822-5d64d655568c");//(13) Инвалидом до 15-ти лет, в стационаре
		public static readonly Guid ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно = new Guid("3e207faf-a63d-8146-4129-ec719947950d");//(14) До 15-ти лет при поствакцинальном осложнении, амбулаторно
		public static readonly Guid ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре = new Guid("40104c90-6e80-40b6-4d06-601c435c5ffd");//(14) До 15-ти лет при поствакцинальном осложнении, в стационаре
		public static readonly Guid ПоУходуДо15тиЛетПриВИЧ = new Guid("7549a195-4b18-bedf-412f-2aa5bfe772d0");//(15) До 15-ти лет, ВИЧ-инфицированным, в стационаре
		public static СлучаиУходаЗаБольнымиДетьми Получить(this СлучаиУходаЗаБольнымиДетьми Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static СлучаиУходаЗаБольнымиДетьми Получить(this СлучаиУходаЗаБольнымиДетьми Значение, Guid Ссылка)
		{
			if(Ссылка == ПоУходуДо3хЛет)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо3хЛет;
			}
			else if(Ссылка == ПоУходуДо7миЛетДляСостоящихВБраке)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетДляСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо7миЛетДляНеСостоящихВБраке)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетДляНеСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо15тиЛетДляСостоящихВБраке)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетДляСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо15тиЛетДляНеСостоящихВБраке)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетДляНеСостоящихВБраке;
			}
			else if(Ссылка == ПоУходуДо7миЛетАмбулаторно)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетАмбулаторно;
			}
			else if(Ссылка == ПоУходуДо7миЛетВСтационаре)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетВСтационаре;
			}
			else if(Ссылка == ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно;
			}
			else if(Ссылка == ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре;
			}
			else if(Ссылка == ПоУходуДо15тиЛетАмбулаторно)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетАмбулаторно;
			}
			else if(Ссылка == ПоУходуДо15тиЛетВСтационаре)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетВСтационаре;
			}
			else if(Ссылка == ПоУходуЗаРебенкомИнвалидомАмбулаторно)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуЗаРебенкомИнвалидомАмбулаторно;
			}
			else if(Ссылка == ПоУходуЗаРебенкомИнвалидомВСтационаре)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуЗаРебенкомИнвалидомВСтационаре;
			}
			else if(Ссылка == ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно;
			}
			else if(Ссылка == ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре;
			}
			else if(Ссылка == ПоУходуДо15тиЛетПриВИЧ)
			{
				return СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриВИЧ;
			}
			return СлучаиУходаЗаБольнымиДетьми.ПустаяСсылка;
		}
		public static byte[] Ключ(this СлучаиУходаЗаБольнымиДетьми Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this СлучаиУходаЗаБольнымиДетьми Значение)
		{
			switch (Значение)
			{
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо3хЛет: return ПоУходуДо3хЛет;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетДляСостоящихВБраке: return ПоУходуДо7миЛетДляСостоящихВБраке;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетДляНеСостоящихВБраке: return ПоУходуДо7миЛетДляНеСостоящихВБраке;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетДляСостоящихВБраке: return ПоУходуДо15тиЛетДляСостоящихВБраке;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетДляНеСостоящихВБраке: return ПоУходуДо15тиЛетДляНеСостоящихВБраке;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетАмбулаторно: return ПоУходуДо7миЛетАмбулаторно;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетВСтационаре: return ПоУходуДо7миЛетВСтационаре;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно: return ПоУходуДо7миЛетПриОсобомЗаболеванииАмбулаторно;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре: return ПоУходуДо7миЛетПриОсобомЗаболеванииВСтационаре;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетАмбулаторно: return ПоУходуДо15тиЛетАмбулаторно;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетВСтационаре: return ПоУходуДо15тиЛетВСтационаре;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуЗаРебенкомИнвалидомАмбулаторно: return ПоУходуЗаРебенкомИнвалидомАмбулаторно;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуЗаРебенкомИнвалидомВСтационаре: return ПоУходуЗаРебенкомИнвалидомВСтационаре;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно: return ПоУходуДо15тиЛетПриПоствакцинальномОсложненииАмбулаторно;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре: return ПоУходуДо15тиЛетПриПоствакцинальномОсложненииВСтационаре;
				case СлучаиУходаЗаБольнымиДетьми.ПоУходуДо15тиЛетПриВИЧ: return ПоУходуДо15тиЛетПриВИЧ;
			}
			return Guid.Empty;
		}
	}
}
