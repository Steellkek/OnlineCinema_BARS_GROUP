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

        movies.forEach((movie) => {
            htmlCatalog += `
                
                <div class="col-lg-3">
                    <div class="photo" alt="Смотреть фильм"><img src="${movie.img}" alt="movie" class="image" ></div>
                                        <p>${movie.name}</p>
                </div>
                
            `;
        });

        const html = `
            <div class="row mt-5 mb-2">${htmlCatalog}</div>
        `;
        
        document.getElementById("movies").innerHTML = html;
    }
}
GetMovies();
