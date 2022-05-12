document.getElementById("review-add").onclick= async function () {
    event.preventDefault();
    let review = document.getElementById("review-body").value;
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

    if(review!="") {
        let Review = {
            id: uuidv4(),
            authorId: parseInt(userId),
            comment: review.toString(),
            dislikes: 0,
            likes: 0,
            movieId: parseInt(localStorage.id)
        }
        console.log(Review)
        let response = await fetch('api/Review', {
            method: 'POST',
            headers: {"Content-Type": "application/json" },
            body: JSON.stringify(Review)
        });
        if (response.ok === true) {
            console.log(5)
        }
    }
    else{
        alert("Вы не ввели сообщение!!")
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
            htmlReviews+=`<p class="alert alert-primary">${review.author.userName}</p>`
            htmlReviews+=`<p class="alert alert-success">${review.comment}</p>`
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

GetComments();