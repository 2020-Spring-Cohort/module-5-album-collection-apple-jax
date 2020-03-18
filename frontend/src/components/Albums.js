export default function Albums(albums){
    return `
    
    ${albums.map(album => {
        return `
        
             <h3><p > Album Id : ${album.id} </p></h3>
             <h3><p > Album Title : ${album.title} </p></h3>
             <h3><p > Album Image : ${album.image} </p></h3>
             <h3><p > Album Record Label : ${album.recordLabel} </p></h3>
       
        `
    }).join("")}
    

    // <section class="add-album">
    //         <input class="add-album__albumTitle" type="text" placeholder="Add an album">
    //         <button class="add-album__submit">Add an album</button>
    //     </section>
    `;
}