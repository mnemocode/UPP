﻿Ext.require(['Данные.Справочники.ОбработкиОбслуживанияТО'], function () 
{
	Ext.define('Справочники.ОбработкиОбслуживанияТО.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:600px;height:300px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Справочник Обработки обслуживания торгового оборудования',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:584px;height:259px;',
			height: 259,width: 584,
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
					width:'80',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Вид торгового оборудования',
					width:'200',
					dataIndex:'Вид.Представление',
					flex:1,
				},
				{
					text:'Наименование',
					width:'300',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ОбработкиОбслуживанияТО").data,
					fields: ['Ссылка','Картинка','Код','Вид.Представление','Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОбработкиОбслуживанияТО/ВыбратьПоСсылке/100', timeout: 200},
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
						name:'Вид',
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
						var грид = Ext.getCmp('СправочникСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.ОбработкиОбслуживанияТО.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОбработкиОбслуживанияТО.ФормаВыбораСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:600px;height:25px;',
			width: 600,
			height: 25,
			items:
			[
				{
					text:'',
					tooltip:'Добавить',
					iconCls:'x-copy',
				},
				{
					text:'',
					tooltip:'Новая группа',
					iconCls:'x-CreateFolder',
				},
				{
					text:'',
					tooltip:'Скопировать',
					iconCls:'x-copy',
				},
				{
					text:'',
					tooltip:'Изменить',
					iconCls:'x-Change',
				},
				{
					text:'',
					tooltip:'Установить пометку удаления',
					iconCls:'x-Delete',
				},
				{
					text:'Выбрать',
					tooltip:'Выбрать значение',
					iconCls:'x-Select',
				},
				'-',
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'',
					tooltip:'',
				},
					]
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