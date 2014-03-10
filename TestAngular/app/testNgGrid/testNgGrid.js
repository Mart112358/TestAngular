(function () {
    'use strict';

    app.controller('testNgGrid',
        [
            '$scope',
            'customerFactory',
            'logger',
            function ($scope, customerFactory, logger) {
                logger.log("Hello World!", null, null, true);
                init();

                function init() {
                    $scope.customers = customerFactory.getCustomers();

                    $scope.gridOptions = {
                        data: 'customers',
                        columnDefs: [
                            { field: 'name', displayName: 'Name' },
                            { field: 'city', displayName: 'City' }
                        ]
                    };
                }
            }
        ]);
})();