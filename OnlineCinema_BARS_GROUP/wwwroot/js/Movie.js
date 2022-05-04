async function GetMovie() {
    const response = await fetch("/api/Home/" + event.target.id, {
        method: "GET",
        headers: { "Accept": "application/json" }
    });
    if (response.ok === true) {
        const movie = await response.json();
        console.log(movie)
    }
}
