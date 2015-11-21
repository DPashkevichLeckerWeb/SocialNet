'use strict';

app.controller('menuAnimationController', ['$scope', function ($scope) {
    $scope.menuClass = "menu closed";
    $scope.contentClass = "col-md-10";
    $scope.menuMockClass = "menuMock opened";

    $scope.openMenu = function () {
        $scope.menuClass = "menu opened col-md-2";
        $scope.menuMockClass = "menuMock closed";
    }
    
    $scope.closeMenu = function () {
        $scope.menuClass = "menu closed";
        $scope.menuMockClass = "menuMock opened";
    }
    
}]);