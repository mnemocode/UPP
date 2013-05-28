﻿Ext.define('Обработки.ДокументооборотСКонтролирующимиОрганами.Справочник_СерверыДокументооборота_ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:554px;height:266px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Серверы документооборота',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:8px;top:33px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 63,
			height: 19,
			style: 'position:absolute;left:208px;top:33px;width:63px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:58px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 338,
			height: 19,
			style: 'position:absolute;left:208px;top:58px;width:338px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьАдресЭлектроннойПочты',
			text: 'Для документооборота с ФНС:',
			style: 'position:absolute;left:8px;top:164px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'АдресЭлектроннойПочты',
			width: 338,
			height: 19,
			style: 'position:absolute;left:208px;top:164px;width:338px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДлительностьОжиданияСервера',
			text: 'Таймаут сервера (сек.):',
			style: 'position:absolute;left:8px;top:109px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ДлительностьОжиданияСервера',
			style: 'position:absolute;left:208px;top:109px;width:63px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСертификат',
			text: 'Сертификат:',
			style: 'position:absolute;left:8px;top:83px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Сертификат',
			width: 338,
			height: 19,
			style: 'position:absolute;left:208px;top:83px;width:338px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Адреса электронной почты',
			style: 'position:absolute;left:8px;top:141px;width:538px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьАдресЭлектроннойПочты1',
			text: 'Для документооборота с ПФР:',
			style: 'position:absolute;left:8px;top:189px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'АдресЭлектроннойПочтыПФР',
			width: 338,
			height: 19,
			style: 'position:absolute;left:208px;top:189px;width:338px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьАдресЭлектроннойПочты2',
			text: 'Для документооборота с Росстатом:',
			style: 'position:absolute;left:8px;top:214px;width:194px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'АдресЭлектроннойПочтыФСГС',
			width: 338,
			height: 19,
			style: 'position:absolute;left:208px;top:214px;width:338px;height:19px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:554px;height:25px;',
			dock: 'top',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:241px;width:554px;height:25px;',
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