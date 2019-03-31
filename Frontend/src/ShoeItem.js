import React, { Component } from "react";

class ShoeItem extends Component {
  render() {
    const { shoeName, description } = this.props;
    return (
      <div>
        <h4>{shoeName}</h4>
        <p>{description}</p>
      </div>
    );
  }
}

export default ShoeItem;
