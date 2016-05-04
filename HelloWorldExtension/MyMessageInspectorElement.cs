using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Configuration;

namespace HelloWorldExtension
{
    /// <summary>
    /// Responsible for applying our WCF service extension class through configuration
    /// </summary>
    public class MyMessageInspectorElement : BehaviorExtensionElement
    {
        // Apply the extension through configuration
        // The BehaviorType property will tell the WCF runtime what type our extension behavior is, 
        // and the CreateBehavior method will tell the WCF runtime how to create the extension behavior class

        public override Type BehaviorType
        {
            get { return typeof(MyMessageInspectorBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new MyMessageInspectorBehavior();
        }
    }
}
