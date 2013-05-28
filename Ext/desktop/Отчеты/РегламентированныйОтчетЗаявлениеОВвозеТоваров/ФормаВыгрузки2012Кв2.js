﻿Ext.define('Отчеты.РегламентированныйОтчетЗаявлениеОВвозеТоваров.ФормаВыгрузки2012Кв2',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:554px;height:669px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Параметры выгрузки',
	
	items:
	[
		{
			xtype: 'fieldset',
			title: 'Сведения об отправителе документа',
			style: 'position:absolute;left:6px;top:30px;width:540px;height:16px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтправительЯвляетсяЮЛ',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:48px;width:120px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:72px;width:540px;height:72px;',
			height: 72,width: 540,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'ЮЛ',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьИНН',
			text: 'ИНН:',
			style: 'position:absolute;left:6px;top:24px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИННЮЛОтпр',
			width: 120,
			height: 19,
			style: 'position:absolute;left:162px;top:24px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКПП1',
			text: 'КПП:',
			style: 'position:absolute;left:6px;top:48px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КППОтпр',
			width: 120,
			height: 19,
			style: 'position:absolute;left:162px;top:48px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Наименование организации:',
			style: 'position:absolute;left:6px;top:0px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаимОтпр',
			width: 372,
			height: 19,
			style: 'position:absolute;left:162px;top:0px;width:372px;height:19px;',
		},
					]
				},
				{
					title:'ФЛ',
					items:
					[
		{
			xtype: 'label',
			name: 'Наименование1',
			text: 'Фамилия, имя, отчество:',
			style: 'position:absolute;left:6px;top:24px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьИНН1',
			text: 'ИНН физического лица:',
			style: 'position:absolute;left:6px;top:0px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИННФЛОтпр',
			width: 120,
			height: 19,
			style: 'position:absolute;left:162px;top:0px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ФамилияФЛОтпр',
			width: 120,
			height: 19,
			style: 'position:absolute;left:162px;top:24px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИмяФЛОтпр',
			width: 120,
			height: 19,
			style: 'position:absolute;left:288px;top:24px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтчествоФЛОтпр',
			width: 120,
			height: 19,
			style: 'position:absolute;left:414px;top:24px;width:120px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'fieldset',
			title: 'Сведения о лицах, подписавших документ',
			style: 'position:absolute;left:6px;top:150px;width:540px;height:16px;',
		},
		{
			xtype: 'fieldset',
			title: 'Сведения о лице, представившем документ в налоговый орган',
			style: 'position:absolute;left:6px;top:480px;width:540px;height:16px;',
		},
		{
			xtype: 'fieldset',
			title: 'Подписант 1',
			style: 'position:absolute;left:6px;top:168px;width:540px;height:162px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Должность:',
			style: 'position:absolute;left:12px;top:246px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ДолжностьПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:246px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Наименование2',
			text: 'Фамилия, имя, отчество:',
			style: 'position:absolute;left:12px;top:270px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Наименование3',
			text: 'Наименование, номер, дата\r\nдоверенности',
			style: 'position:absolute;left:12px;top:294px;width:150px;height:30px;text-align:left;',
		},
		{
			xtype: 'fieldset',
			title: 'Подписант 2',
			style: 'position:absolute;left:6px;top:336px;width:540px;height:138px;',
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Должность:',
			style: 'position:absolute;left:12px;top:378px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ДолжностьПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:378px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Наименование4',
			text: 'Фамилия, имя, отчество:',
			style: 'position:absolute;left:12px;top:402px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Наименование5',
			text: 'Фамилия, имя, отчество:',
			style: 'position:absolute;left:12px;top:582px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьИНН2',
			text: 'ИНН физического лица:',
			style: 'position:absolute;left:12px;top:558px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИННФЛКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:558px;width:120px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Документ направляется  почтовым отправлением или по ТКС.',
			style: 'position:absolute;left:12px;top:498px;width:342px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ФамилияПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:270px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИмяПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:294px;top:270px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтчествоПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:270px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ФамилияПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:402px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИмяПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:294px;top:402px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтчествоПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:402px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаимДовПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:294px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомерДовПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:294px;top:294px;width:120px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаДовПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:294px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ФамилияКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:582px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИмяКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:294px;top:582px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ОтчествоКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:582px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Наименование6',
			text: 'Наименование, номер, дата\r\nдоверенности',
			style: 'position:absolute;left:12px;top:606px;width:150px;height:30px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаимДовКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:606px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомерДовКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:294px;top:606px;width:120px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаДовКурьер',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:606px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИНН3',
			text: 'ИНН физического лица:',
			style: 'position:absolute;left:12px;top:354px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИННФЛПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:354px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИНН4',
			text: 'ИНН физического лица:',
			style: 'position:absolute;left:12px;top:222px;width:150px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ИННФЛПодп1',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:222px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись35',
			text: 'Код налогового органа, куда передаются данные:',
			style: 'position:absolute;left:6px;top:6px;width:258px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КодИФНС',
			width: 60,
			height: 19,
			style: 'position:absolute;left:270px;top:6px;width:60px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Наименование7',
			text: 'Наименование, номер, дата\r\nдокумента, подтвержд. полномочия',
			style: 'position:absolute;left:12px;top:426px;width:150px;height:42px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НаимДовПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:168px;top:426px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'НомерДовПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:294px;top:426px;width:120px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаДовПодп2',
			width: 120,
			height: 19,
			style: 'position:absolute;left:420px;top:426px;width:120px;height:19px;',
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'НП-заявитель',
			style: 'position:absolute;left:12px;top:48px;width:90px;height:19px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Уполномоченный представитель НП',
			style: 'position:absolute;left:108px;top:48px;width:204px;height:19px;',
		},
			]
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'лично - ИП-покупатель',
			style: 'position:absolute;left:12px;top:186px;width:108px;height:30px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Законный представитель организации',
			style: 'position:absolute;left:126px;top:186px;width:150px;height:30px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Уполномоченный представитель',
			style: 'position:absolute;left:282px;top:186px;width:126px;height:30px;',
		},
			]
		},
		{
			xtype: 'radiogroup',
			defaults: {name: 'ccType'},
			items: [
		{
			xtype: 'radio',
			boxLabel: 'лично - ИП-покупатель',
			style: 'position:absolute;left:12px;top:522px;width:108px;height:30px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Законный представитель организации',
			style: 'position:absolute;left:126px;top:522px;width:150px;height:30px;',
		},
		{
			xtype: 'radio',
			boxLabel: 'Уполномоченный представитель',
			style: 'position:absolute;left:282px;top:522px;width:126px;height:30px;',
		},
			]
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:644px;width:554px;height:25px;',
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
			]
		},
	]
});