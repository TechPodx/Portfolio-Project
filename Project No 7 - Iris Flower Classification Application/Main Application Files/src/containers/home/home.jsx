import React, { useState } from "react";
import "./home.css";
import flower_1 from "../../Images/Flower 1.jpeg";
import flower_2 from "../../Images/Flower 2.jpg";
import flower_3 from "../../Images/Flower 3.jpeg";
import flower_4 from "../../Images/Flower 4.jpg";
import { useNavigate } from "react-router-dom";

const Home = () => {
  const [sepalLength, setSepalLength] = useState("");
  const [sepalWidth, setSepalWidth] = useState("");
  const [petalLength, setPetalLength] = useState("");
  const [petalWidth, setPetalWidth] = useState("");

  const navigate = useNavigate();

  const submitClickHandle = async (e) => {
    e.preventDefault(); // Prevent default form submission
    if (
      !sepalLength.trim() ||
      !sepalWidth.trim() ||
      !petalLength.trim() ||
      !petalWidth.trim()
    ) {
      alert("Please fill in all fields");
      return;
    }
    // navigate("/Popups");

    const data = {
      sepal_length: parseFloat(sepalLength),
      sepal_width: parseFloat(sepalWidth),
      petal_length: parseFloat(petalLength),
      petal_width: parseFloat(petalWidth),
    };

    try {
      // Send a POST request to your Flask server
      const response = await fetch("http://localhost:5000", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(data),
      });

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }
      const result = await response.json();
      // console.log("Prediction result:", result);
      // alert(`Prediction: ${result.prediction}`);
      // Navigate to popups

      const handleClick = () => {
        navigate("/popups", { state: { flowerName: result.prediction } });
      };

      const flowe_name = result.prediction;
      if (
        flowe_name == "Iris-setosa" ||
        "Iris-versicolor" ||
        "Iris-virginica"
      ) {
        handleClick();
      } else {
        throw new Error("Failed to fetch data");
      }
    } catch (error) {
      console.error("Error:", error);
      alert("Failed to get prediction");
    }
  };

  return (
    <div className="homePage">
      <img id="flower_1" src={flower_1} alt="flower Image 1" />
      <img id="flower_2" src={flower_2} alt="flower Image 2" />
      <img id="flower_3" src={flower_3} alt="flower Image 3" />
      <img id="flower_4" src={flower_4} alt="flower Image 4" />
      <div className="homePage_form">
        <form action="">
          <h1>Enter Flower Details</h1>
          <div className="container">
            <label htmlFor="sepalLength">
              Sepal Length<span>*</span>
            </label>

            <input
              type="number"
              value={sepalLength}
              onChange={(e) => setSepalLength(e.target.value)}
              placeholder="Type Sepal Length"
              name="sepalLength"
            />
          </div>

          <div className="container">
            <label htmlFor="sepalWidth">
              Sepal Width<span>*</span>
            </label>

            <input
              type="number"
              value={sepalWidth}
              onChange={(e) => setSepalWidth(e.target.value)}
              placeholder="Type Sepal Width"
              name="sepalWidth"
            />
          </div>

          <div className="container">
            <label htmlFor="petalLength">
              Petal Length<span>*</span>
            </label>

            <input
              type="number"
              value={petalLength}
              onChange={(e) => setPetalLength(e.target.value)}
              placeholder="Type Petal Length"
              name="petalLength"
            />
          </div>

          <div className="container">
            <label htmlFor="petalWidths">
              Petal Widths<span>*</span>
            </label>

            <input
              type="number"
              value={petalWidth}
              onChange={(e) => setPetalWidth(e.target.value)}
              placeholder="Type Petal Width"
              name="petalWidths"
            />
          </div>

          <button type="submit" onClick={submitClickHandle}>
            Submit
          </button>
        </form>
      </div>
    </div>
  );
};

export default Home;
