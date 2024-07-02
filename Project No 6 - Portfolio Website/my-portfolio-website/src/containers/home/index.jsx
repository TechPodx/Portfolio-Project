import React from "react";
import "./style.scss";
import { useNavigate } from "react-router-dom";
import { Animate } from "react-simple-animate";

const Home = () => {
  const navigate = useNavigate();

  const navToHearMe = () => {
    navigate("/contact");
  };

  return (
    <section id="home" className="home">
      <div className="home_text_wrapper">
        <h1>
          <Animate
            play
            duration={1.2}
            delay={1}
            start={{
              transform: "translateX(800px)",
            }}
            end={{ transform: "translatey(0px)" }}
          >
            <div className="top_texts">
              <span className="span1">Hello, I am Rasintha</span>
              <br />
              <span className="span1_sub">I am a Junior Data Scientist</span>
            </div>
          </Animate>

          <br />

          <Animate
            play
            duration={1.2}
            delay={1.9}
            start={{
              transform: "translateX(-800px)",
            }}
            end={{ transform: "translatey(0px)" }}
          >
            <span className="span2"></span>
          </Animate>
        </h1>
      </div>
      <Animate
        play
        duration={1.2}
        delay={1}
        start={{
          transform: "translateY(550px)",
        }}
        end={{
          transform: "translatex(0px)",
        }}
      >
        <div className="home_contact_me_button">
          <button onClick={navToHearMe}>Hire me</button>
        </div>
      </Animate>
    </section>
  );
};

export default Home;
