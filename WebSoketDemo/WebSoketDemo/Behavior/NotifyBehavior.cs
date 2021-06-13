using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSoketDemo.Behavior
{
    public class NotifyBehavior : WebSocketBehavior
    {
        protected override void OnOpen()
        {
            Send(JsonConvert.SerializeObject(new { message = "Open" }));
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            string msg = e.Data;
        }

        protected override void OnClose(CloseEventArgs e)
        {

        }

        protected override void OnError(ErrorEventArgs e)
        {

        }
    }
}
