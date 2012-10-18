$(function () {
    $.getJSON("resources/CachedLastFmQuery.json",
            function (json) {
                var pluginInput = {};
                pluginInput.items = json.topalbums.album.map(function (item) {
                	return {
                		url: item.url,
                		image: item.image[3]['#text']
	                };
                });
                pluginInput.itemSize = 150;
                $("#coverFlowControlHost").coverFlow(pluginInput);
            });
});
