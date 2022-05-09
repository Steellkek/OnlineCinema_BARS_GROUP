async function GetMovie() {
    const response = await fetch("/api/Movie/" + localStorage.id, {
        method: "GET",
        headers: { "Accept": "application/json" }
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
                <div class="col-md-6"><iframe width=100% height="400px" src="https://www.youtube.com/embed/3FQVINAen3U" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></div>
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