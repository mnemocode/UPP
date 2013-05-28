﻿Ext.define('Справочники.Номенклатура.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:733px;height:349px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Номенклатура',
	
	items:
	[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:717px;height:306px;',
			height: 306,width: 717,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'ВыборНоменклатуры',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:166px;top:25px;width:551px;height:130px;',
			height: 130,width: 551,
			columns:
			[
				{
					text:'',
					width:'39',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'40',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Артикул ',
					width:'60',
					dataIndex:'Артикул',
					flex:1,
				},
				{
					text:'Наименование',
					width:'220',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Вид номенклатуры',
					width:'110',
					dataIndex:'ВидНоменклатуры',
					flex:1,
				},
				{
					text:'Базовая',
					width:'54',
					dataIndex:'БазоваяЕдиницаИзмерения',
					flex:1,
				},
				{
					text:'Единица',
					width:'54',
					dataIndex:'ЕдиницаХраненияОстатков',
					flex:1,
				},
				{
					text:'Ставка НДС',
					width:'80',
					dataIndex:'СтавкаНДС',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Картинка',
					},
					{
						name:'Код',
					},
					{
						name:'Артикул',
					},
					{
						name:'Наименование',
					},
					{
						name:'ВидНоменклатуры',
					},
					{
						name:'БазоваяЕдиницаИзмерения',
					},
					{
						name:'ЕдиницаХраненияОстатков',
					},
					{
						name:'СтавкаНДС',
					},
				]
			},
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:25px;width:160px;height:130px;',
			height: 130,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'80',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Наименование',
					},
				]
			},
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:161px;width:160px;height:144px;',
			height: 144,width: 160,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:166px;top:161px;width:551px;height:144px;',
			height: 144,width: 551,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Остатки товаров на складах',
			style: 'position:absolute;left:0px;top:0px;width:551px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:152px;top:21px;width:399px;height:99px;',
			height: 99,width: 399,
			columns:
			[
				{
					text:'Характеристика/Склад',
					width:'151',
					dataIndex:'ХарактеристикаСклад',
					flex:1,
				},
				{
					text:'Ячейка склада',
					width:'87',
					dataIndex:'МестоХранения',
					flex:1,
				},
				{
					text:'Общий',
					width:'60',
					dataIndex:'Общий',
					flex:1,
				},
				{
					text:'Свободный',
					width:'71',
					dataIndex:'Свободный',
					flex:1,
				},
				{
					text:'Своб.ожид.',
					width:'68',
					dataIndex:'СвободныйОжидаемый',
					flex:1,
				},
				{
					text:'В резерве',
					width:'75',
					dataIndex:'ВРезерве',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'ХарактеристикаСклад',
					},
					{
						name:'МестоХранения',
					},
					{
						name:'Общий',
					},
					{
						name:'Свободный',
					},
					{
						name:'СвободныйОжидаемый',
					},
					{
						name:'ВРезерве',
					},
				]
			},
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:147px;height:123px;',
			height: 123,width: 147,
			columns:
			[
				{
					text:'Типы цен',
					width:'133',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Ссылка',
					width:'82',
					dataIndex:'Ссылка',
					flex:1,
				},
				{
					text:'БазовыйТипЦен',
					width:'100',
					dataIndex:'БазовыйТипЦен',
					flex:1,
				},
				{
					text:'Рассчитывается',
					width:'100',
					dataIndex:'Рассчитывается',
					flex:1,
				},
				{
					text:'ОкруглятьВБольшуюСторону',
					width:'100',
					dataIndex:'ОкруглятьВБольшуюСторону',
					flex:1,
				},
				{
					text:'ПроцентСкидкиНаценки',
					width:'100',
					dataIndex:'ПроцентСкидкиНаценки',
					flex:1,
				},
				{
					text:'Префикс',
					width:'100',
					dataIndex:'Префикс',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Наименование',
					},
					{
						name:'Ссылка',
					},
					{
						name:'БазовыйТипЦен',
					},
					{
						name:'Рассчитывается',
					},
					{
						name:'ОкруглятьВБольшуюСторону',
					},
					{
						name:'ПроцентСкидкиНаценки',
					},
					{
						name:'Префикс',
					},
				]
			},
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'ВалютаЦены',
			width: 133,
			height: 19,
			style: 'position:absolute;left:418px;top:125px;width:133px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьВалютаЦены',
			text: 'Валюта:',
			style: 'position:absolute;left:370px;top:125px;width:46px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьТипРасчета',
			text: 'Валюта цены:',
			style: 'position:absolute;left:154px;top:125px;width:73px;height:19px;text-align:left;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:230px;top:125px;width:137px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораСпискаНоменклатуры',
			width: 489,
			height: 19,
			style: 'position:absolute;left:228px;top:0px;width:489px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:0px;top:0px;width:160px;height:19px;',
		},
					]
				},
				{
					title:'ВыборНоменклатурыКонтрагента',
					items:
					[
		{
			xtype: 'grid',
			style: 'position:absolute;left:186px;top:0px;width:531px;height:305px;',
			height: 305,width: 531,
			columns:
			[
				{
					text:'',
					width:'28',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Артикул',
					width:'86',
					dataIndex:'АртикулНоменклатурыКонтрагента',
					flex:1,
				},
				{
					text:'Номенклатура',
					width:'242',
					dataIndex:'Номенклатура',
					flex:1,
				},
				{
					text:'Наименование номенклатуры контрагента',
					width:'139',
					dataIndex:'НаименованиеНоменклатурыКонтрагента',
					flex:1,
				},
				{
					text:'Код номенклатуры контрагента',
					width:'157',
					dataIndex:'КодНоменклатурыКонтрагента',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Номенклатура/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Картинка',
					},
					{
						name:'АртикулНоменклатурыКонтрагента',
					},
					{
						name:'Номенклатура',
					},
					{
						name:'НаименованиеНоменклатурыКонтрагента',
					},
					{
						name:'КодНоменклатурыКонтрагента',
					},
				]
			},
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:0px;top:0px;width:180px;height:305px;',
			height: 305,width: 180,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
					]
				},
			]
		},
					]
				},
			]
		},
	],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:733px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'&Добавить',
				},
				{
					text:'Новая группа',
				},
				{
					text:'&Скопировать',
				},
				{
					text:'&Изменить',
				},
				{
					text:'Установить пометку удаления',
				},
				'-',
				{
					text:'Иерархический просмотр',
				},
				{
					text:'Переместить в группу',
				},
				{
					text:'Уровень вверх',
				},
				{
					text:'Уровень вниз',
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
					text:'История отборов',
					menu: [
				{
					text:'(Список отборов)',
				},
				'-',
				{
					text:'(История отборов)',
				},
				'-',
					]
				},
				{
					text:'Отключить отбор',
				},
				{
					xtype: 'splitbutton',
					text:'Сортировка',
					menu: [
				{
					text:'(Поля сортировки)',
				},
					]
				},
				'-',
				{
					text:'Вывести список...',
				},
				{
					text:'Настройка списка...',
				},
				'-',
				{
					text:'Обновить',
				},
				'-',
				{
					text:'Номенклатура контрагента',
				},
				{
					text:'Остатки товаров на складах',
				},
					]
				},
				'-',
				{
					text:'&Добавить',
				},
				{
					text:'Новая группа',
				},
				{
					text:'&Скопировать',
				},
				{
					text:'&Изменить',
				},
				{
					text:'Установить пометку удаления',
				},
				'-',
				{
					text:'Иерархический просмотр',
				},
				{
					text:'Переместить в группу',
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
					text:'История отборов',
					menu: [
					]
				},
				{
					text:'Отключить отбор',
				},
				'-',
				{
					text:'Обновить',
				},
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				{
					text:'',
				},
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
					text:'Справка',
				},
				'-',
				{
					text:'Поиск по штрихкоду',
				},
				'-',
				{
					text:'Изображение',
				},
			]
		},
	]
});