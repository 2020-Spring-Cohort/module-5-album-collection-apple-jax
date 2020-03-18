// List of imports
import Header from './components/Header';
import Footer from './components/Footer';
import Home from './components/Home';
import Artists from './components/Artists';
import Songs from './components/Songs';
import Albums from './components/Albums';
import apiActions from './api/apiActions';

export default pageBuild;

function pageBuild(){
    header();
    footer();
    navHome();
    navArtists();
    navSongs();
    navAlbums();
}

function header() {
    const header = document.querySelector('#header');
    header.innerHTML = Header();
}

function footer(){
    const footer = document.querySelector('#footer');
    footer.innerHTML = Footer();
}

function navHome(){
    const homeButton = document.querySelector('.nav__home');
    homeButton.addEventListener("click", function() {
        document.querySelector("#app").innerHTML = Home();
    });
}

function navArtists(){
    const artistsButton = document.querySelector('.nav__artists');
    const app = document.querySelector('#app');
    
    artistsButton.addEventListener("click", function() {
        apiActions.getRequest('https://localhost:44313/api/artists',
            artists => {
                console.log(artists);
                app.innerHTML = Artists(artists);
        }
        )
    });
}

function navSongs(){
    const songsButton = document.querySelector('.nav__songs');
    const app = document.querySelector('#app');
    
    songsButton.addEventListener("click", function() {
        apiActions.getRequest('https://localhost:44313/api/songs',
            songs => {
                console.log(songs);
                app.innerHTML = Songs(songs);
        }
        )
    });
}

function navAlbums(){
    const albumsButton = document.querySelector('.nav__albums');
    const app = document.querySelector('#app');
    
    albumsButton.addEventListener("click", function() {
        apiActions.getRequest('https://localhost:44313/api/albums',
            albums => {
                console.log(albums);
                app.innerHTML = Albums(albums);
        }
        )
    });
}


// function navArtists(){
//     const todosButton = document.querySelector(".nav__artists");
//     artistsButton.addEventListener("click", function() {
//         apiActions.getRequest("https://localhost:44313/api/artists",
//             artists => {
//                 console.log(artists);
//                 document.querySelector('#app').innerHTML = Artists(artists);
//             }
//         )
       
//       });
// }
//   app.addEventListener("click", function(){
    //     if(event.target.classList.contains('add-artist__submit')){
    //         const artist = event.target.parentElement.querySelector('.add-artist__artistName').value;
    //         console.log(artist);

    //         apiActions.postRequest(
    //             "https://localhost:44393/api/artists",
    //             artist,
    //             newArtist => {
    //                 console.log("Artists returned from back end");
    //                 console.log(newArtist);
    //             }
    //         )
    //     }
    // })
