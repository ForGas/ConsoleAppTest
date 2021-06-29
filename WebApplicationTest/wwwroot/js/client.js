$(document).ready(function () {
    console.log('gg');
    $('.delete').click(function () {
        var clicked = $(this);
        clicked.attr('disabled', 'disabled');

        console.log('gg');
        var id = clicked.attr('client-id');
        var url = '/Client/Remove?Id=' + id;

        $.get(url).done(function (answer) {
            if (answer) {
                clicked.closest(`#${id}`).remove();
            }
        });
    });
});

