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
        console.log(movie)
        let htmlCategory = '';
        movie.genres.forEach((genre) => {
            htmlCategory += `${genre.name + ' '} `
        })
        let htmlMovie = '';
        htmlMovie += `
<div class="container">
    <main role="main">
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
        <div class="card p-5 mb-5">
        <h2 class="text-center">Отзывы</h2>
            <div class="col-lg-12" id="Add-review">
                <form>
                    <div class="form-group">
                        <label for="review-body">Ваш отзыв:</label>
                        <textarea type="name"
                                 class="form-control"
                                 id="review-body" 
                                 placeholder="Введите Отзыв"></textarea>
                    </div>
                    <div class="input-group-append">
                        <div class="rating-area mr-auto" id="rating">
                            <input type="radio" id="star-5" name="rating" value="5">
                            <label for="star-5" title="Оценка «5»"></label>
                            <input type="radio" id="star-4" name="rating" value="4">
                            <label for="star-4" title="Оценка «4»"></label>
                            <input type="radio" id="star-3" name="rating" value="3">
                            <label for="star-3" title="Оценка «3»"></label>
                            <input type="radio" id="star-2" name="rating" value="2">
                            <label for="star-2" title="Оценка «2»"></label>
                            <input type="radio" id="star-1" name="rating" value="1">
                            <label for="star-1" title="Оценка «1»"></label>
                        </div>
                        <div class="form-group text-right">
                            <button type="submit" id="review-add" class="btn btn-primary">Добавить отзыв</button>
                        </div>
                    </div>
                </form>
            </div>
            <div class="form-group text-center">
                <button type="submit" name="" id="delete" class="btn btn-primary hide">Удалить ваш отзыв</button>
            </div>
            <div id="reviews"></div>
    </div>
    </main>
</div>`
        document.getElementById("Title").innerHTML = movie.title;
        document.getElementById("movie").innerHTML = htmlMovie;
    } else {
        alert("У нас проблемы, попробуйте зайти через пару минут!!!")
    }
}

GetMovie();