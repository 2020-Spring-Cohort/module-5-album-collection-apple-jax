export default function Artists(artists){
    return `
    <h2><p><b> Artists</b></p></h2>
    ${artists.map(artist => {
        return `
        
             <h3><p>Name : ${artist.name} </p></h3>
             <h3><p>Image : ${artist.image} </p></h3>
             <img src="../../docs/img/buttons_imgtest.jpg>${artist.image} </a>
             <h3><p>Age : ${artist.age} </p></h3>
             <h3><p>Home Town : ${artist.homeTown} </p></h3>
             <h3><p>Record Label : ${artist.recordLabel} </p></h3>
       
        `
    }).join("")}
    

    <section class="add-artist">
    <input class="add-artist__artistName" type="text" placeholder="Add an Artist">
    <button class="add-artist__submit">Add an Artist</button>
    </section>
    `;
}
