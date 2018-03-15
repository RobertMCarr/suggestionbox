import React, { Component } from 'react';
import CommentEntryBox from './CommentEntryBox'

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
        
        const rating = this.props.reponses.reduce(function(total, response) { 
            return total + response.rating;
        });
        
        return (
            <div>
                <div className="Suggestion_Title">{this.prop.title}</div>
                <div className="Datetime_Submitted">{this.prop.datetime_submitted}</div>
                <div className="Author">{this.prop.author}</div>
                <ul className="Tags">{metaTags}</ul>
                <div className="RatingButtonUp" onClick="() => this.handleRatingButtonClick(1)"/>
                <div className="RatingButtonDown" onClick="() => this.handleRatingButtonClick(-1)"/>
                <div className="Rating">{rating}</div>
                <CommentEntryBox />
                <ul className="Comments">{comments}</ul>
            </div>
        );
    }
};

export default Suggestion;