/// <reference path="~/Scripts/jquery-ui-1.10.3.min.js" />

$(document).ready(function () {
    $(function () {
        var appendTerrain = function (i, value) {
            var spaceNum = "#space-" + i;
            var imgLocation = '<img src="/Content/Images/' + value + '-Tile.png" class="board-tile"/>';
            $(spaceNum).append(imgLocation);
        };

        var initializeBoard = function (data) {
            $.each(data.TerrainTiles, appendTerrain);
        };

        $.ajax({
            url: "/Game/CreateBoard"
        }).done(initializeBoard);

    });

});

