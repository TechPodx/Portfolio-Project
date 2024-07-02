import python from "../../images/skills_icons/python.png";
import Pandas from "../../images/skills_icons/pandas.png";
import Numpy from "../../images/skills_icons/NumPy.png";
import scikitLearn from "../../images/skills_icons/sklearn.png";
import TensorFlow from "../../images/skills_icons/TensorFlow.png";
import PyTorch from "../../images/skills_icons/PyTorch.png";
import XGBoots from "../../images/skills_icons/xgboost.png";

import Matplotlib from "../../images/skills_icons/Matplotlib.png";
import seaborn from "../../images/skills_icons/seaborn.png";
import Tableau from "../../images/skills_icons/Tableau.png";
import PoweBi from "../../images/skills_icons/powerBi.png";

import SQL from "../../images/skills_icons/sql.png";

import JS from "../../images/skills_icons/JS.png";
import React from "../../images/skills_icons/react.png";
import Redux from "../../images/skills_icons/redux.png";
import ExpressJS from "../../images/skills_icons/expressJS.png";
import Node from "../../images/skills_icons/Node.png";
import Mocha from "../../images/skills_icons/Mocha.png";
import Jest from "../../images/skills_icons/jest.png";
import CSharp from "../../images/skills_icons/C#.png";
import HTML from "../../images/skills_icons/html.png";
import CSS from "../../images/skills_icons/css.png";

import VSCode from "../../images/skills_icons/vs code.png";
import VisualStudio from "../../images/skills_icons/visual studio.png";
import Github from "../../images/skills_icons/github.png";
import Git from "../../images/skills_icons/git.png";
import Figma from "../../images/skills_icons/figma.png";
import Docker from "../../images/skills_icons/docker.png";

import Communication from "../../images/skills_icons/communication.png";
import Agile from "../../images/skills_icons/agile.png";
import Jira from "../../images/skills_icons/jira.png";
import Teamwork from "../../images/skills_icons/Teamwork.png";
import ProblemSolving from "../../images/skills_icons/Problem-Solving.png";

export const skillData = [
  {
    label: "Data Science",
    data: [
      {
        skillName: "Python",
        image: [
          python,
          Pandas,
          Numpy,
          scikitLearn,
          TensorFlow,
          PyTorch,
          XGBoots,
        ],
        percentage: "83",
      },
      {
        skillName: "Visualization",
        image: [Matplotlib, seaborn, Tableau, PoweBi],
        percentage: "80",
      },
      {
        skillName: "SQL",
        image: [SQL],
        percentage: "75",
      },
    ],
  },
  {
    label: "Application Development",
    data: [
      {
        skillName: "Languages",
        image: [JS, React, Redux, ExpressJS, Node, CSharp],
        percentage: "90",
      },
      {
        skillName: "HTML/CSS",
        image: [HTML, CSS],
        percentage: "95",
      },
      {
        skillName: "Development Practices",
        image: [VSCode, VisualStudio, Github, Git, Figma, Docker],
        percentage: "85",
      },
      {
        skillName: "Testing",
        image: [Jest, Mocha],
        percentage: "30",
      },
    ],
  },
  {
    label: "General Competencies",
    data: [
      {
        skillName: "Communication Skills",
        image: [Communication],
        percentage: "95",
      },
      {
        skillName: "Project Management",
        image: [Agile, Jira],
        percentage: "90",
      },
      {
        skillName: "Teamwork ",
        image: [Teamwork],
        percentage: "99",
      },
      {
        skillName: "Problem-Solving",
        image: [ProblemSolving],
        percentage: "95",
      },
    ],
  },
];
