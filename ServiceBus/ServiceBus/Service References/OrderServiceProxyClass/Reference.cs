﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceBus.OrderServiceProxyClass {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrderServiceProxyClass.IOrderService")]
    public interface IOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrder", ReplyAction="http://tempuri.org/IOrderService/GetOrderResponse")]
        SharedLibs.DataContracts.Order GetOrder(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetOrder", ReplyAction="http://tempuri.org/IOrderService/GetOrderResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Order> GetOrderAsync(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        SharedLibs.DataContracts.Orders GetAllOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/GetAllOrders", ReplyAction="http://tempuri.org/IOrderService/GetAllOrdersResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Orders> GetAllOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddOrder", ReplyAction="http://tempuri.org/IOrderService/AddOrderResponse")]
        SharedLibs.DataContracts.Result AddOrder(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime orderDate, System.DateTime deliveryDate, SharedLibs.DataContracts.OrderState orderState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddOrder", ReplyAction="http://tempuri.org/IOrderService/AddOrderResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> AddOrderAsync(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime orderDate, System.DateTime deliveryDate, SharedLibs.DataContracts.OrderState orderState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddOrderByObject", ReplyAction="http://tempuri.org/IOrderService/AddOrderByObjectResponse")]
        SharedLibs.DataContracts.Result AddOrderByObject(SharedLibs.DataContracts.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/AddOrderByObject", ReplyAction="http://tempuri.org/IOrderService/AddOrderByObjectResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> AddOrderByObjectAsync(SharedLibs.DataContracts.Order order);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/EditOrder", ReplyAction="http://tempuri.org/IOrderService/EditOrderResponse")]
        SharedLibs.DataContracts.Order EditOrder(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime deliveryDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/EditOrder", ReplyAction="http://tempuri.org/IOrderService/EditOrderResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Order> EditOrderAsync(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime deliveryDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ChangeOrderState", ReplyAction="http://tempuri.org/IOrderService/ChangeOrderStateResponse")]
        SharedLibs.DataContracts.Result ChangeOrderState(System.Guid guid, int newState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/ChangeOrderState", ReplyAction="http://tempuri.org/IOrderService/ChangeOrderStateResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> ChangeOrderStateAsync(System.Guid guid, int newState);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/DeleteOrder", ReplyAction="http://tempuri.org/IOrderService/DeleteOrderResponse")]
        SharedLibs.DataContracts.Result DeleteOrder(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/DeleteOrder", ReplyAction="http://tempuri.org/IOrderService/DeleteOrderResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> DeleteOrderAsync(System.Guid guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CreateEmail", ReplyAction="http://tempuri.org/IOrderService/CreateEmailResponse")]
        SharedLibs.DataContracts.Result CreateEmail(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CreateEmail", ReplyAction="http://tempuri.org/IOrderService/CreateEmailResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> CreateEmailAsync(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/SendEmail", ReplyAction="http://tempuri.org/IOrderService/SendEmailResponse")]
        SharedLibs.DataContracts.Result SendEmail(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/SendEmail", ReplyAction="http://tempuri.org/IOrderService/SendEmailResponse")]
        System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> SendEmailAsync(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CreatePDFDocument", ReplyAction="http://tempuri.org/IOrderService/CreatePDFDocumentResponse")]
        ServiceBus.OrderServiceProxyClass.CreatePDFDocumentResponse CreatePDFDocument(ServiceBus.OrderServiceProxyClass.CreatePDFDocumentRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrderService/CreatePDFDocument", ReplyAction="http://tempuri.org/IOrderService/CreatePDFDocumentResponse")]
        System.Threading.Tasks.Task<ServiceBus.OrderServiceProxyClass.CreatePDFDocumentResponse> CreatePDFDocumentAsync(ServiceBus.OrderServiceProxyClass.CreatePDFDocumentRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreatePDFDocument", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreatePDFDocumentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SharedLibs.DataContracts.User user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public SharedLibs.DataContracts.Order order;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public SharedLibs.Enums.PDFDocumentType documentType;
        
        public CreatePDFDocumentRequest() {
        }
        
        public CreatePDFDocumentRequest(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, SharedLibs.Enums.PDFDocumentType documentType) {
            this.user = user;
            this.order = order;
            this.documentType = documentType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreatePDFDocumentResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class CreatePDFDocumentResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public SharedLibs.DataContracts.Result CreatePDFDocumentResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string pdfFilePath;
        
        public CreatePDFDocumentResponse() {
        }
        
        public CreatePDFDocumentResponse(SharedLibs.DataContracts.Result CreatePDFDocumentResult, string pdfFilePath) {
            this.CreatePDFDocumentResult = CreatePDFDocumentResult;
            this.pdfFilePath = pdfFilePath;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrderServiceChannel : ServiceBus.OrderServiceProxyClass.IOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrderServiceClient : System.ServiceModel.ClientBase<ServiceBus.OrderServiceProxyClass.IOrderService>, ServiceBus.OrderServiceProxyClass.IOrderService {
        
        public OrderServiceClient() {
        }
        
        public OrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SharedLibs.DataContracts.Order GetOrder(System.Guid guid) {
            return base.Channel.GetOrder(guid);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Order> GetOrderAsync(System.Guid guid) {
            return base.Channel.GetOrderAsync(guid);
        }
        
        public SharedLibs.DataContracts.Orders GetAllOrders() {
            return base.Channel.GetAllOrders();
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Orders> GetAllOrdersAsync() {
            return base.Channel.GetAllOrdersAsync();
        }
        
        public SharedLibs.DataContracts.Result AddOrder(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime orderDate, System.DateTime deliveryDate, SharedLibs.DataContracts.OrderState orderState) {
            return base.Channel.AddOrder(guid, basket, user, deliveryAddress, billingInformation, orderDate, deliveryDate, orderState);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> AddOrderAsync(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime orderDate, System.DateTime deliveryDate, SharedLibs.DataContracts.OrderState orderState) {
            return base.Channel.AddOrderAsync(guid, basket, user, deliveryAddress, billingInformation, orderDate, deliveryDate, orderState);
        }
        
        public SharedLibs.DataContracts.Result AddOrderByObject(SharedLibs.DataContracts.Order order) {
            return base.Channel.AddOrderByObject(order);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> AddOrderByObjectAsync(SharedLibs.DataContracts.Order order) {
            return base.Channel.AddOrderByObjectAsync(order);
        }
        
        public SharedLibs.DataContracts.Order EditOrder(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime deliveryDate) {
            return base.Channel.EditOrder(guid, basket, user, deliveryAddress, billingInformation, deliveryDate);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Order> EditOrderAsync(System.Guid guid, SharedLibs.DataContracts.Basket basket, SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Address deliveryAddress, SharedLibs.DataContracts.BillingInformation billingInformation, System.DateTime deliveryDate) {
            return base.Channel.EditOrderAsync(guid, basket, user, deliveryAddress, billingInformation, deliveryDate);
        }
        
        public SharedLibs.DataContracts.Result ChangeOrderState(System.Guid guid, int newState) {
            return base.Channel.ChangeOrderState(guid, newState);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> ChangeOrderStateAsync(System.Guid guid, int newState) {
            return base.Channel.ChangeOrderStateAsync(guid, newState);
        }
        
        public SharedLibs.DataContracts.Result DeleteOrder(System.Guid guid) {
            return base.Channel.DeleteOrder(guid);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> DeleteOrderAsync(System.Guid guid) {
            return base.Channel.DeleteOrderAsync(guid);
        }
        
        public SharedLibs.DataContracts.Result CreateEmail(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment) {
            return base.Channel.CreateEmail(user, order, emailText, attachment);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> CreateEmailAsync(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment) {
            return base.Channel.CreateEmailAsync(user, order, emailText, attachment);
        }
        
        public SharedLibs.DataContracts.Result SendEmail(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment) {
            return base.Channel.SendEmail(user, order, emailText, attachment);
        }
        
        public System.Threading.Tasks.Task<SharedLibs.DataContracts.Result> SendEmailAsync(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, string emailText, string attachment) {
            return base.Channel.SendEmailAsync(user, order, emailText, attachment);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceBus.OrderServiceProxyClass.CreatePDFDocumentResponse ServiceBus.OrderServiceProxyClass.IOrderService.CreatePDFDocument(ServiceBus.OrderServiceProxyClass.CreatePDFDocumentRequest request) {
            return base.Channel.CreatePDFDocument(request);
        }
        
        public SharedLibs.DataContracts.Result CreatePDFDocument(SharedLibs.DataContracts.User user, SharedLibs.DataContracts.Order order, SharedLibs.Enums.PDFDocumentType documentType, out string pdfFilePath) {
            ServiceBus.OrderServiceProxyClass.CreatePDFDocumentRequest inValue = new ServiceBus.OrderServiceProxyClass.CreatePDFDocumentRequest();
            inValue.user = user;
            inValue.order = order;
            inValue.documentType = documentType;
            ServiceBus.OrderServiceProxyClass.CreatePDFDocumentResponse retVal = ((ServiceBus.OrderServiceProxyClass.IOrderService)(this)).CreatePDFDocument(inValue);
            pdfFilePath = retVal.pdfFilePath;
            return retVal.CreatePDFDocumentResult;
        }
        
        public System.Threading.Tasks.Task<ServiceBus.OrderServiceProxyClass.CreatePDFDocumentResponse> CreatePDFDocumentAsync(ServiceBus.OrderServiceProxyClass.CreatePDFDocumentRequest request) {
            return base.Channel.CreatePDFDocumentAsync(request);
        }
    }
}
