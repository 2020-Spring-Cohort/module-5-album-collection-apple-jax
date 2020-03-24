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

    app.addEventListener("click", function(){
        if(event.target.classList.contains('add-artist__submit')){
            const artistName = event.target.parentElement.querySelector('.add-artist__artistName').value;
            const artistAge = event.target.parentElement.querySelector('.add-artist__artistAge').value;
            const artistRecordLabel = event.target.parentElement.querySelector('.add-artist__artistrecordLabel').value;
            const artistHomeTown = event.target.parentElement.querySelector('.add-artist__artisthomeTown').value;
            
            
            console.log(artistName, artistAge, artistRecordLabel, artistHomeTown);

            var requestBody = {
                Name: artistName,
                Age: artistAge,
                Image: "artist1.jpg",
                RecordLabel: artistRecordLabel,
                HomeTown: artistHomeTown
            }

            apiActions.postRequest(
                "https://localhost:44313/api/artists",
                requestBody,
                artists => {
                    console.log("Artists pulled from backend");
                    console.log(artists);
                    app.innerHTML = Artists(artists);
                }
            )
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains('delete-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.artist__id').value;
            console.log(artistId);

            apiActions.deleteRequest(
                `https://localhost:44313/api/artists/${artistId}`,
                artists => {
                    app.innerHTML = Artists(artists);
                }
            )
        }
    })
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
    
        app.addEventListener("click", function(){
            if(event.target.classList.contains('add-song__submit')){
                const songTitle = event.target.parentElement.querySelector('.add-song__songTitle').value;
                const songDuration = event.target.parentElement.querySelector('.add-song__songDuration').value;
                const songLink = event.target.parentElement.querySelector('.add-song__songLink').value;
                const songAlbumId = event.target.parentElement.querySelector('.add-song__songAlbumId').value;
    
    
                console.log(songTitle, songDuration, songLink);
    
                var requestBody = {
                    Title: songTitle,
                    Duration: songDuration,
                    Link: songLink,
                    AlbumId: songAlbumId
                }
    
                apiActions.postRequest(
                    "https://localhost:44313/api/songs",
                    requestBody,
                    songs => {
                        console.log("Songs pulled from backend");
                        console.log(songs);
                        app.innerHTML = Songs(songs);
                    }
                )
            }
        })
    
        app.addEventListener("click", function(){
            if(event.target.classList.contains('delete-song__submit')){
                const songId = event.target.parentElement.querySelector('.song__id').value;
                console.log(songId);
    
                apiActions.deleteRequest(
                    `https://localhost:44313/api/songs/${songId}`,
                    songs => {
                        app.innerHTML = Songs(songs);
                    }
                )
            }
        })
    }






    app.addEventListener("click", function(){
        if(event.target.classList.contains('delete-song__submit')){
            const songId = event.target.parentElement.querySelector('.song__id').value;
            console.log(songId);

            apiActions.deleteRequest(
                `https://localhost:44313/api/songs/${songId}`,
                songs => {
                    app.innerHTML = Songs(songs);
                }
            )
        }
    })
  //  

    
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

    app.addEventListener("click", function(){
        if(event.target.classList.contains('add-album__submit')){
            const albumTitle = event.target.parentElement.querySelector('.add-album__albumTitle').value;
            const albumRecordLabel = event.target.parentElement.querySelector('.add-album__recordLabel').value;
            const albumComment = event.target.parentElement.querySelector('.add-album__comments').value;
            const albumRating = event.target.parentElement.querySelector('.add-album__rating').value;
            const albumArtistId = event.target.parentElement.querySelector('.add-album__albumArtistId').value;
          

            console.log(albumTitle, albumRecordLabel, albumComment, albumRating, albumArtistId);

            var requestBody = {
                Title: albumTitle,
                Image: "album1.jpg",
                RecordLabel: albumRecordLabel,
                Comments: albumComment,
                Rating: albumRating,
                ArtistId: albumArtistId
            }

            apiActions.postRequest(
                "https://localhost:44313/api/albums",
                requestBody,
                albums => {
                    console.log("Albums pulled from backend");
                    console.log(albums);
                    app.innerHTML = Albums(albums);
                }
            )
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains('delete-album__submit')){
            const albumId = event.target.parentElement.querySelector('.album__id').value;
            console.log(albumId);

            apiActions.deleteRequest(
                `https://localhost:44313/api/albums/${albumId}`,
                albums => {
                    app.innerHTML = Albums(albums);
                }
            )
        }
    })
}



