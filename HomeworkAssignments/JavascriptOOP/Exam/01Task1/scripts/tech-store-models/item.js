define(function () {
    var TypeEnum = {
        'accessory': 'accessory',
        'smart-phone': 'smart-phone',
        'notebook': 'notebook',
        'pc': 'pc',
        'tablet': 'tablet'
    };

    var count = 0;

    var Item = (function () {
        function Item(type, name, price) {
            if (type !== TypeEnum[type]) {
                throw new Error('Type can only be: accessory, smart-phone, notebook, pc or tablet.' + count);
            }
            if (name.length < 6) {
                throw new Error('Name should be no less than 6 characters.' + count);
            }
            if (name.length > 40) {
                throw new Error('Name should be no more than 30 characters.' + count)
            }
            if (typeof price !== 'number') {
                throw new Error('Price should be a decimal floating point number.' + count)
            }

            this.type = type;
            this.name = name;
            this.price = price;
        };

        return Item;
    }());

    return Item;
});

