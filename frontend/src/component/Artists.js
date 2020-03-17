export default function Artists(artists){
    return `
    <ul>
    ${artists.map(artist => {
        return `
        <li>
            <h3>${artist}</h3>
        </li> 
        `
    }).join("")}
    </ul>

    <section class="add-artist">
            <input class="add-artist__artistName" type="text" placeholder="Add an Artist">
            <button class="add-artist__submit">Add an Artist</button>
        </section>
    `;
}