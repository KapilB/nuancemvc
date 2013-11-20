define(['./employees', './details'], function (publisher, subscriber) {
    return {
        listing: publisher,
        details: subscriber
    };
});