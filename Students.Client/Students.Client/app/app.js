(function () {
    "use strict";

    var app = angular.module("studentManagement",
        ["common.services"]);
    app.controller('studentsList', function ($scope) {
        $scope.searchName = '',
        $scope.searchMark = function (item) {
            var output = [];
                if (item > $scope.searchMark) {
                    output.push(item);
                };
                return output;
            };
    })

}());