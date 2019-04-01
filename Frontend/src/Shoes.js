import React, { Component } from "react";
import ShoeItem from "./ShoeItem";

class Shoes extends Component {
  addShoe = () => {
    this.props.addNewShoe(this.props.shoeType.shoeTypeId);
  };
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
        shoe={item}
        shoeId={item.shoeId}
        shoeName={item.shoeName}
        imagePath={item.imagePath}
        description={item.description}
        shoeNameText={shoeNameText}
        onShoeNameChange={this.onShoeNameChange}
        onImageChange={this.onImageChange}
        onDescriptionChange={this.context}
      />
    ));
    return (
      <body>
        <div class="card">
          <h2>{shoeTypeName}</h2>
          <div>{shoeItems}</div>
          <div className={`add-form${this.props.shoeTypeId}`}>
            <div>
              <label>Name: </label>
              <input
                className={`add-name${this.props.shoeTypeId}`}
                type="text"
                value={shoeNameText}
                onChange={this.onShoeNameChange}
              />
            </div>
            <div>
              <label>Image URL:</label>
              <input
                className={`add-form${this.props.shoeTypeId}`}
                type="text"
                value={imagePath}
                onChange={this.onImageChange}
              />
            </div>
            <div>
              <label>Description: </label>
              <input
                className={`add-form${this.props.shoeTypeId}`}
                type="text"
                value={description}
                onChange={this.onDescriptionChange}
              />
            </div>
            <button onClick={this.addShoe}>Add Shoes</button>
          </div>
        </div>
      </body>
    );
  }
}

export default Shoes;
