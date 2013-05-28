﻿Ext.define('Обработки.МСФОКонсолидация.ФормаКонсолидацияОтчетности',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:778px;height:455px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Консолидация отчетности по МСФО',
	
	items:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:430px;width:778px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'<< Назад',
				},
				'-',
				{
					text:'Далее >>',
				},
				'-',
				{
					text:'Закрыть',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:762px;height:414px;',
			height: 414,width: 762,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Период консолидации отчетности:',
			style: 'position:absolute;left:0px;top:21px;width:180px;height:19px;text-align:left;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'Период',
			width: 120,
			height: 19,
			style: 'position:absolute;left:182px;top:21px;width:120px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:45px;width:762px;height:120px;',
			height: 120,width: 762,
			columns:
			[
				{
					text:'Фирма',
					width:'220',
					dataIndex:'Фирма',
					flex:1,
				},
				{
					text:'Баланс',
					width:'60',
					dataIndex:'Баланс',
					flex:1,
				},
				{
					text:'Пр.и уб.',
					width:'60',
					dataIndex:'ПрибылиИУбытки',
					flex:1,
				},
				{
					text:'ДДС',
					width:'60',
					dataIndex:'ДДС',
					flex:1,
				},
				{
					text:'Дв.кап.',
					width:'60',
					dataIndex:'ДвижениеКапитала',
					flex:1,
				},
				{
					text:'Уч.пол.',
					width:'60',
					dataIndex:'УчетнаяПолитика',
					flex:1,
				},
				{
					text:'Прим.',
					width:'60',
					dataIndex:'Примечания',
					flex:1,
				},
				{
					text:'Вкл.',
					width:'60',
					dataIndex:'Включать',
					flex:1,
				},
				{
					text:'Способ конс.',
					width:'120',
					dataIndex:'СпособКонсолидации',
					flex:1,
				},
				{
					text:'БалансСсылка',
					width:'21',
					dataIndex:'БалансСсылка',
					flex:1,
				},
				{
					text:'ПрибылиИУбыткиСсылка',
					width:'21',
					dataIndex:'ПрибылиИУбыткиСсылка',
					flex:1,
				},
				{
					text:'ДДССсылка',
					width:'21',
					dataIndex:'ДДССсылка',
					flex:1,
				},
				{
					text:'ДвижениеКапиталаСсылка',
					width:'21',
					dataIndex:'ДвижениеКапиталаСсылка',
					flex:1,
				},
				{
					text:'УчетнаяПолитикаСсылка',
					width:'21',
					dataIndex:'УчетнаяПолитикаСсылка',
					flex:1,
				},
				{
					text:'ПримечанияСсылка',
					width:'21',
					dataIndex:'ПримечанияСсылка',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Фирма',
					},
					{
						name:'Баланс',
					},
					{
						name:'ПрибылиИУбытки',
					},
					{
						name:'ДДС',
					},
					{
						name:'ДвижениеКапитала',
					},
					{
						name:'УчетнаяПолитика',
					},
					{
						name:'Примечания',
					},
					{
						name:'Включать',
					},
					{
						name:'СпособКонсолидации',
					},
					{
						name:'БалансСсылка',
					},
					{
						name:'ПрибылиИУбыткиСсылка',
					},
					{
						name:'ДДССсылка',
					},
					{
						name:'ДвижениеКапиталаСсылка',
					},
					{
						name:'УчетнаяПолитикаСсылка',
					},
					{
						name:'ПримечанияСсылка',
					},
				]
			},
		},
		{
			xtype: 'button',
			name: 'Обновить',
			text: 'Обновить',
			style: 'position:absolute;left:309px;top:21px;width:80px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Выбор отчетов для консолидации',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:214px;width:762px;height:200px;',
			height: 200,width: 762,
			columns:
			[
				{
					text:'Фирма',
					width:'220',
					dataIndex:'Организация',
					flex:1,
				},
				{
					text:'Головная',
					width:'60',
					dataIndex:'Головная',
					flex:1,
				},
				{
					text:'Товары (на начало)',
					width:'104',
					dataIndex:'ТоварыПрибыльНаНачало',
					flex:1,
				},
				{
					text:'Товары (оборот)',
					width:'104',
					dataIndex:'ТоварыПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'Материалы (на начало)',
					width:'100',
					dataIndex:'СырьеИМатериалыПрибыльНаНачало',
					flex:1,
				},
				{
					text:'Материалы (оборот)',
					width:'100',
					dataIndex:'СырьеИМатериалыПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'НЗП (на начало)',
					width:'100',
					dataIndex:'НезавершенноеПроизводствоПрибыльНаНачало',
					flex:1,
				},
				{
					text:'НЗП (оборот)',
					width:'100',
					dataIndex:'НезавершенноеПроизводствоПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'Полуфабрикаты (на начало)',
					width:'100',
					dataIndex:'КомплектующиеИПолуфабрикатыПрибыльНаНачало',
					flex:1,
				},
				{
					text:'Полуфабрикаты (оборот)',
					width:'100',
					dataIndex:'КомплектующиеИПолуфабрикатыПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'ГП (на начало)',
					width:'100',
					dataIndex:'ГотоваяПродукцияПрибыльНаНачало',
					flex:1,
				},
				{
					text:'ГП (оборот)',
					width:'100',
					dataIndex:'ГотоваяПродукцияПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'Товары отгр. (на начало)',
					width:'100',
					dataIndex:'ТоварыОтгруженныеПрибыльНаНачало',
					flex:1,
				},
				{
					text:'Товары отгр. (оборот)',
					width:'100',
					dataIndex:'ТоварыОтгруженныеПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'ОС (на начало)',
					width:'100',
					dataIndex:'ОСПрибыльНаНачало',
					flex:1,
				},
				{
					text:'ОС (оборот)',
					width:'100',
					dataIndex:'ОСПрибыльВТеченииГода',
					flex:1,
				},
				{
					text:'НМА (на начало)',
					width:'100',
					dataIndex:'НМАПрибыльНаНачало',
					flex:1,
				},
				{
					text:'НМА (оборот)',
					width:'100',
					dataIndex:'НМАПрибыльВТеченииГода',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Организация',
					},
					{
						name:'Головная',
					},
					{
						name:'ТоварыПрибыльНаНачало',
					},
					{
						name:'ТоварыПрибыльВТеченииГода',
					},
					{
						name:'СырьеИМатериалыПрибыльНаНачало',
					},
					{
						name:'СырьеИМатериалыПрибыльВТеченииГода',
					},
					{
						name:'НезавершенноеПроизводствоПрибыльНаНачало',
					},
					{
						name:'НезавершенноеПроизводствоПрибыльВТеченииГода',
					},
					{
						name:'КомплектующиеИПолуфабрикатыПрибыльНаНачало',
					},
					{
						name:'КомплектующиеИПолуфабрикатыПрибыльВТеченииГода',
					},
					{
						name:'ГотоваяПродукцияПрибыльНаНачало',
					},
					{
						name:'ГотоваяПродукцияПрибыльВТеченииГода',
					},
					{
						name:'ТоварыОтгруженныеПрибыльНаНачало',
					},
					{
						name:'ТоварыОтгруженныеПрибыльВТеченииГода',
					},
					{
						name:'ОСПрибыльНаНачало',
					},
					{
						name:'ОСПрибыльВТеченииГода',
					},
					{
						name:'НМАПрибыльНаНачало',
					},
					{
						name:'НМАПрибыльВТеченииГода',
					},
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'При двойном щелчке мышью по ячейке, отмеченной "флажком" откроется форма соответствующего отчета.',
			style: 'position:absolute;left:0px;top:171px;width:762px;height:15px;',
		},
		{
			xtype: 'fieldset',
			title: 'Прибыль от внутригрупповых операций в разрезе указанных активов',
			style: 'position:absolute;left:0px;top:193px;width:762px;height:16px;',
		},
					]
				},
				{
					title:'Страница2',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по долгосрочным займам (полученным и выданным) за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись3',
			text: 'В таблицах указаны организации, которые выдали или получили долгосрочные займы друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон5',
			text: 'Итого сумма взаимных займов за :',
			style: 'position:absolute;left:0px;top:186px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон5',
			style: 'position:absolute;left:222px;top:186px;width:120px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по долгосрочным займам (полученным и выданным) за ',
			style: 'position:absolute;left:0px;top:211px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:232px;width:762px;height:138px;',
			height: 138,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред5',
			text: 'Итого сумма взаимных займов за :',
			style: 'position:absolute;left:0px;top:375px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред5',
			style: 'position:absolute;left:222px;top:375px;width:120px;height:19px;',
		},
					]
				},
				{
					title:'Страница3',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по текущим займам (полученным и выданным) за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись4',
			text: 'В таблицах указаны организации, которые выдали или получили краткосрочные займы друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон6',
			text: 'Итого сумма взаимных займов за ',
			style: 'position:absolute;left:0px;top:186px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон6',
			style: 'position:absolute;left:222px;top:186px;width:124px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по текущим займам (полученным и выданным) за ',
			style: 'position:absolute;left:0px;top:211px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:232px;width:762px;height:138px;',
			height: 138,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред6',
			text: 'Итого сумма взаимных займов за ',
			style: 'position:absolute;left:0px;top:375px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред6',
			style: 'position:absolute;left:222px;top:375px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'В таблицах указаны организации, которые выдали или получили долгосрочные авансы друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'В таблицах указаны организации, которые выдали или получили краткосрочные авансы друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
					]
				},
				{
					title:'Страница4',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по авансам выданным и доходами буд.периодов (долгосрочные) за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоКон7',
			text: 'Итого сумма взаимных авансов за ',
			style: 'position:absolute;left:0px;top:186px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон7',
			style: 'position:absolute;left:222px;top:186px;width:124px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по авансам выданным и доходами буд.периодов (долгосрочные) за ',
			style: 'position:absolute;left:0px;top:211px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:232px;width:762px;height:138px;',
			height: 138,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред7',
			text: 'Итого сумма взаимных авансов за ',
			style: 'position:absolute;left:0px;top:375px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред7',
			style: 'position:absolute;left:222px;top:375px;width:124px;height:19px;',
		},
					]
				},
				{
					title:'Страница5',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по авансам выданным и доходами буд.периодов (текущие) за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоКон8',
			text: 'Итого сумма взаимных авансов за ',
			style: 'position:absolute;left:0px;top:186px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон8',
			style: 'position:absolute;left:222px;top:186px;width:124px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по авансам выданным и доходами буд.периодов (текущие) за ',
			style: 'position:absolute;left:0px;top:211px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:232px;width:762px;height:138px;',
			height: 138,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред8',
			text: 'Итого сумма взаимных авансов за ',
			style: 'position:absolute;left:0px;top:375px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред8',
			style: 'position:absolute;left:222px;top:375px;width:124px;height:19px;',
		},
					]
				},
				{
					title:'Страница6',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по выручке от реализации за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'В таблицах указаны организации, которые выдали или получили выручку друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон11',
			text: 'Итого сумма взаимной выручки за ',
			style: 'position:absolute;left:0px;top:197px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон11',
			style: 'position:absolute;left:222px;top:197px;width:124px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по выручке от реализации за ',
			style: 'position:absolute;left:0px;top:222px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:243px;width:762px;height:127px;',
			height: 127,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред11',
			text: 'Итого сумма взаимной выручки за ',
			style: 'position:absolute;left:0px;top:375px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред11',
			style: 'position:absolute;left:222px;top:375px;width:124px;height:19px;',
		},
					]
				},
				{
					title:'Страница7',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по себестоимости реализации за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись8',
			text: 'В таблицах указаны организации, которые выдали или получили себестоимость друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон12',
			text: 'Итого сумма взаимной себест. за ',
			style: 'position:absolute;left:0px;top:186px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон12',
			style: 'position:absolute;left:222px;top:186px;width:124px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по себестоимости реализации за ',
			style: 'position:absolute;left:0px;top:211px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:232px;width:762px;height:138px;',
			height: 138,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред12',
			text: 'Итого сумма взаимной себест. за ',
			style: 'position:absolute;left:0px;top:375px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред12',
			style: 'position:absolute;left:222px;top:375px;width:124px;height:19px;',
		},
					]
				},
				{
					title:'Страница8',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по дивидендам к выплате за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:160px;',
			height: 160,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'Надпись9',
			text: 'В таблицах указаны организации, которые выдали или получили дивиденды друг от друга.',
			style: 'position:absolute;left:0px;top:399px;width:762px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон21',
			text: 'Итого сумма взаимных дивидендов за ',
			style: 'position:absolute;left:0px;top:186px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон21',
			style: 'position:absolute;left:222px;top:186px;width:124px;height:19px;',
		},
		{
			xtype: 'fieldset',
			title: 'Стыковка записей по дивидендам к выплате за ',
			style: 'position:absolute;left:0px;top:211px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:232px;width:762px;height:137px;',
			height: 137,width: 762,
			columns:
			[
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
				]
			},
		},
		{
			xtype: 'label',
			name: 'ИтогоПред21',
			text: 'Итого сумма взаимных дивидендов за ',
			style: 'position:absolute;left:0px;top:374px;width:220px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'Пред21',
			style: 'position:absolute;left:222px;top:374px;width:124px;height:19px;',
		},
					]
				},
				{
					title:'Страница9',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Текущая и долгосрочная дебиторская и кредиторская задолженность за ',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'fieldset',
			title: 'Текущая и долгосрочная дебиторская и кредиторская задолженность за ',
			style: 'position:absolute;left:0px;top:151px;width:762px;height:16px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон41',
			text: 'Текущая дебиторская задолженность:',
			style: 'position:absolute;left:0px;top:22px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон40',
			style: 'position:absolute;left:245px;top:22px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон42',
			text: 'Текущая кредиторская задолженность:',
			style: 'position:absolute;left:0px;top:46px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон41',
			style: 'position:absolute;left:245px;top:46px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон43',
			text: 'Долгосрочная дебиторская задолженность:',
			style: 'position:absolute;left:0px;top:70px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон42',
			style: 'position:absolute;left:245px;top:70px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон44',
			text: 'Долгосрочная кредиторская задолженность:',
			style: 'position:absolute;left:0px;top:94px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумКон43',
			style: 'position:absolute;left:245px;top:94px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон45',
			text: 'Текущая дебиторская задолженность:',
			style: 'position:absolute;left:0px;top:174px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумПред40',
			style: 'position:absolute;left:245px;top:174px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон46',
			text: 'Текущая кредиторская задолженность:',
			style: 'position:absolute;left:0px;top:198px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумПред41',
			style: 'position:absolute;left:245px;top:198px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон47',
			text: 'Долгосрочная дебиторская задолженность:',
			style: 'position:absolute;left:0px;top:222px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумПред42',
			style: 'position:absolute;left:245px;top:222px;width:124px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'ИтогоКон48',
			text: 'Долгосрочная кредиторская задолженность:',
			style: 'position:absolute;left:0px;top:246px;width:237px;height:19px;text-align:left;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'СумПред43',
			style: 'position:absolute;left:245px;top:246px;width:124px;height:19px;',
		},
					]
				},
				{
					title:'Страница10',
					items:
					[
		{
			xtype: 'fieldset',
			title: 'Сформированная консолидированная отчетность',
			style: 'position:absolute;left:0px;top:0px;width:762px;height:16px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:0px;top:21px;width:762px;height:393px;',
			height: 393,width: 762,
			columns:
			[
				{
					text:'Отчет',
					width:'524',
					dataIndex:'Отчет',
					flex:1,
				},
				{
					text:'Ссылка',
					width:'21',
					dataIndex:'Ссылка',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/МСФОКонсолидация/ВыбратьПоСсылке/100'},
				fields:
				[
					{
						name:'Отчет',
					},
					{
						name:'Ссылка',
					},
				]
			},
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