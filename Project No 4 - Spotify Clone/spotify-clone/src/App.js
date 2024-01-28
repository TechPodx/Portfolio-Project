import React, { useEffect } from 'react';
import Login from './Components/login';
import { reducerCases } from './Utilities/Constants';
import { useStateProvider } from './Utilities/StateProvider';
import Spotify from './Components/Spotify';

export default function App() {

  const [{token}, dispatch] = useStateProvider();

  useEffect(() => {
    const hash = window.location.hash; // Assigning hash to hash veriable
    if(hash) {
      const token = hash.substring(1).split("&")[0].split("=")[1]; // USe split method to seperate only the token part. Here we have used split() method to access get the correct part of the hash 
      dispatch({ type: reducerCases.SET_TOKEN, token })
    }
  }, [token, dispatch]);

  return (
    <div>
      {token ? <Spotify /> : <Login />}
    </div>
  );
};
