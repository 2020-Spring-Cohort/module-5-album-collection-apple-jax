export default function AlbumEdits(album){
    return `

    <section class="content__album">
        <h4>${album.title}</h4>
    </section>

    <section class="update-album">
    <input class="update-album__title" type="text" value="${album.title}">
    <input class="update-album__recordlabel" type="text" value="${album.recordLabel}">
    <input class="update-album__image" type="text" value="${album.image}">
    <input class="update-album__id" type="hidden" value="${album.id}">
    <input class="artist__id" type="hidden" value="${album.artist.id}">
    <button class="update-album__submit">Save Changes</button>
    </section>

`;
}