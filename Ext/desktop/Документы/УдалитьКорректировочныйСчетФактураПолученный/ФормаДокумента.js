﻿Ext.define('Документы.УдалитьКорректировочныйСчетФактураПолученный.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:675px;height:445px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Корректировочный счет-фактура полученный',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:32px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:183px;top:32px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:393px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:100px;top:32px;width:80px;height:19px;',
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
			style: 'position:absolute;left:200px;top:32px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 567,
			height: 19,
			style: 'position:absolute;left:100px;top:393px;width:567px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:675px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'label',
			name: 'НадписьСчетФактура',
			text: 'Счет-фактура:\r\n',
			style: 'position:absolute;left:8px;top:104px;width:92px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:420px;width:675px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'ОК',
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
			name: 'НадписьКонтрагент1',
			text: 'Контрагент:\r\n',
			style: 'position:absolute;left:8px;top:80px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДоговорКонтрагента',
			text: 'Договор:\r\n',
			style: 'position:absolute;left:355px;top:80px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:56px;width:92px;height:19px;text-align:left;',
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
			style: 'position:absolute;left:100px;top:56px;width:220px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Контрагент',
			width: 220,
			height: 19,
			style: 'position:absolute;left:100px;top:80px;width:220px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'ДоговорКонтрагента',
			width: 220,
			height: 19,
			style: 'position:absolute;left:447px;top:80px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:369px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Ответственный',
			width: 567,
			height: 19,
			style: 'position:absolute;left:100px;top:369px;width:567px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'СчетФактура',
			width: 567,
			height: 19,
			style: 'position:absolute;left:100px;top:104px;width:567px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:129px;width:659px;height:232px;',
			height: 232,width: 659,
			items:
			[
				{
					title:'Реквизиты счета-фактуры',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомерСчетаФактуры',
			width: 112,
			height: 19,
			style: 'position:absolute;left:138px;top:30px;width:112px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаВходящего',
			width: 80,
			height: 19,
			style: 'position:absolute;left:278px;top:30px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСчетФактураНомер',
			text: 'К счету-фактуре номер:',
			style: 'position:absolute;left:6px;top:30px;width:132px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВходящаяДата',
			text: 'от:',
			style: 'position:absolute;left:257px;top:30px;width:20px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьВходящийНомер',
			text: 'Входящий номер:',
			style: 'position:absolute;left:6px;top:6px;width:132px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомерВходящегоДокумента',
			width: 112,
			height: 19,
			style: 'position:absolute;left:138px;top:6px;width:112px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаИсправления',
			text: 'от:',
			style: 'position:absolute;left:257px;top:6px;width:20px;height:19px;text-align:left;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаВходящегоДокумента',
			width: 80,
			height: 19,
			style: 'position:absolute;left:278px;top:6px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРазницаСНДСКУменьшению',
			text: 'Разница к уменьшению:',
			style: 'position:absolute;left:6px;top:128px;width:132px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'РазницаСНДСКУменьшению',
			style: 'position:absolute;left:138px;top:128px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСуммаНДС',
			text: 'В т.ч. НДС к уменьшению:',
			style: 'position:absolute;left:278px;top:128px;width:140px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'РазницаНДСКУменьшению',
			style: 'position:absolute;left:418px;top:128px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименованиеПродавца',
			text: 'Наименование продавца:',
			style: 'position:absolute;left:6px;top:54px;width:132px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаименованиеПродавца',
			width: 513,
			height: 19,
			style: 'position:absolute;left:138px;top:54px;width:513px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИННПродавца',
			text: 'ИНН / КПП продавца:',
			style: 'position:absolute;left:6px;top:79px;width:132px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИННПродавца',
			width: 120,
			height: 19,
			style: 'position:absolute;left:138px;top:79px;width:120px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			name: 'ВалютаДокумента',
			width: 80,
			height: 19,
			style: 'position:absolute;left:138px;top:104px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКПППродавца',
			text: '/',
			style: 'position:absolute;left:258px;top:79px;width:20px;height:19px;text-align:center;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КПППродавца',
			width: 80,
			height: 19,
			style: 'position:absolute;left:278px;top:79px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаДокумента',
			text: 'Валюта:',
			style: 'position:absolute;left:6px;top:104px;width:132px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьРазницаСНДСКДоплате',
			text: 'Разница к доплате:',
			style: 'position:absolute;left:6px;top:152px;width:132px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'РазницаСНДСКДоплате',
			style: 'position:absolute;left:138px;top:152px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРазницаНДСКДоплате',
			text: 'В т.ч. НДС к доплате:',
			style: 'position:absolute;left:278px;top:152px;width:140px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'РазницаНДСКДоплате',
			style: 'position:absolute;left:418px;top:152px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИтогиКУменьшению',
			text: 'К уменьшению по счету-фактуре: 118 000 руб., в том числе НДС: 18 000 руб. ',
			style: 'position:absolute;left:198px;top:6px;width:453px;height:19px;',
		},
					]
				},
				{
					title:'Восстановление НДС',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:53px;width:645px;height:153px;',
			height: 153,width: 645,
			columns:
			[
				{
					text:'N',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Вид ценности',
					width:'120',
					dataIndex:'ВидЦенности',
					flex:1,
				},
				{
					text:'Сумма с НДС',
					width:'100',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Ставка НДС',
					width:'100',
					dataIndex:'СтавкаНДС',
					flex:1,
				},
				{
					text:'Сумма НДС',
					width:'100',
					dataIndex:'СуммаНДС',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/УдалитьКорректировочныйСчетФактураПолученный/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'ВидЦенности',
					},
					{
						name:'Сумма',
					},
					{
						name:'СтавкаНДС',
					},
					{
						name:'СуммаНДС',
					},
				]
			},
		},
					]
				},
				{
					title:'Вычет НДС',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:53px;width:645px;height:153px;',
			height: 153,width: 645,
			columns:
			[
				{
					text:'N',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Вид ценности',
					width:'120',
					dataIndex:'ВидЦенности',
					flex:1,
				},
				{
					text:'Сумма с НДС',
					width:'100',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Ставка НДС',
					width:'100',
					dataIndex:'СтавкаНДС',
					flex:1,
				},
				{
					text:'Сумма НДС',
					width:'100',
					dataIndex:'СуммаНДС',
					flex:1,
				},
				{
					text:'Счет учета НДС',
					width:'100',
					dataIndex:'СчетУчетаНДС',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/УдалитьКорректировочныйСчетФактураПолученный/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'ВидЦенности',
					},
					{
						name:'Сумма',
					},
					{
						name:'СтавкаНДС',
					},
					{
						name:'СуммаНДС',
					},
					{
						name:'СчетУчетаНДС',
					},
				]
			},
		},
		{
			xtype: 'label',
			name: 'НадписьИтогиКДоплате',
			text: 'К доплате по счету-фактуре: 118 000 руб., в том числе НДС: 18 000 руб. ',
			style: 'position:absolute;left:198px;top:6px;width:453px;height:19px;',
		},
					]
				},
			]
		},
	],
	dockedItems:
	[
	]
});