$(function () {
    // To fetch the 50 top albums for any last.fm user...
    //      + Replace the code in this function with the following code
    //      + Paste in your last.fm api key (http://www.last.fm/api/account)
    //      + Bind Username to user input
    /* $.getJSON("http://ws.audioscrobbler.com/2.0/",
            {
                method: "user.gettopalbums",
                user: "ianreah", // TODO: bind last.fm username to user input
                api_key: INSERT-YOUR-LASTFM-API-KEY-HERE,
                period: "overall",
                format: "json"
            },
            function (json) {
                var pluginInput = {};
                pluginInput.items = json.topalbums.album;
                $("#jQueryControlHost").coverFlow(pluginInput);
            }); */

    $.getJSON("../resources/CachedLastFmQuery.json",
            function (json) {
                var pluginInput = {};
                pluginInput.items = json.topalbums.album.map(function (item) {
                	return {
                		url: item.url,
                		image: item.image[3]['#text']
	                };
                });
                pluginInput.itemSize = 150;
                $("#jQueryControlHost").coverFlow(pluginInput);
            });
});
