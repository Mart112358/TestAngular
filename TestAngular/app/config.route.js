(function () {
    'use strict';

    app.routes =
        [
            { path: '/', name: 'Home', templateUrl: '/app/home/home.html' },
            { path: '/testNgGrid', name: 'Test ng-grid', templateUrl: '/app/testNgGrid/testNgGrid.html', controller: 'testNgGrid' }
        ];

    app.config(
        [
            '$routeProvider',
            function ($routeProvider) {
                for (var i = 0; i < app.routes.length; i++) {
                    var route = app.routes[i];
                    $routeProvider.when(route.path, route);
                }
                $routeProvider.otherwise({ redirectTo: '/' });
            }
        ]);
})();