(function ($) {
    var CoverFlowHelper = function (element, settings) {
        this._element = $(element);
        this._itemsContainer = $("#coverFlowItems", this._element);
        this._items = $("li", this._itemsContainer);
        this._pluginSettings = settings;
        this._currentIndex = 2;
    };

    CoverFlowHelper.prototype.previousItem = function () {
        if (this._currentIndex > 0) {
            var oldIndex = this._currentIndex;
            this._currentIndex--;
            this.currentChanged(oldIndex);
        }
    };

    CoverFlowHelper.prototype.nextItem = function () {
        if (this._currentIndex < this._pluginSettings.items.length - 1) {
            var oldIndex = this._currentIndex;
            this._currentIndex++;
            this.currentChanged(oldIndex);
        }
    };

    CoverFlowHelper.prototype.currentChanged = function (oldIndex) {
        $(this._items[oldIndex - 2]).removeClass("left-2");
        $(this._items[oldIndex - 1]).removeClass("left-1");
        $(this._items[oldIndex]).removeClass("active");
        $(this._items[oldIndex + 1]).removeClass("right-1");
        $(this._items[oldIndex + 2]).removeClass("right-2");

        $(this._items[this._currentIndex - 2]).addClass("left-2");
        $(this._items[this._currentIndex - 1]).addClass("left-1");
        $(this._items[this._currentIndex]).addClass("active");
        $(this._items[this._currentIndex + 1]).addClass("right-1");
        $(this._items[this._currentIndex + 2]).addClass("right-2");

    	// The items container moves to bring the current item into position
        var position = this._currentIndex * this._pluginSettings.itemSize;

    	// Perspective origin is the center of the current item (to keep the perspective symetrical)
        var perspectiveOrigin = position + (this._pluginSettings.itemSize / 2);

    	// The container moves to the left (negative) as current index increases
        position *= -1;

    	// A 50% left margin on the container centralises the left-edge of the current item
    	// Offset by 1/2 item width here to centralise on the center of the current item
        position -= (this._pluginSettings.itemSize / 2);

        this._itemsContainer.css("-webkit-perspective-origin-x", perspectiveOrigin + "px");
        this._itemsContainer.css("-webkit-transform", "translateX(" + position + "px)");
    };

    $.fn.coverFlow = function (settings) {
        settings = $.extend({}, $.fn.coverFlow.defaultSettings, settings || {});

        return this.each(function () {
            $.tmpl(settings.template, settings).appendTo(this);
            $("#coverFlowItems").width(settings.itemSize * settings.items.length);

            var helper = new CoverFlowHelper(this, settings);

            $(document).keydown(function (e) {
                // Left arrow
                if (e.keyCode == 37) {
                    helper.previousItem();
                    return false;
                }

                // Right arrow
                if (e.keyCode == 39) {
                    helper.nextItem();
                    return false;
                }
            });

            helper.currentChanged();
        });
    };

    $.fn.coverFlow.defaultSettings = {
        items: [],
        itemSize: 200,
        template: "<ul id='coverFlowItems'>{{each $data.items}}<li><a href='${$value.url}' tabindex='-1'><img src='${$value.image}' width=${$data.itemSize} height=${$data.itemSize} /></a></li>{{/each}}</ul>"
    };
})(jQuery);