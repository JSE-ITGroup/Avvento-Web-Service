using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.Web;
using log4net;
using System.ServiceModel.Dispatcher;


namespace AvventoWebService.Helpers
{

    public class SvcErrorHandlerBehaviourAttribute : Attribute, IServiceBehavior
    {
        private readonly Type errorHandlerType;

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SvcErrorHandlerBehaviourAttribute (Type errorHandlerType)
        {
            this.errorHandlerType = errorHandlerType;
        }
        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        { } //implementation not needed

        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints,
                                         BindingParameterCollection bindingParameters)
        { } //implementation not needed

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            IErrorHandler handler = (IErrorHandler) Activator.CreateInstance(this.errorHandlerType);

            foreach (ChannelDispatcherBase chanDispBase in serviceHostBase.ChannelDispatchers)
            {
                ChannelDispatcher channelDispatcher = chanDispBase as ChannelDispatcher;
                if (channelDispatcher != null) channelDispatcher.ErrorHandlers.Add(handler);
            }
        }
    }

    public class SvcErrorHandler : IErrorHandler
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public bool HandleError(Exception error)
        {
            //You can log th message if you want.
            log.Error(error);
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message msg)
        {
            if (error is FaultException)
                return;

            FaultException faultException = new FaultException(error.Message);
            MessageFault messageFault = faultException.CreateMessageFault();
            msg = Message.CreateMessage(version, messageFault, faultException.Action);
        }
    }
}