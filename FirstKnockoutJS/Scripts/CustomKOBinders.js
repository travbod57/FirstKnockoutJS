// Custom Bindings
ko.bindingHandlers.date = {
    update: function (element, valueAccessor) {
        var value = valueAccessor();
        var result = value();

        if (result != null) {
            var date = moment(result);
            var strDate = date.format('DD MMMM YYYY');
            $(element).text(strDate);
        }
        else
            $(element).text(' ');
    }
};

ko.bindingHandlers.dateString = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
        var value = valueAccessor(),
        allBindings = allBindingsAccessor();
        var valueUnwrapped = ko.utils.unwrapObservable(value);

        if (valueUnwrapped != null) {
            var pattern = allBindings.datePattern || 'DD MMMM YYYY';
            $(element).text(moment(valueUnwrapped).format(pattern));
        }
        else
            $(element).text(' ');
    }
}