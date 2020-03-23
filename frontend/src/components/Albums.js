export default function Albums(albums){
    return `
    <h2><p><b>Albums</b></p></h2><ul>
    ${albums.map(album => {
        return `
        <li>
             <h3><p>Title : ${album.title}</p></h3>
             <h3><p>Record Label : ${album.recordLabel}</p></h3>
             <img src="./img/${album.image}" class="album__img">

             <button class="delete-album__submit">Delete</button>
             <input class="album__id" type="hidden" value="${album.id}">
                     <br><br>
       </li>
        `
    }).join("")}
    </ul>

    <section class="add-album">
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