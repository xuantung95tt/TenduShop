﻿/// <reference path="F:\Git\TeduShop\TeduShop.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('tedushop.product_categories', ['tedushop.common']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('product_categories', {
            url: "/product_categories",
            parent: "base",
            templateUrl: "/app/components/product_categories/ProductCategoryListView.html",
            controller: "productCategoryListController"
        }).state('add_product_category', {
            url: "/add_product_category",
            parent: "base",
            templateUrl: "/app/components/product_categories/ProductCategoryAddView.html",
            controller: "productCategoryAddController"
        }).state('edit_product_category', {
            url: "/edit_product_category/:id",
            parent: "base",
            templateUrl: "/app/components/product_categories/ProductCategoryEditView.html",
            controller: "productCategoryEditController"
        });;
    }
})();