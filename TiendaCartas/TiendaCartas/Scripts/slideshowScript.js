(function () {

    var counter = 0,
    $items = document.querySelectorAll('.slideshow figure'),
    numItems = $items.length;

    var showCurrent = function() {
        var itemToShow = Math.abs(counter % numItems);

        [].forEach.call($items, function(el) {
            el.classList.remove('show');
        });

        $items[itemToShow].classList.add('show');
    };

    document.querySelector('.next').addEventListener('click', function () {

        counter++;
        showCurrent();
    }, false);

    document.querySelector('.prev').addEventListener('click', function () {
       
        counter--;
        showCurrent();
       
    }, false);

    window.setInterval(function () {
        counter++;
        showCurrent();
        counter > showCurrent
    }, 3000);

    


})();
