



$(document).on("click", "a[data-modal]", function (e)
{
    $('#myModalContent').load(this.href,function()
    {
        $('#myModal').modal();
        bindForm(this);
    })

    return false;
});


$(document).on("click", "a[data-alert]", function (e) {
    alert("Hola Mundo");
});





function bindForm(dialog)
{

    $('form', dialog).submit(function () {

        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            cache: false,
            success: function (result)
            {
                $('#myModalContent').html(result);
            }
        })

    });

 }

