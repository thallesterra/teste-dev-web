angular.module('charliedog').controller('FotosController', function ($scope, $http) {
    
    $scope.infos = [];

    $scope.filtro = '';

    $scope.hidd = '';
    $scope.InserirCarrinho = function (id) {
        $scope.hidd = id;
    };

    $http({
        method: 'GET',
        url: '/Home/ReturnDogs'
    }).then(function (success) {
        $scope.infos = success.data;
    }, function (error) {
        console.log(erro);
    });
});