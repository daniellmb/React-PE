var CommentForm = React.createClass({
 
  handleSubmit(e) {
  // don't submit the page
    e.preventDefault();

  // read values from the DOM (& fake authenticated user avatar)
  var text = this.refs.text.getDOMNode().value.trim();

  // quick data sanity check
    if (!text) {
      return;
    }

  // notify parent commonent there is new data
    this.props.onCommentSubmit({Author: this.props.author, Text: text});

  // clear the message text field
    this.refs.text.getDOMNode().value = '';
  },

  render() {
    return (
    <form role="form" onSubmit={this.handleSubmit} method="post" action={this.props.action}>
      <div className="input-group">
      <input type="hidden" name="author" value={this.props.author} />
      <input type="text" 
        ref="text" 
        name="text" 
        autoComplete="off"
        className="form-control" 
        placeholder="Chime in..." />
      <span className="input-group-btn">
        <button className="btn btn-default" type="submit">Say</button>
      </span>
    </div>
      </form>
    );
  }
});