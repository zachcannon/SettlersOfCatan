/// <reference path="~/Scripts/jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $('.three-row').fadeOut(1000);
    $('.three-row').fadeIn(1000);
});


/*      
$(function () {
    var appendType = function (i, value) {
        $("#container").append(i+ " " +value + " " )
    };

    var initializeBoard = function (data) {
        $.each(data.Tiles, appendType);
    };

    $.ajax({
        url: "/Game/CreateBoard"
    }).done(initializeBoard);

});
*/
