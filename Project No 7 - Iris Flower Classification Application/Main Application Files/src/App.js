import "./App.css";
import Welcome from "./containers/welcome/welcome";
import Home from "./containers/home/home";
import Popups from "./containers/popups/Popups";
import { Routes, Route } from "react-router-dom";

function App() {
  return (
    <div className="App">
      <Routes>
        <Route index path="/" element={<Welcome />} />
        <Route path="/Home" element={<Home />} />
        <Route path="/Popups" element={<Popups />} />
      </Routes>
    </div>
  );
}

export default App;
