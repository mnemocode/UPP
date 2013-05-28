﻿Ext.define('Обработки.ПоказНамеченныхСобытийПоПерсоналу.ФормаОбработки',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:541px;height:374px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Запланированные кадровые перестановки',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Период с:',
			style: 'position:absolute;left:8px;top:8px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаНачала',
			width: 80,
			height: 19,
			style: 'position:absolute;left:91px;top:8px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'по:',
			style: 'position:absolute;left:173px;top:8px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаОкончания',
			width: 80,
			height: 19,
			style: 'position:absolute;left:191px;top:8px;width:80px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:80px;width:525px;height:261px;',
			height: 261,width: 525,
			columns:
			[
				{
					text:'',
					width:'28',
					dataIndex:'ФормироватьДокумент',
					flex:1,
				},
				{
					text:'Дата',
					width:'80',
					dataIndex:'Период',
					flex:1,
				},
				{
					text:'Сотрудник',
					width:'160',
					dataIndex:'Сотрудник',
					flex:1,
				},
				{
					text:'Организация',
					width:'100',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'109',
					dataIndex:'Подразделение',
					flex:1,
				},
				{
					text:'Должность',
					width:'91',
					dataIndex:'Должность',
					flex:1,
				},
				{
					text:'График работы',
					width:'42',
					dataIndex:'ГрафикРаботы',
					flex:1,
				},
				{
					text:'Ставка',
					width:'40',
					dataIndex:'Ставка',
					flex:1,
				},
				{
					text:'Занимать',
					width:'46',
					dataIndex:'ЗаниматьСтавку',
					flex:1,
				},
				{
					text:'Планируемое событие',
					width:'124',
					dataIndex:'ПланируемоеСобытие',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ПоказНамеченныхСобытийПоПерсоналу/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'ФормироватьДокумент',
					},
					{
						name:'Период',
					},
					{
						name:'Сотрудник',
					},
					{
						name:'Организация',
					},
					{
						name:'Подразделение',
					},
					{
						name:'Должность',
					},
					{
						name:'ГрафикРаботы',
					},
					{
						name:'Ставка',
					},
					{
						name:'ЗаниматьСтавку',
					},
					{
						name:'ПланируемоеСобытие',
					},
				]
			},
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораПериода',
			text: '...',
			style: 'position:absolute;left:273px;top:8px;width:20px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:349px;width:541px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Создать',
				},
				'-',
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:32px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			trigger3Cls: 'x-form-search-trigger',
			name: 'Организация',
			width: 442,
			height: 19,
			style: 'position:absolute;left:91px;top:32px;width:442px;height:19px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:56px;width:525px;height:24px;',
			dock: 'top',
			items:
			[
				'-',
				{
					text:'Удалить',
				},
				{
					text:'',
				},
				{
					text:'',
				},
				{
					text:'Конструктор настроек...',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Заполнить',
				},
				'-',
				{
					text:'Установить',
				},
				{
					text:'Снять',
				},
				'-',
				{
					text:'Инвертировать',
				},
			]
		},
	]
});