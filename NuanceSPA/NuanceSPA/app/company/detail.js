define(['durandal/app', 'knockout'], function (app, ko) {
    var vm =  {
        FirstName: ko.observable({ name: 'WWrrrsffsfdsTTTT' }),
        subscription:ko.observable(),
        selectedEmployee: ko.observable({FirstName: 'Test'} ),
        activate: function () {
            var sub = app.on('sample:event').then(function (employee) {
                vm.selectedEmployee(employee);
            }, this);

            this.subscription(sub);
        }
    };

    return vm;
});