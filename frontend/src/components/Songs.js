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
            <input class="add-song__songTitle" type="text" placeholder="Add a song">
             <button class="add-song__submit">Add a song</button>
     </section>
    `;
}
