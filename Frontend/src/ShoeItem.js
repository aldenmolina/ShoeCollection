import React, { Component } from "react";

class ShoeItem extends Component {
  onUpdateShoe = () => {
    this.props.updateShoe(this.props.shoeId, this.props.shoeId);
  };

  render() {
    const { item, shoeName, imagePath, description } = this.props;
    return (
      <div>
        <div className="Item">
          <h4>{shoeName}</h4>
          <img src={imagePath} />
          <p>{description}</p>
        </div>
        <div>
          <div>
            <label>Name: </label>
            <input
              type="text"
              value={this.props.shoeName}
              onChange={this.props.onShoeNameChange}
            />
          </div>
          <div>
            <label>Image URL: </label>
            <input
              type="text"
              value={this.props.imagePath}
              onChange={this.props.onImageChange}
            />
          </div>
          <div>
            <label>Description: </label>
            <input
              type="text"
              value={this.props.description}
              onChange={this.props.onDescriptionChange}
            />
          </div>
          <button onClick={this.onUpdateShoe}>Update</button>
        </div>
      </div>
    );
  }
}

export default ShoeItem;
