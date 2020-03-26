export default function Songs(songs){
    return `
    <h2><p><b>Songs</b></p></h2>
    ${songs.map(song => {
        return `
        <table class="japple3"> <tr> 
           <td> <h3><a href= ${song.link} title="${song.title} Link" target="_blank">${song.title}</a>- ${song.duration} mins</h3></td></tr></table>
            <button class="edit-song__submit btn-full">Edit</button>
            <button class="delete-song__submit btn-full">Delete</button>
            <input class="song__id" type="hidden" value="${song.id}">
                    <br><br>
   
        `
        
    }).join("")}
    
    <div style="text-align:center;">
    <section class="add-song">
        <input class="add-song__songTitle add-album-style" type="text" placeholder="Add a Song">
        <input class="add-song__songDuration add-album-style" type="text" placeholder="Add Duration">
        <input class="add-song__songLink add-album-style" type="text add-album-style" placeholder="Add a Link">
        <input class="add-song__songAlbumId add-album-style" type="text" placeholder="Add an Album Id">
        <button class="add-song__submit add-album-style">Add a Song</button>
    </section>
    `;
    
}
