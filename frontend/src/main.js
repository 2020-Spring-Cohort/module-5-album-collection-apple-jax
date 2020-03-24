// List of imports
import Header from './components/Header';
import Footer from './components/Footer';
import Home from './components/Home';
import Artists from './components/Artists';
import Songs from './components/Songs';
import Albums from './components/Albums';
import AlbumEdits from './components/AlbumEdits';
import SongEdits from './components/SongEdits';
import ArtistEdits from './components/ArtistEdits';
import apiActions from './api/apiActions';

export default pageBuild;

function pageBuild(){
    header();
    footer();
    navHome();
    navArtists();
    navSongs();
    navAlbums();
    AlbumEdits();
    SongEdits();
    ArtistEdits();
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

        // When the user clicks the edit button, we will call the get fetch request
    // to get the entire Todo object
    // and then display the Todo object in the TodoEdit form
    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.artist__id').value;
            console.log(artistId);

            apiActions.getRequest(
                `https://localhost:44313/api/artists/${artistId}`,
                ArtistEdit => {
                    console.log(ArtistEdit);
                    app.innerHTML = ArtistEdits(ArtistEdit);
                  }
            )

        }
    })


    app.addEventListener("click", function(){
        if(event.target.classList.contains('update-artist__submit')){
            const artistId = event.target.parentElement.querySelector('.update-artist__Id').value;
            const artistName = event.target.parentElement.querySelector('.update-artist__name').value;
            const artistImage = event.target.parentElement.querySelector('.update-artist__image').value;
            const artistAge = event.target.parentElement.querySelector('.update-artist__age').value;
            const artistHomeTown = event.target.parentElement.querySelector('.update-artist__hometown').value;
            const artistRecordLabel = event.target.parentElement.querySelector('.update-artist__recordlabel').value;
            
            
            const artistData = {
                Id: artistId,
                Name: artistName,
                Image: artistImage,
                Age: artistAge,
                HomeTown: artistHomeTown,
                RecordLabel: artistRecordLabel
              };

            console.log(artistData);

            apiActions.putRequest(
                `https://localhost:44313/api/artists/${artistId}`,
                artistData,
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

      // When the user clicks the edit button, we will call the get fetch request
    // to get the entire Todo object
    // and then display the Todo object in the TodoEdit form
    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-song__submit')){
            const songId = event.target.parentElement.querySelector('.song__id').value;
            console.log(songId);

            apiActions.getRequest(
                `https://localhost:44313/api/songs/${songId}`,
                SongEdit => {
                    console.log(SongEdit);
                    app.innerHTML = SongEdits(SongEdit);
                  }
            )

        }
    })

      
    // When the user clicks the Save Changes button on the TodoEdit form
    // we will capture the data from the TodoEdit form
    // and call the put fetch request
    // and then redisplay the Todos component with the updated list of todos
    
    app.addEventListener("click", function(){
        if(event.target.classList.contains('update-song__submit')){
            const songId = event.target.parentElement.querySelector('.update-song__songId').value;
            const albumId = event.target.parentElement.querySelector('.update-song__songAlbumId').value;
            const songTitle = event.target.parentElement.querySelector('.update-song__songTitle').value;
            const songDuration = event.target.parentElement.querySelector('.update-song__songDuration').value;
            const songLink = event.target.parentElement.querySelector('.update-song__songLink').value;
           
            const songData = {
                Id: songId,
                AlbumId: albumId,
                Title: songTitle,
                Duration: songDuration,
                Link: songLink
              };

            console.log(songData);

            apiActions.putRequest(
                `https://localhost:44313/api/songs/${songId}`,
                songData,
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

      // When the user clicks the edit button, we will call the get fetch request
    // to get the entire Todo object
    // and then display the Todo object in the TodoEdit form
    app.addEventListener("click", function(){
        if(event.target.classList.contains('edit-album__submit')){
            const albumEId = event.target.parentElement.querySelector('.album__id').value;
            console.log(albumEId);

            apiActions.getRequest(
                `https://localhost:44313/api/albums/${albumEId}`,
                AlbumEdit => {
                    console.log(AlbumEdit);
                    app.innerHTML = AlbumEdits(AlbumEdit);
                  }
            )

        }
    })

    
    // When the user clicks the Save Changes button on the TodoEdit form
    // we will capture the data from the TodoEdit form
    // and call the put fetch request
    // and then redisplay the Todos component with the updated list of todos
    
    app.addEventListener("click", function(){
        if(event.target.classList.contains('update-album__submit')){
            const albumId = event.target.parentElement.querySelector('.update-album__id').value;
            const artistId = event.target.parentElement.querySelector('.artist__id').value;
            const albumTitle = event.target.parentElement.querySelector('.update-album__title').value;
            const albumRecordLabel = event.target.parentElement.querySelector('.update-album__recordlabel').value;
            const albumImage = event.target.parentElement.querySelector('.update-album__image').value;
            
            const albumData = {
                Id: albumId,
                Title: albumTitle,
                RecordLabel: albumRecordLabel,
                Image: albumImage,
                ArtistId: artistId
              };

            console.log(albumData);

            apiActions.putRequest(
                `https://localhost:44313/api/albums/${albumId}`,
                albumData,
                albums => {
                    app.innerHTML = Albums(albums);
                }
            )
        }
    })
}



