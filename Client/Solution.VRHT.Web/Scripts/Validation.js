(function (Validation, $) {
        
    $.fn.IsValidForm = function () {
        debugger
        var valid = true,
            $form = this;

        $form.find('input,select,textarea').each(function (index, elem) {
            //debugger
            var item = $(elem).hasClass('ignorefield');
            if (!item) {
                //debugger
                var isElemValid = $form.validate().element($(this));
                if (isElemValid != null) {
                    valid = valid & isElemValid;
                    if (valid == false) {
                        //debugger
                        console.log($(this));
                    }
                }
            }
        });
        debugger
        return valid;
    }

    var app = {
        removeValidation: function (element) {
            $(element).removeClass("input-validation-error").addClass("ignorefield");
            $(element)[0].nextElementSibling.innerHTML = ""
        }
    }

    window.Validation = $.extend(Validation, app);

})(window.Validation || {}, jQuery)