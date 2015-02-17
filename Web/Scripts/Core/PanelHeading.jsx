var PanelHeading = React.createClass({
  render() {
    return (
    <div className="panel-heading">
    <h3 className="panel-title">
      {this.props.children}
    </h3>
    </div>
    );
  }
});