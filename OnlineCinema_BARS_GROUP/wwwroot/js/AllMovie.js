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
                <li>
                    <span>${movie.name}</span>
                    <div class="photo" alt="Смотреть фильм"><img src="${movie.img}" alt="movie" class="image" ></div>
                </li>
            `;
        });

        const html = `
            <ul>
                ${htmlCatalog}
            </ul>
        `;
        
        document.getElementById("movies").innerHTML = html;
    }
}
GetMovies();
