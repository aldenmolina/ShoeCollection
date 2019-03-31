import React, { Component } from "react";

class ShoeItem extends Component {
  render() {
    const { shoeName, imagePath, description } = this.props;
    return (
      <div>
        <h4>{shoeName}</h4>
        <img src={imagePath} />
        <p>{description}</p>
      </div>
    );
  }
}

export default ShoeItem;

class Item extends React.Component {
  render() {
    return(
      <div className="Item" style={{backgroundImage: 'url(' + this.props.backdrop + ')'}}>
        <div className="overlay">
          <div className="title">{this.props.title}</div>
          <div className="rating">{this.props.score} / 10</div>
          <div className="plot">{this.props.overview}</div>
          <ListToggle />
        </div>
      </div>