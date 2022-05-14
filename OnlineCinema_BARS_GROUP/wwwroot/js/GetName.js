function getName() {
    var currentName = sessionStorage.getItem('user');
    document.getElementById('nickName').textContent = currentName;
}
getName();