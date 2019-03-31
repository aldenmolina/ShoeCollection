import React, { Component } from 'react';

class Navigation extends Component {
              state = {
                scrolling: false
              }
            
              componentDidMount() {
                window.addEventListener('scroll', this.handleScroll);
              }
            
              componentWillUnmount() {
                window.removeEventListener('scroll', this.handleScroll);
              }
            
              /** changes the scrolling state depending on the Y-position */
              handleScroll = (event) => {
                if (window.scrollY === 0) {
                  this.setState({ scrolling: false });
                }
                else if (window.scrollY > 50) {
                  this.setState({ scrolling: true });
                }
              }
                      
              render() {
                const { scrolling } = this.state;
                const { showShoeBrands } = this.props;
            
                return (
                  <div id="navigator" className="Navigation" >
        <nav>
          <ul>
            <li>Home</li>
            <li>Add A New Shoe</li>
            <li>Update A Shoe Listing</li>
          </ul>
        </nav>
      </div>
                );
            }
}

export default Navigation; 