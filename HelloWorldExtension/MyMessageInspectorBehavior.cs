using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Collections.ObjectModel;

namespace HelloWorldExtension
{
    /// <summary>
    /// Responsible for extending our WCF service extension class through behaviors
    /// The IServiceBehavior interface implementation is so that we can apply our extension behavior to the WCF runtime.
    /// The Attribute class inheritence is so that this extension behavior can be applied by using attributes in code.
    /// </summary>
    public class MyMessageInspectorBehavior : Attribute, IServiceBehavior
    {
        void IServiceBehavior.ApplyDispatchBehavior(ServiceDescription serviceDescription,ServiceHostBase serviceHostBase)
        {
            foreach (ChannelDispatcher cDispatcher in serviceHostBase.ChannelDispatchers)
            {
                foreach (EndpointDispatcher eDispatcher in cDispatcher.Endpoints)
                {
                    eDispatcher.DispatchRuntime.MessageInspectors.Add(new MyMessageInspector());
                }
            }
        }

        void IServiceBehavior.AddBindingParameters(ServiceDescription serviceDescription,ServiceHostBase serviceHostBase,Collection<ServiceEndpoint> endpoints,BindingParameterCollection bindingParameters)
        {
            //do nothing
        }

        void IServiceBehavior.Validate(ServiceDescription serviceDescription,ServiceHostBase serviceHostBase)
        {
            //do nothing
        }
    }
}
