import React from "react";
import { BsFileEarmarkTextFill } from "react-icons/bs";
import PageHeaderContent from "../../components/pageHeaderContent";
import {
  VerticalTimeline,
  VerticalTimelineElement,
} from "react-vertical-timeline-component";
import { data } from "./utils";
import "react-vertical-timeline-component/style.min.css";
import "./style.scss";
import { MdWork, MdSchool } from "react-icons/md";
import downloadImage from "../../images/Other/Download.gif";
import my_cv from "../../containers/resume/CV/Rasi_CV.pdf";

const DownloadCVButton = () => {
  return (
    <a href={my_cv} download="Rasi_CV.pdf" className="download-btn">
      <img
        src={downloadImage}
        alt="download button"
        title="Download the CV here"
      />
    </a>
  );
};

const Resume = () => {
  return (
    <section id="resume" className="resume">
      <PageHeaderContent
        headerText="My Resume"
        img={<DownloadCVButton />}
        icon={<BsFileEarmarkTextFill size={40} />}
      />

      <div className="timeline">
        <div className="timeline_experience">
          <h3 className="timeline_experience_header_text">Experience</h3>
          <VerticalTimeline
            layout="{1-column}"
            lineColor="var(--blue-theme-main-color)"
          >
            {data.experience.map((item, i) => (
              <VerticalTimelineElement
                key={i}
                className="timeline_experience_vertical_timeline_element"
                contentStyle={{
                  background: "none",
                  color: "var(--blue-theme-sub-text-color)",
                  border: "1.5px solid var(--blue-theme-main-color)",
                }}
                date={item.date}
                icon={<MdWork />}
                iconStyle={{
                  background: "#181818",
                  color: "var(--blue-theme-main-color)",
                }}
              >
                <div className="vertical_timeline_element_title_wrapper">
                  <h3>{item.title}</h3>
                  <h4>{item.company}</h4>
                </div>
                <p className="vertical_timeline_element_title_wrapper_description">
                  {item.description}
                </p>
              </VerticalTimelineElement>
            ))}
          </VerticalTimeline>
        </div>
        <div className="timeline_education">
          <h3 className="timeline_education_header_text">Education</h3>
          <VerticalTimeline
            layout="{1-column}"
            lineColor="var(--blue-theme-main-color)"
          >
            {data.education.map((item, i) => (
              <VerticalTimelineElement
                key={i}
                className="timeline_education_vertical_timeline_element"
                contentStyle={{
                  background: "none",
                  color: "var(--blue-theme-sub-text-color)",
                  border: "1.5px solid var(--blue-theme-main-color)",
                }}
                date={item.date}
                icon={<MdSchool />}
                iconStyle={{
                  background: "#181818",
                  color: "var(--blue-theme-main-color)",
                }}
              >
                <div className="vertical_timeline_element_title_wrapper">
                  <h3>{item.subject}</h3>
                  <h4>{item.institution}</h4>
                </div>
                <p className="vertical_timeline_element_title_wrapper_description">
                  {item.description}
                </p>
              </VerticalTimelineElement>
            ))}
          </VerticalTimeline>
        </div>
      </div>
    </section>
  );
};

export default Resume;
