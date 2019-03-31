import React, { Component } from 'react';

class Header extends Component {
    render() {
        const backgroundStyle = {
            backgroundSize: "cover",
            backgroundImage: `url(https://image.tmdb.org/t/p/original/${props.movie.backdrop_path})`,
            backgroundPosition: "center",
          } = this.props;

        return (
            <header style={backgroundStyle} className="header">   
            </header>
        );
    }
}

export default Header;