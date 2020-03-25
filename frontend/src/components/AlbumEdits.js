export default function AlbumEdits(album){
    return `
    
    <section class="update-album">
    <h3><b>Edit Album</b></h3><br>
        <h4>${album.title}</h4><br>
    <label >Title</label><br>
    <input class="update-album__title add-album-style" type="text" value="${album.title}"><br><br>

    <label >Record Label</label><br>
    <input class="update-album__recordlabel add-album-style" type="text" value="${album.recordLabel}"><br><br>

    <label >Image</label><br>
    <input class="update-album__image add-album-style" type="text" value="${album.image}"><br><br>

    
    <input class="update-album__id add-album-style" type="hidden" value="${album.id}">
    <input class="artist__id add-album-style" type="hidden" value="${album.artist.id}">
    <button class="update-album__submit add-album-style">Save Changes</button>
    </section>

`;
}