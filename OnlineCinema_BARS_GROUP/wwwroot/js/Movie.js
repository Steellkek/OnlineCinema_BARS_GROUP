async function GetMovie() {
    const response = await fetch("/api/Movie/" + sessionStorage.id, {
        method: "GET",
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
            "Accept": "application/json",
        }
    });
    if (response.ok === true) {
        const movie = await response.json();
        console.log(movie)
        let htmlCategory='';
        movie.genres.forEach((genre)=>{
            htmlCategory+=`${genre.name + ' '} `})
        let htmlMovie='';
        htmlMovie+=`
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-6"><img src="${movie.imagePath}" alt="${movie.title}" width=70% height=70%></div>
                <div class="col-md-4">
                    <div class="grid">
                        <div class="g-col-4"><h3>${movie.title}</h3></div>
                        <div class="g-col-4"><h5>Описание: ${movie.longDescription}</h5></div>
                        <div class="g-col-4"><h4>Жанр:<h5>${htmlCategory}<h5></h4></div>
                    </div>
                </div>
            </div>    
            <div class="row">
                <div class="col"></div>
                <div class="col"></div>
            </div>
        </div>

        </div>`;
        document.getElementById("Title").innerHTML = movie.title;
        document.getElementById("movie").innerHTML = htmlMovie;
    }
    else{
        alert("У нас проблемы, попробуйте зайти через пару минут!!!")
    }
}
GetMovie();