﻿Ext.define('Документы.ПогашениеЗадолженностиПодотчетныхЛиц.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:600px;height:379px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Погашение задолженности подотчетных лиц',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:96px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:176px;top:33px;width:20px;height:19px;text-align:center;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'Дата',
			width: 120,
			height: 19,
			style: 'position:absolute;left:196px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьМесяц',
			text: 'Месяц начисления:',
			style: 'position:absolute;left:336px;top:33px;width:105px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьПодразделение',
			text: 'Подразделение:',
			style: 'position:absolute;left:8px;top:57px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Подразделение',
			width: 220,
			height: 19,
			style: 'position:absolute;left:96px;top:57px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:327px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 496,
			height: 19,
			style: 'position:absolute;left:96px;top:327px;width:496px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:336px;top:57px;width:105px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			trigger3Cls: 'x-form-search-trigger',
			name: 'Ответственный',
			width: 151,
			height: 19,
			style: 'position:absolute;left:441px;top:57px;width:151px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер',
			style: 'position:absolute;left:8px;top:33px;width:88px;height:19px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:83px;width:584px;height:238px;',
			height: 238,width: 584,
			items:
			[
				{
					title:'Начисления',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:570px;height:188px;',
			height: 188,width: 570,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Работник',
					width:'100',
					dataIndex:'Сотрудник',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'100',
					dataIndex:'Подразделение',
					flex:1,
				},
				{
					text:'Результат',
					width:'100',
					dataIndex:'Результат',
					flex:1,
				},
				{
					text:'Расчетный документ',
					width:'100',
					dataIndex:'РасчетныйДокумент',
					flex:1,
				},
				{
					text:'Валюта',
					width:'100',
					dataIndex:'ВалютаВзаиморасчетов',
					flex:1,
				},
				{
					text:'Сумма в валюте',
					width:'100',
					dataIndex:'СуммаВзаиморасчетов',
					flex:1,
				},
				{
					text:'Курс',
					width:'100',
					dataIndex:'КурсВзаиморасчетов',
					flex:1,
				},
				{
					text:'Кратность',
					width:'100',
					dataIndex:'КратностьВзаиморасчетов',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ПогашениеЗадолженностиПодотчетныхЛиц/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'Сотрудник',
					},
					{
						name:'Подразделение',
					},
					{
						name:'Результат',
					},
					{
						name:'РасчетныйДокумент',
					},
					{
						name:'ВалютаВзаиморасчетов',
					},
					{
						name:'СуммаВзаиморасчетов',
					},
					{
						name:'КурсВзаиморасчетов',
					},
					{
						name:'КратностьВзаиморасчетов',
					},
				]
			},
		},
					]
				},
				{
					title:'Удержания',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:24px;width:570px;height:188px;',
			height: 188,width: 570,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Работник',
					width:'100',
					dataIndex:'Физлицо',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'100',
					dataIndex:'Подразделение',
					flex:1,
				},
				{
					text:'Результат',
					width:'100',
					dataIndex:'Результат',
					flex:1,
				},
				{
					text:'Расчетный документ',
					width:'100',
					dataIndex:'РасчетныйДокумент',
					flex:1,
				},
				{
					text:'Валюта',
					width:'100',
					dataIndex:'ВалютаВзаиморасчетов',
					flex:1,
				},
				{
					text:'Сумма в валюте',
					width:'100',
					dataIndex:'СуммаВзаиморасчетов',
					flex:1,
				},
				{
					text:'Курс',
					width:'100',
					dataIndex:'КурсВзаиморасчетов',
					flex:1,
				},
				{
					text:'Кратность',
					width:'100',
					dataIndex:'КратностьВзаиморасчетов',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ПогашениеЗадолженностиПодотчетныхЛиц/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'Физлицо',
					},
					{
						name:'Подразделение',
					},
					{
						name:'Результат',
					},
					{
						name:'РасчетныйДокумент',
					},
					{
						name:'ВалютаВзаиморасчетов',
					},
					{
						name:'СуммаВзаиморасчетов',
					},
					{
						name:'КурсВзаиморасчетов',
					},
					{
						name:'КратностьВзаиморасчетов',
					},
				]
			},
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ПредставлениеПериодаРегистрации',
			width: 151,
			height: 19,
			style: 'position:absolute;left:441px;top:33px;width:151px;height:19px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:25px;',
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
					text:'Очистить',
				},
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:354px;width:600px;height:25px;',
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