define(['durandal/app', 'durandal/system', 'knockout'], function (app, system, ko) {

    var self = this;
    self.vm = {
        selectEmployee: function(){
            alert('employee selected');
        },
        employees: ko.observableArray([]),
        activate: function () {
            getData();
        }
    }

    function getData() {
        $.get('http://localhost:23295/Employee/List', function (dataResult) {
            $.each(dataResult, function (index, item) {
                self.vm.employees.push(item)
            });
        });
    }

    return self.vm;

});