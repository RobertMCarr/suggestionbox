import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Suggestion from './components/Suggestion';
import data from './mock-data/suggestions.json';

class App extends Component {
  constructor(props) {
    super(props);

    this.state = {
      suggestions: []//data.suggestions,
    };
  };

  render() {
    const suggestions = data.suggestions.map((suggestion) =>
        <Suggestion 
          title={suggestion.title}
          submitted={suggestion.datetime_submitted}
          author={suggestion.author}
          tags={suggestion.tags}
          responses={suggestion.responses}
        />
    );
    
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to React</h1>
        </header>
        <div>
          {suggestions}
        </div>
      </div>
    );
  }
}

export default App;
