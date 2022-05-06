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
}

function GoToMovie(){
    localStorage["id"]=event.target.id;
    window.location.href = 'Movie.html';
}

window.onload=() =>{
    let input= document.querySelector('#input')
    input.oninput=function (){
        let value = this.value.trim();
        let list = document.querySelectorAll(".col-3")
        //console.log(list)
        //console.log(list[0].getElementsByTagName('h5')[0].innerText)
        if(value){
            list.forEach(elem=>{
                if(elem.getElementsByTagName('h5')[0].innerText.toLowerCase().search(value) ===-1){
                    elem.classList.add('hide')
                }
                else{
                    elem.classList.remove('hide')
                }
            });
        }else
        {
            list.forEach(elem=>{
                elem.classList.remove('hide')
            })
        }

    }
}

GetMovies();

