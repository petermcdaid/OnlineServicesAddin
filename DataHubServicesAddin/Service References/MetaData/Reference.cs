﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataHubServicesAddin.MetaData {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DataSetMetaData", Namespace="http://datahub.esriuk.com/")]
    [System.SerializableAttribute()]
    public partial class DataSetMetaData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AbstractField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThumbnailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TermsAndConditionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailField;
        
        private bool IsPremiumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GazUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GazIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceTypeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Abstract {
            get {
                return this.AbstractField;
            }
            set {
                if ((object.ReferenceEquals(this.AbstractField, value) != true)) {
                    this.AbstractField = value;
                    this.RaisePropertyChanged("Abstract");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Thumbnail {
            get {
                return this.ThumbnailField;
            }
            set {
                if ((object.ReferenceEquals(this.ThumbnailField, value) != true)) {
                    this.ThumbnailField = value;
                    this.RaisePropertyChanged("Thumbnail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string TermsAndConditions {
            get {
                return this.TermsAndConditionsField;
            }
            set {
                if ((object.ReferenceEquals(this.TermsAndConditionsField, value) != true)) {
                    this.TermsAndConditionsField = value;
                    this.RaisePropertyChanged("TermsAndConditions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Detail {
            get {
                return this.DetailField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailField, value) != true)) {
                    this.DetailField = value;
                    this.RaisePropertyChanged("Detail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public bool IsPremium {
            get {
                return this.IsPremiumField;
            }
            set {
                if ((this.IsPremiumField.Equals(value) != true)) {
                    this.IsPremiumField = value;
                    this.RaisePropertyChanged("IsPremium");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Url {
            get {
                return this.UrlField;
            }
            set {
                if ((object.ReferenceEquals(this.UrlField, value) != true)) {
                    this.UrlField = value;
                    this.RaisePropertyChanged("Url");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string TokenUrl {
            get {
                return this.TokenUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenUrlField, value) != true)) {
                    this.TokenUrlField = value;
                    this.RaisePropertyChanged("TokenUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string GazUrl {
            get {
                return this.GazUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.GazUrlField, value) != true)) {
                    this.GazUrlField = value;
                    this.RaisePropertyChanged("GazUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string GazId {
            get {
                return this.GazIdField;
            }
            set {
                if ((object.ReferenceEquals(this.GazIdField, value) != true)) {
                    this.GazIdField = value;
                    this.RaisePropertyChanged("GazId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string ServiceType {
            get {
                return this.ServiceTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ServiceTypeField, value) != true)) {
                    this.ServiceTypeField = value;
                    this.RaisePropertyChanged("ServiceType");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://datahub.esriuk.com/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://datahub.esriuk.com/", ConfigurationName="MetaData.MetaDataSoap")]
    public interface MetaDataSoap {
        
        // CODEGEN: Generating message contract since element name ListDataSetsResult from namespace http://datahub.esriuk.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://datahub.esriuk.com/ListDataSets", ReplyAction="*")]
        DataHubServicesAddin.MetaData.ListDataSetsResponse ListDataSets(DataHubServicesAddin.MetaData.ListDataSetsRequest request);
        
        // CODEGEN: Generating message contract since element name inUsername from namespace http://datahub.esriuk.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://datahub.esriuk.com/ListSubscribedDataSets", ReplyAction="*")]
        DataHubServicesAddin.MetaData.ListSubscribedDataSetsResponse ListSubscribedDataSets(DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListDataSetsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListDataSets", Namespace="http://datahub.esriuk.com/", Order=0)]
        public DataHubServicesAddin.MetaData.ListDataSetsRequestBody Body;
        
        public ListDataSetsRequest() {
        }
        
        public ListDataSetsRequest(DataHubServicesAddin.MetaData.ListDataSetsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListDataSetsRequestBody {
        
        public ListDataSetsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListDataSetsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListDataSetsResponse", Namespace="http://datahub.esriuk.com/", Order=0)]
        public DataHubServicesAddin.MetaData.ListDataSetsResponseBody Body;
        
        public ListDataSetsResponse() {
        }
        
        public ListDataSetsResponse(DataHubServicesAddin.MetaData.ListDataSetsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://datahub.esriuk.com/")]
    public partial class ListDataSetsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DataHubServicesAddin.MetaData.DataSetMetaData[] ListDataSetsResult;
        
        public ListDataSetsResponseBody() {
        }
        
        public ListDataSetsResponseBody(DataHubServicesAddin.MetaData.DataSetMetaData[] ListDataSetsResult) {
            this.ListDataSetsResult = ListDataSetsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListSubscribedDataSetsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListSubscribedDataSets", Namespace="http://datahub.esriuk.com/", Order=0)]
        public DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequestBody Body;
        
        public ListSubscribedDataSetsRequest() {
        }
        
        public ListSubscribedDataSetsRequest(DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://datahub.esriuk.com/")]
    public partial class ListSubscribedDataSetsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string inUsername;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string inPassword;
        
        public ListSubscribedDataSetsRequestBody() {
        }
        
        public ListSubscribedDataSetsRequestBody(string inUsername, string inPassword) {
            this.inUsername = inUsername;
            this.inPassword = inPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListSubscribedDataSetsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListSubscribedDataSetsResponse", Namespace="http://datahub.esriuk.com/", Order=0)]
        public DataHubServicesAddin.MetaData.ListSubscribedDataSetsResponseBody Body;
        
        public ListSubscribedDataSetsResponse() {
        }
        
        public ListSubscribedDataSetsResponse(DataHubServicesAddin.MetaData.ListSubscribedDataSetsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://datahub.esriuk.com/")]
    public partial class ListSubscribedDataSetsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public DataHubServicesAddin.MetaData.ArrayOfString ListSubscribedDataSetsResult;
        
        public ListSubscribedDataSetsResponseBody() {
        }
        
        public ListSubscribedDataSetsResponseBody(DataHubServicesAddin.MetaData.ArrayOfString ListSubscribedDataSetsResult) {
            this.ListSubscribedDataSetsResult = ListSubscribedDataSetsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MetaDataSoapChannel : DataHubServicesAddin.MetaData.MetaDataSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MetaDataSoapClient : System.ServiceModel.ClientBase<DataHubServicesAddin.MetaData.MetaDataSoap>, DataHubServicesAddin.MetaData.MetaDataSoap {
        
        public MetaDataSoapClient() {
        }
        
        public MetaDataSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MetaDataSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetaDataSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MetaDataSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataHubServicesAddin.MetaData.ListDataSetsResponse DataHubServicesAddin.MetaData.MetaDataSoap.ListDataSets(DataHubServicesAddin.MetaData.ListDataSetsRequest request) {
            return base.Channel.ListDataSets(request);
        }
        
        public DataHubServicesAddin.MetaData.DataSetMetaData[] ListDataSets() {
            DataHubServicesAddin.MetaData.ListDataSetsRequest inValue = new DataHubServicesAddin.MetaData.ListDataSetsRequest();
            inValue.Body = new DataHubServicesAddin.MetaData.ListDataSetsRequestBody();
            DataHubServicesAddin.MetaData.ListDataSetsResponse retVal = ((DataHubServicesAddin.MetaData.MetaDataSoap)(this)).ListDataSets(inValue);
            return retVal.Body.ListDataSetsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataHubServicesAddin.MetaData.ListSubscribedDataSetsResponse DataHubServicesAddin.MetaData.MetaDataSoap.ListSubscribedDataSets(DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequest request) {
            return base.Channel.ListSubscribedDataSets(request);
        }
        
        public DataHubServicesAddin.MetaData.ArrayOfString ListSubscribedDataSets(string inUsername, string inPassword) {
            DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequest inValue = new DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequest();
            inValue.Body = new DataHubServicesAddin.MetaData.ListSubscribedDataSetsRequestBody();
            inValue.Body.inUsername = inUsername;
            inValue.Body.inPassword = inPassword;
            DataHubServicesAddin.MetaData.ListSubscribedDataSetsResponse retVal = ((DataHubServicesAddin.MetaData.MetaDataSoap)(this)).ListSubscribedDataSets(inValue);
            return retVal.Body.ListSubscribedDataSetsResult;
        }
    }
}