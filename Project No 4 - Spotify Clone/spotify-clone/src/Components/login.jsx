import React from 'react';
import styled from 'styled-components';

export default function Login() {

  const handleClick = () => {
    const clientId = "e83063437b414b4aa6344280415a0912"; // Get it from https://developer.spotify.com/ 
    const redirectUrl = "http://localhost:3000/"; 
    const apiUrl = "https://accounts.spotify.com/authorize";
    const scope = [ // Added all the required scopes from https://developer.spotify.com/documentation/web-api/concepts/scopes
      "user-read-email",
      "user-read-private",
      "user-modify-playback-state",
      "user-read-playback-state",
      "user-read-currently-playing",
      "user-read-recently-played",
      "user-read-playback-position",
      "user-top-read",
      "playlist-read-private",
    ];
    // Dynamically create the URL using above veriables
    window.location.href = `${apiUrl}?client_id=${clientId}&redirect_uri=${redirectUrl}&scope=${scope.join(
      " "
    )}&response_type=token&show_daialog=true`;
  };

  return (
    <Container>
      <img src="https://storage.googleapis.com/pr-newsroom-wp/1/2018/11/Spotify_Logo_CMYK_Black.png" alt="Spotify Logo" />
      <button onClick={handleClick}>Connect Spotify</button>
    </Container>
  );
};

// Style Container and its child elements
const Container = styled.div`
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: 5rem;
  height: 100vh;
  width: 100vw;
  background-color: #1db954;
  img {
    height: 20vh;
  }
  button {
    padding: 1rem 5rem;
    border-radius: 5rem;
    border: none;
    background-color: #000;
    color: #49d585;
    font-size: 1.4rem;
    cursor: pointer;
  }
`;