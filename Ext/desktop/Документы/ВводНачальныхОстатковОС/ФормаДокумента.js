﻿Ext.require(['Данные.Документы.ВводНачальныхОстатковОС'], function () 
{
	Ext.define('Документы.ВводНачальныхОстатковОС.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:654px;height:420px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Ввод начальных остатков ОС',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:96px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:178px;top:33px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'Дата',
			width: 120,
			height: 19,
			style: 'position:absolute;left:196px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:368px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 556,
			height: 19,
			style: 'position:absolute;left:90px;top:368px;width:556px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:96px;top:57px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'checkbox',
			boxLabel: 'упр. учете',
			style: 'position:absolute;left:426px;top:33px;width:68px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'бух. учете',
			style: 'position:absolute;left:497px;top:33px;width:69px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:654px;height:25px;',
			width: 654,
			height: 25,
			items:
			[
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'Движения документа по регистрам',
					tooltip:'',
				},
				{
					text:'',
					tooltip:'',
				},
				'-',
					]
				},
				'-',
				{
					text:'',
					tooltip:'Открыть свойства',
				},
				{
					text:'',
					tooltip:'Открыть категории',
				},
				'-',
				{
					text:'Дт/кт',
					tooltip:'Проводки БУ',
				},
				{
					text:'Дт/кт',
					tooltip:'Проводки НУ',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОтражать',
			text: 'Отражать:',
			style: 'position:absolute;left:336px;top:33px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'налог. учете',
			style: 'position:absolute;left:566px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПодразделениеОрганизации',
			text: 'Подразделение организации:',
			style: 'position:absolute;left:336px;top:53px;width:88px;height:27px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			trigger2Cls: 'x-form-select-trigger',
			trigger3Cls: 'x-form-search-trigger',
			name: 'ПодразделениеОрганизации.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:426px;top:57px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'НадписьПодразделение',
			text: 'Подразделение:',
			style: 'position:absolute;left:338px;top:81px;width:88px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Подразделение.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:426px;top:81px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'panel',
			style: 'position:absolute;left:8px;top:108px;width:638px;height:252px;',
			height: 252,width: 638,
			items:
			[
				{
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:624px;height:24px;',
			width: 624,
			height: 24,
			items:
			[
				{
					text:'По группе ОС',
					tooltip:'Заполнить по группе ОС',
				},
				{
					text:'По наименованию',
					tooltip:'Заполнить табличную часть элементами справочника с одинаковыми наименованиями',
				},
			]
		},
		{
			id: 'ОС',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:31px;width:624px;height:195px;',
			height: 195,width: 624,
			columns:
			[
				{
					text:'N',
					width:'43',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Инв. номер',
					width:'54',
					dataIndex:'ИнвентарныйНомер',
					flex:1,
				},
				{
					text:'Основное средство',
					width:'122',
					dataIndex:'ОсновноеСредство',
					flex:1,
				},
				{
					text:'Инв. номер (Регл)',
					width:'85',
					dataIndex:'ИнвентарныйНомерРегл',
					flex:1,
				},
				{
					text:'Дата принятия к учету',
					width:'35',
					dataIndex:'ДатаПринятияКУчету',
					flex:1,
				},
				{
					text:'Событие принятия к учету',
					width:'55',
					dataIndex:'СобытиеПринятияКУчету',
					flex:1,
				},
				{
					text:'Название документа принятия к учету',
					width:'55',
					dataIndex:'НазваниеДокументаПринятияКУчету',
					flex:1,
				},
				{
					text:'Номер документа принятия к учету',
					width:'55',
					dataIndex:'НомерДокументаПринятияКУчету',
					flex:1,
				},
				{
					text:'Дата принятия к учету (Регл)',
					width:'61',
					dataIndex:'ДатаПринятияКУчетуРегл',
					flex:1,
				},
				{
					text:'Событие принятия к учету (Регл)',
					width:'61',
					dataIndex:'СобытиеПринятияКУчетуРегл',
					flex:1,
				},
				{
					text:'Название документа принятия к учету (Регл)',
					width:'61',
					dataIndex:'НазваниеДокументаПринятияКУчетуРегл',
					flex:1,
				},
				{
					text:'Номер документа принятия к учету (Регл)',
					width:'61',
					dataIndex:'НомерДокументаПринятияКУчетуРегл',
					flex:1,
				},
				{
					text:'Способ поступления (БУ)',
					width:'100',
					dataIndex:'СпособПоступленияБУ',
					flex:1,
				},
				{
					text:'Дата ввода в эксплуатацию',
					width:'56',
					dataIndex:'ДатаВводаВЭксплуатацию',
					flex:1,
				},
				{
					text:'Событие ввода в эксплуатацию',
					width:'56',
					dataIndex:'СобытиеВводВЭксплуатацию',
					flex:1,
				},
				{
					text:'Название документа ввода в эксплуатацию',
					width:'56',
					dataIndex:'НазваниеДокументаВводаВЭксплуатацию',
					flex:1,
				},
				{
					text:'Номер документа ввода в эксплуатацию',
					width:'56',
					dataIndex:'НомерДокументаВводаВЭксплуатацию',
					flex:1,
				},
				{
					text:'Дата ввода в эксплуатацию (Регл)',
					width:'56',
					dataIndex:'ДатаВводаВЭксплуатациюРегл',
					flex:1,
				},
				{
					text:'Событие ввода в эксплуатацию (Регл)',
					width:'56',
					dataIndex:'СобытиеВводВЭксплуатациюРегл',
					flex:1,
				},
				{
					text:'Название документа ввода в эксплуатацию (Регл)',
					width:'56',
					dataIndex:'НазваниеДокументаВводаВЭксплуатациюРегл',
					flex:1,
				},
				{
					text:'Номер документа ввода в эксплуатацию (Регл)',
					width:'56',
					dataIndex:'НомерДокументаВводаВЭксплуатациюРегл',
					flex:1,
				},
				{
					text:'Списать на затраты при вводе',
					width:'100',
					dataIndex:'СписатьНаЗатратыПриВводе',
					flex:1,
				},
				{
					text:'Списать на затраты при вводе (БУ)',
					width:'100',
					dataIndex:'СписатьНаЗатратыПриВводеРегл',
					flex:1,
				},
				{
					text:'Первоначальная стоимость',
					width:'100',
					dataIndex:'ПервоначальнаяСтоимость',
					flex:1,
				},
				{
					text:'Текущая стоимость',
					width:'100',
					dataIndex:'ТекущаяСтоимость',
					flex:1,
				},
				{
					text:'Накопленная амортизация',
					width:'100',
					dataIndex:'НакопленнаяАмортизация',
					flex:1,
				},
				{
					text:'Первоначальная стоимость (БУ)',
					width:'100',
					dataIndex:'ПервоначальнаяСтоимостьБУ',
					flex:1,
				},
				{
					text:'Текущая стоимость (БУ)',
					width:'100',
					dataIndex:'ТекущаяСтоимостьБУ',
					flex:1,
				},
				{
					text:'Накопленная амортизация (БУ)',
					width:'100',
					dataIndex:'НакопленнаяАмортизацияБУ',
					flex:1,
				},
				{
					text:'Первоначальная стоимость (НУ)',
					width:'100',
					dataIndex:'ПервоначальнаяСтоимостьНУ',
					flex:1,
				},
				{
					text:'Текущая стоимость (НУ)',
					width:'100',
					dataIndex:'ТекущаяСтоимостьНУ',
					flex:1,
				},
				{
					text:'Накопленная амортизация (НУ)',
					width:'100',
					dataIndex:'НакопленнаяАмортизацияНУ',
					flex:1,
				},
				{
					text:'Счет учета (БУ)',
					width:'100',
					dataIndex:'СчетУчетаБУ',
					flex:1,
				},
				{
					text:'Счет амортизации (БУ)',
					width:'100',
					dataIndex:'СчетАмортизацииБУ',
					flex:1,
				},
				{
					text:'Счет учета (НУ)',
					width:'100',
					dataIndex:'СчетУчетаНУ',
					flex:1,
				},
				{
					text:'Счет амортизации (НУ)',
					width:'100',
					dataIndex:'СчетАмортизацииНУ',
					flex:1,
				},
				{
					text:'МОЛ',
					width:'100',
					dataIndex:'МОЛ',
					flex:1,
				},
				{
					text:'МОЛ (Регл)',
					width:'100',
					dataIndex:'МОЛРегл',
					flex:1,
				},
				{
					text:'Срок полезного использования, мес.',
					width:'100',
					dataIndex:'СрокПолезногоИспользования',
					flex:1,
				},
				{
					text:'Срок полезного использования (БУ), мес.',
					width:'100',
					dataIndex:'СрокПолезногоИспользованияБУ',
					flex:1,
				},
				{
					text:'Дата приобретения (УСН)',
					width:'100',
					dataIndex:'ДатаПриобретенияУСН',
					flex:1,
				},
				{
					text:'Срок полезного использования, мес. (УСН)',
					width:'100',
					dataIndex:'СрокПолезногоИспользованияУСН',
					flex:1,
				},
				{
					text:'Срок полезного использования (НУ), мес.',
					width:'100',
					dataIndex:'СрокПолезногоИспользованияНУ',
					flex:1,
				},
				{
					text:'Первоначальная стоимость (УСН)',
					width:'100',
					dataIndex:'ПервоначальнаяСтоимостьУСН',
					flex:1,
				},
				{
					text:'Сумма начисленной амортизации (до перехода на УСН)',
					width:'100',
					dataIndex:'СуммаНачисленнойАмортизацииУСН',
					flex:1,
				},
				{
					text:'Порядок включения стоимости в состав расходов (УСН)',
					width:'100',
					dataIndex:'ПорядокВключенияСтоимостиВСоставРасходовУСН',
					flex:1,
				},
				{
					text:'Стоимость до 2002 года (НУ)',
					width:'100',
					dataIndex:'СтоимостьДо2002НУ',
					flex:1,
				},
				{
					text:'Амортизация до 2002 года (НУ)',
					width:'100',
					dataIndex:'АмортизацияДо2002НУ',
					flex:1,
				},
				{
					text:'Начислять амортизацию',
					width:'100',
					dataIndex:'НачислятьАмортизацию',
					flex:1,
				},
				{
					text:'Способ начисления амортизации',
					width:'100',
					dataIndex:'СпособНачисленияАмортизации',
					flex:1,
				},
				{
					text:'Способ отражения расходов по амортизации',
					width:'100',
					dataIndex:'СпособОтраженияРасходовПоАмортизации',
					flex:1,
				},
				{
					text:'Начислять амортизацию (БУ)',
					width:'100',
					dataIndex:'НачислятьАмортизациюБУ',
					flex:1,
				},
				{
					text:'Способ начисления амортизации (БУ)',
					width:'100',
					dataIndex:'СпособНачисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'Способ отражения расходов по амортизации (БУ)',
					width:'100',
					dataIndex:'СпособОтраженияРасходовПоАмортизацииБУ',
					flex:1,
				},
				{
					text:'Начислять амортизацию (НУ)',
					width:'100',
					dataIndex:'НачислятьАмортизациюНУ',
					flex:1,
				},
				{
					text:'Метод начисления амортизации (НУ)',
					width:'100',
					dataIndex:'МетодНачисленияАмортизацииНУ',
					flex:1,
				},
				{
					text:'Способ отражения расходов по амортизации (НУ)',
					width:'100',
					dataIndex:'СпособОтраженияРасходовПоАмортизацииНУ',
					flex:1,
				},
				{
					text:'Стоимость для вычисления амортизации',
					width:'100',
					dataIndex:'СтоимостьДляВычисленияАмортизации',
					flex:1,
				},
				{
					text:'Стоимость для вычисления амортизации (БУ)',
					width:'100',
					dataIndex:'СтоимостьДляВычисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'Параметр выработки',
					width:'53',
					dataIndex:'ПараметрВыработки',
					flex:1,
				},
				{
					text:'Предполагаемый объем продукции (работ) в натуральных ед.',
					width:'53',
					dataIndex:'ОбъемПродукцииРабот',
					flex:1,
				},
				{
					text:'Объем продукции (работ) для исчисления амортизации в натуральных ед.',
					width:'53',
					dataIndex:'ОбъемПродукцииРаботДляВычисленияАмортизации',
					flex:1,
				},
				{
					text:'Выработка количество',
					width:'53',
					dataIndex:'ВыработкаКоличество',
					flex:1,
				},
				{
					text:'Параметр выработки (БУ)',
					width:'106',
					dataIndex:'ПараметрВыработкиБУ',
					flex:1,
				},
				{
					text:'Предполагаемый объем продукции (работ) в натуральных ед. (БУ)',
					width:'53',
					dataIndex:'ОбъемПродукцииРаботБУ',
					flex:1,
				},
				{
					text:'Объем продукции (работ) для исчисления амортизации в натуральных ед. (БУ)',
					width:'53',
					dataIndex:'ОбъемПродукцииРаботДляВычисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'Выработка количество (БУ)',
					width:'106',
					dataIndex:'ВыработкаКоличествоБУ',
					flex:1,
				},
				{
					text:'Процент годовой амортизации',
					width:'100',
					dataIndex:'КоэффициентАмортизации',
					flex:1,
				},
				{
					text:'График амортизации',
					width:'100',
					dataIndex:'ГрафикАмортизации',
					flex:1,
				},
				{
					text:'Процент годовой амортизации (БУ)',
					width:'100',
					dataIndex:'КоэффициентАмортизацииБУ',
					flex:1,
				},
				{
					text:'График амортизации (БУ)',
					width:'100',
					dataIndex:'ГрафикАмортизацииБУ',
					flex:1,
				},
				{
					text:'Коэффициент ускорения',
					width:'100',
					dataIndex:'КоэффициентУскорения',
					flex:1,
				},
				{
					text:'Коэффициент ускорения (БУ)',
					width:'100',
					dataIndex:'КоэффициентУскоренияБУ',
					flex:1,
				},
				{
					text:'Специальный коэффициент (НУ)',
					width:'100',
					dataIndex:'СпециальныйКоэффициентНУ',
					flex:1,
				},
				{
					text:'Порядок включения стоимости в состав расходов (НУ)',
					width:'100',
					dataIndex:'ПорядокВключенияСтоимостиВСоставРасходовНУ',
					flex:1,
				},
				{
					text:'Текущая стоимость(ПР)',
					width:'106',
					dataIndex:'ТекущаяСтоимостьПР',
					flex:1,
				},
				{
					text:'Накопленная амортизация (ПР)',
					width:'106',
					dataIndex:'НакопленнаяАмортизацияПР',
					flex:1,
				},
				{
					text:'Стоимость для вычисления амортизации (ПР)',
					width:'100',
					dataIndex:'СтоимостьДляВычисленияАмортизацииПР',
					flex:1,
				},
				{
					text:'Срок использования для вычисления амортизации, мес.',
					width:'94',
					dataIndex:'СрокИспользованияДляВычисленияАмортизации',
					flex:1,
				},
				{
					text:'Срок использования для вычисления амортизации, мес. (БУ)',
					width:'100',
					dataIndex:'СрокИспользованияДляВычисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'Начислять по базовой стоимости (НУ)',
					width:'54',
					dataIndex:'НачислятьПоБазовойСтоимостиНУ',
					flex:1,
				},
				{
					text:'Дата перехода к расчету по базовой стоимости (НУ)',
					width:'54',
					dataIndex:'ДатаПереходаКРасчетуПоБазовойСтоимостиНУ',
					flex:1,
				},
				{
					text:'Фактический срок использования (НУ)',
					width:'54',
					dataIndex:'ФактическийСрокИспользованияНУ',
					flex:1,
				},
				{
					text:'Сумма накопленной амортизации (НУ) (при переходе к начислению по базовой стоимости)',
					width:'54',
					dataIndex:'СуммаНакопленнойАмортизацииНУ',
					flex:1,
				},
				{
					text:'Родительское ОС',
					width:'100',
					dataIndex:'РодительскоеОС',
					flex:1,
				},
				{
					text:'Номенклатура',
					width:'100',
					dataIndex:'Номенклатура',
					flex:1,
				},
				{
					text:'Характеристика номенклатуры',
					width:'100',
					dataIndex:'ХарактеристикаНоменклатуры',
					flex:1,
				},
				{
					text:'Дата последней модернизации',
					width:'52',
					dataIndex:'ДатаПоследнейМодернизации',
					flex:1,
				},
				{
					text:'Сумма последней модернизации',
					width:'52',
					dataIndex:'СуммаПоследнейМодернизации',
					flex:1,
				},
				{
					text:'Событие модернизации',
					width:'52',
					dataIndex:'СобытиеМодернизации',
					flex:1,
				},
				{
					text:'Название документа модернизации',
					width:'52',
					dataIndex:'НазваниеДокументаМодернизации',
					flex:1,
				},
				{
					text:'Номер документа модернизации',
					width:'52',
					dataIndex:'НомерДокументаМодернизации',
					flex:1,
				},
				{
					text:'Дата последней модернизации (Регл)',
					width:'55',
					dataIndex:'ДатаПоследнейМодернизацииРегл',
					flex:1,
				},
				{
					text:'Сумма последней модернизации (БУ)',
					width:'55',
					dataIndex:'СуммаПоследнейМодернизацииБУ',
					flex:1,
				},
				{
					text:'Сумма последней модернизации (НУ)',
					width:'55',
					dataIndex:'СуммаПоследнейМодернизацииНУ',
					flex:1,
				},
				{
					text:'Событие модернизации (Регл)',
					width:'55',
					dataIndex:'СобытиеМодернизацииРегл',
					flex:1,
				},
				{
					text:'Название документа модернизации (Регл)',
					width:'55',
					dataIndex:'НазваниеДокументаМодернизацииРегл',
					flex:1,
				},
				{
					text:'Номер документа модернизации (Регл)',
					width:'55',
					dataIndex:'НомерДокументаМодернизацииРегл',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ВводНачальныхОстатковОС/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'ИнвентарныйНомер',
					},
					{
						name:'ОсновноеСредство',
					},
					{
						name:'ИнвентарныйНомерРегл',
					},
					{
						name:'ДатаПринятияКУчету',
					},
					{
						name:'СобытиеПринятияКУчету',
					},
					{
						name:'НазваниеДокументаПринятияКУчету',
					},
					{
						name:'НомерДокументаПринятияКУчету',
					},
					{
						name:'ДатаПринятияКУчетуРегл',
					},
					{
						name:'СобытиеПринятияКУчетуРегл',
					},
					{
						name:'НазваниеДокументаПринятияКУчетуРегл',
					},
					{
						name:'НомерДокументаПринятияКУчетуРегл',
					},
					{
						name:'СпособПоступленияБУ',
					},
					{
						name:'ДатаВводаВЭксплуатацию',
					},
					{
						name:'СобытиеВводВЭксплуатацию',
					},
					{
						name:'НазваниеДокументаВводаВЭксплуатацию',
					},
					{
						name:'НомерДокументаВводаВЭксплуатацию',
					},
					{
						name:'ДатаВводаВЭксплуатациюРегл',
					},
					{
						name:'СобытиеВводВЭксплуатациюРегл',
					},
					{
						name:'НазваниеДокументаВводаВЭксплуатациюРегл',
					},
					{
						name:'НомерДокументаВводаВЭксплуатациюРегл',
					},
					{
						name:'СписатьНаЗатратыПриВводе',
					},
					{
						name:'СписатьНаЗатратыПриВводеРегл',
					},
					{
						name:'ПервоначальнаяСтоимость',
					},
					{
						name:'ТекущаяСтоимость',
					},
					{
						name:'НакопленнаяАмортизация',
					},
					{
						name:'ПервоначальнаяСтоимостьБУ',
					},
					{
						name:'ТекущаяСтоимостьБУ',
					},
					{
						name:'НакопленнаяАмортизацияБУ',
					},
					{
						name:'ПервоначальнаяСтоимостьНУ',
					},
					{
						name:'ТекущаяСтоимостьНУ',
					},
					{
						name:'НакопленнаяАмортизацияНУ',
					},
					{
						name:'СчетУчетаБУ',
					},
					{
						name:'СчетАмортизацииБУ',
					},
					{
						name:'СчетУчетаНУ',
					},
					{
						name:'СчетАмортизацииНУ',
					},
					{
						name:'МОЛ',
					},
					{
						name:'МОЛРегл',
					},
					{
						name:'СрокПолезногоИспользования',
					},
					{
						name:'СрокПолезногоИспользованияБУ',
					},
					{
						name:'ДатаПриобретенияУСН',
					},
					{
						name:'СрокПолезногоИспользованияУСН',
					},
					{
						name:'СрокПолезногоИспользованияНУ',
					},
					{
						name:'ПервоначальнаяСтоимостьУСН',
					},
					{
						name:'СуммаНачисленнойАмортизацииУСН',
					},
					{
						name:'ПорядокВключенияСтоимостиВСоставРасходовУСН',
					},
					{
						name:'СтоимостьДо2002НУ',
					},
					{
						name:'АмортизацияДо2002НУ',
					},
					{
						name:'НачислятьАмортизацию',
					},
					{
						name:'СпособНачисленияАмортизации',
					},
					{
						name:'СпособОтраженияРасходовПоАмортизации',
					},
					{
						name:'НачислятьАмортизациюБУ',
					},
					{
						name:'СпособНачисленияАмортизацииБУ',
					},
					{
						name:'СпособОтраженияРасходовПоАмортизацииБУ',
					},
					{
						name:'НачислятьАмортизациюНУ',
					},
					{
						name:'МетодНачисленияАмортизацииНУ',
					},
					{
						name:'СпособОтраженияРасходовПоАмортизацииНУ',
					},
					{
						name:'СтоимостьДляВычисленияАмортизации',
					},
					{
						name:'СтоимостьДляВычисленияАмортизацииБУ',
					},
					{
						name:'ПараметрВыработки',
					},
					{
						name:'ОбъемПродукцииРабот',
					},
					{
						name:'ОбъемПродукцииРаботДляВычисленияАмортизации',
					},
					{
						name:'ВыработкаКоличество',
					},
					{
						name:'ПараметрВыработкиБУ',
					},
					{
						name:'ОбъемПродукцииРаботБУ',
					},
					{
						name:'ОбъемПродукцииРаботДляВычисленияАмортизацииБУ',
					},
					{
						name:'ВыработкаКоличествоБУ',
					},
					{
						name:'КоэффициентАмортизации',
					},
					{
						name:'ГрафикАмортизации',
					},
					{
						name:'КоэффициентАмортизацииБУ',
					},
					{
						name:'ГрафикАмортизацииБУ',
					},
					{
						name:'КоэффициентУскорения',
					},
					{
						name:'КоэффициентУскоренияБУ',
					},
					{
						name:'СпециальныйКоэффициентНУ',
					},
					{
						name:'ПорядокВключенияСтоимостиВСоставРасходовНУ',
					},
					{
						name:'ТекущаяСтоимостьПР',
					},
					{
						name:'НакопленнаяАмортизацияПР',
					},
					{
						name:'СтоимостьДляВычисленияАмортизацииПР',
					},
					{
						name:'СрокИспользованияДляВычисленияАмортизации',
					},
					{
						name:'СрокИспользованияДляВычисленияАмортизацииБУ',
					},
					{
						name:'НачислятьПоБазовойСтоимостиНУ',
					},
					{
						name:'ДатаПереходаКРасчетуПоБазовойСтоимостиНУ',
					},
					{
						name:'ФактическийСрокИспользованияНУ',
					},
					{
						name:'СуммаНакопленнойАмортизацииНУ',
					},
					{
						name:'РодительскоеОС',
					},
					{
						name:'Номенклатура',
					},
					{
						name:'ХарактеристикаНоменклатуры',
					},
					{
						name:'ДатаПоследнейМодернизации',
					},
					{
						name:'СуммаПоследнейМодернизации',
					},
					{
						name:'СобытиеМодернизации',
					},
					{
						name:'НазваниеДокументаМодернизации',
					},
					{
						name:'НомерДокументаМодернизации',
					},
					{
						name:'ДатаПоследнейМодернизацииРегл',
					},
					{
						name:'СуммаПоследнейМодернизацииБУ',
					},
					{
						name:'СуммаПоследнейМодернизацииНУ',
					},
					{
						name:'СобытиеМодернизацииРегл',
					},
					{
						name:'НазваниеДокументаМодернизацииРегл',
					},
					{
						name:'НомерДокументаМодернизацииРегл',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ОС');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
					]
				},
				{
					items:
					[
		{
			id: 'ТабИтогов',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:624px;height:220px;',
			height: 220,width: 624,
			columns:
			[
				{
					text:'Имя',
					width:'100',
					dataIndex:'Имя',
					flex:1,
				},
				{
					text:'Название колонки',
					width:'224',
					dataIndex:'Представление',
					flex:1,
				},
				{
					text:'Итог по колонке',
					width:'100',
					dataIndex:'Итог',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ВводНачальныхОстатковОС/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Имя',
					},
					{
						name:'Представление',
					},
					{
						name:'Итог',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ТабИтогов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:81px;width:88px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Ответственный.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:96px;top:81px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.ВводНачальныхОстатковОС.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:395px;width:654px;height:25px;',
			width: 654,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Печать',
					tooltip:'Печать',
				},
				'-',
				{
					text:'OK',
					tooltip:'Записать объект и закрыть форму',
					iconCls:'x-WriteAndClose',
				},
				'-',
				{
					text:'Записать',
					tooltip:'Записать объект',
					iconCls:'x-SaveFile',
				},
				'-',
				{
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
			]
		},
	]
	});
});