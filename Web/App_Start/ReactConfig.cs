using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Web.ReactConfig), "Configure")]

namespace Web
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			// ES6 features are enabled by default. Uncomment the below line to disable them.
			// See http://reactjs.net/guides/es6.html for more information.
			ReactSiteConfiguration.Configuration.SetUseHarmony(true);

			// Uncomment the below line if you are using Flow
			// See http://reactjs.net/guides/flow.html for more information.
			//ReactSiteConfiguration.Configuration.SetStripTypes(true);

            // If you want to use server-side rendering of React components, 
            // add all the necessary JavaScript files here. This includes 
            // your components as well as all of their dependencies.
            // See http://reactjs.net/ for more information.
            ReactSiteConfiguration.Configuration
                // global var mocks
                .AddScript("~/Scripts/mocks.js")
                // core
                .AddScript("~/Scripts/Core/Panel.jsx")
                .AddScript("~/Scripts/Core/PanelBody.jsx")
                .AddScript("~/Scripts/Core/PanelFooter.jsx")
                .AddScript("~/Scripts/Core/PanelHeading.jsx")
                // comments
                .AddScript("~/Scripts/Comments/Comment.jsx")
                .AddScript("~/Scripts/Comments/CommentForm.jsx")
                .AddScript("~/Scripts/Comments/CommentList.jsx")
                .AddScript("~/Scripts/Comments/CommentPanel.jsx");
		}
	}
}