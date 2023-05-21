'use strict';

// build reference to button
const switcher = document.querySelector('.btn');

// add event handler for "click" event
switcher.addEventListener('click', function() {
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');
});