﻿Ext.define('Документы.ЗарплатаКВыплате.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:537px;height:524px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Зарплата к выплате',
	
	items:
	[
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:118px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОт',
			text: 'от:',
			style: 'position:absolute;left:198px;top:33px;width:20px;height:19px;text-align:center;',
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
			style: 'position:absolute;left:218px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьОтветственный',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:59px;width:84px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			trigger3Cls: 'x-form-search-trigger',
			name: 'Ответственный',
			width: 220,
			height: 19,
			style: 'position:absolute;left:118px;top:59px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:472px;width:88px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 433,
			height: 19,
			style: 'position:absolute;left:96px;top:472px;width:433px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:222px;width:521px;height:24px;',
			items:
			[
				{
					text:'&Добавить',
				},
				{
					text:'Удалить',
				},
				'-',
				{
					text:'',
				},
				{
					text:'',
				},
				{
					text:'Конструктор настроек...',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Подбор списком',
				},
				'-',
				{
					text:'Удалить пустые',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:246px;width:521px;height:220px;',
			height: 220,width: 521,
			columns:
			[
				{
					text:'Картинка',
					width:'21',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Признак автоматического расчета',
					width:'21',
					dataIndex:'Авторасчет',
					flex:1,
				},
				{
					text:'№',
					width:'31',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Сотрудник',
					width:'323',
					dataIndex:'Физлицо',
					flex:1,
				},
				{
					text:'Сумма',
					width:'104',
					dataIndex:'Сумма',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ЗарплатаКВыплате/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Картинка',
					},
					{
						name:'Авторасчет',
					},
					{
						name:'НомерСтроки',
					},
					{
						name:'Физлицо',
					},
					{
						name:'Сумма',
					},
				]
			},
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:88px;width:521px;height:60px;',
			height: 60,width: 521,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'ХарактерВыплаты',
			width: 400,
			height: 19,
			style: 'position:absolute;left:110px;top:31px;width:400px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Подразделение',
			width: 400,
			height: 19,
			style: 'position:absolute;left:110px;top:6px;width:400px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьХарактерВыплаты',
			text: 'Выплачивать:',
			style: 'position:absolute;left:6px;top:31px;width:80px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'button',
			name: 'КнопкаЗаполнить',
			text: 'Заполнить',
			style: 'position:absolute;left:8px;top:159px;width:116px;height:35px;',
		},
		{
			xtype: 'label',
			name: 'НадписьПараметрыЗаполнения',
			text: '',
			style: 'position:absolute;left:157px;top:159px;width:372px;height:35px;',
		},
		{
			xtype: 'fieldset',
			title: 'Сотрудники',
			style: 'position:absolute;left:8px;top:206px;width:521px;height:16px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:49px;top:341px;width:458px;height:24px;',
			items:
			[
				{
					text:'',
				},
				{
					text:'',
				},
				'-',
				{
					text:'Установить отбор и сортировку списка...',
				},
				{
					text:'Отбор по значению в текущей колонке',
				},
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'(Список отборов)',
				},
				'-',
				{
					text:'(История отборов)',
				},
					]
				},
				{
					text:'Отключить отбор',
				},
				'-',
				{
					text:'Вывести список...',
				},
				{
					text:'Настройка списка...',
				},
			]
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:537px;height:25px;',
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
				{
					text:'Записать',
				},
				{
					text:'Записать и закрыть',
				},
				'-',
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
					]
				},
				'-',
				{
					text:'Закрыть',
				},
				'-',
				{
					text:'Редактировать номер',
				},
					]
				},
				'-',
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
					]
				},
				'-',
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
				{
					text:'',
				},
				{
					text:'',
				},
					]
				},
				'-',
				{
					text:'Провести',
				},
				{
					text:'Действие1',
				},
				'-',
				{
					text:'Действие4',
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
			style: 'position:absolute;left:0px;top:499px;width:537px;height:25px;',
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