import React, { Component } from 'react';

    class Hero extends React.Component {
                render() {
                  return(
                    <div id="hero"  className="Hero" style={{backgroundImage: 'url(https://picserio.com/data/out/57/neon-3d-wallpapers_2799270.jpg)'}}>
                      <div className="content">
                        <img className="logo" src="https://i.pinimg.com/originals/d4/f5/93/d4f593edecbaa6ae8865f376b2d6d261.jpg" alt="main background"/>
                        <h1>I still have my feet on the ground, I just wear better shoes. ...</h1>

                      </div>
                      <div className="overlay"></div>
                    </div>
        );
    }
}

export default Hero;