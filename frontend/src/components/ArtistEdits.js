export default function ArtistEdits(artist){
    return `

    

    <section class="update-artist">
    <h3><b>Edit Artist</b></h3><br>
    <h4>${artist.name}</h4><br>
    <label >Name</label><br>
    <input class="update-artist__name add-album-style" type="text" value="${artist.name}"><br><br>

    <label >Image</label><br>
    <input class="update-artist__image add-album-style" type="text" value="${artist.image}"><br><br>

    <label >Age</label><br>
    <input class="update-artist__age add-album-style" type="text" value="${artist.age}"><br><br>

    <label >Home Town</label><br>
    <input class="update-artist__hometown add-album-style" type="text" value="${artist.homeTown}"><br><br>

    <label >Record Label</label><br>
    <input class="update-artist__recordlabel add-album-style" type="text" value="${artist.recordLabel}"><br><br>
    <input class="update-artist__Id add-album-style" type="hidden" value="${artist.id}"><br><br>
    <button class="update-artist__submit add-album-style">Update a Artist</button>
    </section>

`;
}