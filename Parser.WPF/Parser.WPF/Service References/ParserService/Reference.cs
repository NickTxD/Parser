﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Parser.WPF.ParserService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LiquidDTO", Namespace="http://schemas.datacontract.org/2004/07/Parser.DTO")]
    [System.SerializableAttribute()]
    public partial class LiquidDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AmountIndicatedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ArticleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AvailabilityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LinkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double[] StrengthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StrengthIndicatedField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((object.ReferenceEquals(this.AmountField, value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AmountIndicated {
            get {
                return this.AmountIndicatedField;
            }
            set {
                if ((this.AmountIndicatedField.Equals(value) != true)) {
                    this.AmountIndicatedField = value;
                    this.RaisePropertyChanged("AmountIndicated");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Article {
            get {
                return this.ArticleField;
            }
            set {
                if ((this.ArticleField.Equals(value) != true)) {
                    this.ArticleField = value;
                    this.RaisePropertyChanged("Article");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Availability {
            get {
                return this.AvailabilityField;
            }
            set {
                if ((this.AvailabilityField.Equals(value) != true)) {
                    this.AvailabilityField = value;
                    this.RaisePropertyChanged("Availability");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Link {
            get {
                return this.LinkField;
            }
            set {
                if ((object.ReferenceEquals(this.LinkField, value) != true)) {
                    this.LinkField = value;
                    this.RaisePropertyChanged("Link");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double[] Strength {
            get {
                return this.StrengthField;
            }
            set {
                if ((object.ReferenceEquals(this.StrengthField, value) != true)) {
                    this.StrengthField = value;
                    this.RaisePropertyChanged("Strength");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool StrengthIndicated {
            get {
                return this.StrengthIndicatedField;
            }
            set {
                if ((this.StrengthIndicatedField.Equals(value) != true)) {
                    this.StrengthIndicatedField = value;
                    this.RaisePropertyChanged("StrengthIndicated");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ParserService.IParserService")]
    public interface IParserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParserService/GetLiquids", ReplyAction="http://tempuri.org/IParserService/GetLiquidsResponse")]
        Parser.WPF.ParserService.LiquidDTO[] GetLiquids();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParserService/GetLiquids", ReplyAction="http://tempuri.org/IParserService/GetLiquidsResponse")]
        System.Threading.Tasks.Task<Parser.WPF.ParserService.LiquidDTO[]> GetLiquidsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IParserServiceChannel : Parser.WPF.ParserService.IParserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ParserServiceClient : System.ServiceModel.ClientBase<Parser.WPF.ParserService.IParserService>, Parser.WPF.ParserService.IParserService {
        
        public ParserServiceClient() {
        }
        
        public ParserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ParserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Parser.WPF.ParserService.LiquidDTO[] GetLiquids() {
            return base.Channel.GetLiquids();
        }
        
        public System.Threading.Tasks.Task<Parser.WPF.ParserService.LiquidDTO[]> GetLiquidsAsync() {
            return base.Channel.GetLiquidsAsync();
        }
    }
}