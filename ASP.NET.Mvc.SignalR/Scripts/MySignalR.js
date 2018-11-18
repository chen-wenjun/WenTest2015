//alert('worked');
(function () {
    $.connection.hub.start()
        .done(function () {
            $.connection.hub.logging = true;
            AppendMsg('connected!<br />');
            $.connection.myHub.server.send('SignalR is connected.');
            $.connection.hub.log('called server send');
        })
        .fail(function () {
            alert('error');
        })

    $.connection.myHub.client.push = function (message) {
        AppendMsg(message + '<br />');
    }

    $('#getTimeBtn').click(function () {
        $.connection.myHub.server.getServerTime()
            .done(function (data) {
                AppendMsg(data + '<br />');
            })
            .fail(function (err) {
                AppendMsg(err + '<br />');
            });

    })

    function AppendMsg(message) {
        $('#msgDiv').append(message);
    }
})();
