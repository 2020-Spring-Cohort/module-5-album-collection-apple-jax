export default function Albums(albums){
    return `

    <h2><p><b>Albums</b></p></h2>
    ${albums.map(album => {
        return `
        <table class="japple3"> <tr>  
         <td>  <img src="./img/${album.image}" class="album__img"><td>
           <td> <h3><p>Title : ${album.title}</p></h3><td>
           <td> <h3><p>Record Label : ${album.recordLabel}</p></h3></td></tr></table>
           <div style="text-align:right;">
           <button class="edit-album__submit">Edit</button>
           <button class="delete-album__submit">Delete</button></div>
           <input class="album__id" type="hidden" value="${album.id}">
            <br><br>
       
        `
    }).join("")}
    

    <section class="add-album  class="japple3"">
        <input class="add-album__albumTitle" type="text" placeholder="Add an album">
        <input class="add-album__image" type="text" readonly placeholder="album1.jpg">
        <input class="add-album__recordLabel" type="text" placeholder="Add a Record Label">
        <input class="add-album__comments" type="text" placeholder="Add a Comment">
        <input class="add-album__rating" type="text" placeholder="Add a Rating">
        <input class="add-album__albumArtistId" type="text" placeholder="Add an Artist Id">
        <button class="add-album__submit">Add an album</button>
    </section>
    `;
}

