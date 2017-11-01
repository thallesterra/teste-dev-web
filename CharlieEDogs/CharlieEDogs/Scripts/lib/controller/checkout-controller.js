angular.module('charliedog').controller('CheckoutController', function ($scope, $http, $window) {
    
    $scope.datax = window.data;

    console.log($scope.datax)

    $scope.info = window.data;
    
});