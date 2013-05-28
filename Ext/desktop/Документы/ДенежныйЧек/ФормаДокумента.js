﻿Ext.define('Документы.ДенежныйЧек.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:663px;height:370px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Денежный чек',
	
	items:
	[
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:57px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Организация',
			width: 219,
			height: 19,
			style: 'position:absolute;left:102px;top:57px;width:219px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'Банковский счет:',
			style: 'position:absolute;left:8px;top:81px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'СчетОрганизации',
			width: 219,
			height: 19,
			style: 'position:absolute;left:102px;top:81px;width:219px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Касса:',
			style: 'position:absolute;left:341px;top:81px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Касса',
			width: 219,
			height: 19,
			style: 'position:absolute;left:435px;top:81px;width:219px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'Сумма по чеку:',
			style: 'position:absolute;left:8px;top:105px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СуммаДокумента',
			style: 'position:absolute;left:102px;top:105px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись8',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:129px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-search-trigger',
			name: 'Ответственный',
			width: 219,
			height: 19,
			style: 'position:absolute;left:102px;top:129px;width:219px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:193px;width:647px;height:100px;',
			height: 100,width: 647,
			columns:
			[
				{
					text:'№',
					width:'28',
					dataIndex:'НомерСтроки',
					flex:1,
				},
				{
					text:'Ведомость',
					width:'290',
					dataIndex:'Ведомость',
					flex:1,
				},
				{
					text:'Сумма',
					width:'122',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Статья движения денежных средств',
					width:'202',
					dataIndex:'СтатьяДвиженияДенежныхСредств',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ДенежныйЧек/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'НомерСтроки',
					},
					{
						name:'Ведомость',
					},
					{
						name:'Сумма',
					},
					{
						name:'СтатьяДвиженияДенежныхСредств',
					},
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:92px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:102px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'от:',
			style: 'position:absolute;left:184px;top:33px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'Дата',
			width: 119,
			height: 19,
			style: 'position:absolute;left:202px;top:33px;width:119px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Оплачено:',
			style: 'position:absolute;left:341px;top:33px;width:92px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаОплаты',
			width: 80,
			height: 19,
			style: 'position:absolute;left:435px;top:33px;width:80px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Рамка',
			style: 'position:absolute;left:8px;top:153px;width:647px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'НадписьИтогоЗП',
			text: 'Итого на выплату заработной платы: 15000 руб',
			style: 'position:absolute;left:8px;top:298px;width:364px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалюта',
			text: 'Руб',
			style: 'position:absolute;left:224px;top:105px;width:97px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьСтатья',
			text: 'Статья движ. ден. средств:',
			style: 'position:absolute;left:341px;top:105px;width:92px;height:27px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'СтатьяДвиженияДенежныхСредств',
			width: 220,
			height: 19,
			style: 'position:absolute;left:435px;top:105px;width:220px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьКомментарий',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:318px;width:73px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 568,
			height: 19,
			style: 'position:absolute;left:87px;top:318px;width:568px;height:19px;',
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:169px;width:647px;height:24px;',
			dock: 'top',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:663px;height:25px;',
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
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:345px;width:663px;height:25px;',
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