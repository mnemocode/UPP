﻿Ext.define('Обработки.РедактированиеКонтактнойИнформации.ФормаЗаписиАдреса',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:330px;height:437px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Адрес',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:330px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
					]
				},
				'-',
				{
					text:'Классификатор',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:412px;width:330px;height:25px;',
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
		{
			xtype: 'fieldset',
			title: 'Адрес',
			style: 'position:absolute;left:8px;top:131px;width:314px;height:16px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:152px;width:314px;height:228px;',
			height: 228,width: 314,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'РегламентированныйАдрес',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Регион:',
			style: 'position:absolute;left:0px;top:0px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Регион',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:0px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Район:',
			style: 'position:absolute;left:0px;top:24px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Район',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:24px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись8',
			text: 'Город:',
			style: 'position:absolute;left:0px;top:48px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Город',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:48px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись9',
			text: 'Нас. пункт:',
			style: 'position:absolute;left:0px;top:72px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаселенныйПункт',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:72px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись10',
			text: 'Улица:',
			style: 'position:absolute;left:0px;top:96px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Улица',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:96px;width:226px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Дом',
			width: 36,
			height: 19,
			style: 'position:absolute;left:88px;top:120px;width:36px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Корпус',
			width: 36,
			height: 19,
			style: 'position:absolute;left:200px;top:120px;width:36px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Квартира',
			width: 32,
			height: 19,
			style: 'position:absolute;left:282px;top:120px;width:32px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись14',
			text: 'Индекс:',
			style: 'position:absolute;left:0px;top:144px;width:86px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Индекс',
			width: 60,
			height: 19,
			style: 'position:absolute;left:88px;top:144px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись18',
			text: 'Представление:',
			style: 'position:absolute;left:0px;top:168px;width:86px;height:19px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'Представление',
			style: 'position:absolute;left:88px;top:168px;width:226px;height:60px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ТипКвартиры',
			width: 42,
			height: 19,
			style: 'position:absolute;left:238px;top:120px;width:42px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ТипКорпуса',
			width: 72,
			height: 19,
			style: 'position:absolute;left:126px;top:120px;width:72px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-trigger-square',
			name: 'ТипДома',
			width: 86,
			height: 19,
			style: 'position:absolute;left:0px;top:120px;width:86px;height:19px;',
		},
					]
				},
				{
					title:'ПроизвольныйАдрес',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись19',
			text: 'Представление:',
			style: 'position:absolute;left:0px;top:24px;width:86px;height:19px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'Представление1',
			style: 'position:absolute;left:88px;top:24px;width:226px;height:204px;',
		},
		{
			xtype: 'label',
			name: 'Надпись20',
			text: 'Страна:',
			style: 'position:absolute;left:0px;top:0px;width:86px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Поле1',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:0px;width:226px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:314px;height:92px;',
			height: 92,width: 314,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Для контактной информации',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьОбъект',
			text: 'Объект:',
			style: 'position:absolute;left:0px;top:0px;width:88px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись17',
			text: 'Вид адреса:',
			style: 'position:absolute;left:0px;top:27px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Вид',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:27px;width:226px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Объект',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:0px;width:226px;height:19px;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'Российский адрес',
			style: 'position:absolute;left:0px;top:54px;width:116px;height:15px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Адрес за пределами РФ',
			style: 'position:absolute;left:0px;top:77px;width:147px;height:15px;',
		},
			]
		},
					]
				},
				{
					title:'Для регламентированной отчетности',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьКодРегиона',
			text: 'Код региона:',
			style: 'position:absolute;left:6px;top:27px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КодРегиона',
			width: 40,
			height: 19,
			style: 'position:absolute;left:88px;top:27px;width:40px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКодСтраны',
			text: 'Код страны:',
			style: 'position:absolute;left:6px;top:51px;width:80px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КодСтраны',
			width: 40,
			height: 19,
			style: 'position:absolute;left:88px;top:51px;width:40px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Коды',
			style: 'position:absolute;left:0px;top:6px;width:314px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:384px;width:314px;height:20px;',
			height: 20,width: 314,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 226,
			height: 19,
			style: 'position:absolute;left:88px;top:1px;width:226px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись15',
			text: 'Комментарий:',
			style: 'position:absolute;left:0px;top:0px;width:88px;height:19px;text-align:left;',
		},
					]
				},
			]
		},
	],
	dockedItems:
	[
	]
});