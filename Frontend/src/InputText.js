import React, { Component } from "react";

class InputText extends Component {
  onSetTypeName = e => {
    this.props.setTypeName(e.target.value);
  };
  onSetBrandName = e => {
    this.props.setBrandName(e.target.value);
  };
  onSetBrandImgPath = e => {
    this.props.setBrandImgPath(e.target.value);
  };
  onSetBrandInfo = e => {
    this.props.setBrandInfo(e.target.value);
  };
  onSetTypeImgPath = e => {
    this.props.setTypeImagePath(e.target.value);
  };
  onSetTypeInfo = e => {
    this.props.setTypeInfo(e.target.value);
  };

  render() {
    const {
      shoeTypeName,
      shoeBrandName,
      brandImgPath,
      shoeBrandInfo,
      typeImagePath,
      shoeTypeInfo
    } = this.props;
    return (
      <div>
        Shoe Type:{" "}
        <input type="text" value={shoeTypeName} onChange={this.onSetTypeName} />
        Shoe Brand:{" "}
        <input
          type="text"
          value={shoeBrandName}
          onChange={this.onSetBrandName}
        />
        Brand Image URL:{" "}
        <input
          type="text"
          value={brandImgPath}
          onChange={this.onSetBrandImgPath}
        />
        Brand Info:{" "}
        <input
          type="text"
          value={shoeBrandInfo}
          onChange={this.onSetBrandInfo}
        />
        Shoe Type Image URL:{" "}
        <input
          type="text"
          value={typeImagePath}
          onChange={this.typeImagePath}
        />
        Shoe Type Info:{" "}
        <input type="text" value={shoeTypeInfo} onChange={this.onSetTypeInfo} />
      </div>
    );
  }
}

export default InputText;
