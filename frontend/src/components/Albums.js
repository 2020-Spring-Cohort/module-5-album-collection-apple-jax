export default function Albums(albums){
    return `
    <h2><p><b>Albums</b></p></h2>
    ${albums.map(album => {
        return `
        
             <h3><p>Title : ${album.title}</p></h3>
             <h3><p>Record Label : ${album.recordLabel}</p></h3>
             <img src=${album.image}></a>
       
        `
    }).join("")}
    

    <section class="add-album">
        <input class="add-album__albumTitle" type="text" placeholder="Add an album">
        <button class="add-album__submit">Add an album</button>
    </section>
    `;
}