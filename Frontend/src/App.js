import React, { Component } from "react";
import "./App.css";
import InputText from "./InputText";
import ShoeType from "./ShoeType";

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
      shoeType: []
    };
  }

  componentDidMount() {
    fetch("https://localhost:44355/api/shoetype")
      .then(res => res.json())
      .then(json => this.setState({ shoeType: json }));
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
    const listTypes = this.state.shoeType.map(item => (
      <ShoeType shoeTypeId={item.shoeTypeId} shoeType={this.state.shoeType} />
    ));
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
        <ul>{listTypes}</ul>
      </div>
    );
  }
}

export default App;
