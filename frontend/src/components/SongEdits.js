export default function SongEdits(song){
    return `

    

    <section class="update-song">
    <h3><b>Edit Song</b></h3><br>
    <h4>${song.title}</h4><br>
    <label >Title</label><br>
    <input class="update-song__songTitle add-album-style" type="text" value="${song.title}"><br><br>

    <label >Duration</label><br>
    <input class="update-song__songDuration add-album-style" type="text" value="${song.duration}"><br><br>

    <label >Link</label><br>
    <input class="update-song__songLink add-album-style" type="text" value="${song.link}"><br><br>

    <label >Album Id</label><br>
    <input class="update-song__songAlbumId add-album-style" type="text" type="hidden"  value="${song.album.id}"><br><br>

  
    <input class="update-song__songId add-album-style" type= type="hidden" value="${song.id}"><br><br>
    <button class="update-song__submit add-album-style">Update a Song</button>
    </section>

`;
}