$(function () {
    

    $('.list-item').click(function () {
        $(".list-item", $(this).parent())
            .removeClass("selected");
        $(this).addClass("selected");
        var url = $(this).data("url");
        $.get(url, function (data) {
            $("#selectedDetail").html(data);

        })
    })
    var eventclickaction = function () {
        $('#EditTag').click(function (e) {
            e.preventDefault()
            var url = $(this).attr('href')
            $.get(url, function (data) {
                $("#selectedDetail").html(data);

            })
        })
    };
    $(document).ajaxComplete(eventclickaction);
    eventclickaction();
})
