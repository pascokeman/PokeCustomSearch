//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPLibrary.SPSites {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", ConfigurationName="SPSites.SitesSoap")]
    public interface SitesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetSite", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetSite(string SiteUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetSite", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetSiteAsync(string SiteUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetSiteTemplates", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SPLibrary.SPSites.GetSiteTemplatesResponse GetSiteTemplates(SPLibrary.SPSites.GetSiteTemplatesRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetSiteTemplates", ReplyAction="*")]
        System.Threading.Tasks.Task<SPLibrary.SPSites.GetSiteTemplatesResponse> GetSiteTemplatesAsync(SPLibrary.SPSites.GetSiteTemplatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetUpdatedFormDigest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetUpdatedFormDigest();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetUpdatedFormDigest", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetUpdatedFormDigestAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetUpdatedFormDigestInformation", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SPLibrary.SPSites.FormDigestInformation GetUpdatedFormDigestInformation(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/GetUpdatedFormDigestInformation", ReplyAction="*")]
        System.Threading.Tasks.Task<SPLibrary.SPSites.FormDigestInformation> GetUpdatedFormDigestInformationAsync(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/IsScriptSafeUrl", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool[] IsScriptSafeUrl(string[] urls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/IsScriptSafeUrl", ReplyAction="*")]
        System.Threading.Tasks.Task<bool[]> IsScriptSafeUrlAsync(string[] urls);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/ExportWeb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ExportWeb(string jobName, string webUrl, string dataPath, bool includeSubwebs, bool includeUserSecurity, bool overWrite, int cabSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/ExportWeb", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ExportWebAsync(string jobName, string webUrl, string dataPath, bool includeSubwebs, bool includeUserSecurity, bool overWrite, int cabSize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/ImportWeb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int ImportWeb(string jobName, string webUrl, string[] dataFiles, string logPath, bool includeUserSecurity, bool overWrite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/ImportWeb", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ImportWebAsync(string jobName, string webUrl, string[] dataFiles, string logPath, bool includeUserSecurity, bool overWrite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/ExportSolution", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string ExportSolution(string solutionFileName, string title, string description, bool fullReuseExportMode, bool includeWebContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/ExportSolution", ReplyAction="*")]
        System.Threading.Tasks.Task<string> ExportSolutionAsync(string solutionFileName, string title, string description, bool fullReuseExportMode, bool includeWebContent);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/CreateWeb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SPLibrary.SPSites.CreateWebResponseCreateWebResult CreateWeb(string url, string title, string description, string templateName, uint language, uint locale, uint collationLocale, bool uniquePermissions, bool anonymous, bool presence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/CreateWeb", ReplyAction="*")]
        System.Threading.Tasks.Task<SPLibrary.SPSites.CreateWebResponseCreateWebResult> CreateWebAsync(string url, string title, string description, string templateName, uint language, uint locale, uint collationLocale, bool uniquePermissions, bool anonymous, bool presence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/DeleteWeb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void DeleteWeb(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://schemas.microsoft.com/sharepoint/soap/DeleteWeb", ReplyAction="*")]
        System.Threading.Tasks.Task DeleteWebAsync(string url);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class Template : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string titleField;
        
        private string nameField;
        
        private bool isUniqueField;
        
        private bool isHiddenField;
        
        private string descriptionField;
        
        private string imageUrlField;
        
        private bool isCustomField;
        
        private bool isSubWebOnlyField;
        
        private bool isRootWebOnlyField;
        
        private string displayCategoryField;
        
        private string filterCategoriesField;
        
        private bool hasProvisionClassField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsUnique {
            get {
                return this.isUniqueField;
            }
            set {
                this.isUniqueField = value;
                this.RaisePropertyChanged("IsUnique");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsHidden {
            get {
                return this.isHiddenField;
            }
            set {
                this.isHiddenField = value;
                this.RaisePropertyChanged("IsHidden");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImageUrl {
            get {
                return this.imageUrlField;
            }
            set {
                this.imageUrlField = value;
                this.RaisePropertyChanged("ImageUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsCustom {
            get {
                return this.isCustomField;
            }
            set {
                this.isCustomField = value;
                this.RaisePropertyChanged("IsCustom");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsSubWebOnly {
            get {
                return this.isSubWebOnlyField;
            }
            set {
                this.isSubWebOnlyField = value;
                this.RaisePropertyChanged("IsSubWebOnly");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsRootWebOnly {
            get {
                return this.isRootWebOnlyField;
            }
            set {
                this.isRootWebOnlyField = value;
                this.RaisePropertyChanged("IsRootWebOnly");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisplayCategory {
            get {
                return this.displayCategoryField;
            }
            set {
                this.displayCategoryField = value;
                this.RaisePropertyChanged("DisplayCategory");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FilterCategories {
            get {
                return this.filterCategoriesField;
            }
            set {
                this.filterCategoriesField = value;
                this.RaisePropertyChanged("FilterCategories");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool HasProvisionClass {
            get {
                return this.hasProvisionClassField;
            }
            set {
                this.hasProvisionClassField = value;
                this.RaisePropertyChanged("HasProvisionClass");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class FormDigestInformation : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string digestValueField;
        
        private int timeoutSecondsField;
        
        private string webFullUrlField;
        
        private string libraryVersionField;
        
        private string supportedSchemaVersionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string DigestValue {
            get {
                return this.digestValueField;
            }
            set {
                this.digestValueField = value;
                this.RaisePropertyChanged("DigestValue");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int TimeoutSeconds {
            get {
                return this.timeoutSecondsField;
            }
            set {
                this.timeoutSecondsField = value;
                this.RaisePropertyChanged("TimeoutSeconds");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string WebFullUrl {
            get {
                return this.webFullUrlField;
            }
            set {
                this.webFullUrlField = value;
                this.RaisePropertyChanged("WebFullUrl");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string LibraryVersion {
            get {
                return this.libraryVersionField;
            }
            set {
                this.libraryVersionField = value;
                this.RaisePropertyChanged("LibraryVersion");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string SupportedSchemaVersions {
            get {
                return this.supportedSchemaVersionsField;
            }
            set {
                this.supportedSchemaVersionsField = value;
                this.RaisePropertyChanged("SupportedSchemaVersions");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSiteTemplates", WrapperNamespace="http://schemas.microsoft.com/sharepoint/soap/", IsWrapped=true)]
    public partial class GetSiteTemplatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=0)]
        public uint LCID;
        
        public GetSiteTemplatesRequest() {
        }
        
        public GetSiteTemplatesRequest(uint LCID) {
            this.LCID = LCID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetSiteTemplatesResponse", WrapperNamespace="http://schemas.microsoft.com/sharepoint/soap/", IsWrapped=true)]
    public partial class GetSiteTemplatesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=0)]
        public uint GetSiteTemplatesResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://schemas.microsoft.com/sharepoint/soap/", Order=1)]
        public SPLibrary.SPSites.Template[] TemplateList;
        
        public GetSiteTemplatesResponse() {
        }
        
        public GetSiteTemplatesResponse(uint GetSiteTemplatesResult, SPLibrary.SPSites.Template[] TemplateList) {
            this.GetSiteTemplatesResult = GetSiteTemplatesResult;
            this.TemplateList = TemplateList;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class CreateWebResponseCreateWebResult : object, System.ComponentModel.INotifyPropertyChanged {
        
        private CreateWebResponseCreateWebResultCreateWeb createWebField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CreateWebResponseCreateWebResultCreateWeb CreateWeb {
            get {
                return this.createWebField;
            }
            set {
                this.createWebField = value;
                this.RaisePropertyChanged("CreateWeb");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/sharepoint/soap/")]
    public partial class CreateWebResponseCreateWebResultCreateWeb : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string urlField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Url {
            get {
                return this.urlField;
            }
            set {
                this.urlField = value;
                this.RaisePropertyChanged("Url");
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
    public interface SitesSoapChannel : SPLibrary.SPSites.SitesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SitesSoapClient : System.ServiceModel.ClientBase<SPLibrary.SPSites.SitesSoap>, SPLibrary.SPSites.SitesSoap {
        
        public SitesSoapClient() {
        }
        
        public SitesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SitesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SitesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SitesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetSite(string SiteUrl) {
            return base.Channel.GetSite(SiteUrl);
        }
        
        public System.Threading.Tasks.Task<string> GetSiteAsync(string SiteUrl) {
            return base.Channel.GetSiteAsync(SiteUrl);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SPLibrary.SPSites.GetSiteTemplatesResponse SPLibrary.SPSites.SitesSoap.GetSiteTemplates(SPLibrary.SPSites.GetSiteTemplatesRequest request) {
            return base.Channel.GetSiteTemplates(request);
        }
        
        public uint GetSiteTemplates(uint LCID, out SPLibrary.SPSites.Template[] TemplateList) {
            SPLibrary.SPSites.GetSiteTemplatesRequest inValue = new SPLibrary.SPSites.GetSiteTemplatesRequest();
            inValue.LCID = LCID;
            SPLibrary.SPSites.GetSiteTemplatesResponse retVal = ((SPLibrary.SPSites.SitesSoap)(this)).GetSiteTemplates(inValue);
            TemplateList = retVal.TemplateList;
            return retVal.GetSiteTemplatesResult;
        }
        
        public System.Threading.Tasks.Task<SPLibrary.SPSites.GetSiteTemplatesResponse> GetSiteTemplatesAsync(SPLibrary.SPSites.GetSiteTemplatesRequest request) {
            return base.Channel.GetSiteTemplatesAsync(request);
        }
        
        public string GetUpdatedFormDigest() {
            return base.Channel.GetUpdatedFormDigest();
        }
        
        public System.Threading.Tasks.Task<string> GetUpdatedFormDigestAsync() {
            return base.Channel.GetUpdatedFormDigestAsync();
        }
        
        public SPLibrary.SPSites.FormDigestInformation GetUpdatedFormDigestInformation(string url) {
            return base.Channel.GetUpdatedFormDigestInformation(url);
        }
        
        public System.Threading.Tasks.Task<SPLibrary.SPSites.FormDigestInformation> GetUpdatedFormDigestInformationAsync(string url) {
            return base.Channel.GetUpdatedFormDigestInformationAsync(url);
        }
        
        public bool[] IsScriptSafeUrl(string[] urls) {
            return base.Channel.IsScriptSafeUrl(urls);
        }
        
        public System.Threading.Tasks.Task<bool[]> IsScriptSafeUrlAsync(string[] urls) {
            return base.Channel.IsScriptSafeUrlAsync(urls);
        }
        
        public int ExportWeb(string jobName, string webUrl, string dataPath, bool includeSubwebs, bool includeUserSecurity, bool overWrite, int cabSize) {
            return base.Channel.ExportWeb(jobName, webUrl, dataPath, includeSubwebs, includeUserSecurity, overWrite, cabSize);
        }
        
        public System.Threading.Tasks.Task<int> ExportWebAsync(string jobName, string webUrl, string dataPath, bool includeSubwebs, bool includeUserSecurity, bool overWrite, int cabSize) {
            return base.Channel.ExportWebAsync(jobName, webUrl, dataPath, includeSubwebs, includeUserSecurity, overWrite, cabSize);
        }
        
        public int ImportWeb(string jobName, string webUrl, string[] dataFiles, string logPath, bool includeUserSecurity, bool overWrite) {
            return base.Channel.ImportWeb(jobName, webUrl, dataFiles, logPath, includeUserSecurity, overWrite);
        }
        
        public System.Threading.Tasks.Task<int> ImportWebAsync(string jobName, string webUrl, string[] dataFiles, string logPath, bool includeUserSecurity, bool overWrite) {
            return base.Channel.ImportWebAsync(jobName, webUrl, dataFiles, logPath, includeUserSecurity, overWrite);
        }
        
        public string ExportSolution(string solutionFileName, string title, string description, bool fullReuseExportMode, bool includeWebContent) {
            return base.Channel.ExportSolution(solutionFileName, title, description, fullReuseExportMode, includeWebContent);
        }
        
        public System.Threading.Tasks.Task<string> ExportSolutionAsync(string solutionFileName, string title, string description, bool fullReuseExportMode, bool includeWebContent) {
            return base.Channel.ExportSolutionAsync(solutionFileName, title, description, fullReuseExportMode, includeWebContent);
        }
        
        public SPLibrary.SPSites.CreateWebResponseCreateWebResult CreateWeb(string url, string title, string description, string templateName, uint language, uint locale, uint collationLocale, bool uniquePermissions, bool anonymous, bool presence) {
            return base.Channel.CreateWeb(url, title, description, templateName, language, locale, collationLocale, uniquePermissions, anonymous, presence);
        }
        
        public System.Threading.Tasks.Task<SPLibrary.SPSites.CreateWebResponseCreateWebResult> CreateWebAsync(string url, string title, string description, string templateName, uint language, uint locale, uint collationLocale, bool uniquePermissions, bool anonymous, bool presence) {
            return base.Channel.CreateWebAsync(url, title, description, templateName, language, locale, collationLocale, uniquePermissions, anonymous, presence);
        }
        
        public void DeleteWeb(string url) {
            base.Channel.DeleteWeb(url);
        }
        
        public System.Threading.Tasks.Task DeleteWebAsync(string url) {
            return base.Channel.DeleteWebAsync(url);
        }
    }
}
