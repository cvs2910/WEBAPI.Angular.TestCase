(function () {
    "use strict";
    angular
        .module("studentManagement")
        .controller("studentsList",
            ["studentResource",
                studentsList]);

    function studentsList(studentResource) {
        var vm = this;

        studentResource.query(function (data) {
            vm.students = data;
        });
    }
}());
