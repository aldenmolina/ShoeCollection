import React, { Component } from "react";

class InputText extends Component {
  onSetTypeName = e => {
    this.props.setTypeName(e.target.value);
  };
  onSetName = e => {
    this.props.setName(e.target.value);
  };
  onSetDescription = e => {
    this.props.setDescription(e.target.value);
  };

  render() {
    const { shoeTypeName, shoeName, shoeDescription } = this.props;
    return (
      <div>
        Shoe Type:{" "}
        <input type="text" value={shoeTypeName} onChange={this.onSetTypeName} />
        Shoe Name:{" "}
        <input type="text" value={shoeName} onChange={this.onSetName} />
        Description:{" "}
        <input
          type="text"
          value={shoeDescription}
          onChange={this.onSetDescription}
        />
      </div>
    );
  }
}

export default InputText;
