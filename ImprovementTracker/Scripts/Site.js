$(function () {
    

    //$('.list-item').click(function () {
    //    $(".list-item", $(this).parent())
    //        .removeClass("selected");
    //    $(this).addClass("selected");
    //    var url = $(this).data("url");
    //    $.get(url, function (data) {
    //        $("#selectedDetail").html(data);

    //    })
    //})
    var eventclickaction = function () {
        $('#EditTag').click(function (e) {
            e.preventDefault()
            var url = $(this).attr('href')
            $.get(url, function (data) {
                $("#selectedDetail").html(data);

            })
        })
    };

    var eventclickaction2 = function () {
        $('.list-item').click(function (e) {
            e.preventDefault()
            var url = $(this).data("url");
            $.getJSON(url).done(function (data) {
                $("#selectedDetail #DescriptionText").html(data.Description);
            }).fail(function (jqxhr, textstatus, err) {
                $("#selectedDetail #DescriptionText").html(err);
            })
        })
    };


    //$(document).ajaxComplete(eventclickaction2);
    eventclickaction2();
})
