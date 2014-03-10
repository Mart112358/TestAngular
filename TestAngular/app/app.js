'use strict';

var app = angular
    .module('app',
    [
        'ngRoute',
        'ngAnimate',
        'ngGrid'
    ])
    .controller('routeController', function ($scope, $route) {
        $scope.$route = $route;
        $scope.links = app.routes;
    });