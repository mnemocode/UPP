﻿Ext.define('Обработки.ДокументооборотСКонтролирующимиОрганами.Справочник_ВидыОтправляемыхДокументов_ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:470px;height:525px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Вид отправляемого документа',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:59px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 368,
			height: 19,
			style: 'position:absolute;left:94px;top:59px;width:368px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьРодитель',
			text: 'Группа:',
			style: 'position:absolute;left:8px;top:32px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Источник',
			width: 454,
			height: 19,
			style: 'position:absolute;left:8px;top:471px;width:454px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-search-trigger',
			name: 'Родитель',
			width: 368,
			height: 19,
			style: 'position:absolute;left:94px;top:32px;width:368px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Имя объекта метаданных (служебный реквизит):',
			style: 'position:absolute;left:8px;top:448px;width:261px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Свойства отправки',
			style: 'position:absolute;left:8px;top:379px;width:454px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипПолучателя',
			text: 'Тип получателя:',
			style: 'position:absolute;left:8px;top:399px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'ТипПолучателя',
			width: 367,
			height: 19,
			style: 'position:absolute;left:95px;top:399px;width:367px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипДокумента',
			text: 'Тип документа:',
			style: 'position:absolute;left:8px;top:423px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'ТипДокумента',
			width: 367,
			height: 19,
			style: 'position:absolute;left:95px;top:423px;width:367px;height:19px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'Описание',
			style: 'position:absolute;left:8px;top:106px;width:454px;height:268px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОписание',
			text: 'Описание:',
			style: 'position:absolute;left:8px;top:86px;width:84px;height:15px;text-align:left;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:500px;width:470px;height:25px;',
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
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:470px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
	]
});