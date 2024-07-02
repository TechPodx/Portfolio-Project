import "./App.scss";
import { Routes, Route, useLocation } from "react-router-dom";
import Home from "./containers/home";
import About from "./containers/about";
import Resume from "./containers/resume";
import Skills from "./containers/skills";
import Portfolio from "./containers/portfolio";
import Contact from "./containers/contact";
import Navbar from "./components/navBar";
import React from "react";
import Particles from "react-tsparticles";
import { loadFull } from "tsparticles";
import particles from "./utils.js/particles";

function App() {
  const handleInit = async (main) => {
    await loadFull(main);
  };

  const location = useLocation();
  const particlesOnlyInHomePage = location.pathname === "/";

  return (
    <div className="App">
      {particlesOnlyInHomePage && (
        <Particles id="particles" options={particles} init={handleInit} />
      )}

      {/* navbar */}
      <Navbar />
      {/* main page content */}
      <div className="App_main_page_content">
        <Routes>
          <Route index path="/" element={<Home />} />
          <Route path="/about" element={<About />} />
          <Route path="/resume" element={<Resume />} />
          <Route path="/skills" element={<Skills />} />
          <Route path="/portfolio" element={<Portfolio />} />
          <Route path="/contact" element={<Contact />} />
        </Routes>
      </div>
    </div>
  );
}

export default App;
