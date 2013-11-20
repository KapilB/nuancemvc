define(['tab1'], function (constants, localization) {
    function getData() {
        $.get(constants.URLForList, function (dataResult) {
            $.each(dataResult, function (index, item) {
                self.employees.push(item)
            });
        });
    }


    return {
        getEmployees: getData
    }
});