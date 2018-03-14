// Write your JavaScript code.
var enterTip = function () {
    var $this = $(this);
    $this.addClass("selected");
    var prediction = parseInt($this.data("prediction"));
    var matchId = parseInt($this.parent().data("matchid"));
    var memberId = 1;

    // TODO: save a member ID, match ID, team ID
    //$.ajax({
    //    type: "POST",
    //    url: "/TipEntry/Enter/",
    //    contentType: "application/json; charset=utf-8",
    //    dataType: "json",
    //    data: JSON.stringify({"matchId": matchId, "teamId": teamId, "memberId": memberId}),
    //    processData: false,
    //    async: true,
    //    cache: false,
    //    success: function (data) {
    //        console.log("cue the streamers!");
    //    }
    //});

    $.post("/tipentry/enter?matchId=" + matchId + "&prediction=" + prediction + "&memberId=" + memberId)
        .done(function () { console.log("cue the balloons!"); });
}

$("body").on("click", ".tip-entry td", enterTip);