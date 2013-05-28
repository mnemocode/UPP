﻿Ext.define('Отчеты.РегламентированныйОтчетАлкоПриложение7.ОсновнаяФорма',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:276px;height:310px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Закупки спирта и алкогольной продукции',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьПериодСоставленияОтчета',
			text: '',
			style: 'position:absolute;left:121px;top:105px;width:120px;height:19px;text-align:center;',
		},
		{
			xtype: 'button',
			name: 'КнопкаПредыдущийПериод',
			text: '',
			style: 'position:absolute;left:100px;top:105px;width:19px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаСледующийПериод',
			text: '',
			style: 'position:absolute;left:243px;top:105px;width:19px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ОписаниеНормативДок',
			text: '',
			style: 'position:absolute;left:14px;top:158px;width:248px;height:86px;text-align:left;',
		},
		{
			xtype: 'button',
			name: 'КнопкаВыбораФормы',
			text: 'Выбрать форму',
			style: 'position:absolute;left:14px;top:251px;width:100px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Период составления отчета',
			style: 'position:absolute;left:8px;top:60px;width:260px;height:15px;',
		},
		{
			xtype: 'fieldset',
			title: 'Форма',
			style: 'position:absolute;left:8px;top:137px;width:260px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПериодичность',
			text: 'Периодичность:',
			style: 'position:absolute;left:14px;top:81px;width:84px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:100px;top:81px;width:162px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПериод',
			text: 'Период:',
			style: 'position:absolute;left:14px;top:105px;width:45px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация',
			width: 260,
			height: 19,
			style: 'position:absolute;left:8px;top:27px;width:260px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Организация',
			style: 'position:absolute;left:8px;top:8px;width:260px;height:15px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:285px;width:276px;height:25px;',
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
					text:'Отмена',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
	]
});