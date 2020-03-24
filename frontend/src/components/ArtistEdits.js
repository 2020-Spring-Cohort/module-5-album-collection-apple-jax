export default function ArtistEdits(artist){
    return `

    <section class="content__album">
        <h4>${artist.name}</h4>
    </section>

    <section class="update-artist">
    <input class="update-artist__name" type="text" value="${artist.name}">
    <input class="update-artist__image" type="text" value="${artist.image}">
    <input class="update-artist__age" type="text" value="${artist.age}">
    <input class="update-artist__hometown" type="text" value="${artist.homeTown}">
    <input class="update-artist__recordlabel" type="text" value="${artist.recordLabel}">
    <input class="update-artist__Id" type="text" type="hidden"  value="${artist.id}">
    <button class="update-artist__submit">Update a Artist</button>
    </section>

`;
}