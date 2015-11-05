(function ($) { // esto es una iife un metodo autoinvocado es como un namespace para que naidie mas acceda a tu js 
    $(function () {// esto quiere decir que cuando se haya cargado el dom document object model osea tu rama de htm recien cuando se carge se 
        

        //InicioJPopUp('#PopupRegistrarAlumno', 400, 350, false, 'Registrar Alumno');
        //$('#btnAdd').click(AbrirPopupRergisrtrarAlumno);

        $("#btnAdd").on("click", function (e) {
            $('#myModalContent').load(urlAction.urlRegistrarAlumno, function () {
                $('#myModal').modal({
                    keyboard: false
                }, 'show');
                bindForms(this);

            });
            return false;
        });

    });

    
    function bindForms(dialog) {
        $('form', dialog).submit(function (e) {
            e.preventDefault();
            $.ajax({
                url: this.action,
                type: this.method,
                data: $(this).serialize(),
                success: function (result) {
                    if (result != "") {

                        $('#myModal').modal('hide');
                        $.notify(result, "success");
                       
                    }
                }
            });
            return false;
        });
    }


    //var AbrirPopupRergisrtrarAlumno = function () {
    //    $.ajax({
    //        url: urlAction.urlRegistrarAlumno,            
    //        type: 'GET',
    //        success: function (viewResult) {                
    //            $('#myModalContent').empty().html(viewResult);
    //            InicioJPopUpOpen('#myModalContent');
    //        }
    //    });        

        
    //}



    $(document).ready(function () {
        
        
        $("#cboCliente").on("select2-selecting", CargarProyectoSearch);
        //SetTotalRegistrosAdmisionDbf();
    });

    function CargarProyectoSearch(e) {
        var xid = 0;
        if (e.val != '') {
            xid = e.val;
        }
        CargarComboSelect2Search("#cboProyecto", urlObtenerProyecto, "", { id: xid });
    }

})(jQuery)
