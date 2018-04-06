import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import Suggestion from './components/Suggestion';
import data from './mock-data/suggestions.json';
import Navigation from './components/Navigation';

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
        <div>
          <Navigation />
          {suggestions}
        </div>
      </div>
    );
  }
}

export default App;
