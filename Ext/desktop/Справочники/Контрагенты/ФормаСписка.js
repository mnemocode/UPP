﻿Ext.require(['Данные.Справочники.Контрагенты'], function () 
{
	Ext.define('Справочники.Контрагенты.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:694px;height:321px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Контрагенты',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:174px;top:57px;width:512px;height:256px;',
			height: 256,width: 512,
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
					width:'40',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'120',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'ИНН',
					width:'100',
					dataIndex:'ИНН',
					flex:1,
				},
				{
					text:'Полное наименование',
					width:'220',
					dataIndex:'НаименованиеПолное',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'105',
					dataIndex:'Комментарий',
					flex:1,
				},
				{
					text:'Основной менеджер покупателя',
					width:'179',
					dataIndex:'ОсновнойМенеджерПокупателя.Представление',
					flex:1,
				},
				{
					text:'Головной контрагент',
					width:'120',
					dataIndex:'ГоловнойКонтрагент.Представление',
					flex:1,
				},
				{
					text:'Документ, удостоверяющий личность',
					width:'120',
					dataIndex:'ДокументУдостоверяющийЛичность',
					flex:1,
				},
				{
					text:'Дополнительное описание',
					width:'120',
					dataIndex:'ДополнительноеОписание',
					flex:1,
				},
				{
					text:'Источник информации при обращении',
					width:'120',
					dataIndex:'ИсточникИнформацииПриОбращении.Представление',
					flex:1,
				},
				{
					text:'Код по ОКПО',
					width:'80',
					dataIndex:'КодПоОКПО',
					flex:1,
				},
				{
					text:'КПП',
					width:'80',
					dataIndex:'КПП',
					flex:1,
				},
				{
					text:'Не является резидентом',
					width:'80',
					dataIndex:'НеЯвляетсяРезидентом',
					flex:1,
				},
				{
					text:'ОКОПФ',
					width:'80',
					dataIndex:'ОКОПФ.Представление',
					flex:1,
				},
				{
					text:'Основное контактное лицо',
					width:'120',
					dataIndex:'ОсновноеКонтактноеЛицо.Представление',
					flex:1,
				},
				{
					text:'Основной банковский счет',
					width:'120',
					dataIndex:'ОсновнойБанковскийСчет.Представление',
					flex:1,
				},
				{
					text:'Основной вид деятельности',
					width:'120',
					dataIndex:'ОсновнойВидДеятельности.Представление',
					flex:1,
				},
				{
					text:'Основной договор контрагента',
					width:'120',
					dataIndex:'ОсновнойДоговорКонтрагента.Представление',
					flex:1,
				},
				{
					text:'Покупатель',
					width:'80',
					dataIndex:'Покупатель',
					flex:1,
				},
				{
					text:'Поставщик',
					width:'80',
					dataIndex:'Поставщик',
					flex:1,
				},
				{
					text:'Расписание работы строкой',
					width:'120',
					dataIndex:'РасписаниеРаботыСтрокой',
					flex:1,
				},
				{
					text:'Регион',
					width:'120',
					dataIndex:'Регион.Представление',
					flex:1,
				},
				{
					text:'Срок выполнения заказа поставщиком (в днях)',
					width:'80',
					dataIndex:'СрокВыполненияЗаказаПоставщиком',
					flex:1,
				},
				{
					text:'Юр. / физ. лицо',
					width:'120',
					dataIndex:'ЮрФизЛицо.Представление',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.Контрагенты").data,
					fields: ['Ссылка','Родитель.Представление','Картинка','Код','Наименование','ИНН','НаименованиеПолное','Комментарий','ОсновнойМенеджерПокупателя.Представление','ГоловнойКонтрагент.Представление','ДокументУдостоверяющийЛичность','ДополнительноеОписание','ИсточникИнформацииПриОбращении.Представление','КодПоОКПО','КПП','НеЯвляетсяРезидентом','ОКОПФ.Представление','ОсновноеКонтактноеЛицо.Представление','ОсновнойБанковскийСчет.Представление','ОсновнойВидДеятельности.Представление','ОсновнойДоговорКонтрагента.Представление','Покупатель','Поставщик','РасписаниеРаботыСтрокой','Регион.Представление','СрокВыполненияЗаказаПоставщиком','ЮрФизЛицо.Представление',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Контрагенты/ВыбратьПоСсылке/100', timeout: 200},
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
						name:'ИНН',
					},
					{
						name:'НаименованиеПолное',
					},
					{
						name:'Комментарий',
					},
					{
						name:'ОсновнойМенеджерПокупателя',
					},
					{
						name:'ГоловнойКонтрагент',
					},
					{
						name:'ДокументУдостоверяющийЛичность',
					},
					{
						name:'ДополнительноеОписание',
					},
					{
						name:'ИсточникИнформацииПриОбращении',
					},
					{
						name:'КодПоОКПО',
					},
					{
						name:'КПП',
					},
					{
						name:'НеЯвляетсяРезидентом',
					},
					{
						name:'ОКОПФ',
					},
					{
						name:'ОсновноеКонтактноеЛицо',
					},
					{
						name:'ОсновнойБанковскийСчет',
					},
					{
						name:'ОсновнойВидДеятельности',
					},
					{
						name:'ОсновнойДоговорКонтрагента',
					},
					{
						name:'Покупатель',
					},
					{
						name:'Поставщик',
					},
					{
						name:'РасписаниеРаботыСтрокой',
					},
					{
						name:'Регион',
					},
					{
						name:'СрокВыполненияЗаказаПоставщиком',
					},
					{
						name:'ЮрФизЛицо',
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
						Ext.require(['Справочники.Контрагенты.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Контрагенты.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			id: 'СправочникДерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:160px;height:256px;',
			height: 256,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'160',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.Контрагенты").data,
					fields: ['Ссылка','Родитель.Представление','Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/Контрагенты/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
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
						var грид = Ext.getCmp('СправочникДерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.Контрагенты.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.Контрагенты.ФормаСпискаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:694px;height:25px;',
			width: 694,
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
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Помощник ввода',
					tooltip:'',
				},
				'-',
				'-',
				{
					text:'Отчет',
					tooltip:'',
				},
				'-',
				{
					text:'Файлы',
					tooltip:'',
				},
				'-',
					]
				},
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				'-',
				{
					text:'Список событий',
					tooltip:'',
				},
				{
					text:'Электронные письма (контрагент)',
					tooltip:'Электронные письма (контрагент)',
				},
				{
					text:'Электронные письма (контрагент + контактные лица)',
					tooltip:'Электронные письма (контрагент + контактные лица)',
				},
					]
				},
				'-',
				{
					text:'Свойства',
					tooltip:'Открыть свойства',
				},
				{
					text:'Категории',
					tooltip:'Категории',
				},
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Помощник ввода',
					tooltip:'',
				},
				'-',
				'-',
				{
					text:'Отчет',
					tooltip:'',
				},
				'-',
				{
					text:'Файлы',
					tooltip:'',
				},
				'-',
					]
				},
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				'-',
				{
					text:'Список событий',
					tooltip:'',
				},
				{
					text:'Электронные письма (контрагент)',
					tooltip:'Электронные письма (контрагент)',
				},
				{
					text:'Электронные письма (контрагент + контактные лица)',
					tooltip:'Электронные письма (контрагент + контактные лица)',
				},
					]
				},
				'-',
				{
					text:'Свойства',
					tooltip:'Открыть свойства',
				},
				{
					text:'Категории',
					tooltip:'Категории',
				},
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Помощник ввода',
					tooltip:'',
				},
				'-',
				'-',
				{
					text:'Отчет',
					tooltip:'',
				},
				'-',
				{
					text:'Файлы',
					tooltip:'',
				},
				'-',
					]
				},
				{
					xtype: 'splitbutton',
					text:'Перейти',
					menu: [
				'-',
				{
					text:'Список событий',
					tooltip:'',
				},
				{
					text:'Электронные письма (контрагент)',
					tooltip:'Электронные письма (контрагент)',
				},
				{
					text:'Электронные письма (контрагент + контактные лица)',
					tooltip:'Электронные письма (контрагент + контактные лица)',
				},
					]
				},
				'-',
				{
					text:'Свойства',
					tooltip:'Открыть свойства',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ЗначениеОтбораСпискаКонтрагентов',
			width: 451,
			height: 19,
			style: 'position:absolute;left:235px;top:33px;width:451px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьЗначениеОтбораСпискаНоменклатуры',
			text: 'содержит:',
			style: 'position:absolute;left:174px;top:33px;width:57px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:8px;top:33px;width:160px;height:19px;',
			width: 160,
			height: 19,
		},
		],
	}],
	dockedItems:
	[
	]
	});
});