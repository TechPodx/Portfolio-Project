import React from "react";
import styled from "styled-components";
import SoundCoreLogo from '../Resources/SoundCore.png';

export default function Login() {
  const handleClick = async () => {
    const client_id = "e83063437b414b4aa6344280415a0912";
    const redirect_url = "http://localhost:3000/";
    const api_url = "https://accounts.spotify.com/authorize";
    const scope = [
      "user-read-private",
      "user-read-email",
      "user-modify-playback-state",
      "user-read-playback-state",
      "user-read-currently-playing",
      "user-read-recently-played",
      "user-top-read",
    ];
    window.location.href = `${api_url}?client_id=${client_id}&redirect_uri=${redirect_url}&scope=${scope.join(
      " "
    )}&response_type=token&show_dialog=true`;
  };
  return (
    <Container>
      <img
        src={SoundCoreLogo}
        alt="SoundCore Logo"
      />
      <button onClick={handleClick}>Connect SoundCore</button>
    </Container>
  );
}

const Container = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  height: 100vh;
  width: 100vw;
  background-color: #52D3D8;
  gap: 5rem;
  img {
    height: 35vh;
    border-radius: 3rem;
  }
  button {
    padding: 1rem 5rem;
    border-radius: 5rem;
    background-color: black;
    color: #3887BE;
    border: none;
    font-size: 1.4rem;
    cursor: pointer;
    transition: 0.3s;
    &:hover {
      color: #e7235a;
      border: 1px solid #e7235a;
    }
  }
`;
