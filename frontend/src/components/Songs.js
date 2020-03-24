export default function Songs(songs){
    return `
    <h2><p><b>Songs</b></p></h2><ul>
    ${songs.map(song => {
        return `
        <li>
            <h3><a href= ${song.link} title="${song.title} Link" target="_blank">${song.title}</a>- ${song.duration} mins</h3>
            <button class="edit-song__submit">Edit</button>
            <button class="delete-song__submit">Delete</button>
            <input class="song__id" type="hidden" value="${song.id}">
                    <br><br>
    </li>
        `
        
    }).join("")}
    </ul>
    <section class="add-song">
        <input class="add-song__songTitle" type="text" placeholder="Add a Song">
        <input class="add-song__songDuration" type="text" placeholder="Add Duration">
        <input class="add-song__songLink" type="text" placeholder="Add a Link">
        <input class="add-song__songAlbumId" type="text" placeholder="Add an Album Id">
        <button class="add-song__submit">Add a Song</button>
    </section>
    `;
    
}
