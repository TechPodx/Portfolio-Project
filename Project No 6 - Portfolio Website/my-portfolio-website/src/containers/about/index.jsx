import React from "react";
import { BsPersonFill } from "react-icons/bs";
import PageHeaderContent from "../../components/pageHeaderContent/";
import { Animate } from "react-simple-animate";
import "./style.scss";

const personalDetails = [
  {
    label: "Name: ",
    value: "Rasintha Lahiru",
  },
  {
    label: "Nationality: ",
    value: "Sri Lankan",
  },
  {
    label: "Languages: ",
    value: "English (fluent) & Sinhala",
  },
  {
    label: "Current City: ",
    value: "Ipswich",
  },
  {
    label: "Hobbies and Interests: ",
    value: "Fitness, Travel, Gaming ",
  },
  {
    label: "Email: ",
    value: "lahirurasi@gmail.com",
  },
  {
    label: "Contact No: ",
    value: "+44 7341 367867",
  },
];

const jobSummery =
  "I am actively a new opportunities to kickstart my career in data science. With nearly 5 years of experience as a full stack web developer, I have honed my skills in web development. Additionally, I bring a strong background in finance and accounting, which provides me with a solid foundation for analyzing and interpreting financial data. Now, I am eager to leverage my diverse skill set and pursue a career in data science and machine learning. I am committed to furthering my education in this area and am excited about the prospect of applying my programming expertise and financial acumen to solve complex data driven challenges.";

const About = () => {
  return (
    <section id="about" className="about">
      <PageHeaderContent
        headerText="About Me"
        icon={<BsPersonFill size={40} />}
      />
      <div className="about_content">
        <div className="about_content_wrapper">
          <Animate
            play
            duration={1.5}
            delay={1}
            start={{
              transform: "translateX(-900px)",
            }}
            end={{ transform: "translatex(0px)" }}
          >
            <h3>Junior Data Scientist</h3>
            <p>{jobSummery}</p>
          </Animate>

          <Animate
            play
            duration={1.5}
            delay={1}
            start={{
              transform: "translateX(500px)",
            }}
            end={{ transform: "translatex(0px)" }}
          >
            <h3 className="personalInfo">Personal Information</h3>
            <ul>
              {personalDetails.map((item, i) => (
                <li key={i}>
                  <span className="title">{item.label}</span>
                  <span className="value">{item.value}</span>
                </li>
              ))}
            </ul>
          </Animate>
        </div>
        <div className="about_content_wrapper_services">
          <Animate
            play
            duration={1.5}
            delay={1}
            start={{
              transform: "translateX(550px)",
            }}
            end={{ transform: "translatex(0px)" }}
          >
            <div className="about_content_wrapper_services_box"></div>
          </Animate>
        </div>
      </div>
    </section>
  );
};

export default About;
