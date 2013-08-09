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

    getPlayerResources();

    $('#roll-die-button').click(function () {

        var updateLastRoll = function (data) {
            $('#result-of-roll span').text(data);
        }

        $.ajax({
            url: "/Game/RollDie"
        }).done(updateLastRoll);
    });

});

var getPlayerResources = function () {
    var updatePlayerBox = function (data) {
        $('#player-one .resource-display:eq(0)').text('Brick: ' + data.BrickResource);
        $('#player-one .resource-display:eq(1)').text('Ore: ' + data.OreResource);
        $('#player-one .resource-display:eq(2)').text('Sheep: ' + data.SheepResource);
        $('#player-one .resource-display:eq(3)').text('Wheat: ' + data.WheatResource);
        $('#player-one .resource-display:eq(4)').text('Wood: ' + data.WoodResource);
    };

    $.ajax({
        url: "/Game/GetPlayerInfo"
    }).done(updatePlayerBox);
};