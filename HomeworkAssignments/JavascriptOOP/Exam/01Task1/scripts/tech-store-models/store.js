define(function () {
    var Store = (function () {
        function Store(name) {
            if (name.length < 6 || name.length > 40) {
                throw new Error('Name should be no less than 6 characters and no more than 30 characters.');
            }

            this.name = name;
            this._items = [];
        };

        return Store;
    }());

    // Private internal funcions
    function compare(a, b, type) {
        if (a.name > b.name)
            return 1;
        if (a.name < b.name)
            return -1;
        return 0;
    }

    function compareByPrice(a, b) {
        if (a.price > b.price)
            return 1;
        if (a.price < b.price)
            return -1;
        return 0;
    }

    // Public functions
    function getTwoTypesOfItems(collection, typeOne, typeTwo) {
        var result = [];

        collection.forEach(function (item) {
            if (item.type === typeOne || item.type === typeTwo) {
                result.push(item);
            }
        });

        return result;
    }

    Store.prototype.addItem = function (item) {
        if (item.constructor.name !== 'Item')
        {
            throw new Error('Item can only be an object of type "Item".');
        }

        this._items.push(item);
        return this;
    };

    Store.prototype.getAll = function () {
        var result = this._items.slice(0);

        result.sort(compare);

        return result;
    };

    Store.prototype.getSmartPhones = function () {
        var result = [];

        this._items.forEach(function (item) {
            if (item.type === 'smart-phone') {
                result.push(item);
            }
        });

        result.sort(compare);

        return result;
    };

    Store.prototype.getMobiles = function () {
        var result = getTwoTypesOfItems(this._items, 'smart-phone', 'tablet');
        result.sort(compare);

        return result;
    };

    Store.prototype.getComputers = function () {
        var result = getTwoTypesOfItems(this._items, 'pc', 'notebook');
        result.sort(compare);

        return result;
    };

    Store.prototype.filterItemsByPrice = function (options) {
        options = options || {};
        options.min = options.min || 0;
        options.max = options.max || Infinity;

        var result = [];
        var sortedItems = this._items.slice(0);
        sortedItems.sort(compareByPrice);
        for (var i = 0; i < sortedItems.length; i += 1) {
            if (sortedItems[i].price >= options.min && sortedItems[i].price <= options.max) {
                result.push(sortedItems[i]);
            }
        }

        return result;
    };

    Store.prototype.filterItemsByType = function (type) {
        var result = getTwoTypesOfItems(this._items, type, undefined);
        result.sort(compare);

        return result;
    };

    Store.prototype.filterItemsByName = function (name) {
        var result = [];

        this._items.forEach(function (item) {
            if (item.name.toLowerCase().contains(name.toLowerCase()))
            {
                result.push(item);
            }
        });

        result.sort(compare);

        return result;
    };

    Store.prototype.countItemsByType = function () {
        var result = [];

        for (var i = 0; i < this._items.length; i += 1) {
            if (result[this._items[i].type] === undefined) {
                result[this._items[i].type] = 1;
            } else {
                result[this._items[i].type] += 1;
            }
        }

        return result;
    };

    return Store;
});