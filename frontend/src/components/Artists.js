export default function Artists(artists){
    return `
   
    ${artists.map(artist => {
        return `
        
             <h3><p > Artist Id : ${artist.id} </p></h3>
             <h3><p > Artist Name : ${artist.name} </p></h3>
             <h3><p > Artist Age : ${artist.age} </p></h3>
             <h3><p > Artist Home Town : ${artist.homeTown} </p></h3>
       
        `
    }).join("")}
    

    // <section class="add-artist">
    //         <input class="add-artist__artistName" type="text" placeholder="Add an Artist">
    //         <button class="add-artist__submit">Add an Artist</button>
    //     </section>
    `;
}
