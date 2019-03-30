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
        <input type="text" value={shoeTypeName} onChange={}  />
        <input type="text" value={shoeBrandName} onChange={}  />
        <input type="text" value={brandImgPath} onChange={}  />
        <input type="text" value={shoeBrandInfo} onChange={}  />
        <input type="text" value={typeImagePath} onChange={}  />
        <input type="text" value={shoeTypeInfo} onChange={}  />
      </div>
    );
  }
}

export default InputText;
