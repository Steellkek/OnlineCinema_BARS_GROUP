// Добавление пользователя
async function CreateUser(userName, surname, password) {

    const response = await fetch("api/registration", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            UserName: userName,
            SurName: surname,
            Password: password
        })
    });
    alert(await response.json());
}
// отправка формы
document.forms["userForm"].addEventListener("submit", e => {
    e.preventDefault();
    const form = document.forms["userForm"];
    const name = form.elements["name"].value;
    const surname = form.elements["surname"].value;
    const password = form.elements["password"].value;
    CreateUser(name, surname, password);
    location.href = 'login.html';
});