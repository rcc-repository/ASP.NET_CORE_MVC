
function AjaxModal() {

    $(document).ready(function () {
        $(function () {

            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {
                    $('#myModalContent').load(this.ref,
                        function () {
                            $('#myModal').modal({
                                keyboard: true
                            }, 'show');
                            bindForm(this);
                        });

                    return false;
                });
        });




    });
}