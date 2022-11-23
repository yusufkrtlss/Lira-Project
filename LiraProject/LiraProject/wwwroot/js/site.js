// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#id").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: '/home/search',
                headers: { "RequestVerificationToken": $('input[name="__RequestVerificationToken"]').val() },
                data: { "term": request.term },
                dataType: "json",
                success: function (data) {
                    response($.map(data, function (item) {
                        return item;
                    }))
                },
                error: function (xhr, textStatus, error) {
                    alert(xhr.statusText);
                    alert(textStatus);
                    alert(error);
                },
                failure: function (response) {
                    alert("failure " + response.responseText);
                }
            });
        },
        select: function (e, i) {
            $("#id").text(i.item.value);
        },
        minLength: 2
    });
});