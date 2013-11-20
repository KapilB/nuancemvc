define(['durandal/app', 'knockout', 'jquery'], function (app, ko, $) {

    var vm = {
        selectedEmployee: ko.observable(),
        employees: ko.observableArray([]),
        selectEmployee: function (data) {
            app.trigger('sample:event', data);
            return false;
        },
        activate: function () {
            $.get('/Employee/List',
                function (data) {
                    $.each(data, function(index, item){
                        vm.employees.push( item);
                    })
                }
            )
        }
    };

    return vm;
});