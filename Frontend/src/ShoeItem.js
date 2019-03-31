import React, { Component } from "react";

class ShoeItem extends Component {
  render() {
    const { shoeName, imagePath, description } = this.props;
    return (
      <div className= "Item">
        <h4>{shoeName}</h4>
        <img src={imagePath} />
        <p>{description}</p>
      </div>
    );
  }
}

export default ShoeItem;

