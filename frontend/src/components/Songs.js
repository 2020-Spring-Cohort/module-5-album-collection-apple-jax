export default function Songs(songs){
    return `
    
    ${songs.map(song => {
        return `
        
            //  <h3><p > Song Id : ${song.id} </p></h3>
             <h3><p > Song Title : ${song.title} </p></h3>
             <h3><p > Song Duration : ${song.duration} </p></h3>
             <h3><p > Song Link : ${song.link} </p></h3>
       
        `
    }).join("")}
    

    // <section class="add-song">
    //         <input class="add-song__songTitle" type="text" placeholder="Add a song">
    //         <button class="add-song__submit">Add a song</button>
    //     </section>
    `;
}
