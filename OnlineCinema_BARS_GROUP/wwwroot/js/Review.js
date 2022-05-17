//добавление отзыва
document.getElementById("review-add").onclick= async function () {
    event.preventDefault();
    let review = document.getElementById("review-body").value;
    const Rating = document.querySelectorAll('input[name="rating"]')
    let rate;
    for (const f of Rating) {
        if (f.checked) {
            rate=f.value
            f.checked=false
            break
        }
        rate=null;
    }
    if((review!=="")&&(rate!=null)) {
        let userId;
        const response = await fetch("/api/User/" + sessionStorage.user, {
            method: "GET",
            headers: {
                "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
                "Accept": "application/json"
            }
        });
        if (response.ok===true){
            const user= await response.json();
            userId=user.id;
        }
        let Review = {
            id: uuidv4(),
            authorId: parseInt(userId),
            comment: review.toString(),
            movieId: parseInt(sessionStorage.id),
            time: Math.floor(Date.now() / 1000),
            rating:parseInt(rate)
        }
        let response1 = await fetch('api/Review', {
            method: 'POST',
            headers: {
                "Content-Type": "application/json",
                "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
            },
            body: JSON.stringify(Review)
        });
        if (response1.ok === true) {
            document.getElementById("review-body").value = "";
            GetComments();
        }
    }
    else {
        alert("Вы не ввели отзыв или не оставили оценку!!")
    }
    

}



async function GetComments() {
    const response = await fetch("/api/Review/" + sessionStorage.id , {
        method: "GET",
        headers: {"Accept": "application/json"}
    });
    if (response.ok === true) {
        const reviews = await response.json();
        let htmlReviews='';
        reviews.forEach((review)=>{
            if (review.author.userName === sessionStorage.user){
                document.getElementById("Add-review").classList.add('hide')
                document.getElementById("delete").classList.remove('hide')
                document.getElementById("delete").name=review.id;
            }
            htmlReviews += `<p class="text-right small"><em>${timeConverter(review.time)}</em></p>`;
            htmlReviews+=`<p class="alert alert-primary">Пользователь: ${review.author.userName}</p>`
            htmlReviews+=`<p class="alert alert-success">Оценка: ${'★'.repeat(review.rating)}<br>
            Отзыв: ${review.comment}</p>`
        })
        document.getElementById("reviews").innerHTML=htmlReviews;
    }
}

document.getElementById("delete").onclick= async function (){
    let id =document.getElementById("delete").name
    let response1 = await fetch('api/Review/'+id, {
        method: 'DELETE',
        headers: {"Accept": "application/json"}
    });
    if (response1.ok === true) {
        document.getElementById("Add-review").classList.remove('hide')
        document.getElementById("delete").classList.add('hide')
        GetComments();
    }
}

function uuidv4() {
    return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
        var r = Math.random() * 16 | 0, v = c == 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
    });
}

function timeConverter(UNIX_timestamp){
    var a = new Date(UNIX_timestamp * 1000);
    var months = ['Янв', 'Фев', 'Мар', 'Апр', 'Май', 'Июн', 'Июл', 'Авг', 'Сен', 'Окт', 'Ноя', 'Дек'];
    var year = a.getFullYear();
    var month = months[a.getMonth()];
    var date = a.getDate();
    var hour = a.getHours();
    var min = a.getMinutes();
    var sec = a.getSeconds();
    var time = date + ' ' + month + ' ' + year + ' ' + hour + ':' + min + ':' + sec ;
    return time;
}

GetComments();