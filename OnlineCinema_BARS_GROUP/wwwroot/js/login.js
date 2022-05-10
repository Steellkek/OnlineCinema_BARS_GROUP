// Добавление пользователя
async function Login(userName, password) {

    const response = await fetch("api/login", {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify({
            UserName: userName,
            Password: password
        })
    });
}
// отправка формы
document.forms["userForm"].addEventListener("submit", e => {
    e.preventDefault();
    const form = document.forms["userForm"];
    const name = form.elements["name"].value;
    const password = form.elements["password"].value;
    Login(name, password);
});