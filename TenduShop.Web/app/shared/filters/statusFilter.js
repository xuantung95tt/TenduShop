/// <reference path="F:\Git\TeduShop\TeduShop.Web\Assets/admin/libs/angular/angular.js" />
(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            if (input == true) {
                return 'Kích Hoạt';
            }
            else {
                return 'Khóa';
            }
        }
    });
})(angular.module('tedushop.common'));