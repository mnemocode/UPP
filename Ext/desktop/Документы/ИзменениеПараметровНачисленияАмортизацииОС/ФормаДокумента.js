﻿Ext.define('Документы.ИзменениеПараметровНачисленияАмортизацииОС.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:671px;height:395px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Изменение параметров начисления амортизации ОС',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:92px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОт',
			text: 'от:',
			style: 'position:absolute;left:174px;top:33px;width:16px;height:19px;text-align:center;',
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
			style: 'position:absolute;left:192px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:154px;width:654px;height:24px;',
			items:
			[
				'-',
				'-',
				{
					text:'Подбор',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:179px;width:654px;height:159px;',
			height: 159,width: 654,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Основное средство',
					width:'200',
					dataIndex:'ОсновноеСредство',
					flex:1,
				},
				{
					text:'Инв. №',
					width:'100',
					dataIndex:'ИнвентарныйНомер',
					flex:1,
				},
				{
					text:'Срок использ. (УУ)',
					width:'120',
					dataIndex:'СрокПолезногоИспользованияУУ',
					flex:1,
				},
				{
					text:'Срок для аморт. (УУ)',
					width:'100',
					dataIndex:'СрокИспользованияДляВычисленияАмортизацииУУ',
					flex:1,
				},
				{
					text:'Объем работ (УУ)',
					width:'124',
					dataIndex:'ОбъемПродукцииРаботУУ',
					flex:1,
				},
				{
					text:'Объем работ для аморт. (УУ)',
					width:'76',
					dataIndex:'ОбъемПродукцииРаботДляВычисленияАмортизацииУУ',
					flex:1,
				},
				{
					text:'Стоимость для вычисления аморт. (УУ)',
					width:'116',
					dataIndex:'СтоимостьДляВычисленияАмортизацииУУ',
					flex:1,
				},
				{
					text:'% год. аморт. (УУ)',
					width:'116',
					dataIndex:'КоэффициентАмортизацииУУ',
					flex:1,
				},
				{
					text:'Коэф. ускорения (УУ)',
					width:'116',
					dataIndex:'КоэффициентУскоренияУУ',
					flex:1,
				},
				{
					text:'Срок использ. (БУ)',
					width:'118',
					dataIndex:'СрокПолезногоИспользованияБУ',
					flex:1,
				},
				{
					text:'Срок для аморт. (БУ)',
					width:'98',
					dataIndex:'СрокИспользованияДляВычисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'Объем работ (БУ)',
					width:'98',
					dataIndex:'ОбъемПродукцииРаботБУ',
					flex:1,
				},
				{
					text:'Объем работ для аморт. (БУ)',
					width:'98',
					dataIndex:'ОбъемПродукцииРаботДляВычисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'Стоимость для вычисления аморт. (БУ)',
					width:'116',
					dataIndex:'СтоимостьДляВычисленияАмортизацииБУ',
					flex:1,
				},
				{
					text:'% год. аморт. (БУ)',
					width:'116',
					dataIndex:'КоэффициентАмортизацииБУ',
					flex:1,
				},
				{
					text:'Коэф. ускорения (БУ)',
					width:'116',
					dataIndex:'КоэффициентУскоренияБУ',
					flex:1,
				},
				{
					text:'Срок использ. (НУ)',
					width:'113',
					dataIndex:'СрокПолезногоИспользованияНУ',
					flex:1,
				},
				{
					text:'Изменить начисление по базовой ст. (НУ)',
					width:'221',
					dataIndex:'ИзменятьПараметрыНачисленияПоБазовойСтоимостиНУ',
					flex:1,
				},
				{
					text:'Начислять по базовой ст. (НУ)',
					width:'147',
					dataIndex:'НачислятьПоБазовойСтоимости',
					flex:1,
				},
				{
					text:'Накопленная амортизация (НУ)',
					width:'202',
					dataIndex:'НакопленнаяАмортизацияНУ',
					flex:1,
				},
				{
					text:'Накопленный фактический срок (НУ)',
					width:'202',
					dataIndex:'НакопленныйФактическийСрокИспользованияНУ',
					flex:1,
				},
				{
					text:'Постоянные разницы для вычисления амортизации',
					width:'144',
					dataIndex:'ПРДляВычисленияАмортизации',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ИзменениеПараметровНачисленияАмортизацииОС/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'ОсновноеСредство',
					},
					{
						name:'ИнвентарныйНомер',
					},
					{
						name:'СрокПолезногоИспользованияУУ',
					},
					{
						name:'СрокИспользованияДляВычисленияАмортизацииУУ',
					},
					{
						name:'ОбъемПродукцииРаботУУ',
					},
					{
						name:'ОбъемПродукцииРаботДляВычисленияАмортизацииУУ',
					},
					{
						name:'СтоимостьДляВычисленияАмортизацииУУ',
					},
					{
						name:'КоэффициентАмортизацииУУ',
					},
					{
						name:'КоэффициентУскоренияУУ',
					},
					{
						name:'СрокПолезногоИспользованияБУ',
					},
					{
						name:'СрокИспользованияДляВычисленияАмортизацииБУ',
					},
					{
						name:'ОбъемПродукцииРаботБУ',
					},
					{
						name:'ОбъемПродукцииРаботДляВычисленияАмортизацииБУ',
					},
					{
						name:'СтоимостьДляВычисленияАмортизацииБУ',
					},
					{
						name:'КоэффициентАмортизацииБУ',
					},
					{
						name:'КоэффициентУскоренияБУ',
					},
					{
						name:'СрокПолезногоИспользованияНУ',
					},
					{
						name:'ИзменятьПараметрыНачисленияПоБазовойСтоимостиНУ',
					},
					{
						name:'НачислятьПоБазовойСтоимости',
					},
					{
						name:'НакопленнаяАмортизацияНУ',
					},
					{
						name:'НакопленныйФактическийСрокИспользованияНУ',
					},
					{
						name:'ПРДляВычисленияАмортизации',
					},
				]
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:671px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'Структура подчиненности документа',
				},
				'-',
					]
				},
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:370px;width:671px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Печать',
				},
				'-',
				{
					text:'OK',
				},
				'-',
				{
					text:'Записать',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Ответственный:',
			style: 'position:absolute;left:336px;top:57px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Ответственный',
			width: 240,
			height: 19,
			style: 'position:absolute;left:422px;top:57px;width:240px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:343px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 570,
			height: 19,
			style: 'position:absolute;left:92px;top:343px;width:570px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'упр. учете',
			style: 'position:absolute;left:422px;top:33px;width:70px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'бух. учете',
			style: 'position:absolute;left:496px;top:33px;width:70px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтражатьВ',
			text: 'Отражать в:',
			style: 'position:absolute;left:336px;top:33px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Применять параметры в текущем месяце',
			style: 'position:absolute;left:336px;top:84px;width:236px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация',
			width: 220,
			height: 19,
			style: 'position:absolute;left:92px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'налог. учете',
			style: 'position:absolute;left:576px;top:33px;width:86px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Основные средства',
			style: 'position:absolute;left:8px;top:138px;width:654px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСобытие',
			text: 'Событие:',
			style: 'position:absolute;left:8px;top:83px;width:73px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Событие',
			width: 220,
			height: 19,
			style: 'position:absolute;left:92px;top:83px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСобытиеРегл',
			text: 'Событие регл.:',
			style: 'position:absolute;left:8px;top:108px;width:76px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'СобытиеРегл',
			width: 220,
			height: 19,
			style: 'position:absolute;left:92px;top:108px;width:220px;height:19px;',
		},
	],
	dockedItems:
	[
	]
});