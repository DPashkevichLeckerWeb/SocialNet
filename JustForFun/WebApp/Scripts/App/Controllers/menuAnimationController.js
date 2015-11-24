'use strict';

app.controller('menuAnimationController', ['$scope', function ($scope) {
    $scope.moveContent = "content moved";
    $scope.allowMove = true;

    $scope.openMenu = function () {
        $scope.moveContent = "content";
    }
    
    $scope.closeMenu = function () {
        if ($scope.allowMove)
            $scope.moveContent = "content moved";
    }

    $scope.togglePinMenuBar = function () {
        $scope.allowMove = !$scope.allowMove;
        if ($scope.allowMove) {
            $scope.pinned = "";
        }
        else {
            $scope.pinned = "pinned";
        }
    }


    
}]);