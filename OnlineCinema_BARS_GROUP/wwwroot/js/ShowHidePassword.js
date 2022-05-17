var input = document.getElementById("show1");
var button = document.getElementById("show");
button.onclick = show;

function show() {
    if (input.getAttribute('type') == 'password') {
        input.removeAttribute('type');
        input.setAttribute('type', 'text');
        button.innerHTML = 'Скрыть пароль';

    } else {
        input.removeAttribute('type');
        input.setAttribute('type', 'password');
        button.innerHTML = 'Показать пароль';

    }
}