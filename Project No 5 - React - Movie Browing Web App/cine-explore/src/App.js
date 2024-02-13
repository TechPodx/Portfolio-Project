import React, { useEffect, useState } from "react";
import "./App.css";
import SearchIcon from "./search.svg";
import MovieCard from "./MovieCard";

const MOVIE_API = "http://www.omdbapi.com?apikey=e7a9b536"; // calling API and assigning it to a static variable

const App = () => {
  const [movies, setMovies] = useState([]);
  const [searchName, setSearchName] = useState("");

  const searchMovies = async (title) => {
    const apiResponse = await fetch(`${MOVIE_API}&s=${title}`);
    const getData = await apiResponse.json();

    setMovies(getData.Search); // Pass search results based on the title to the setMovies
  };

  // use useEffect hook to fetch the API data once the page loaded
  useEffect(() => {
    // Adding the function that fetch the initial movie data
    searchMovies("Avengers");
  }, []);

  return (
    <div className="app">
      <h1>CINE EXPLORE</h1>

      <div className="search">
        <input
          placeholder="Explore Movies"
          value={searchName}
          onChange={(event) => {
            setSearchName(event.target.value);
          }}
        />
        <img
          src={SearchIcon}
          alt="Search"
          onClick={() => searchMovies(searchName)}
        />
      </div>
      <div>
        {movies.length > 0 ? (
          <div className="container">
            {movies.map((movie) => (
              <MovieCard movie={movie} />
            ))}
          </div>
        ) : (
          <div className="empty">
            <h2>No Movie Found 😟</h2>
          </div>
        )}
      </div>
    </div>
  );
};

export default App;
