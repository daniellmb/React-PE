var Panel = React.createClass({
  render() {
    return (
      <div className="panel panel-default">
    <PanelHeading>
      {this.props.title}
    </PanelHeading>
    <PanelBody>
      <strong>{this.props.body}</strong>
    </PanelBody>
    <PanelFooter>
      {this.props.footer}
    </PanelFooter>
      </div>
    );
  }
});