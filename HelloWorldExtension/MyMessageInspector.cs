using System;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Web.Hosting;

namespace HelloWorldExtension
{
    /// <summary>
    /// Extension Class responsible for logging incoming & outgoing messages
    /// See page: 351, chapter 12
    /// </summary>
    public class MyMessageInspector : IDispatchMessageInspector
    {

        /*
            Because the body of the request/reply message can only be processed once, here we have to pass a buffer of the original message to the
            TraceMessage method, create a new message from the buffer, and then return a new message to the original method, to ensure the original
            methods doe's not get affected. Also we make the AfterReceiveRequest method return null, because we don't need to correlate between the two
            methods (parameter correlationState in the BeforeSendReply method is the return result of the AfterReceiveRequest method).
        */

        private Message TraceMessage(MessageBuffer buffer)
        {
            // Here we are logging to a file. We might want to log to the
            // Windows event logs or a database depending.
            Message msg = buffer.CreateMessage();
            string appPath = HostingEnvironment.ApplicationPhysicalPath;
            string logPath = appPath + "\\log.txt";

            File.AppendAllText(logPath, DateTime.Now.ToString("G"));
            File.AppendAllText(logPath, "\r\n");
            File.AppendAllText(logPath, "HelloWorldService is invoked");
            File.AppendAllText(logPath, "\r\n");
            File.AppendAllText(logPath, $"Message={msg}");
            File.AppendAllText(logPath, "\r\n");

            return buffer.CreateMessage();
        }

        // inspector methods to inspect the outgoing and incoming messages. 
        // In this case, we just log the messages, but we can even modify the messages according to other requirements as necessary.

        public object AfterReceiveRequest(ref Message request, IClientChannel channel,InstanceContext instanceContext)
        {
            request = TraceMessage(request.CreateBufferedCopy(int.MaxValue));
            return null;
        }

        public void BeforeSendReply(ref Message reply, object correlationState)
        {
            reply = TraceMessage(reply.CreateBufferedCopy(int.MaxValue));
        }
    }
}
