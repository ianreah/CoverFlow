$(function () {
    $.getJSON("../resources/CachedLastFmQuery.json",
            function (json) {
                var pluginInput = {};
                pluginInput.items = json.topalbums.album;
                $("#jQueryControlHost").coverFlow(pluginInput);
            });
});
