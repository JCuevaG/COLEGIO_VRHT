// modalform.js

$(function () {
    $.ajaxSetup({ cache: false });

    $("a.crud").on("click", function (e) {
        // hide dropdown if any (this is used wehen invoking modal from link in bootstrap dropdown )
        //$(e.target).closest('.btn-group').children('.dropdown-toggle').dropdown('toggle');
        alert("");
        $('#myModalContent').load(this.href, function () {
            //jQuery('#myModal').modal('show');
            $('#myModal').modal({
                /*backdrop: 'static',*/
                keyboard: true
            }, 'show');
            bindForm(this);
            
        });
        return false;
    });
});

function bindForm(dialog) {
    $('form', dialog).submit(function () {
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function (result) {
                if (result.success) {
                    $('#myModal').modal('hide');
                    //$('#replacetarget').load(result.url); //  Load data from the server and place the returned HTML into the matched element
                    //refresh
                    location.reload();
                } else {
                    $('#myModalContent').html(result);
                    
                    bindForm();
                }
            }
        });
        return false;
    });
}