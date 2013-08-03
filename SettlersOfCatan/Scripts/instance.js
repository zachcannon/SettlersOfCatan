/// <reference path="~/Scripts/jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $(function () {
        var appendTerrain = function (i, value) {
            var spaceNum = "#space-" + i;
            var imgLocation = '<img src="/Content/Images/' + value + '-Tile.png" class="board-tile"/>';
            $(spaceNum).append(imgLocation);
        };

        var appendNumberTokens = function (i, value) {
            var spaceNum = "#space-" + i;
            if (value != 0) {
                $(spaceNum).append('<img src="/Content/Images/Number-Token-'+value+'.png" class="space-number-token"/>'); 
            }
        }

        var initializeBoard = function (data) {
            $.each(data.TerrainTiles, appendTerrain);
            $.each(data.NumberTokens, appendNumberTokens);
        };

        $.ajax({
            url: "/Game/CreateBoard"
        }).done(initializeBoard);

    });

});

