export default function Songs(songs){
    return `
    <h2><p><b>Songs</b></p></h2>
    ${songs.map(song => {
        return `
        
             <h3><p>Title : ${song.title} </p></h3>
             <h3><p>Duration : ${song.duration} </p></h3>
             <h3><p> ${song.title} Link : <a href="https://www.youtube.com/watch?v=InPfnkn5Fqk&list=RDInPfnkn5Fqk&start_radio=1" target="_blank"> ${song.link}</a> </p></h3>
             
      
        `
    }).join("")}
    
     <section class="add-song">
            <input class="add-song__songTitle" type="text" placeholder="Add a song">
             <button class="add-song__submit">Add a song</button>
     </section>
    `;
}
