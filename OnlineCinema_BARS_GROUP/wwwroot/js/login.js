document.forms["userForm"].addEventListener("submit", e => {
    e.preventDefault();
    const form = document.forms["userForm"];
    const username = form.elements["username"].value;
    const password = form.elements["password"].value;
    Login(username, password);
});

async function Login(username, password) {
    let user = {
        username: username,
        password: password
    };

    let response = await fetch('https://localhost:7019/api/login', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify(user)
    });
    const result = await response.text();
    if (result.length < 60) 
        alert(result);
    else
        location.href = '/api/movie'
}