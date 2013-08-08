/// <reference path="~/Scripts/jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $(function () {
        var appendTerrain = function (i, value) {
            $('.board-tile:eq(' + i + ')').addClass(value.TerrainType.toLowerCase() + '-terrain');
        };

        var appendNumberToken = function (i, value) {           
            if (value.HasNumberToken) $('.board-tile:eq(' + i + ')').html('<img src="/Content/Images/Number-Token-' + value.NumberTokenValue + '.png" class="number-token"/>');
            
        }

        var initializeBoard = function (data) {
            $.each(data.TerrainTiles, appendTerrain);
            $.each(data.TerrainTiles, appendNumberToken);
        };

        $.ajax({
            url: "/Game/CreateBoard"
        }).done(initializeBoard);

    });




});

