﻿Ext.require(['Данные.Справочники.СпособыОтраженияЗарплатыВУпрУчете'], function () 
{
	Ext.define('Справочники.СпособыОтраженияЗарплатыВУпрУчете.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:528px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Способы отражения зарплаты в управленческом учете ',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:512px;height:280px;',
			height: 280,width: 512,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Наименование',
					width:'220',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Статья затрат',
					width:'120',
					dataIndex:'СтатьяЗатрат.Представление',
					flex:1,
				},
				{
					text:'Номенклатурная группа',
					width:'140',
					dataIndex:'НоменклатурнаяГруппа.Представление',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.СпособыОтраженияЗарплатыВУпрУчете").data,
					fields: ['Ссылка','Картинка','Наименование','СтатьяЗатрат.Представление','НоменклатурнаяГруппа.Представление',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/СпособыОтраженияЗарплатыВУпрУчете/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Наименование',
					},
					{
						name:'СтатьяЗатрат',
					},
					{
						name:'НоменклатурнаяГруппа',
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
						var грид = Ext.getCmp('СправочникСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.СпособыОтраженияЗарплатыВУпрУчете.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.СпособыОтраженияЗарплатыВУпрУчете.ФормаВыбораСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:528px;height:25px;',
			width: 528,
			height: 25,
			items:
			[
				{
					text:'Выбрать',
				},
				'-',
			]
		},
		],
	}],
	dockedItems:
	[
	]
	});
});