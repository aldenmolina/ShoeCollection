import React, { Component } from "react";

class ShoeItem extends Component {
  onUpdateShoe = () => {
    this.props.updateShoe(this.props.shoeId, this.props.shoeId);
  };

  delete = shoeId => {
    const url = "https://localhost:44382/api/shoe/" + shoeId;
    fetch(url, {
      method: "DELETE",
      headers: {
        "Content-Type": "application/json"
      }
    })
      .then(res => {
        if (res.ok) {
          console.log("Shoe data deleted");
        }
      })
      .catch(err => {
        console.error(err);
      });
  };

  render() {
    const { item, shoeId, shoeName, imagePath, description } = this.props;
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
          <button onClick={() => this.delete(shoeId)}>Delete Shoe</button>
        </div>
      </div>
    );
  }
}

export default ShoeItem;
