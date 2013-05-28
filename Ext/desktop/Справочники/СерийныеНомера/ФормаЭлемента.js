﻿Ext.define('Справочники.СерийныеНомера.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:422px;height:110px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Серийные номера',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Серийный номер:',
			style: 'position:absolute;left:8px;top:58px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 314,
			height: 19,
			style: 'position:absolute;left:100px;top:58px;width:314px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНоменклатура',
			text: 'Номенклатура:',
			style: 'position:absolute;left:8px;top:33px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-search-trigger',
			name: 'Владелец',
			width: 314,
			height: 19,
			style: 'position:absolute;left:100px;top:33px;width:314px;height:19px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:422px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:85px;width:422px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
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
	]
});