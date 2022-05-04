async function GetMovie() {
    const response = await fetch("/api/Home/" + localStorage.id, {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    if (response.ok === true) {
        const movie = await response.json();
        console.log(movie)
        let htmlCategory='';
        movie.categories.forEach((category)=>{
            htmlCategory+=`${category.categoryName + ' '} `})
        let htmlMovie='';
        htmlMovie+=`
        <div class="container-fluid">
            <div class="row">
                <div class="col-md-6"><img src="${movie.img}" alt="${movie.name}" width=100% height=100%></div>
                <div class="col-md-4">
                    <div class="grid">
                        <div class="g-col-4"><h3>${movie.name}</h3></div>
                        <div class="g-col-4"><h5>Описание: ${movie.longDesc}</h5></div>
                        <div class="g-col-4"><h4>Жанр:${htmlCategory}</h4></div>
                    </div>
                </div>
            </div>    
            <div class="row">

                <div class="col align-self-center"><iframe width=100% height="600px" src="https://www.youtube.com/embed/3FQVINAen3U" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe></div>

            </div>
        </div>

        </div>`;

        document.getElementById("movie").innerHTML = htmlMovie;
    }
}
GetMovie();