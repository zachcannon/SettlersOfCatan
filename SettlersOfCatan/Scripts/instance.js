/// <reference path="~/Scripts/jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $(function () {
        var appendType = function (i, value) {
            $("#data-container").append(i + " " + value + " ")
        };

        var initializeBoard = function (data) {
            $.each(data, appendType);
        };

        $.ajax({
            url: "/Game/CreateAndGetBoard"
        }).done(initializeBoard);

    });

    $('#space-0').prepend('<img src="Desert-Tile.png" />')
});

