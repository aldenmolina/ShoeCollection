import React, { Component } from "react";

class ShoeCollection extends Component {
  render() {
    const { shoeCollection } = this.props;
    const shoeTypeList = shoeCollection.map(item => (
      <div>
        <h2>{item.ShoeTypeName}</h2>
        <ul>
          <li>
            <img src={item.TypeImagePath} />
          </li>
          <li>{item.ShoeTypeInfo}</li>
        </ul>
      </div>
    ));
    const shoeBrandList = shoeCollection.map(item => item.ShoeBrands.map(
        <div>
            <h3>{</h3>
        </div>
    ));
    return (
      <div>
        {shoeTypeList} {shoeBrandList}
      </div>
    );
  }
}

export default ShoeCollection;
