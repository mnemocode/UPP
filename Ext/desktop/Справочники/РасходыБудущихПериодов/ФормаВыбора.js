﻿Ext.require(['Данные.Справочники.РасходыБудущихПериодов'], function () 
{
	Ext.define('Справочники.РасходыБудущихПериодов.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:716px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Справочник Расходы будущих периодов',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:716px;height:25px;',
			width: 716,
			height: 25,
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
			]
		},
		{
			id: 'Дерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:142px;height:284px;',
			height: 284,width: 142,
			columns:
			[
				{
					text:'Код',
					width:'78',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'371',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.РасходыБудущихПериодов").data,
					fields: ['Ссылка','Родитель.Представление','Код','Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/РасходыБудущихПериодов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('Дерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.РасходыБудущихПериодов.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.РасходыБудущихПериодов.ФормаВыбораСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			id: 'СправочникВыбор',
			xtype: 'grid',
			style: 'position:absolute;left:157px;top:33px;width:551px;height:284px;',
			height: 284,width: 551,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'72',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'220',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Вид РБП',
					width:'220',
					dataIndex:'ВидРБП.Представление',
					flex:1,
				},
				{
					text:'Способ признания расходов',
					width:'100',
					dataIndex:'СпособПризнанияРасходов.Представление',
					flex:1,
				},
				{
					text:'Сумма',
					width:'80',
					dataIndex:'Сумма',
					flex:1,
				},
				{
					text:'Начало списания',
					width:'80',
					dataIndex:'ДатаНачалаСписания',
					flex:1,
				},
				{
					text:'Окончание списания',
					width:'80',
					dataIndex:'ДатаОкончанияСписания',
					flex:1,
				},
				{
					text:'Подразделение',
					width:'120',
					dataIndex:'Подразделение.Представление',
					flex:1,
				},
				{
					text:'Подразделение (орг.)',
					width:'120',
					dataIndex:'ПодразделениеОрганизации.Представление',
					flex:1,
				},
				{
					text:'Статья затрат',
					width:'120',
					dataIndex:'СтатьяЗатрат.Представление',
					flex:1,
				},
				{
					text:'Счет',
					width:'80',
					dataIndex:'СчетБУ.Представление',
					flex:1,
				},
				{
					text:'Счет (НУ)',
					width:'80',
					dataIndex:'СчетНУ.Представление',
					flex:1,
				},
				{
					text:'Хар-р затрат',
					width:'120',
					dataIndex:'ХарактерЗатрат',
					flex:1,
				},
				{
					text:'Вид аналитики',
					width:'284',
					dataIndex:'ВидАналитики',
					flex:1,
				},
				{
					text:'Вид аналитики (доп.)',
					width:'284',
					dataIndex:'ВидАналитикиДоп',
					flex:1,
				},
				{
					text:'Вид субконто 1',
					width:'94',
					dataIndex:'ВидСубконто1',
					flex:1,
				},
				{
					text:'Вид субконто 2',
					width:'94',
					dataIndex:'ВидСубконто2',
					flex:1,
				},
				{
					text:'Вид субконто 3',
					width:'94',
					dataIndex:'ВидСубконто3',
					flex:1,
				},
				{
					text:'Вид субконто 1 (НУ)',
					width:'78',
					dataIndex:'ВидСубконтоНУ1',
					flex:1,
				},
				{
					text:'Вид субконто 2 (НУ)',
					width:'78',
					dataIndex:'ВидСубконтоНУ2',
					flex:1,
				},
				{
					text:'Вид субконто 3 (НУ)',
					width:'78',
					dataIndex:'ВидСубконтоНУ3',
					flex:1,
				},
				{
					text:'Аналитика',
					width:'117',
					dataIndex:'Аналитика',
					flex:1,
				},
				{
					text:'Номенклатурная группа',
					width:'182',
					dataIndex:'НоменклатурнаяГруппа.Представление',
					flex:1,
				},
				{
					text:'Номенклатурная группа (доп)',
					width:'154',
					dataIndex:'НоменклатурнаяГруппаДоп',
					flex:1,
				},
				{
					text:'Способ распределения затрат на выпуск',
					width:'153',
					dataIndex:'СпособРаспределенияЗатратНаВыпуск.Представление',
					flex:1,
				},
				{
					text:'Субконто 1',
					width:'100',
					dataIndex:'Субконто1',
					flex:1,
				},
				{
					text:'Субконто 2',
					width:'100',
					dataIndex:'Субконто2',
					flex:1,
				},
				{
					text:'Субконто 3',
					width:'100',
					dataIndex:'Субконто3',
					flex:1,
				},
				{
					text:'Субконто 1 (НУ)',
					width:'100',
					dataIndex:'СубконтоНУ1.Представление',
					flex:1,
				},
				{
					text:'Субконто 2 (НУ)',
					width:'100',
					dataIndex:'СубконтоНУ2.Представление',
					flex:1,
				},
				{
					text:'Субконто 3 (НУ)',
					width:'100',
					dataIndex:'СубконтоНУ3.Представление',
					flex:1,
				},
				{
					text:'Продукция',
					width:'100',
					dataIndex:'Продукция.Представление',
					flex:1,
				},
				{
					text:'Характеристика продукции',
					width:'100',
					dataIndex:'ХарактеристикаПродукции.Представление',
					flex:1,
				},
				{
					text:'Серия продукции',
					width:'100',
					dataIndex:'СерияПродукции.Представление',
					flex:1,
				},
				{
					text:'Объект строительства',
					width:'117',
					dataIndex:'ОбъектСтроительства.Представление',
					flex:1,
				},
				{
					text:'Способ строительства',
					width:'110',
					dataIndex:'СпособСтроительства.Представление',
					flex:1,
				},
				{
					text:'Вид актива',
					width:'100',
					dataIndex:'ВидАктива.Представление',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.РасходыБудущихПериодов").data,
					fields: ['Ссылка','Родитель.Представление','Картинка','Код','Наименование','ВидРБП.Представление','СпособПризнанияРасходов.Представление','Сумма','ДатаНачалаСписания','ДатаОкончанияСписания','Подразделение.Представление','ПодразделениеОрганизации.Представление','СтатьяЗатрат.Представление','СчетБУ.Представление','СчетНУ.Представление','ХарактерЗатрат','ВидАналитики','ВидАналитикиДоп','ВидСубконто1','ВидСубконто2','ВидСубконто3','ВидСубконтоНУ1','ВидСубконтоНУ2','ВидСубконтоНУ3','Аналитика','НоменклатурнаяГруппа.Представление','НоменклатурнаяГруппаДоп','СпособРаспределенияЗатратНаВыпуск.Представление','Субконто1','Субконто2','Субконто3','СубконтоНУ1.Представление','СубконтоНУ2.Представление','СубконтоНУ3.Представление','Продукция.Представление','ХарактеристикаПродукции.Представление','СерияПродукции.Представление','ОбъектСтроительства.Представление','СпособСтроительства.Представление','ВидАктива.Представление',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/РасходыБудущихПериодов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
					},
					{
						name:'ВидРБП',
					},
					{
						name:'СпособПризнанияРасходов',
					},
					{
						name:'Сумма',
					},
					{
						name:'ДатаНачалаСписания',
					},
					{
						name:'ДатаОкончанияСписания',
					},
					{
						name:'Подразделение',
					},
					{
						name:'ПодразделениеОрганизации',
					},
					{
						name:'СтатьяЗатрат',
					},
					{
						name:'СчетБУ',
					},
					{
						name:'СчетНУ',
					},
					{
						name:'ХарактерЗатрат',
					},
					{
						name:'ВидАналитики',
					},
					{
						name:'ВидАналитикиДоп',
					},
					{
						name:'ВидСубконто1',
					},
					{
						name:'ВидСубконто2',
					},
					{
						name:'ВидСубконто3',
					},
					{
						name:'ВидСубконтоНУ1',
					},
					{
						name:'ВидСубконтоНУ2',
					},
					{
						name:'ВидСубконтоНУ3',
					},
					{
						name:'Аналитика',
					},
					{
						name:'НоменклатурнаяГруппа',
					},
					{
						name:'НоменклатурнаяГруппаДоп',
					},
					{
						name:'СпособРаспределенияЗатратНаВыпуск',
					},
					{
						name:'Субконто1',
					},
					{
						name:'Субконто2',
					},
					{
						name:'Субконто3',
					},
					{
						name:'СубконтоНУ1',
					},
					{
						name:'СубконтоНУ2',
					},
					{
						name:'СубконтоНУ3',
					},
					{
						name:'Продукция',
					},
					{
						name:'ХарактеристикаПродукции',
					},
					{
						name:'СерияПродукции',
					},
					{
						name:'ОбъектСтроительства',
					},
					{
						name:'СпособСтроительства',
					},
					{
						name:'ВидАктива',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('СправочникВыбор');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.РасходыБудущихПериодов.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.РасходыБудущихПериодов.ФормаВыбораСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		],
	}],
	dockedItems:
	[
	]
	});
});