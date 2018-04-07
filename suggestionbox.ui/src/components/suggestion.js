import React, { Component } from 'react';
import { Text, TextArea } from "@blueprintjs/core";

class Suggestion extends Component {
    handleRatingButtonClick = (value) => {
        // TODO: call api to change rating.
    }

    render() {
        const comments = this.props.responses.map((response) =>
            <li key={response.user_id}>{response.comment}</li>
        );

        const tags = this.props.tags.map((tag) =>
            <span className="pt-tag pt-intent-primary">{tag}</span>
        );

        const rating = this.props.responses.reduce((total, response) => {
            return  total + response.rating 
        }, 0);
        
        return (
            <div className="Suggestion pt-dark">
            <Text >{this.props.title}</Text>
            <div className="Datetime_Submitted">{this.props.datetime_submitted}</div>
            <Text>{this.props.author}</Text>
            <p>{tags}</p>
            <div className="pt-button-group pt-vertical">
                <a className="pt-button pt-icon-arrow-up" role="button" tabindex="0" onClick={() => this.handleRatingButtonClick(1)}></a>
                <a className="pt_button pt-active" role="button" tabindex="0">{rating}</a>
                <a className="pt-button pt-icon-arrow-down" role="button" tabindex="0" nClick={() => this.handleRatingButtonClick(-1)}></a>
            </div>
            <TextArea value={comments}></TextArea>
            </div>
        );
    }
};

export default Suggestion;