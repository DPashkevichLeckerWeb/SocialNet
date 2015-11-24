'use strict';

app.controller('userController', ['$scope', function ($scope) {
    $scope.currentUser = currentUser;
    $scope.isAuthenticated = isAuthenticated;
}]);