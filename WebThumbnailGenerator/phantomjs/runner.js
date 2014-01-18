var async = require('c:/dev/tools/phantomjs/async.js'),system = require('system');

if (system.args.length === 1) {
    console.log('Usage: runnerjs.js data');
    phantom.exit();
}

var website = address = system.args[1];
console.log(website);

var webname = address = system.args[2];
console.log(webname);


var page = require('webpage').create();
	//page.zoomFactor = 1;
	page.viewportSize = {width: 1440, height: 900};

	page.open(website, function () {    
		var name = '../../haystack/Chef/Content/' + webname + '.png';
    page.render(name);
    console.log(name);
    page.close();
   
phantom.exit();
});


