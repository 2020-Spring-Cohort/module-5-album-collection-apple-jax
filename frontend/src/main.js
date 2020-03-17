// List of imports
import Header from './components/Header';
import Footer from './components/Footer';
import Home from './components/Home';
import Artists from './components/Artists';
import apiActions from './api/apiActions';

export default pageBuild;

function pageBuild(){
    header();
    footer();
    navHome();
    navArtists();
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
    const artistsButton = document.querySelector(".nav__artists");
    const app = document.querySelector('#app');

    artistsButton.addEventListener("click", function() {
        apiActions.getRequest("https://localhost:44313/api/artists",
            artists => {
                console.log(artists);
                app.innerHTML = Artists(artists);
            }
        )
      });

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
}