var CommentList = React.createClass({

  componentDidUpdate() {
    // scroll to the top of the list
  this.refs.list.getDOMNode().scrollTop = 0;
  },
  
  render() {
  
  // quick data check
  if (!this.props.data) {
    return;
  }
    
  var commentNodes = this.props.data.map(function (comment) {
      return (
        <Comment author={comment.Author}>
          {comment.Text}
        </Comment>
      );
    });

    return (
      <ul className="media-list" ref="list">
        {commentNodes}
      </ul>
    );
  }
});