(function(){
    $(function () {
        $('#btn-Login').on('click', Home);
    });

    var Home = function () {
        debugger;
        location.href = UrlAction.urlHome;
    }
})(jQuery)