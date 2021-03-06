import React, {Component} from 'react';
import { Navbar } from "@blueprintjs/core";

class Navigation extends Component {
    render(){
        return (
            <nav className="pt-navbar pt-dark pt-fixed-top">
                <div className="pt-navbar-group pt-align-left">
                    <div className="pt-navbar-heading">Suggestion Box</div>
                    <input className="pt-input" placeholder="Search suggestions..." type="text" />
                </div>
                <div className="pt-navbar-group pt-align-right">
                    <button className="pt-button pt-minimal pt-icon-home">Home</button>
                    <button className="pt-button pt-minimal pt-icon-document">My Suggestions</button>
                    <span className="pt-navbar-divider"></span>
                    <button className="pt-button pt-minimal pt-icon-notifications"></button>
                    <button className="pt-button pt-minimal pt-icon-user"></button>
                    <button className="pt-button pt-minimal pt-icon-cog"></button>
                </div>
            </nav>
        )
    }
};

export default Navigation;
