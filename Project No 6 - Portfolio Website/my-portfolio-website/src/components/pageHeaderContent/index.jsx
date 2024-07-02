import "./style.scss";

const PageHeaderContent = (props) => {
  const { headerText, img, icon } = props;

  return (
    <div className="wrapper">
      <div className="wrapper_main">
        <h2>{headerText}</h2>
        <span>{img}</span>
      </div>
      <span>{icon}</span>
    </div>
  );
};

export default PageHeaderContent;
