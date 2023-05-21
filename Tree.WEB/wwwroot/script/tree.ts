const btn = document.getElementById('genres-loader-btn');
const container = document.getElementById('genres-container');

btn.addEventListener('click', async () => {
    const result = await (await fetch('Tree/GenresList')).json();
    container.innerText = JSON.stringify(result);
})