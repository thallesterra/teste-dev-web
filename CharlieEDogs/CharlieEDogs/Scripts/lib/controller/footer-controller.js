angular.module('charliedog').controller('FooterController', function ($scope) {

    $scope.portes = [
        { tipo: 'mini' },
        { tipo: 'pequeno porte' },
        { tipo: 'médio porte' },
        { tipo: 'grande porte' }
    ];

    $scope.precos = [
        { faixa: 'até R$ 100' },
        { faixa: 'de R$ 100 a R$ 300' },
        { faixa: 'de R$ 300 a R$ 500' },
        { faixa: 'acima de R$ 500' }
    ];

    $scope.contato = {
        telefone: '11 0000.0000',
        email: 'contato@charlieedog.com.br'
    }
});