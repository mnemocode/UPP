﻿
using System;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	public enum ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете
	{
		ПустаяСсылка = - 1,
		НаСчетахРасходовНаОплатуТруда = 0,//На счетах расходов на оплату труда
		НаСчетахЗатратСоответствующихСчетамБухУчета = 1,//На счетах затрат, соответствующих счетам бух учета
	}
	public static partial class ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НаСчетахРасходовНаОплатуТруда = new Guid("0242628b-6399-79b2-4ed0-9d71ad143cd2");//На счетах расходов на оплату труда
		public static readonly Guid НаСчетахЗатратСоответствующихСчетамБухУчета = new Guid("aef7fdae-b506-5e95-4a34-f3c07b7ff848");//На счетах затрат, соответствующих счетам бух учета
		public static ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете Получить(this ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете Получить(this ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете Значение, Guid Ссылка)
		{
			if(Ссылка == НаСчетахРасходовНаОплатуТруда)
			{
				return ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете.НаСчетахРасходовНаОплатуТруда;
			}
			else if(Ссылка == НаСчетахЗатратСоответствующихСчетамБухУчета)
			{
				return ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете.НаСчетахЗатратСоответствующихСчетамБухУчета;
			}
			return ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете Значение)
		{
			switch (Значение)
			{
				case ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете.НаСчетахРасходовНаОплатуТруда: return НаСчетахРасходовНаОплатуТруда;
				case ВариантыУчетаРасходовПоНалогамСФОТВНалоговомУчете.НаСчетахЗатратСоответствующихСчетамБухУчета: return НаСчетахЗатратСоответствующихСчетамБухУчета;
			}
			return Guid.Empty;
		}
	}
}
