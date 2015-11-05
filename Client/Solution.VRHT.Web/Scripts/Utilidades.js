function HeightScrollCrud() {
    var heightCabeza = $("#cabeza").height();
    var heightPie = $("#pie").height();
    var hVentana = screen.availHeight;//$(document).height();
    //var hMin = hVentana - (heightCabeza + heightPie);
    var hMin = hVentana - (heightCabeza + heightPie);
    $("#scrollDiv").css("height", hMin - 95);
}

function HeightScroll() {
    var heightCabeza = $("#cabeza").height();
    var heightPie = $("#pie").height();
    var hVentana = screen.availHeight;//$(document).height();
    //var hMin = hVentana - (heightCabeza + heightPie);
    var hMin = hVentana - (heightCabeza);
    $("#scrollDiv").css("height", hMin -60);
}

/// 
///     Carga por Dato
/// 
function CargarComboSelect2(selectorString, url, placeholder, xdata) {
   
    $.post(url, xdata, function (data) {
        var select = $(selectorString);
        if (select.prop) {
            var options = select.prop('options');
        }
        else {
            var options = select.attr('options');
        }
        $('option', select).remove();
        //options[options.length] = new Option("","");
        $.each(data, function (val, text) {
            options[options.length] = new Option(text.text, text.id);
        });
        $(selectorString).select2({
            placeholder: placeholder
        });
    });
}

function CargarComboSelect2Search(selectorString, url, placeholder, xdata) {
    debugger
    $.post(url, xdata, function (data) {
        debugger
        var select = $(selectorString);
        if (select.prop) {
            var options = select.prop('options');
        }
        else {
            var options = select.attr('options');
        }
        $('option', select).remove();
        debugger
        options[options.length] = new Option(":: SELECCIONAR ::","");
        $.each(data, function (val, text) {
            options[options.length] = new Option(text.text, text.id);
        });
        $(selectorString).select2({
            placeholder: placeholder
        });
    });
}

//function CargarDivContent(url, selectorString) {
//    $.ajax({
//        url: url,
//        dataType: 'html',
//        data: '{}',
//        traditional: true,
//        type: 'POST',
//        success: function (content) {
//            $(selectorString).html(content);
//        }
//    });
//}

//function CargarDatableNetData(selectorString, scroll, data, colums, filtro, LengthChange) {
    
//    var $table = $(selectorString).dataTable({
//        "sScrollX": scroll,
//        "aaData": data,
//        "aoColumns": colums,
//        "aaSorting": [[4, "desc"]],
//        "bDestroy": true,
//        "bLengthChange": LengthChange,
//        "bFilter": filtro,
//        "fnRowCallback": function (nRow, aData, iDisplayIndex, iDisplayIndexFull) {
//            nRow.className = nRow.className + " " + "gradeA";

//        }
//    });
//    $(selectorString + ' tbody').on("click", "tr", function () {
//        if ($(this).hasClass('selected')) {
//            $(this).removeClass('selected');
//        }
//        else {
//            table.$('tr.selected').removeClass('selected');
//            $(this).addClass('selected');
//        }
//    });
//    return $table;
//}

$(function () {
    $("#cuerpo").css("min-height", "0")
    $("#cuerpo").css("height", "100%")
    $('#div_carga')
        .hide()
        .ajaxStart(function () {
            var width;
            var height;
            width = $('body').css('width')
            height = $('body').css('height')
            $('#div_carga').css('width', width)
            $('#div_carga').css('height', height)
            $(this).show();
        })
        .ajaxStop(function () {
            $(this).hide();
        });
})