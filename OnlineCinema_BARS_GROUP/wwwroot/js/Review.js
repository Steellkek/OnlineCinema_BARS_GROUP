document.getElementById("review-add").onclick= function (){
    event.preventDefault();
    let review = document.getElementById("review-body").value;
    console.log(review);
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
GetComments();