console.log('woot');
var system = require('system');
var page = require('webpage').create();

console.log('baaaaam');

page.viewportSize = { width: 1440, height: 900 };

page.open("http://www.onlinebooq.dk", function () {
    var name = 'webname' + '.png';
    page.render(name);
    console.log(name);
    page.close();

    phantom.exit();
});