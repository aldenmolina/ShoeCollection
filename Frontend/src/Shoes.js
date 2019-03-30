import React, { Component } from "react";

class Shoes extends Component {
  render() {
    const { shoes } = this.props;
    const shoeList = shoes.map(item => (
      <li>
        <p>{item.shoeTypeName}</p>
      </li>
    ));
    return <ul>{shoeList}</ul>;
  }
}

export default Shoes;
