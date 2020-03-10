## Album Collection

Our super hip ironic friend needs an easy way to curate soundscapes for the Italian scooter/coffee hybrid co-op startup at which they volunteer (they also fix old polaroid cameras).

They have tasked us with creating an application that can easily keep track of their _EXTENSIVE_ record collection and access music by artists, albums, or individual tracks.

The best way to approach this is with a Single Page Application (SPA). So we are going to need two independent pieces that will interact with each other.

## Back-end/API

We are going to need to create an API using ASP.Net Entity Framework that will handle our DB and interactions with it.

#### API Interactions:

- All `CRUD` operations for `artist`s
- All `CRUD` operations for `album`s
- All `CRUD` operations for `song`s
- An endpoint to view all `artist`s
- An endpoint to view all `album`s
- An endpoint to view all `song`s

#### Relationships

Our user should be able to:

- access `song`s from the `album` the song is on.
- access `album`s from the `artist` that made them

#### User Input

Each entity should have fields the user can interact with:

- Should have ratings (rating system can be your own design)
- Should have comments with a way to add them
- Should have tags

## Front-end

Our front-end should be an SPA that uses JS to build out components that our users can interact with. Use modular JS along with Webpack to create reusable components.

#### User Interaction

Our users should be able to add new instances of all entities as well as comments, tags, and ratings

#### Entities

### `artist`

- name
- image
- albums
- any other pertinent info. which could include:
  - age
  - record label
  - hometown

### `album`

- title
- image
- songs
- record label

### `song`

- title
- link (optional)
- duration
