﻿Ext.define('Документы.АмортизацияОС.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:596px;height:185px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Амортизация ОС',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись1',
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
			style: 'position:absolute;left:98px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'от:',
			style: 'position:absolute;left:180px;top:33px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'Дата',
			width: 143,
			height: 19,
			style: 'position:absolute;left:198px;top:33px;width:143px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:82px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация',
			width: 490,
			height: 19,
			style: 'position:absolute;left:98px;top:82px;width:490px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:107px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Ответственный',
			width: 490,
			height: 19,
			style: 'position:absolute;left:98px;top:107px;width:490px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:133px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 490,
			height: 19,
			style: 'position:absolute;left:98px;top:133px;width:490px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтраженияВУчете',
			text: 'Отразить в:',
			style: 'position:absolute;left:8px;top:58px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'бух. учете',
			style: 'position:absolute;left:180px;top:58px;width:71px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'налог. учете',
			style: 'position:absolute;left:259px;top:58px;width:82px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'упр. учете',
			style: 'position:absolute;left:98px;top:58px;width:71px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Месяц начисления:',
			style: 'position:absolute;left:346px;top:33px;width:102px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: true,
			name: 'ПредставлениеПериодаРегистрации',
			width: 137,
			height: 19,
			style: 'position:absolute;left:451px;top:33px;width:137px;height:19px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:596px;height:25px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'Движения документа по регистрам',
				},
				{
					text:'',
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
				'-',
				{
					text:'Дт/кт',
				},
				{
					text:'Дт/кт',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:160px;width:596px;height:25px;',
			dock: 'bottom',
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
	]
});