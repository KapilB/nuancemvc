define(['./employees', './detail'], function (publisher, subscriber) {
    return {
        listing:publisher,
        details: subscriber
    };
});