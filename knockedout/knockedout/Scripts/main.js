define(['dataccess'], function (da) {
    var success = "This worked!!";

    var self = this;

    self.vm = function () {
        employees = ko.observableArray([{
            FirstName: 'Bill',
            Company: 'Microsoft',
            City: 'Washington',
        }])
    };

    ko.applyBindings(self.vm);

    da.getEmployees();
});