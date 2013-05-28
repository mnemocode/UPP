﻿Ext.define('Справочники.ЗаявкиКандидатов.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:665px;height:580px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Кандидат',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьКод',
			text: 'Код:',
			style: 'position:absolute;left:366px;top:35px;width:24px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Код',
			width: 92,
			height: 19,
			style: 'position:absolute;left:392px;top:35px;width:92px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНаименование',
			text: 'Наименование:',
			style: 'position:absolute;left:8px;top:35px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Наименование',
			width: 253,
			height: 19,
			style: 'position:absolute;left:96px;top:35px;width:253px;height:19px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			style: 'position:absolute;left:8px;top:200px;width:341px;height:163px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Работа по кандидату завершена',
			style: 'position:absolute;left:366px;top:491px;width:291px;height:15px;',
		},
		{
			xtype: 'textarea',
			hideLabel: true,
			disabled: false,
			name: 'РезультатЗакрытия',
			style: 'position:absolute;left:366px;top:507px;width:291px;height:40px;',
		},
		{
			xtype: 'label',
			name: 'НадписьФизЛицо',
			text: 'Физическое лицо:',
			style: 'position:absolute;left:366px;top:438px;width:118px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'ФизЛицо',
			width: 167,
			height: 19,
			style: 'position:absolute;left:490px;top:438px;width:167px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьГруппаЗадач',
			text: 'Группа кандидатов:',
			style: 'position:absolute;left:366px;top:414px;width:118px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'ГруппаЗадач',
			width: 167,
			height: 19,
			style: 'position:absolute;left:490px;top:414px;width:167px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИсточникИнформации',
			text: 'Источник информации:',
			style: 'position:absolute;left:366px;top:390px;width:118px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'ИсточникИнформации',
			width: 167,
			height: 19,
			style: 'position:absolute;left:490px;top:390px;width:167px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Дополнительно',
			style: 'position:absolute;left:366px;top:370px;width:291px;height:16px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:63px;width:649px;height:127px;',
			height: 127,width: 649,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьСостояние',
			text: 'Результат:',
			style: 'position:absolute;left:359px;top:28px;width:57px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			name: 'Состояние',
			width: 220,
			height: 19,
			style: 'position:absolute;left:421px;top:28px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДатаОткрытия',
			text: 'Дата поступления кандидата:',
			style: 'position:absolute;left:359px;top:76px;width:155px;height:19px;text-align:left;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаОткрытия',
			width: 80,
			height: 19,
			style: 'position:absolute;left:520px;top:76px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВажность',
			text: 'Важность:',
			style: 'position:absolute;left:359px;top:52px;width:57px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Важность',
			width: 220,
			height: 19,
			style: 'position:absolute;left:421px;top:52px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВакансия',
			text: 'Вакансия:',
			style: 'position:absolute;left:6px;top:28px;width:100px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Вакансия',
			width: 230,
			height: 19,
			style: 'position:absolute;left:111px;top:28px;width:230px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Позиционирование',
			style: 'position:absolute;left:6px;top:6px;width:335px;height:16px;',
		},
		{
			xtype: 'fieldset',
			title: 'Состояние',
			style: 'position:absolute;left:359px;top:6px;width:282px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДолжность',
			text: 'Должность:',
			style: 'position:absolute;left:6px;top:52px;width:100px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Должность',
			width: 230,
			height: 19,
			style: 'position:absolute;left:111px;top:52px;width:230px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:6px;top:76px;width:335px;height:24px;',
			height: 24,width: 335,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Организация',
					items:
					[
		{
			xtype: 'label',
			name: 'НадписьОрганизация',
			text: 'Организация:',
			style: 'position:absolute;left:0px;top:0px;width:100px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация',
			width: 230,
			height: 19,
			style: 'position:absolute;left:105px;top:0px;width:230px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьПодразделениеОрганизации',
			text: 'Подразделение:',
			style: 'position:absolute;left:6px;top:100px;width:100px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Подразделение',
			width: 230,
			height: 19,
			style: 'position:absolute;left:111px;top:100px;width:230px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:390px;width:341px;height:157px;',
			height: 157,width: 341,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'ВидДокумента',
					flex:1,
				},
				{
					text:'',
					width:'21',
					dataIndex:'ЕстьВложения',
					flex:1,
				},
				{
					text:'Дата контакта',
					width:'132',
					dataIndex:'ДатаКонтакта',
					flex:1,
				},
				{
					text:'Тема',
					width:'166',
					dataIndex:'Тема',
					flex:1,
				},
				{
					text:'Отправитель',
					width:'100',
					dataIndex:'ОтправительИмя',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЗаявкиКандидатов/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'ВидДокумента',
					},
					{
						name:'ЕстьВложения',
					},
					{
						name:'ДатаКонтакта',
					},
					{
						name:'Тема',
					},
					{
						name:'ОтправительИмя',
					},
				]
			},
		},
		{
			xtype: 'label',
			name: 'НадписьЖурнал',
			text: 'Переписка, встречи и опросы',
			style: 'position:absolute;left:8px;top:370px;width:341px;height:15px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаОткрытьРезюме',
			text: 'Открыть резюме',
			style: 'position:absolute;left:490px;top:33px;width:167px;height:24px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:366px;top:462px;width:118px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Ответственный',
			width: 167,
			height: 19,
			style: 'position:absolute;left:490px;top:462px;width:167px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТекущаяРабота',
			text: 'Текущая работа по кандидату',
			style: 'position:absolute;left:366px;top:200px;width:291px;height:15px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:366px;top:220px;width:291px;height:144px;',
			height: 144,width: 291,
			columns:
			[
				{
					text:'Дата',
					width:'80',
					dataIndex:'Период',
					flex:1,
				},
				{
					text:'Что сделано',
					width:'115',
					dataIndex:'Описание',
					flex:1,
				},
				{
					text:'Результат',
					width:'100',
					dataIndex:'Состояние',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЗаявкиКандидатов/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Период',
					},
					{
						name:'Описание',
					},
					{
						name:'Состояние',
					},
				]
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:16px;top:500px;width:251px;height:24px;',
			items:
			[
				{
					text:'Зарегистрировать результат',
				},
			]
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:665px;height:25px;',
			dock: 'top',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'Найти в списке',
				},
				'-',
				{
					text:'Перечитать',
				},
				{
					text:'Скопировать',
				},
				'-',
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'',
				},
					]
				},
				'-',
				{
					text:'Записать',
				},
				{
					text:'Записать и закрыть',
				},
				'-',
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Редактировать код',
				},
					]
				},
				'-',
				{
					text:'Файлы',
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:555px;width:665px;height:25px;',
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