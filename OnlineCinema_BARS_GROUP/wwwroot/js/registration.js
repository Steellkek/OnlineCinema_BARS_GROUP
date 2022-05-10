document.forms["userForm"].addEventListener("submit", e => {
    e.preventDefault();
    const form = document.forms["userForm"];
    const username = form.elements["username"].value;
    const surname = form.elements["surname"].value;
    const password = form.elements["password"].value;
    addUser(username, surname, password);
});

async function addUser(username, surname, password) {
    let user = {
        username: username,
        surname: surname,
        password: password
    };

    let response = await fetch('https://localhost:7019/api/registration', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify(user)
    });

    try {
        await response.json();
        location.href = 'login.html'
    } catch (err) {
        alert('Пользователь с таким именем уже существует');
    }
}