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


    $(function () {
        $.ajax({
            url: "/Game/CreatePlayers"
        }).done(updatePlayersResources);
    });
    

    $('#roll-die-button').click(function () {

        var updateLastRoll = function (data) {
            $('#result-of-roll span').text(data);
        }

        $.ajax({
            url: "/Game/RollDie"
        }).done(updateLastRoll);
    });

});

var createPlayers = function (playerId) {
    $.ajax({
        url: "/Game/CreatePlayers"
    });
};

var updatePlayersResources = function () {
    var updatePlayerBox = function (data) {
        $('#player-' + data.PlayerId + ' .resource-display:eq(0)').text('Brick: ' + data.BrickResource);
        $('#player-' + data.PlayerId + ' .resource-display:eq(1)').text('Ore: ' + data.OreResource);
        $('#player-' + data.PlayerId + ' .resource-display:eq(2)').text('Sheep: ' + data.SheepResource);
        $('#player-' + data.PlayerId + ' .resource-display:eq(3)').text('Wheat: ' + data.WheatResource);
        $('#player-' + data.PlayerId + ' .resource-display:eq(4)').text('Wood: ' + data.WoodResource);
    };


    for (var playerNum = 1; playerNum <= 4; playerNum++) {
        $.ajax({
            url: "/Game/GetPlayerResources",
            data: { "input": playerNum }
        }).done(updatePlayerBox);
    }
};