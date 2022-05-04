//Вывод всех фильмов
async function GetMovies() {
    // отправляет запрос и получаем ответ
    const response = await fetch("/api/Home", {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    // если запрос прошел нормально
    if (response.ok === true) {
        // получаем данные
        const movies = await response.json();
        let htmlCatalog = '';
        //console.log(movies)
        movies.forEach((movie) => {
            let htmlCategory=''
            movie.categories.forEach((category)=>{
                htmlCategory+=`${category.categoryName + ' '} `})
            htmlCatalog += `
                
                <div class="col-3">
                    <button onclick="GoToMovie()" type="button" class="btn btn-link"><div class="photo"  id="${movie.id}" alt="Смотреть фильм"><img src=${movie.img} alt="movie" class="image"></div></button>
                    <p>${movie.name}</p>
                    <a>${htmlCategory}</a>
                </div>
                
            `;
        });

        document.getElementById("movies").innerHTML = `
            <div class="container"><div class="row row-cols-4">${htmlCatalog}</div></div>
        `;
    }
}

function GoToMovie(){
    localStorage["id"]=event.target.id;
    window.location.href = 'Movie.html';
}

GetMovies();

