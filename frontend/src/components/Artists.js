export default function Artists(artists){
    return `
    <h2><p><b>Artists</b></p></h2><ul>
    ${artists.map(artist => {
        return `
        <li>
             <h3><p>${artist.name} </p></h3>
             <img src="./img/${artist.image}" class="album__img">
             <h3><p>Age : ${artist.age} </p></h3>
             <h3><p>Home Town : ${artist.homeTown} </p></h3>
             <h3><p>Record Label : ${artist.recordLabel} </p></h3>
             <button class="edit-artist__submit">Edit</button>
             <button class="delete-artist__submit">Delete</button>
             <input class="artist__id" type="hidden" value="${artist.id}">
             </li>
        `
    }).join("")}
    </ul>

    <section class="add-artist">
        <input class="add-artist__artistName" type="text" placeholder="Add an Artist">
        <input class="add-artist__artistImage" type="text" readonly placeholder="artist1.jpg">
        <input class="add-artist__artistAge" type="text" placeholder="Add Artist Age">
        <input class="add-artist__artisthomeTown" type="text" placeholder="Add Home Town">
        <input class="add-artist__artistrecordLabel" type="text" placeholder="Add Record Label">
        <button class="add-artist__submit">Add an Artist</button>
    </section>
    `;

}