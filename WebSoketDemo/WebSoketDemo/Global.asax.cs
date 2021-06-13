using System.Web;
using System.Web.Http;
using WebSocketSharp.Server;
using WebSoketDemo.Behavior;

namespace WebSoketDemo
{
    public class WebApiApplication : HttpApplication
    {
        public static WebSocketServer WebSocketServer { get; private set; }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            WebSocketServer = new WebSocketServer(5000);
            WebSocketServer.AddWebSocketService<NotifyBehavior>("/notify");
            WebSocketServer.Start();
        }
    }
}
