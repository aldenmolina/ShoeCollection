import React, { Component } from "react";
import ShoeItem from "./ShoeItem";

class Shoes extends Component {
  onShoeNameChange = e => {
    this.props.setShoeName(e.target.value);
  };
  onImageChange = e => {
    this.props.setImagePath(e.target.value);
  };
  onDescriptionChange = e => {
    this.props.setDescription(e.target.value);
  };
  render() {
    const {
      shoeTypeName,
      shoeBrands,
      shoeNameText,
      imagePath,
      description
    } = this.props;
    const shoeItems = shoeBrands.map(item => (
      <ShoeItem
        shoeId={item.shoeId}
        shoeTypeId={item.shoeTypeId}
        shoeName={item.shoeName}
        imagePath={item.imagePath}
        description={item.description}
        shoeNameText={shoeNameText}
      />
    ));
    return (
      <body>
        <div class="card">
          <h2>{shoeTypeName}</h2>

          <div className={`add-form${this.props.shoeTypeId}`}>
            Shoe Name:{" "}
            <input
              className={`add-name${this.props.shoeTypeId}`}
              type="text"
              value={shoeNameText}
              onChange={this.onShoeNameChange}
            />
            Image URL:{" "}
            <input
              className={`add-form${this.props.shoeTypeId}`}
              type="text"
              value={imagePath}
              onChange={this.onImageChange}
            />
            Description:{" "}
            <input
              className={`add-form${this.props.shoeTypeId}`}
              type="text"
              value={description}
              onChange={this.onDescriptionChange}
            />
            <button>Add Shoes</button>
          </div>
          <div>{shoeItems}</div>
        </div>
      </body>
    );
  }
}

export default Shoes;
