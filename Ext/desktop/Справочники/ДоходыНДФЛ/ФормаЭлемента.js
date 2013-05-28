﻿Ext.define('Справочники.ДоходыНДФЛ.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:471px;height:247px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Код дохода для исчисления НДФЛ',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:8px;top:33px;width:29px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 60,
			height: 19,
			style: 'position:absolute;left:38px;top:33px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:100px;top:33px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 280,
			height: 19,
			style: 'position:absolute;left:183px;top:33px;width:280px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтавкаНалогообложенияРезидента',
			text: 'Ставка налогообложения (для налоговых резидентов):',
			style: 'position:absolute;left:8px;top:81px;width:172px;height:31px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'СтавкаНалогообложенияРезидента',
			width: 60,
			height: 19,
			style: 'position:absolute;left:183px;top:86px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКодДляОтчетности',
			text: 'Код для отражения в отчетности:',
			style: 'position:absolute;left:8px;top:57px;width:172px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КодДляОтчетности',
			width: 60,
			height: 19,
			style: 'position:absolute;left:183px;top:57px;width:60px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Доход не облагается у налогового агента',
			style: 'position:absolute;left:16px;top:195px;width:276px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Не отражается в отчетности с 2010 г.',
			style: 'position:absolute;left:248px;top:57px;width:215px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьУчитыватьПоПериодуДействия',
			text: 'Порядок учета дохода при исчислении НДФЛ:',
			style: 'position:absolute;left:8px;top:122px;width:284px;height:19px;text-align:left;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'По месяцу, за который производится начисление',
			style: 'position:absolute;left:16px;top:147px;width:276px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'По месяцу начисления',
			style: 'position:absolute;left:16px;top:169px;width:276px;height:19px;',
		},
			]
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:471px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:222px;width:471px;height:25px;',
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