define(['plugins/router'], function (router) {
    return {
        router: router,
        activate: function () {
            return router.map([
                { route: ['', 'home'],                  moduleId: 'hello/index',            title: 'Hello World',       nav: 1 },
                { route: 'company',                     moduleId: 'company/index',               title: 'Nuance',  nav: true},
                { route: 'view-composition',            moduleId: 'viewComposition/index',  title: 'View Composition',  nav: true },
                { route: 'modal',                       moduleId: 'modal/index',            title: 'Modal Dialogs',     nav: 4 },
                { route: 'event-aggregator',            moduleId: 'eventAggregator/index',  title: 'Events',            nav: 2 },
                { route: 'widgets',                     moduleId: 'widgets/index',          title: 'Widgets',           nav: true },
                { route: 'master-detail',               moduleId: 'masterDetail/index',     title: 'Master Detail',     nav: 3 }
            ]).buildNavigationModel()
              .mapUnknownRoutes('hello/index', 'not-found')
              .activate();
        }
    };
});