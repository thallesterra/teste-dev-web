angular.module('minhasDiretivas', []).directive('meuPainel', function () {
    var ddo = {};

    ddo.restrict = "AE";
    ddo.transclude = true;

    ddo.scope = {
        nome: '@',
        foto: '@',
        idade: '@',
        preco: '@',
        idcachorro: '@'
    };

    ddo.templateUrl = '../Scripts/lib/directives/meu-painel.html';

    return ddo;
});