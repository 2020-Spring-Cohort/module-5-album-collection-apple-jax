export default function Albums(albums){
    return `

    <h2><p><b>Albums</b></p></h2>
    ${albums.map(album => {
        return `
        <table class="japple3"> <tr>  
           <td><img src="./img/${album.image}" class="album__img"><td>
           <td><h3><p>Title : ${album.title}</p></h3><td>
           <td><h3><p>Record Label : ${album.recordLabel}</p></h3></td></tr></table>
           <button class="edit-album__submit btn-full"> Edit</button>
           <button class="delete-album__submit btn-full"> Delete</button>
           <input class="album__id" type="hidden" value="${album.id}">
            <br><br>
       
        `
    }).join("")}
    
    <div style="text-align:center;">
    <section class="add-album">    
        <input class="add-album__albumTitle add-album-style" type="text" placeholder="Add an album">
        <input class="add-album__image add-album-style" type="text" readonly placeholder="album1.jpg">
        <input class="add-album__recordLabel add-album-style" type="text" placeholder="Add a Record Label">
        <input class="add-album__comments add-album-style" type="text" placeholder="Add a Comment">
        <input class="add-album__rating add-album-style" type="text" placeholder="Add a Rating">
        <input class="add-album__albumArtistId add-album-style" type="text" placeholder="Add an Artist Id">
        <button class="add-album__submit add-album-style">Add an album</button>       
    </section>
    </div>
    
    `;
}

