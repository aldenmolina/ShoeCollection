import React, { Component } from "react";
import "./App.css";
import InputText from "./InputText";
import Shoes from "./Shoes";

class App extends Component {
  constructor() {
    super();
    this.state = {
      shoeTypeName: [],
      shoeName: [],
      shoeDescription: "",
      shoes: [{}]
    };
  }

  componentDidMount() {
    fetch("https://localhost:44382/api/shoetype")
      .then(res => res.json())
      .then(json => this.setState({ shoes: json }));
  }

  setTypeName = newTypeName => {
    this.setState({ shoeTypeName: newTypeName });
  };
  setName = newName => {
    this.setState({ shoeName: newName });
  };

  setDescription = newDescription => {
    this.setState({ shoeDescription: newDescription });
  };

  setType = newType => {
    this.setState({ shoeType: newType });
  };

  render() {
    return (
      <div>
        <InputText
          shoeTypeName={this.state.shoeTypeName}
          shoeBrandName={this.state.shoeBrandName}
          shoeDescription={this.state.shoeDescription}
          setTypeName={this.setTypeName}
          setName={this.setName}
          setDescription={this.setDescription}
        />
        <Shoes shoes={this.state.shoes} />
      </div>
    );
  }
}

export default App;
