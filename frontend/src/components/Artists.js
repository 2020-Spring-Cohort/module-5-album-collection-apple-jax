export default function Artists(artists){
    return `
    <h2><p><b>Artists</b></p></h2>
    ${artists.map(artist => {
        return `
        <table class="japple3"> <tr> 
             <td> <img src="./img/${artist.image}" class="album__img"></td> 
             <td><h3><p>${artist.name} </p></h3></td>            
             <td> <h3><p>Age : ${artist.age} </p></h3></td>
             <td><h3><p>Home Town : ${artist.homeTown} </p></h3></td>
             <td><h3><p>Record Label : ${artist.recordLabel} </p></h3></td></tr></table>
             <button class="edit-artist__submit btn-full">Edit</button>
             <button class="delete-artist__submit btn-full">Delete</button>
             <input class="artist__id" type="hidden" value="${artist.id}">
             </li>
        `
    }).join("")}
    

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