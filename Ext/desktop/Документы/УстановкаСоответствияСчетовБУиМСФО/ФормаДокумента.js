﻿Ext.require(['Данные.Документы.УстановкаСоответствияСчетовБУиМСФО'], function () 
{
	Ext.define('Документы.УстановкаСоответствияСчетовБУиМСФО.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:740px;height:422px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Установка соответствия счетов БУ и МСФО',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:740px;height:25px;',
			width: 740,
			height: 25,
			items:
			[
				{
					xtype: 'splitbutton',
					text:'',
					menu: [
				{
					text:'',
					tooltip:'',
				},
				'-',
					]
				},
			]
		},
		{
			xtype: 'label',
			name: 'НадписьНомер',
			text: 'Номер:',
			style: 'position:absolute;left:8px;top:33px;width:43px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'НадписьДата',
			text: 'от:',
			style: 'position:absolute;left:131px;top:33px;width:20px;height:19px;text-align:center;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Номер',
			width: 80,
			height: 19,
			style: 'position:absolute;left:51px;top:33px;width:80px;height:19px;',
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
			style: 'position:absolute;left:151px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Комментарий:',
			style: 'position:absolute;left:8px;top:345px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'Комментарий',
			width: 636,
			height: 19,
			style: 'position:absolute;left:96px;top:345px;width:636px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись2',
			text: 'Ответственный:',
			style: 'position:absolute;left:8px;top:370px;width:82px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Ответственный.Представление',
			width: 636,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:96px;top:370px;width:636px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Документы.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Документы.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия'], function ()
					{
						var объект = Ext.create("Документы.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'panel',
			style: 'position:absolute;left:8px;top:57px;width:724px;height:283px;',
			height: 283,width: 724,
			items:
			[
				{
					items:
					[
		{
			id: 'СоответствиеСчетовБУиМСФО',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:710px;height:227px;',
			height: 227,width: 710,
			columns:
			[
				{
					text:'',
					width:'20',
					dataIndex:'Учитывается',
					flex:1,
				},
				{
					text:'Счет хозрасчетный',
					width:'74',
					dataIndex:'СчетХозрасчетный',
					flex:1,
				},
				{
					text:'Вид движения',
					width:'107',
					dataIndex:'ВидДвижения',
					flex:1,
				},
				{
					text:'Субконто хозр.',
					width:'181',
					dataIndex:'СубконтоХозр1',
					flex:1,
				},
				{
					text:'',
					width:'181',
					dataIndex:'СубконтоХозр2',
					flex:1,
				},
				{
					text:'',
					width:'181',
					dataIndex:'СубконтоХозр3',
					flex:1,
				},
				{
					text:'Счет международный',
					width:'69',
					dataIndex:'СчетМеждународный',
					flex:1,
				},
				{
					text:'Субконто межд.',
					width:'128',
					dataIndex:'СубконтоМежд1',
					flex:1,
				},
				{
					text:'',
					width:'128',
					dataIndex:'СубконтоМежд2',
					flex:1,
				},
				{
					text:'',
					width:'128',
					dataIndex:'СубконтоМежд3',
					flex:1,
				},
				{
					text:'Реквизит',
					width:'103',
					dataIndex:'РеквизитПредставление',
					flex:1,
				},
				{
					text:'Значение',
					width:'103',
					dataIndex:'Значение',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'85',
					dataIndex:'Комментарий',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/УстановкаСоответствияСчетовБУиМСФО/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Учитывается',
					},
					{
						name:'СчетХозрасчетный',
					},
					{
						name:'ВидДвижения',
					},
					{
						name:'СубконтоХозр1',
					},
					{
						name:'СубконтоХозр2',
					},
					{
						name:'СубконтоХозр3',
					},
					{
						name:'СчетМеждународный',
					},
					{
						name:'СубконтоМежд1',
					},
					{
						name:'СубконтоМежд2',
					},
					{
						name:'СубконтоМежд3',
					},
					{
						name:'РеквизитПредставление',
					},
					{
						name:'Значение',
					},
					{
						name:'Комментарий',
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
						var грид = Ext.getCmp('СоответствиеСчетовБУиМСФО');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:710px;height:24px;',
			width: 710,
			height: 24,
			items:
			[
				'-',
				{
					text:'Установить Флажки',
					tooltip:'Установить Флажки',
				},
				{
					text:'Снять Флажки',
					tooltip:'Снять Флажки',
				},
				'-',
			]
		},
					]
				},
				{
					items:
					[
		{
			id: 'ИсключениеПроводок',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:30px;width:710px;height:227px;',
			height: 227,width: 710,
			columns:
			[
				{
					text:'',
					width:'21',
					dataIndex:'Учитывается',
					flex:1,
				},
				{
					text:'Счет Дт',
					width:'55',
					dataIndex:'СчетДт',
					flex:1,
				},
				{
					text:'Субконто Дт 1',
					width:'224',
					dataIndex:'СубконтоДт1',
					flex:1,
				},
				{
					text:'Субконто Дт 2',
					width:'224',
					dataIndex:'СубконтоДт2',
					flex:1,
				},
				{
					text:'Субконто Дт 3',
					width:'224',
					dataIndex:'СубконтоДт3',
					flex:1,
				},
				{
					text:'Счет Кт',
					width:'58',
					dataIndex:'СчетКт',
					flex:1,
				},
				{
					text:'Субконто Кт 1',
					width:'141',
					dataIndex:'СубконтоКт1',
					flex:1,
				},
				{
					text:'Субконто Кт 2',
					width:'141',
					dataIndex:'СубконтоКт2',
					flex:1,
				},
				{
					text:'Субконто Кт 3',
					width:'141',
					dataIndex:'СубконтоКт3',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'206',
					dataIndex:'Комментарий',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/УстановкаСоответствияСчетовБУиМСФО/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Учитывается',
					},
					{
						name:'СчетДт',
					},
					{
						name:'СубконтоДт1',
					},
					{
						name:'СубконтоДт2',
					},
					{
						name:'СубконтоДт3',
					},
					{
						name:'СчетКт',
					},
					{
						name:'СубконтоКт1',
					},
					{
						name:'СубконтоКт2',
					},
					{
						name:'СубконтоКт3',
					},
					{
						name:'Комментарий',
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
						var грид = Ext.getCmp('ИсключениеПроводок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.УстановкаСоответствияСчетовБУиМСФО.ФормаДокументаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:6px;top:6px;width:710px;height:24px;',
			width: 710,
			height: 24,
			items:
			[
				'-',
				{
					text:'Установить Флажки',
					tooltip:'Установить Флажки',
				},
				{
					text:'Снять Флажки',
					tooltip:'Снять Флажки',
				},
				'-',
			]
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:397px;width:740px;height:25px;',
			width: 740,
			height: 25,
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'Печать',
					tooltip:'Печать',
				},
				'-',
				{
					text:'OK',
					tooltip:'Записать объект и закрыть форму',
					iconCls:'x-WriteAndClose',
				},
				'-',
				{
					text:'Записать',
					tooltip:'Записать объект',
					iconCls:'x-SaveFile',
				},
				'-',
				{
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
			]
		},
	]
	});
});