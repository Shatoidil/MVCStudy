$(document).ready(function() {
    $('.sex').each(function () {
        switch ($(this).html()) {
            case '0':
                $(this).html('Женщина');
                break;
            case '1':
                $(this).html('Мужчина');
                break;
            default:
                $(this).html('Не определен');
                break;
        }
    });

});
