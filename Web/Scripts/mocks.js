// this file contains mocks for global variables that are referenced by server-side code but ONLY needed client-side. For example SignalR.

// mock jQuery
var $ = jQuery = {};

// mock SignalR API
$.hubConnection = function() {};