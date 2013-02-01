﻿
var РедактируемаяЯчейка;
$(document).ready
(
	function ()
	{
		$(".Форма").draggable({cursor: 'move', handle: 'div'});
		$(".Форма").resizable();

		$('.ТабличноеПоле td').click(function(){
			РедактируемаяЯчейка = this;
			var КоординатыУгла = $(this).position();
			$('#ТабличноеПоле_Редактор').css({
				'top': (КоординатыУгла.top + 1) + 'px',
				'left': (КоординатыУгла.left + 1) + 'px',
				'width': $(this).width(),
				'height': $(this).height()
			}).val($(this).html()).show().focus();
		});

		$('#ТабличноеПоле_Редактор').blur(function(){
			$(this).hide();
			$(РедактируемаяЯчейка).html($(this).val());
		});

	}
)
var Вызов = false;
function СлучайноеЦелоеЧисло(Максимум)
{
		return Math.round(Math.random() * Максимум);
}
function ЗагрузитьДанные()
{
	if (Вызов == true)
	{
		return;
	}
	Вызов = true;
	Время.innerText = СлучайноеЦелоеЧисло(1000000000000000);
	Старт = new Date();
	$.ajaxSetup({ scriptCharset: "utf-8", contentType: "application/json; charset=utf-8" });
	$.ajax({
		url: 'http://127.0.0.1:1337/Catalogs/Nomenklatura?callback=?',
		dataType: 'json',
		data: { Code: СлучайноеЦелоеЧисло(100) },
		jsonpCallback: 'ЗаполнитьПоля',
	});
}
function ОбновитьФорму()
{
	ЗагрузитьДанные();
	//setInterval(ЗагрузитьДанные, 100);
}
function ЗаполнитьПоля(Ссылка)
{
	Период.value	= Ссылка.Период;
	ОтношениеКВоинскойОбязанности.value	= Ссылка.ОтношениеКВоинскойОбязанности;
	ОтношениеКВоинскомуУчету.value	= Ссылка.ОтношениеКВоинскомуУчету;
	Годность.value	= Ссылка.Годность;
	Звание.value	= Ссылка.Звание;
	ЗабронированОрганизацией.value	= Ссылка.ЗабронированОрганизацией;
	Военкомат.value	= Ссылка.Военкомат;
	ВУС.value	= Ссылка.ВУС;
	КатегорияЗапаса.value	= Ссылка.КатегорияЗапаса;
	Состав.value	= Ссылка.Состав;
	НомерКомандыПартии.value	= Ссылка.НомерКомандыПартии;
	var Стоп = new Date();
	Время.innerText = (Стоп - Старт);
	Вызов = false;
}
