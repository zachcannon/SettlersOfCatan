/// <reference path="~/Scripts/jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $(function () {
        var appendTerrain = function (i, value) {
            $('.board-tile:eq(' + i + ')').addClass(value.toLowerCase()+'-terrain');
        };
        var appendNumberToken = function (i, value) {
            if (value != 0) $('.board-tile:eq(' + i + ')').html('<img src="/Content/Images/Num-Tile-Placeholder.png" class="number-token"/>');
        }

        var initializeBoard = function (data) {
            $.each(data.TerrainTiles, appendTerrain);
            $.each(data.NumberTokens, appendNumberToken);
        };

        $.ajax({
            url: "/Game/CreateBoard"
        }).done(initializeBoard);

    });

});

