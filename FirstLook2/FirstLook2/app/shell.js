define(['plugins/router'], function (router) {
    return {
        router: router,
        activate: function () {
            return router.map([
                { route: ['', 'home'],                  moduleId: 'hello/index',            title: 'Home',       nav: 1 },
                { route: 'emps',            moduleId: 'viewComposition/index',  title: 'Employees',  nav: 2 },
                { route: 'reviews',                       moduleId: 'modal/index',            title: 'Reviews',     nav: 3 },
                { route: 'company',            moduleId: 'company/index',  title: 'Nuance',            nav: true },
                { route: 'widgets',                     moduleId: 'widgets/index',          title: 'Widgets',           nav: true },
                { route: 'master-detail',               moduleId: 'masterDetail/index',     title: 'Master Detail',     nav: true },
                { route: 'knockout-samples*details',    moduleId: 'ko/index',               title: 'Knockout Samples',  nav: true, hash: '#knockout-samples' }
            ]).buildNavigationModel()
              .mapUnknownRoutes('hello/index', 'not-found')
              .activate();
        }
    };
});