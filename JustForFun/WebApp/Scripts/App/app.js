'use strict';

var app = angular.module('app-module', [
     //'ngGrid',
     //'ngRoute',
     //'ui.bootstrap',
     //'ui.router',
     'angular-loading-bar',
     //'LocalStorageModule',
     //'ui.bootstrap.tooltip',
     //'ui'
     //Services
]);

app.config(['cfpLoadingBarProvider', function(cfpLoadingBarProvider) {
    cfpLoadingBarProvider.includeSpinner = false;
}]);

//app.config(function ($stateProvider, $urlRouterProvider, $httpProvider) {
//    //$urlRouterProvider.when('/DataAdmin', '/DataAdmin/Users');
//    //$urlRouterProvider.when('', 'CPRs');
//    //$urlRouterProvider.otherwise('/Error');

//    //$stateProvider
//    //    .state('Error', {
//    //        url: '/Error',
//    //        templateUrl: 'Error/ClientError'
//    //    })
//    //    .state('NoState', {
//    //        url: ''
//    //    })
//    //    .state('CPRs', {
//    //        url: '/CPRs',
//    //        templateUrl: 'CPR/CPRs'
//    //    })
//    //    .state('MyCPRs', {
//    //        url: '/MyCPRs',
//    //        templateUrl: 'CPR/CPRs'
//    //    })
//    //    .state('CPR', {
//    //        url: '/CPRs/CPR/{ContractId}',
//    //        templateUrl: 'CPR/CPR'
//    //    })
//    //    //.state('MessageCenter', {
//    //    //    url: '/MessageCenter',
//    //    //    templateUrl: 'MessageCenter/MessageCenter'
//    //    //})
//    //    //.state('Reports', {
//    //    //    url: '/Reports',
//    //    //    templateUrl: 'CPR/CPRs'
//    //    //})
//    //    .state('ApprovalDashboard', {
//    //        url: '/ApprovalDashboard',
//    //        templateUrl: 'ApprovalDashboard/ApprovalDashboard'
//    //    })
//    //    //.state('ProductMaster', {
//    //    //    url: '/ProductMaster',
//    //    //    templateUrl: 'ProductMaster/ProductMaster'
//    //    //})
//    //    //.state('Profile', {
//    //    //    url: '/Profile',
//    //    //    templateUrl: 'User/Profile'
//    //    //})
//    //    .state('DataAdmin', {
//    //        url: '/DataAdmin',
//    //        templateUrl: 'DataAdmin/DataAdmin',
//    //    })
//    //    .state('DataAdmin.SalesPersons', {
//    //        url: '/SalesPersons',
//    //        templateUrl: 'DataAdmin/SalesPersons'
//    //    })
//    //    .state('DataAdmin.Users', {
//    //        url: '/Users',
//    //        templateUrl: 'DataAdmin/Users'
//    //    })
//    //    .state('Login', {
//    //        url: '/Login',
//    //        templateUrl: 'User/Login'
//    //    })
//    //    .state('LogOut', {
//    //        url: '/Login',
//    //        templateUrl: 'User/Login'
//    //    })
//    //    .state('DataAdmin.SalesPersons.SalesPerson', {
//    //        url: '/SalesPerson/{SalesPersonId}'
//    //    })
//    //    .state('DataAdmin.Users.User', {
//    //        url: '/User/{UserId}',
//    //        //templateUrl: 'Users/User'
//    //        //onEnter: ['$modal', function ($modal) {
//    //        //    $modal.open({
//    //        //        templateUrl: 'userModal',
//    //        //        controller: 'userCtrl',
//    //        //    });
//    //        //}]
//    //    });
//    //$httpProvider.interceptors.push('authInterceptorService');
//});


app.run(
    //['authService', function (authService) {
    //    authService.fillAuthData();
    //}]
);