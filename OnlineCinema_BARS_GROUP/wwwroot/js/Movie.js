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
        let htmlCategory = '';
        movie.genres.forEach((genre) => {
            htmlCategory += `${genre.name + ' '} `
        })
        let htmlMovie = '';
        htmlMovie += `
<div class="container">
    <div class="card p-5 mb-5">
        <div class="row">
            <div class="col">  
                <img src="${movie.imagePath}" alt="${movie.title}" class="img-fluid">
            </div>
            <div class="col-md-5">
                <div class="grid">
                    <div class="g-col-4"><h1>${movie.title}</h1></div>
                    <div class="g-col-4"><h4>Продолжителность:<br><font size="4">${movie.duration}</font></h4></div>
                    <div class="g-col-4"><h4 id="Rating">Оценка:<br><font size="4">КП ${movie.rating}</font></h4></div>
                    <div class="g-col-4"><h4>Жанр:<br><font size="4">${htmlCategory}</font></h4></div>
                    <div class="g-col-4"><h4>Описание:<br><font size="4"> ${movie.longDescription}</font></h4></div>
    
                </div>
            </div>
        </div>
    </div>  
    <div class="card p-5 mb-5">
        <div class="row d-flex justify-content-center">
            <div class="col">
                <h2 class="text-center">Трейлер</h2>
                <div class="embed-responsive embed-responsive-16by9">v
                    <iframe 
                            width="100%"
                            height="100%"
                            src="${movie.filmPath}" 
                            title="YouTube video player" 
                            frameborder="0" 
                            allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                            allowfullscreen>
                    </iframe>
                </div>
            </div>
        </div>
    </div>
</div>`
        document.getElementById("Title").innerHTML = movie.title;
        document.getElementById("movie").innerHTML = htmlMovie;
    } else {
        alert("У нас проблемы, попробуйте зайти через пару минут!!!")
    }
}

GetMovie();