﻿Ext.require(['Данные.Отчеты.РапортРуководителю'], function () 
{
	Ext.define('Отчеты.РапортРуководителю.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:238px;height:294px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Показатели рапорта',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'ТабличноеПолеДеревоПоказателей',
			xtype: 'grid',
			style: 'position:absolute;left:10px;top:33px;width:220px;height:228px;',
			height: 228,width: 220,
			columns:
			[
				{
					text:'Показатель',
					width:'220',
					dataIndex:'ПредставлениеПоказателя',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/РапортРуководителю/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ПредставлениеПоказателя',
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
						var грид = Ext.getCmp('ТабличноеПолеДеревоПоказателей');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.РапортРуководителю.ФормаВыбораСобытия'], function ()
						{
							var obj = Ext.create("Справочники.РапортРуководителю.ФормаВыбораСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:10px;top:8px;width:220px;height:24px;',
			width: 220,
			height: 24,
			items:
			[
				{
					text:'Снять пометки',
				},
				{
					text:'Установить пометки',
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:269px;width:238px;height:25px;',
			width: 238,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'ОК',
				},
				{
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
			]
		},
	]
	});
});