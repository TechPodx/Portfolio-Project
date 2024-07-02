import React from "react";
import { BsEnvelopeFill } from "react-icons/bs";
import PageHeaderContent from "../../components/pageHeaderContent";
import { Animate } from "react-simple-animate";
import "./style.scss";
import { useRef } from "react";
import emailjs from "@emailjs/browser";
import Swal from "sweetalert2";

const Contact = () => {
  const form = useRef();

  const sendEmail = (e) => {
    e.preventDefault();

    emailjs
      .sendForm("service_h8xhvvv", "template_9mqa8dz", form.current, {
        publicKey: "Xs2rTdqbQk-Chngfj",
      })
      .then(
        () => {
          Swal.fire({
            title: "Success!",
            text: "Message Sent Successfully!",
            icon: "success",
          });
        },
        (error) => {
          Swal.fire({
            icon: "Error",
            title: "Oops...",
            text: "Something went wrong!",
            footer: `<a href="#">Why do I have this issue?${error.text}</a>`,
          });
        }
      );
  };

  return (
    <section id="contact" className="contact">
      <PageHeaderContent
        headerText="My Contact"
        icon={<BsEnvelopeFill size={40} />}
      />
      <div className="contact_content">
        <Animate
          play
          duration={1}
          delay={0}
          start={{
            transform: "translateX(-200px)",
          }}
          end={{
            transform: "translateX(0px)",
          }}
        >
          <h3 className="contact_content_header_text">Let's Talk</h3>
        </Animate>
        <Animate
          play
          duration={1}
          delay={0}
          start={{
            transform: "translateX(200px)",
          }}
          end={{
            transform: "translateX(0px)",
          }}
        >
          <form
            className="contact_content_form"
            ref={form}
            onSubmit={sendEmail}
          >
            <div className="contact_content_form_controls_wrapper">
              <div>
                <input
                  type={"text"}
                  name="name"
                  className="inputName"
                  required
                  autoComplete="off"
                />
                <label htmlFor="name" className="nameLabel">
                  Full Name
                </label>
              </div>
              <div>
                <input
                  type={"text"}
                  name="email"
                  className="inputEmail"
                  required
                  autoComplete="off"
                />
                <label htmlFor="email" className="emailLabel">
                  Email Address
                </label>
              </div>
              <div>
                <input
                  type={"text"}
                  name="phone"
                  className="inputPhone"
                  required
                  autoComplete="off"
                />
                <label htmlFor="phone" className="phoneLabel">
                  Phone Number
                </label>
              </div>
              <div>
                <input
                  type={"text"}
                  name="subject"
                  className="inputSubject"
                  required
                  autoComplete="off"
                />
                <label htmlFor="subject" className="subjectLabel">
                  Subject
                </label>
              </div>

              <div>
                <textarea
                  type={"text"}
                  name="description"
                  className="inputDescription"
                  required
                  autoComplete="off"
                  rows={5}
                />
                <label htmlFor="description" className="descriptionLabel">
                  Your Message
                </label>
              </div>
            </div>
            <button type="submit" value="Send">
              Submit
            </button>
          </form>
        </Animate>
      </div>
    </section>
  );
};

export default Contact;
