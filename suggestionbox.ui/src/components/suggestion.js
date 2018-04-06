import React, { Component } from 'react';

class Suggestion extends Component {
    handleRatingButtonClick = (value) => {
        // TODO: call api to change rating.
    }

    render() {
        const metaTags = this.props.tags.map((tag) =>
            <li key={tag}>{tag}</li>
        );

        const comments = this.props.responses.map((response) =>
            <li key={response.user_id}>{response.comment}</li>
        );

        const rating = this.props.responses.reduce((total, response) => {
            return  total + response.rating 
        }, 0);
        
        return (
            <div className="Suggestion">
                <div className="Suggestion_Title">{this.props.title}</div>
                <div className="Datetime_Submitted">{this.props.datetime_submitted}</div>
                <div className="Author">{this.props.author}</div>
                <ul className="Tags">{metaTags}</ul>
                <div className="RatingButtonUp" onClick={() => this.handleRatingButtonClick(1)}/>
                <div className="RatingButtonDown" onClick={() => this.handleRatingButtonClick(-1)}/>
                <div className="Rating">{rating}</div>
                <ul className="Comments">{comments}</ul>
            </div>
        );
    }
};

export default Suggestion;