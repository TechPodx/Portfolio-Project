import React, {useEffect, useRef, useState} from 'react';
import styled from 'styled-components';
import Sidebar from './Sidebar';
import Navbar from './Navbar';
import Footer from './Footer';
import Body from './Body';
import { useStateProvider } from '../Utilities/StateProvider';
import axios from 'axios';
import { reducerCases } from '../Utilities/Constants';

export default function Spotify() {
  const [{ token }, dispatch] = useStateProvider();
  const bodyRef = useRef();
  const [navBackground, setNavBackground] = useState(false);
  const [headerBackground, setHeaderBackground] = useState(false);
  const bodyScrolled = () => {
    bodyRef.current.scrollTop >= 30
      ? setNavBackground(true)
      : setNavBackground(false);
    bodyRef.current.scrollTop >= 268
      ? setHeaderBackground(true)
      : setHeaderBackground(false);
  };
  useEffect(() => {
    // Getting API
    const getUserInfo = async() => {
      const {data} = await axios.get(
        "https://api.spotify.com/v1/me",
        {
          headers: {
            Authorization: "Bearer " + token,
            "Content-Type": "application/json",
          }
        },
      );
      // Getting user info
      const userInfo = {
        userId: data.id,
        userName: data.display_name,
      }
      // Dispatching above userInfo
      dispatch({type: reducerCases.SET_USER, userInfo});
    };
    getUserInfo();
  }, [dispatch, token]);

  return (
    <Container>
      <div className='spotify_body'>
        <Sidebar />
        <div className="body" ref={bodyRef} onScroll={bodyScrolled}>
          <Navbar navBackground={navBackground} />
          <div className="body_contents">
            <Body headerBackground={headerBackground} />
          </div>
        </div>
      </div>
      <div className="spotify_footer">
        <Footer />
      </div>
    </Container>
  );
};

const Container = styled.div`
  background-color: #aaa;
  max-height: 100vh;
  max-width: 100vw;
  overflow: hidden;
  display: grid;
  grid-template-rows: 85vh 15vh;
  .spotify_body {
    display: grid;
    grid-template-columns: 15vw 85vw;
    height: 100%;
    width: 100%;
    background: linear-gradient(transparent, rgba(0, 0, 0, 1));
    background-color: rgb(32, 87, 100);
    .body {
      height: 100%;
      width: 100%;
      overflow: auto;
    }
  }
`;
