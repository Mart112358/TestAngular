angular
    .module('app',
    [
        'ngRoute',
        'ngGrid'
    ])
    .factory('customerFactory', function () {
        var factory = {};
        var customers = [
        { name: 'John Smith', city: 'Phoenix' },
        { name: 'John Doe', city: 'New York' },
        { name: 'Jane Doe', city: 'San Francisco' }
        ];
        factory.getCustomers = function () {
            return customers;
        };

        return factory;
    })
    .config(function ($routeProvider) {
        $routeProvider
            .when('/',
            {
                redirectTo: '/view1'
            })
            .when('/view1',
            {
                controller: 'AppController',
                templateUrl: '/app/views/view1.html'
            })
            .otherwise(
            {
                redirectTo: '/'
            });
    })
    .controller("AppController", function ($scope, customerFactory) {
        $scope.customers = [];

        init();

        function init() {
            $scope.customers = customerFactory.getCustomers();

            $scope.gridOptions = {
                data: 'customers',
                columnDefs: [
                    { field: 'name', displayName: 'Name' },
                    { field: 'city', displayName: 'City' },
                ]
            };
        }

        $scope.addCustomer = function () {
            $scope.customers.push({ name: $scope.newCustomer.name, city: $scope.newCustomer.city });
        };
    });