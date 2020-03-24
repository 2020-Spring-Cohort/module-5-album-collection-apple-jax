export default function AlbumEdit(album){
    return `
    <section class="content__album">
        <h4>${album.title}</h4>
    </section>
    
    <ul class="update-album">
    <li>
    <h3><p>Title : ${album.title}</p></h3>
    <h3><p>Record Label : ${album.recordLabel}</p></h3>
    <img src="./img/${album.image}" class="album__img">

    <button class="Update-album__submit">Update</button>
    <input class="album__id" type="hidden" value="${album.id}">
    <input class="artist__id" type="hidden" value="${album.artist.id}">
    <br><br>
</li>
    </ul>
`;
}