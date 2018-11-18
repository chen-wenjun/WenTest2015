let delay = 1000 * 60 * 60;
let end = Date.now() + delay;
let start = Date.now();
while (Date.now() <= end) {
    if (Date.now() - start >= 1000) {
        postMessage(new Date());
        start = Date.now();
    }
}