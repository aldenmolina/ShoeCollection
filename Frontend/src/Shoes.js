import React, { Component } from "react";
import ShoeItem from "./ShoeItem";

class Shoes extends Component {
  render() {
    const { shoeBrands, shoeTypeName } = this.props;
    const shoeItems = shoeBrands.map(item => (
      <ShoeItem shoeName={item.shoeName} imagePath={item.imagePath} description={item.description} />
    ));
    return (
      <body>
        <div class="card">
         <h2>{shoeTypeName}</h2> 
        {shoeItems}
      </div>
      </body>
        );
      }
    }

export default Shoes;
