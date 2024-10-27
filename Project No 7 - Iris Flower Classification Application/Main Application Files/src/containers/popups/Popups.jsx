import React from "react";
import "./Popups.css";
import { useLocation } from "react-router-dom";
const Popups = () => {
  const location = useLocation();
  const flower_name = location.state.flowerName;
  return (
    <div className="popupBackground">
      <div className="popupBackground_popUp">
        <div className="popupBackground_popUp_answer">{flower_name}</div>
      </div>
    </div>
  );
};

export default Popups;
