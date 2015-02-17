var CommentPanel = React.createClass({

  getHub() {
    return this.props.conn.createHubProxy('commentHub');
  },

  handleCommentSubmit: function(comment) {  
    var hub = this.getHub();

    // perform optimistic update
    this.handleNewComment(comment);

    // send to socket
    hub.invoke('send', comment);
  },

  handleNewComment(comment) {  
    // read the current state  
    var comments = this.state.data,
        lastComment = comments[0],
        delta = comments.length - this.props.limit;
  
    // enforce display limit
    if (delta >= 0) {
      // truncate list
      comments.length = this.props.limit;
    }

    // add new new comment to the beginning of the list
    comments.unshift(comment);
  
    // update the current state
    this.setState({data: comments});
  },
  
  connectionStateChanged: function (state) {
    var stateConversion = {
      0: 'connecting', 
      1: 'connected', 
      2: 'reconnecting', 
      4: 'disconnected'
    };
    this.setState({connection: stateConversion[state.newState]});
  },

  getInitialState() {
    return {
      data: this.props.data,
      connection: ''
    };
  },
  
  componentDidMount() {
    var conn = this.props.conn;
  
    // check if we have access to a socket
    if (!conn) {
      return;
    }
  
    var hub = this.getHub(); 
  
    // listen for new data from the hub
    hub.on('newComment', this.handleNewComment);

    // listen for connection state changes
    conn.stateChanged(this.connectionStateChanged);

    // connect to the hub
    conn.start({ waitForPageLoad: false });
  },

  render() {
    return (
      <div className="panel panel-default comments">
        <PanelHeading>
          {this.props.title} <small>{this.state.connection}</small>
        </PanelHeading>
        <PanelBody>
          <strong>{this.props.body}</strong>
        </PanelBody>
        <CommentList data={this.state.data} />
        <PanelFooter>
          <CommentForm 
            author={this.props.author} 
            action={this.props.action} 
            onCommentSubmit={this.handleCommentSubmit} />
        </PanelFooter>
      </div>
    );
  }
});