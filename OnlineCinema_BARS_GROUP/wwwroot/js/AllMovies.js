// Рендеринг панели фильтров
function renderFilterCategories(categories, genres) {
    let html = ``;
    html=`<div>
            <input type="radio" name="Category" id="" checked >
            <label>Все фильмы<label>
          </div>`;
    document.getElementById("filterCategories").innerHTML += html;
    categories.forEach(x => {
        //console.log(movies)
        html=`<div>
                    <input type="radio" name="Category" id="${x.id}">
                    <label>${x.name}</label>
              </div>`;
        document.getElementById("filterCategories").innerHTML += html;
    })
    html=`<div>
            <input type="radio" name="Genre" id="" checked >
            <label>Все жанры<label>
          </div>`;
    document.getElementById("filterGenres").innerHTML += html;
    genres.forEach(x => {
        //console.log(movies)
        html=`<div>
                <input type="radio" name="Genre" id="${x.id}" >
                <label>${x.name}<label>
              </div>`;
        document.getElementById("filterGenres").innerHTML += html;
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
    console.log(7)
    let categorys=document.querySelectorAll('input[name="Category"]')
    let genres = document.querySelectorAll('input[name="Genre"]')
    let genreId
    for (const l of genres) {
        if (l.checked) {
            genreId=l.id
            break
        }
    }
    let categoryId;
    for (const f of categorys) {
        if (f.checked) {
            categoryId=f.id
            break
        }
    }
    let moviesOptionsDto={
        categoryId:categoryId,
        genreId:genreId
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
    console.log(JSON.stringify(moviesOptionsDto))
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

// Получить список категорий.
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

//Получить список жанров.
async function getGenres() {
    // отправляет запрос и получаем ответ
    const response = await fetch("/api/Movie/allGenres", {
        method: "GET",
        headers: {
            "Authorization": "Bearer " + sessionStorage.getItem("accessToken"),
            "Accept": "application/json"
        }
    }).catch(e => {
        console.error(e);
    });

    // получаем данные
    const genres = await response.json();
    console.log(genres)
    return genres;
}

// Рендеринг страницы.
async function renderPage() {
    try {
        let movies = await getMovies();
        let categories = await getCategories();
        let genres = await getGenres();
        
        console.log(categories)
        await renderList(movies);
        renderFilterCategories(categories, genres);
    }
    catch(e) {
        console.log(e)
        alert("Войдите в систему, прежде чем смотреть фильмы!!!")
    }
}
getGenres();
renderPage();


