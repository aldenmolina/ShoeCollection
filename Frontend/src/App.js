import React, { Component } from "react";
import "./App.css";
import InputText from "./InputText";
import Shoes from "./Shoes";
import Navigation from "./Navigation";
import Hero from "./Hero";

class App extends Component {
  constructor() {
    super();
    this.state = {
      shoeName: "",
      imagePath: "",
      description: "",
      shoes: []
    };
  }

  componentDidMount() {
    fetch("https://localhost:44382/api/shoetype")
      .then(res => res.json())
      .then(json => this.setState({ shoes: json }));
  }

  addNewShoe = newShoeTypeId => {
    const newShoeType = {
      shoeTypeId: newShoeTypeId,
      shoeName: this.state.shoeName,
      imagePath: this.state.imagePath,
      description: this.state.description
    };
    fetch("https://localhost:44382/api/shoe", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(newShoeType)
    }).then(res => {
      if (res.ok) {
        const shoeTypeIndex = newShoeTypeId - 1;
        const newShoes = [
          ...this.state.shoeType[shoeTypeIndex].shoeBrands,
          newShoeType
        ];
        const updateShoeType = this.state.shoeType[shoeTypeIndex];
        updateShoeType.shoeBrands = newShoes;
        const newShoeType = this.state.shoeType;
        newShoeType[shoeTypeIndex] = updateShoeType;
        this.setState({ shoeType: newShoeType });
      }
    });
  };

  setShoeName = newName => {
    this.setState({ shoeName: newName });
  };

  setImagePath = newPath => {
    this.setState({ imagePath: newPath });
  };

  setDescription = newText => {
    this.setState({ description: newText });
  };

  updateShoe = (newShoeId, newShoeTypeId) => {
    const newShoe = {
      shoeId: newShoeId,
      shoeTypeId: newShoeTypeId,
      shoeName: this.state.shoeName,
      imagePath: this.state.imagePath,
      description: this.state.description
    };
    const url = "https://localhost:44382/api/shoe/" + newShoeId;
    fetch(url, {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(newShoe)
    }).then(res => {
      if (res.ok) {
        const shoeTypeIndex = newShoeTypeId - 1;
        const newShoes = [...this.state.shoeType[shoeTypeIndex].shoeBrands];
        let shoePlacer = 0;
        newShoes.forEach((shoe, index) => {
          if (shoe.shoeId === newShoeId) {
            shoePlacer = index;
          }
        });
        newShoes[shoePlacer] = newShoe;
        const newShoeType = this.state.shoeType[shoeTypeIndex];
        newShoeType.shoeBrands = newShoes;
        const newShoeTypes = this.state.shoeType;
        newShoeTypes[shoeTypeIndex] = newShoeType;
        this.setState({ shoeType: newShoeType });
      }
    });
  };

  render() {
    const shoeList = this.state.shoes.map(item => (
      <Shoes
        shoeType={item}
        shoeTypeId={item.shoeTypeId}
        shoeTypeName={item.shoeTypeName}
        shoeBrands={item.shoeBrands}
        imagePath={this.imagePath}
        setShoeName={this.setShoeName}
        setImagePath={this.setImagePath}
        setDescription={this.setDescription}
        shoeNameText={this.shoeName}
        addNewShoe={this.addNewShoe}
        updateShoe={this.updateShoe}
      />
    ));
    return (
      <div className="main-container">
        <header className="header">
          <Navigation />
        </header>
        <div className="main">
          <Hero />
        </div>
        <div className="main-2">{shoeList}</div>
      </div>
    );
  }
}

export default App;
