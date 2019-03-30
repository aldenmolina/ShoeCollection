import React, { Component } from "react";
import "./App.css";
import InputText from "./InputText";
import ShoeType from "./ShoeType";

class App extends Component {
  constructor() {
    super();
    this.state = {
      shoeTypeName: [],
      shoeName: [],
      shoeDescription: "",
      shoeType: []
    };
  }

  componentDidMount() {
    fetch("https://localhost:44382/api/shoetype")
      .then(res => res.json())
      .then(json => this.setState({ shoeType: json }));
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
    const listTypes = this.state.shoeType.map(item => (
      <ShoeType shoeTypeId={item.shoeTypeId} shoeType={this.state.shoeType} />
    ));
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
        <ul>{listTypes}</ul>
      </div>
    );
  }
}

export default App;
