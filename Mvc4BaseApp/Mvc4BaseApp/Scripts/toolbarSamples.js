$(document).ready(function ($) {

    // Define any icon actions before calling the toolbar 
    $('.toolbar-icons a').on('click', function (event) {
        event.preventDefault();
    });

    $('#normal-button').toolbar({ content: '#user-toolbar-options', position: 'top' });
    $('#normal-button-bottom').toolbar({ content: '#user-options', position: 'bottom' });
    $('#normal-button-small').toolbar({ content: '#user-options-small', position: 'top', hideOnClick: true });
    $('#button-left').toolbar({ content: '#user-options', position: 'left' });
    $('#button-right').toolbar({ content: '#user-options', position: 'right' });
    $('#link-toolbar').toolbar({ content: '#user-options', position: 'top' });

});