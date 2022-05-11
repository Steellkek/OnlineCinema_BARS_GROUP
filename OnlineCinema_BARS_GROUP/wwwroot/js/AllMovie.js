

//Вывод всех фильмов
async function GetMovies() {
    // отправляет запрос и получаем ответ
    const response = await fetch("/api/Movie", {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    // если запрос прошел нормально
    if (response.ok === true) {
        // получаем данные
        const movies = await response.json();
        console.log(movies)
        let htmlCatalog = '';
        //console.log(movies)
        movies.forEach((movie) => {
            let htmlCategory=''
            movie.genres.forEach((genre)=>{
                htmlCategory+=`${genre.name + ' '} `})
            htmlCatalog += `
                
                <div class="col-3">
                    <button onclick="GoToMovie()" type="button" class="btn btn-link"><div class="photo"  id="${movie.id}" alt="Смотреть фильм"><img src=${movie.imagePath} alt="movie" class="image"></div></button>
                    <h5>${movie.title}</h5>
                    <h6>${htmlCategory}</h6>
                </div>
                
            `;
        });

        document.getElementById("movies").innerHTML = `
            <div class="container"><div class="row row-cols-4">${htmlCatalog}</div></div>
        `;
    }
    else{
        alert("У нас проблемы, попробуйте зайти через пару минут!!!")
    }
}

//Перейти на фильм при нажатии на картинку
function GoToMovie(){
    localStorage["id"]=event.target.id;
    window.location.href = 'Movie.html';
}


GetMovies();

console.log(localStorage.user)
