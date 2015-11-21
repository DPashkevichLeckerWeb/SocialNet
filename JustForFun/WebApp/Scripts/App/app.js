'use strict';

var app = angular.module('app-module', [
     //'ngGrid',
     //'ngRoute',
     //'ui.bootstrap',
     'ui.router',
     'angular-loading-bar',
     'ct.ui.router.extras',
     'ngMaterial',
     //'LocalStorageModule',
     //'ui.bootstrap.tooltip',
     //'ui'
     //Services
]);

app.config(['cfpLoadingBarProvider', function(cfpLoadingBarProvider) {
    cfpLoadingBarProvider.includeSpinner = false;
}]);

app.config(function ($stateProvider, $urlRouterProvider, $httpProvider) {
    //$urlRouterProvider.when('/DataAdmin', '/DataAdmin/Users');
    //$urlRouterProvider.when('', 'CPRs');
    $urlRouterProvider.otherwise('/');

    $stateProvider
        .state('index', {
            url: '/',
            templateUrl: '/MainPage/MyProfile'
        })
        .state('login', {
            url: '/login',
            templateUrl: '/Account/Login'
        })
        .state('value', {
            url: '/value/{id}',
            //templateUrl: 'MainPage/value/{id}'
        })
        //.state('DataAdmin.SalesPersons.SalesPerson', {
        //    url: '/SalesPerson/{SalesPersonId}'
        //})        
    //$httpProvider.interceptors.push('authInterceptorService');
});


app.run(
    //['authService', function (authService) {
    //    authService.fillAuthData();
    //}]
);