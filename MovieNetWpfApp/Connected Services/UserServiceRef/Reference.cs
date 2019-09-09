﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieNetWpfApp.UserServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/MovieNetWcfService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameGetSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdGetSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameGetSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginGetSetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordGetSetField;
        
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
        public string FirstnameGetSet {
            get {
                return this.FirstnameGetSetField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameGetSetField, value) != true)) {
                    this.FirstnameGetSetField = value;
                    this.RaisePropertyChanged("FirstnameGetSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdGetSet {
            get {
                return this.IdGetSetField;
            }
            set {
                if ((this.IdGetSetField.Equals(value) != true)) {
                    this.IdGetSetField = value;
                    this.RaisePropertyChanged("IdGetSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastnameGetSet {
            get {
                return this.LastnameGetSetField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameGetSetField, value) != true)) {
                    this.LastnameGetSetField = value;
                    this.RaisePropertyChanged("LastnameGetSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LoginGetSet {
            get {
                return this.LoginGetSetField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginGetSetField, value) != true)) {
                    this.LoginGetSetField = value;
                    this.RaisePropertyChanged("LoginGetSet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PasswordGetSet {
            get {
                return this.PasswordGetSetField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordGetSetField, value) != true)) {
                    this.PasswordGetSetField = value;
                    this.RaisePropertyChanged("PasswordGetSet");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceRef.IUserServiceWCF")]
    public interface IUserServiceWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/GetUsers", ReplyAction="http://tempuri.org/IUserServiceWCF/GetUsersResponse")]
        MovieNetWpfApp.UserServiceRef.User[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/GetUsers", ReplyAction="http://tempuri.org/IUserServiceWCF/GetUsersResponse")]
        System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/GetUsersFind", ReplyAction="http://tempuri.org/IUserServiceWCF/GetUsersFindResponse")]
        MovieNetWpfApp.UserServiceRef.User[] GetUsersFind(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/GetUsersFind", ReplyAction="http://tempuri.org/IUserServiceWCF/GetUsersFindResponse")]
        System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User[]> GetUsersFindAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/CreateUser", ReplyAction="http://tempuri.org/IUserServiceWCF/CreateUserResponse")]
        bool CreateUser(string _Firstname, string _Lastname, string _Login, string _Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/CreateUser", ReplyAction="http://tempuri.org/IUserServiceWCF/CreateUserResponse")]
        System.Threading.Tasks.Task<bool> CreateUserAsync(string _Firstname, string _Lastname, string _Login, string _Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/DeleteUser", ReplyAction="http://tempuri.org/IUserServiceWCF/DeleteUserResponse")]
        bool DeleteUser(MovieNetWpfApp.UserServiceRef.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/DeleteUser", ReplyAction="http://tempuri.org/IUserServiceWCF/DeleteUserResponse")]
        System.Threading.Tasks.Task<bool> DeleteUserAsync(MovieNetWpfApp.UserServiceRef.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/UpdateUser", ReplyAction="http://tempuri.org/IUserServiceWCF/UpdateUserResponse")]
        bool UpdateUser(string _nom, string _prenom, string _login, string _password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/UpdateUser", ReplyAction="http://tempuri.org/IUserServiceWCF/UpdateUserResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserAsync(string _nom, string _prenom, string _login, string _password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/LoginUser", ReplyAction="http://tempuri.org/IUserServiceWCF/LoginUserResponse")]
        MovieNetWpfApp.UserServiceRef.User LoginUser(string _Login, string _Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/LoginUser", ReplyAction="http://tempuri.org/IUserServiceWCF/LoginUserResponse")]
        System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User> LoginUserAsync(string _Login, string _Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/GetUsersFindByLogin", ReplyAction="http://tempuri.org/IUserServiceWCF/GetUsersFindByLoginResponse")]
        MovieNetWpfApp.UserServiceRef.User[] GetUsersFindByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserServiceWCF/GetUsersFindByLogin", ReplyAction="http://tempuri.org/IUserServiceWCF/GetUsersFindByLoginResponse")]
        System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User[]> GetUsersFindByLoginAsync(string login);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceWCFChannel : MovieNetWpfApp.UserServiceRef.IUserServiceWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceWCFClient : System.ServiceModel.ClientBase<MovieNetWpfApp.UserServiceRef.IUserServiceWCF>, MovieNetWpfApp.UserServiceRef.IUserServiceWCF {
        
        public UserServiceWCFClient() {
        }
        
        public UserServiceWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MovieNetWpfApp.UserServiceRef.User[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public MovieNetWpfApp.UserServiceRef.User[] GetUsersFind(int id) {
            return base.Channel.GetUsersFind(id);
        }
        
        public System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User[]> GetUsersFindAsync(int id) {
            return base.Channel.GetUsersFindAsync(id);
        }
        
        public bool CreateUser(string _Firstname, string _Lastname, string _Login, string _Password) {
            return base.Channel.CreateUser(_Firstname, _Lastname, _Login, _Password);
        }
        
        public System.Threading.Tasks.Task<bool> CreateUserAsync(string _Firstname, string _Lastname, string _Login, string _Password) {
            return base.Channel.CreateUserAsync(_Firstname, _Lastname, _Login, _Password);
        }
        
        public bool DeleteUser(MovieNetWpfApp.UserServiceRef.User user) {
            return base.Channel.DeleteUser(user);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteUserAsync(MovieNetWpfApp.UserServiceRef.User user) {
            return base.Channel.DeleteUserAsync(user);
        }
        
        public bool UpdateUser(string _nom, string _prenom, string _login, string _password) {
            return base.Channel.UpdateUser(_nom, _prenom, _login, _password);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserAsync(string _nom, string _prenom, string _login, string _password) {
            return base.Channel.UpdateUserAsync(_nom, _prenom, _login, _password);
        }
        
        public MovieNetWpfApp.UserServiceRef.User LoginUser(string _Login, string _Password) {
            return base.Channel.LoginUser(_Login, _Password);
        }
        
        public System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User> LoginUserAsync(string _Login, string _Password) {
            return base.Channel.LoginUserAsync(_Login, _Password);
        }
        
        public MovieNetWpfApp.UserServiceRef.User[] GetUsersFindByLogin(string login) {
            return base.Channel.GetUsersFindByLogin(login);
        }
        
        public System.Threading.Tasks.Task<MovieNetWpfApp.UserServiceRef.User[]> GetUsersFindByLoginAsync(string login) {
            return base.Channel.GetUsersFindByLoginAsync(login);
        }
    }
}
