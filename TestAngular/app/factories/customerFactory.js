(function () {
    'use strict';
    app.factory('customerFactory',
        [
            function () {
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
            }
        ]);
})();