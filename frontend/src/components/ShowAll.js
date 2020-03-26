export default function ShowAll(albums){
    return `
    <h2><p><b>Albums</b></p></h2>
    ${albums.map(album => {
        
        return `
        
             <h3><p>Title : ${album.title}</p></h3>
             <h3><p>Name : ${album.artist.name}</p></h3>
             <h3><p>Record Label : ${album.recordLabel}</p></h3>
             <img src="./img/${album.image}" class="album__img">
             <h3><p>Home Town : ${album.artist.homeTown} </p></h3>
             <h3><p>Age : ${album.artist.age} </p></h3>
             <h3><p>City : ${album.artist.homeTown}</p></h3>
       
        `
      
    }).join("")}
    `;
}



