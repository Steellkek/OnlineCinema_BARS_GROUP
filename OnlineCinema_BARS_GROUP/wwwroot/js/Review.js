document.getElementById("review-add").onclick= async function () {
    event.preventDefault();
    let review = document.getElementById("review-body").value;
    if(review!=="") {
        let userId;
        console.log(localStorage.user);
        const response = await fetch("/api/User/" + localStorage.user, {
            method: "GET",
            headers: {"Accept": "application/json"}
        });
        if (response.ok===true){
            const user= await response.json();
            userId=user.id;
            console.log(userId)
        }
        let Review = {
            id: uuidv4(),
            authorId: parseInt(userId),
            comment: review.toString(),
            dislikes: 0,
            likes: 0,
            movieId: parseInt(localStorage.id),
            time: Math.floor(Date.now() / 1000)
        }
        console.log(Review)
        let response1 = await fetch('api/Review', {
            method: 'POST',
            headers: {"Content-Type": "application/json" },
            body: JSON.stringify(Review)
        });
        if (response1.ok === true) {
            document.getElementById("review-body").value="";
            GetComments();
        }
    }
    else{
        alert("Вы не ввели отзыв!!")
    }
    

}




async function GetComments() {
    console.log(localStorage.id)
    // отправляет запрос и получаем ответ
    const response = await fetch("/api/Review/" + localStorage.id , {
        method: "GET",
        headers: {"Accept": "application/json"}
    });
    if (response.ok === true) {
        const reviews = await response.json();
        console.log(reviews);
        let htmlReviews='';
        reviews.forEach((review)=>{
            htmlReviews += `<p class="text-right small"><em>${timeConverter(review.time)}</em></p>`;
            htmlReviews+=`<p class="alert alert-primary">Пользователь: ${review.author.userName}</p>`
            htmlReviews+=`<p class="alert alert-success">Отзыв: ${review.comment}</p>`
        })
        document.getElementById("reviews").innerHTML=htmlReviews;
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
    var months = ['Jan','Feb','Mar','Apr','May','Jun','Jul','Aug','Sep','Oct','Nov','Dec'];
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