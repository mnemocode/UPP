﻿Ext.define('Отчеты.ОборотноСальдоваяВедомостьБухМСФО.ФормаНастройка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:328px;height:311px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка: Оборотно-сальдовая ведомость',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:312px;height:270px;',
			height: 270,width: 312,
			items:
			[
				{
					title:'Общие',
					items:
					[
		{
			xtype: 'checkbox',
			boxLabel: 'Данные по забалансовым счетам',
			style: 'position:absolute;left:12px;top:143px;width:200px;height:15px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация',
			width: 220,
			height: 19,
			style: 'position:absolute;left:84px;top:30px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Организация:',
			style: 'position:absolute;left:6px;top:30px;width:76px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Детализация по субсчетам и субконто',
			style: 'position:absolute;left:12px;top:103px;width:220px;height:15px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаНач',
			width: 80,
			height: 19,
			style: 'position:absolute;left:84px;top:6px;width:80px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаКон',
			width: 80,
			height: 19,
			style: 'position:absolute;left:184px;top:6px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Период с:',
			style: 'position:absolute;left:6px;top:6px;width:76px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'по:',
			style: 'position:absolute;left:166px;top:6px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Данные по валютам',
			style: 'position:absolute;left:12px;top:123px;width:128px;height:15px;',
		},
		{
			xtype: 'fieldset',
			title: 'Выводить данные:',
			style: 'position:absolute;left:6px;top:62px;width:298px;height:16px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:266px;top:6px;width:20px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Развернутое сальдо',
			style: 'position:absolute;left:12px;top:83px;width:128px;height:15px;',
		},
					]
				},
				{
					title:'Развернутое сальдо',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:298px;height:220px;',
			height: 220,width: 298,
			columns:
			[
				{
					text:'Счет',
					width:'80',
					dataIndex:'Счет',
					flex:1,
				},
				{
					text:'По субсчетам',
					width:'80',
					dataIndex:'Субсчета',
					flex:1,
				},
				{
					text:'По субконто',
					width:'120',
					dataIndex:'ПредставлениеРазворотПоСубконто',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОборотноСальдоваяВедомостьБухМСФО/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Счет',
					},
					{
						name:'Субсчета',
					},
					{
						name:'ПредставлениеРазворотПоСубконто',
					},
				]
			},
		},
					]
				},
				{
					title:'Детализация',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:298px;height:220px;',
			height: 220,width: 298,
			columns:
			[
				{
					text:'Счет',
					width:'80',
					dataIndex:'Счет',
					flex:1,
				},
				{
					text:'По субсчетам',
					width:'80',
					dataIndex:'Субсчета',
					flex:1,
				},
				{
					text:'По субконто',
					width:'120',
					dataIndex:'ПредставлениеРазворотПоСубконто',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОборотноСальдоваяВедомостьБухМСФО/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Счет',
					},
					{
						name:'Субсчета',
					},
					{
						name:'ПредставлениеРазворотПоСубконто',
					},
				]
			},
		},
					]
				},
			]
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:286px;width:328px;height:25px;',
			dock: 'bottom',
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
					text:'Закрыть',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
	]
});