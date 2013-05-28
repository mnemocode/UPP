﻿Ext.define('Отчеты.РегистрУчетаДоходовТекущегоПериода.ФормаНастройка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:372px;height:352px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Обработка  Регистр учета операций приобретения имущества, работ, услуг, прав',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:8px;width:358px;height:312px;',
			height: 312,width: 358,
			items:
			[
				{
					title:'Общие',
					items:
					[
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Организация',
			width: 266,
			height: 19,
			style: 'position:absolute;left:84px;top:30px;width:266px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Организация:',
			style: 'position:absolute;left:6px;top:30px;width:76px;height:19px;',
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
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:266px;top:6px;width:20px;height:19px;',
		},
		{
			xtype: 'itemselector',
			style: 'position:absolute;left:6px;top:6px;width:320px;height:280px;',
		},
					]
				},
				{
					title:'Виды доходов',
					items:
					[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:326px;top:6px;width:24px;height:280px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'',
				},
			]
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
			style: 'position:absolute;left:0px;top:327px;width:372px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Закрыть',
				},
			]
		},
	]
});