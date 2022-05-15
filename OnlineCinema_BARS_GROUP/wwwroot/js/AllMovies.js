// Рендеринг панели фильтров
function renderFilterCategories(categories, movies) {
    let html = ``;
    categories.forEach(x => {
        let category = x;
        html+=`<li>
                    <a href="#"
                       id = "filter_${x.name}">
                       ${x.name}
                    </a>
               </li>`
        document.getElementById(`filter_${x.name}`)
                .addEventListener('click', renderList(movies));
    })
    
    document.getElementById("filterCategories").innerHTML = html;
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
        
        
        renderList(movies);
        renderFilterCategories(categories, movies);
    }
    catch(e) {
        alert("Войдите в систему, прежде чем смотреть фильмы!!!")
    }
}

renderPage();


