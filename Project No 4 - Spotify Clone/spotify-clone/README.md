# SoundCore Music App (Spotify API)

The SoundCore music player is a fully functional web application that serves as a music player, allowing users to choose from various playlists and songs.

## Preview - 01 

![preview_1](https://github.com/TechPodx/Style-Repo/blob/fcbab6d1c0baeaa086c496845bd7f272f3380ce1/Images/Music_player_preview_1.png)


## Preview - 02

![preview_2](https://github.com/TechPodx/Style-Repo/blob/4daaeb14c1c9cf9fbcc7b67ba76ca634a00f7e27/Gif/Preview.gif)

## Languages

**React**

## Other Resources

**Spotify API**

## How to operate

1. Clone the repository
2. Copy and paste a unique Client Id into the Client_id variable in "login.jsx"
3. Add your Redirect URL to "redirect_url" in "login.jsx"
4. Copy a Playlist Id from your playlist and paste it into "selectedPlaylistId" in "Reducer.js"
5. Install all the necessary dependencies (run npm install or yarn)
6. Run the application (execute npm start or yarn start)

## Limitations

- The application is limited in functionality compared to Spotify's complete set of features; it currently allows users to select playlists and play songs from them.
- To access the full range of Spotify functionalities, a premium account is required.
- Users with free accounts may encounter 403 or 429 errors, preventing them from playing songs.