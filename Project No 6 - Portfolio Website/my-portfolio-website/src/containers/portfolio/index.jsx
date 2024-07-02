import React, { useState } from "react";
import { BsBriefcaseFill } from "react-icons/bs";
import PageHeaderContent from "../../components/pageHeaderContent";

import vid1 from "../../images/Portfolio Images/vid1.mp4";
import vid2 from "../../images/Portfolio Images/vid2.mp4";
import vid3 from "../../images/Portfolio Images/vid3.mp4";
import vid4 from "../../images/Portfolio Images/vid4.mp4";
import vid5 from "../../images/Portfolio Images/vid5.mp4";
import vid6 from "../../images/Portfolio Images/vid6.mp4";
import vid7 from "../../images/Portfolio Images/vid7.mp4";

import "./style.scss";

const portfolioData = [
  {
    id: 3,
    name: "Cine Explore",
    media: vid1,
    link: "https://github.com/TechPodx/Portfolio-Projects/tree/main/Project%20No%205%20-%20React%20-%20Movie%20Browing%20Web%20App/cine-explore",
  },
  {
    id: 3,
    name: "SoundCore",
    media: vid2,
    link: "https://github.com/TechPodx/Portfolio-Projects/tree/main/Project%20No%204%20-%20Spotify%20Clone/spotify-clone",
  },
  {
    id: 3,
    name: "Keyboard",
    media: vid3,
    link: "https://github.com/TechPodx/Portfolio-Projects/tree/main/Project%20No%203%20-%20Realistic%20Music%20Keyboard",
  },
  {
    id: 3,
    name: "Payroll System",
    media: vid4,
    link: "https://github.com/TechPodx/Portfolio-Projects/tree/main/Project%20No%202%20-%20PayRoll%20Management%20System%20Using%20C%23.Net",
  },
  {
    id: 3,
    name: "Message Generator",
    media: vid5,
    link: "https://github.com/TechPodx/Portfolio-Projects/tree/main/Project%20No%201%20-%20Message%20Generator",
  },
  {
    id: 2,
    name: "LC Loan Data Analysis",
    media: vid6,
    link: "https://github.com/TechPodx/DataMystics/tree/main/Lending%20Club%20Project",
  },
  {
    id: 2,
    name: "Birds vs Drones Detection",
    media: vid7,
    link: "https://github.com/TechPodx/DataMystics/tree/main/Birds%20vs%20Drones%20Detection",
  },
];

const filterData = [
  {
    filterId: 1,
    label: "All",
  },
  {
    filterId: 2,
    label: "Data Science",
  },
  {
    filterId: 3,
    label: "App Dev",
  },
];

const Portfolio = () => {
  const [filteredValue, setFilteredValue] = useState(1);
  const [hoveredValue, setHoveredValue] = useState(null);

  function handleFilter(currentId) {
    setFilteredValue(currentId);
  }

  function handleHover(index) {
    setHoveredValue(index);
  }

  const filteredItems =
    filteredValue === 1
      ? portfolioData
      : portfolioData.filter((item) => item.id === filteredValue);

  return (
    <section id="portfolio" className="portfolio">
      <PageHeaderContent
        headerText="My Portfolio"
        icon={<BsBriefcaseFill size={40} />}
      />
      <div className="portfolio_content">
        <ul className="portfolio_content_filter">
          {filterData.map((item) => (
            <li
              className={item.filterId === filteredValue ? "active" : ""}
              onClick={() => handleFilter(item.filterId)}
              key={item.filterId}
            >
              {item.label}
            </li>
          ))}
        </ul>
        <div className="portfolio_content_cards">
          {filteredItems.map((item, index) => (
            <div
              className="portfolio_content_cards_item"
              key={`cardItem${item.name.trim()}`}
              onMouseEnter={() => handleHover(index)}
              onMouseLeave={() => handleHover(null)}
            >
              <div className="portfolio_content_cards_item_img_wrapper">
                <div>
                  <video
                    autoPlay
                    loop
                    muted
                    src={item.media}
                    type="video/mp4"
                  ></video>
                </div>
              </div>
              <div className="overlay">
                {index === hoveredValue && (
                  <div>
                    <p>{item.name}</p>
                    <a
                      href={item.link}
                      target="_blank"
                      rel="noopener noreferrer"
                    >
                      <button>Visit</button>
                    </a>
                  </div>
                )}
              </div>
            </div>
          ))}
        </div>
      </div>
    </section>
  );
};

export default Portfolio;
