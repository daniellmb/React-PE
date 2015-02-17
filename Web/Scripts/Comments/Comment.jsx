var Comment = React.createClass({
  render() {
    return (
    <li className="media">
      <div className="media-left"><img className="media-object" src={this.props.author} /></div>
      <div className="media-body">
        <p>{this.props.children}</p>
      </div>
    </li>
    );
  }
});