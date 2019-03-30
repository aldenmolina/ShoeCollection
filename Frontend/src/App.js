import React, { Component } from "react";
import "./App.css";
import InputText from "./InputText";
import ShoeCollection from "./ShoeCollection";

class App extends Component {
  constructor() {
    super();
    this.state = {
      shoeTypeName: [],
      shoeBrandName: [],
      brandImgPath: "",
      shoeBrandInfo: "",
      typeImagePath: "",
      shoeTypeInfo: "",
      shoeCollection: [{}]
    };
  }

  componentDidMount() {
    fetch("https://localhost:44355/api/shoetype")
      .then(res => res.json())
      .then(json => this.setState({ createdMemes: json }));
  }

  setTypeName = newTypeName => {
    this.setState({ shoeTypeName: newTypeName });
  };
  setBrandName = newBrandName => {
    this.setState({ shoeBrandName: newBrandName });
  };
  setBrandImgPath = newBrandImagePath => {
    this.setState({ brandImgPath: newBrandImagePath });
  };
  setBrandInfo = newBrandInfo => {
    this.setState({ shoeBrandInfo: newBrandInfo });
  };
  setTypeImgPath = newTypeImagePath => {
    this.setState({ typeImagePath: newTypeImagePath });
  };
  setTypeInfo = newTypeInfo => {
    this.setState({ shoeTypeInfo: newTypeInfo });
  };

  render() {
    return (
      <div>
        <InputText
          shoeTypeName={this.state.shoeTypeName}
          shoeBrandName={this.state.shoeBrandName}
          brandImgPath={this.state.brandImgPath}
          shoeBrandInfo={this.state.shoeBrandInfo}
          typeImagePath={this.state.typeImagePath}
          shoeTypeInfo={this.state.shoeTypeInfo}
          setTypeName={this.setTypeName}
          setBrandName={this.setBrandName}
          setBrandImgPath={this.setBrandImgPath}
          setBrandInfo={this.setBrandInfo}
          setTypeImgPath={this.setTypeImgPath}
          setTypeInfo={this.setTypeInfo}
        />
        <ShoeCollection shoeCollection={this.state.shoeCollection} />
      </div>
    );
  }
}

export default App;
