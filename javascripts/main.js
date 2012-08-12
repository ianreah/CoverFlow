$(function () {
    $.getJSON("resources/CachedLastFmQuery.json",
            function (json) {
                var pluginInput = {};
                pluginInput.items = json.topalbums.album;
                $("#coverFlowControlHost").coverFlow(pluginInput);
            });
});
