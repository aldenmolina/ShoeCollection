import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";

class App extends Component {
  constructor() {
    super();
    this.state = {
      shoeType: ["Basketball", "Cross-Trainer", "Casual", "Running"],
      shoeBrand: ["Nike", "Addidas", "Reebok", "New Balance"],
      ImgPath: "",
      shoeDescription: ""
    };
  }

  setImage = newImageURL => {
    this.setState({ ImgPath: newImageURL });
  };

  render() {
    return <div> </div>;
  }
}

export default App;
