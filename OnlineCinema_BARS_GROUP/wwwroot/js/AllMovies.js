// Рендеринг панели фильтров
function renderFilterCategories(categories, movies) {
    let html = ``;
    categories.forEach(x => {
        let category = x.name;
        //console.log(movies)
        html=`<li>
                    <a href="#"
                       class="btn"
                       id = "${x.id}"
                       onclick="getMoviesByCategory()">
                       ${x.name}
                    </a>
               </li>`;
        document.getElementById("filterCategories").innerHTML += html;
    })
    

}


//Вывод всех фильмов
async function renderList(movies, categoryId = null) {
    let htmlCatalog = '';
    //console.log(movies)
    movies.forEach((movie) => {
        let htmlCategory = ''
        movie.genres.forEach((genre) => {
            htmlCategory += `${genre.name + ' '} `
        })
        htmlCatalog += `
            
            <div class="col-3">
                <button onclick="GoToMovie()" type="button" class="btn btn-link">
                    <div class="photo"  id="${movie.id}" alt="Смотреть фильм">
                        <img src=${movie.imagePath} alt="movie" class="image">
                    </div>
                </button>
                <h4>${movie.title}</h4>
                <h6>${htmlCategory}</h6>
            </div>
            
        `;
    });

    document.getElementById("movies").innerHTML = `
        <div class="container"><div class="row row-cols-4">${htmlCatalog}</div></div>
    `;
}

async function getMoviesByCategory() {
    let categoryId=event.target.id;
    console.log(categoryId)
    let moviesOptionsDto={
        categoryId:categoryId.toString()
    }
     //отправляет запрос и получаем ответ
    const response = await fetch("/api/Movie/list", {
        method: "Post",
        headers: {
            "Content-Type": "application/json",
            "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
        },
        body: JSON.stringify(moviesOptionsDto)
    }).catch(e => {
        console.error(e);
    });

    // получаем данные
    const mo = await response.json();
    renderList(mo)
}

// Получить список фильмов.
async function getMovies() {
    // отправляет запрос и получаем ответ
    const response = await fetch("/api/Movie", {
        method: "GET",
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
            "Accept": "application/json"
        }
    }).catch(e => {
        console.error(e);
    });

    // получаем данные
    const movies = await response.json();
    console.log(movies)
    return movies;
}

// Получить список жанров.
async function getCategories() {
    // отправляет запрос и получаем ответ
    const response = await fetch("/api/Movie/allCategories", {
        method: "GET",
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
            "Accept": "application/json"
        }
    }).catch(e => {
        console.error(e);
    });

    // получаем данные
    const categories = await response.json();
    console.log(categories)
    return categories;
}

//Перейти на фильм при нажатии на картинку
function GoToMovie() {
    sessionStorage["id"] = event.target.id;
    window.location.href = 'Movie.html';
}

// Рендеринг страницы.
async function renderPage() {
    try {
        let movies = await getMovies();
        let categories = await getCategories();
        
        console.log(categories)
        await renderList(movies);
        renderFilterCategories(categories, movies);
    }
    catch(e) {
        console.log(e)
        alert("Войдите в систему, прежде чем смотреть фильмы!!!")
    }
}

renderPage();


