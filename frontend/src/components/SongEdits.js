export default function SongEdits(song){
    return `

    <section class="content__album">
        <h4>${song.title}</h4>
    </section>

    <section class="update-song">
    <input class="update-song__songTitle" type="text" value="${song.title}">
    <input class="update-song__songDuration" type="text" value="${song.duration}">
    <input class="update-song__songLink" type="text" value="${song.link}">
    <input class="update-song__songAlbumId" type="text" type="hidden"  value="${song.album.id}">
    <input class="update-song__songId" type="text" type="hidden"  value="${song.id}">
    <button class="update-song__submit">Update a Song</button>
    </section>

`;
}