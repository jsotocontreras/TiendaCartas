(function () {

    var counter = 0,
    $items = document.querySelectorAll('.slideshow figure'),
    numItems = $items.length;
    var interval = 3000;

    var showCurrent = function () {
        var itemToShow = Math.abs(counter % numItems);

        [].forEach.call($items, function (el) {
            el.classList.remove('show');
        });

        $items[itemToShow].classList.add('show');
    };

    document.querySelector('.next').addEventListener('click', function () {

        counter++;
        interval + 10000;
        showCurrent();
    }, false);

    document.querySelector('.prev').addEventListener('click', function () {

        counter--;
        interval + 10000;
        showCurrent();

    }, false);

    window.setInterval(function () {
        counter++;
        showCurrent();
    }, interval);




})();
