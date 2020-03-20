export default function Songs(songs){
    return `
    <h2><p><b>Songs</b></p></h2>
    ${songs.map(song => {
        return `
        
             <h3><a href= ${song.link} title="${song.title} Link" target="_blank">${song.title}</a>- ${song.duration} mins</h3>
             <br><br>
      
        `
    }).join("")}
    
    <section class="add-song">
        <input class="add-song__songTitle" type="text" placeholder="Add a Song">
        <input class="add-song__songDuration" type="text" placeholder="Add Duration">
        <input class="add-song__songLink" type="text" placeholder="Add a Link">
        <input class="add-song__songAlbumId" type="text" placeholder="Add a AlbumId">
        <button class="add-song__submit">Add a Song</button>
    </section>
    `;
    
}
