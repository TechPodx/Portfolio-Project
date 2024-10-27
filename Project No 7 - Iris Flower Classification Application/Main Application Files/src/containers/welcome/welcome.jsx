import React from "react";
import "./welcome.css";
import { useNavigate } from "react-router-dom";

const Welcome = () => {
  const navigate = useNavigate();

  const handleClick = () => {
    navigate("/Home");
  };

  return (
    <div className="welcomePage">
      <h1>Iris Flower Classification</h1>
      <button onClick={handleClick}>Start</button>
    </div>
  );
};

export default Welcome;
