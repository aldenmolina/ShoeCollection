import React, { Component } from "react";
import "./App.css";
import InputText from "./InputText";

class App extends Component {
  constructor() {
    super();
    this.state = {
      shoeTypeName: [],
      shoeBrandName: [],
      brandImgPath: "",
      shoeBrandInfo: "",
      typeImagePath: "",
      shoeTypeInfo: ""
    };
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
      </div>
    );
  }
}

export default App;
