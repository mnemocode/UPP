﻿Ext.define('Отчеты.ШахматнаяВедомостьХозрасчетный.ФормаОсновная',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:604px;height:437px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Шахматная оборотная ведомость',
	
	items:
	[
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаНач',
			width: 80,
			height: 19,
			style: 'position:absolute;left:64px;top:33px;width:80px;height:19px;',
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
			style: 'position:absolute;left:173px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Период с:',
			style: 'position:absolute;left:8px;top:33px;width:51px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'по:',
			style: 'position:absolute;left:149px;top:33px;width:20px;height:19px;text-align:center;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:258px;top:33px;width:19px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация',
			width: 231,
			height: 19,
			style: 'position:absolute;left:365px;top:33px;width:231px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Организация:',
			style: 'position:absolute;left:286px;top:33px;width:76px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Данные по забалансовым счетам',
			style: 'position:absolute;left:397px;top:59px;width:195px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'По субсчетам',
			style: 'position:absolute;left:286px;top:59px;width:97px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'По валютам',
			style: 'position:absolute;left:173px;top:59px;width:80px;height:15px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:604px;height:25px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'Сформировать',
				},
				{
					text:'Заголовок',
				},
				{
					text:'Восстановить значения...',
				},
				{
					text:'Сохранить значения...',
				},
				'-',
				{
					text:'Закрыть',
				},
				{
					text:'Справка',
				},
					]
				},
				'-',
				{
					text:'Сформировать',
				},
				'-',
				{
					text:'Заголовок',
				},
				'-',
				{
					text:'Восстановить значения',
				},
				{
					text:'Сохранить значения...',
				},
				{
					text:'Справка',
				},
			]
		},
	]
});