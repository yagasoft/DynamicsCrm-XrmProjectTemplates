using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]
namespace Xrm.Framework.Test.Unit
{

	/// <summary>
	/// Assembly that contains one or more plug-in types.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("pluginassembly")]
	public partial class PluginAssembly : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public PluginAssembly() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "pluginassembly";
		
		public const int EntityTypeCode = 4605;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.PluginAssemblyId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Bytes of the assembly, in Base64 format.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
		public string Content
		{
			get
			{
				return this.GetAttributeValue<string>("content");
			}
			set
			{
				this.OnPropertyChanging("Content");
				this.SetAttributeValue("content", value);
				this.OnPropertyChanged("Content");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in assembly was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the pluginassembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Culture code for the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("culture")]
		public string Culture
		{
			get
			{
				return this.GetAttributeValue<string>("culture");
			}
			set
			{
				this.OnPropertyChanging("Culture");
				this.SetAttributeValue("culture", value);
				this.OnPropertyChanged("Culture");
			}
		}
		
		/// <summary>
		/// Customization Level.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Description of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			set
			{
				this.OnPropertyChanging("IsHidden");
				this.SetAttributeValue("ishidden", value);
				this.OnPropertyChanged("IsHidden");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isolationmode")]
		public Microsoft.Xrm.Sdk.OptionSetValue IsolationMode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("isolationmode");
			}
			set
			{
				this.OnPropertyChanging("IsolationMode");
				this.SetAttributeValue("isolationmode", value);
				this.OnPropertyChanged("IsolationMode");
			}
		}
		
		/// <summary>
		/// Major of the assembly version.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("major")]
		public System.Nullable<int> Major
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("major");
			}
		}
		
		/// <summary>
		/// Minor of the assembly version.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minor")]
		public System.Nullable<int> Minor
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("minor");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in assembly was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the pluginassembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the plug-in assembly is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// File name of the plug-in assembly. Used when the source type is set to 1.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("path")]
		public string Path
		{
			get
			{
				return this.GetAttributeValue<string>("path");
			}
			set
			{
				this.OnPropertyChanging("Path");
				this.SetAttributeValue("path", value);
				this.OnPropertyChanged("Path");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
		public System.Nullable<System.Guid> PluginAssemblyId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyid");
			}
			set
			{
				this.OnPropertyChanging("PluginAssemblyId");
				this.SetAttributeValue("pluginassemblyid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PluginAssemblyId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyidunique")]
		public System.Nullable<System.Guid> PluginAssemblyIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyidunique");
			}
		}
		
		/// <summary>
		/// Public key token of the assembly. This value can be obtained from the assembly by using reflection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publickeytoken")]
		public string PublicKeyToken
		{
			get
			{
				return this.GetAttributeValue<string>("publickeytoken");
			}
			set
			{
				this.OnPropertyChanging("PublicKeyToken");
				this.SetAttributeValue("publickeytoken", value);
				this.OnPropertyChanged("PublicKeyToken");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Hash of the source of the assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcehash")]
		public string SourceHash
		{
			get
			{
				return this.GetAttributeValue<string>("sourcehash");
			}
			set
			{
				this.OnPropertyChanging("SourceHash");
				this.SetAttributeValue("sourcehash", value);
				this.OnPropertyChanged("SourceHash");
			}
		}
		
		/// <summary>
		/// Location of the assembly, for example 0=database, 1=on-disk.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue SourceType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("sourcetype");
			}
			set
			{
				this.OnPropertyChanging("SourceType");
				this.SetAttributeValue("sourcetype", value);
				this.OnPropertyChanged("SourceType");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Version number of the assembly. The value can be obtained from the assembly through reflection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public string Version
		{
			get
			{
				return this.GetAttributeValue<string>("version");
			}
			set
			{
				this.OnPropertyChanging("Version");
				this.SetAttributeValue("version", value);
				this.OnPropertyChanged("Version");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N pluginassembly_plugintype
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
		public System.Collections.Generic.IEnumerable<PluginType> pluginassembly_plugintype
		{
			get
			{
				return this.GetRelatedEntities<PluginType>("pluginassembly_plugintype", null);
			}
			set
			{
				this.OnPropertyChanging("pluginassembly_plugintype");
				this.SetRelatedEntities<PluginType>("pluginassembly_plugintype", null, value);
				this.OnPropertyChanged("pluginassembly_plugintype");
			}
		}
	}
	public class PluginAssemblyEnums
		{
			[DataContractAttribute]
			public enum ComponentState 
			{
				[EnumMemberAttribute]Published = 0,
				[EnumMemberAttribute]Unpublished = 1,
				[EnumMemberAttribute]Deleted = 2,
				[EnumMemberAttribute]DeletedUnpublished = 3,
			}		
			[DataContractAttribute]
			public enum IsolationMode 
			{
				[EnumMemberAttribute]None = 1,
				[EnumMemberAttribute]Sandbox = 2,
			}		
			[DataContractAttribute]
			public enum SourceType 
			{
				[EnumMemberAttribute]Database = 0,
				[EnumMemberAttribute]Disk = 1,
				[EnumMemberAttribute]Normal = 2,
			}		
		}
		public class PluginAssemblyFields
		{
			public const string SchemaName = "pluginassembly";
			
			public const string ComponentState = "componentstate";
			public const string Content = "content";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string Culture = "culture";
			public const string CustomizationLevel = "customizationlevel";
			public const string Description = "description";
			public const string IntroducedVersion = "introducedversion";
			public const string IsHidden = "ishidden";
			public const string IsManaged = "ismanaged";
			public const string IsolationMode = "isolationmode";
			public const string Major = "major";
			public const string Minor = "minor";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverwriteTime = "overwritetime";
			public const string Path = "path";
			public const string PluginAssemblyId = "pluginassemblyid";
			public const string PluginAssemblyIdUnique = "pluginassemblyidunique";
			public const string PublicKeyToken = "publickeytoken";
			public const string SolutionId = "solutionid";
			public const string SourceHash = "sourcehash";
			public const string SourceType = "sourcetype";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string Version = "version";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// Type that inherits from the IPlugin interface and is contained within a plug-in assembly.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("plugintype")]
	public partial class PluginType : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public PluginType() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "plugintype";
		
		public const int EntityTypeCode = 4602;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.PluginTypeId = value;
			}
		}
		
		/// <summary>
		/// Full path name of the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assemblyname")]
		public string AssemblyName
		{
			get
			{
				return this.GetAttributeValue<string>("assemblyname");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in type was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the plugintype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Culture code for the plug-in assembly.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("culture")]
		public string Culture
		{
			get
			{
				return this.GetAttributeValue<string>("culture");
			}
		}
		
		/// <summary>
		/// Customization level of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Serialized Custom Activity Type information, including required arguments. For more information, see SandboxCustomActivityInfo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customworkflowactivityinfo")]
		public string CustomWorkflowActivityInfo
		{
			get
			{
				return this.GetAttributeValue<string>("customworkflowactivityinfo");
			}
		}
		
		/// <summary>
		/// Description of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// User friendly name for the plug-in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
		public string FriendlyName
		{
			get
			{
				return this.GetAttributeValue<string>("friendlyname");
			}
			set
			{
				this.OnPropertyChanging("FriendlyName");
				this.SetAttributeValue("friendlyname", value);
				this.OnPropertyChanged("FriendlyName");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Indicates if the plug-in is a custom activity for workflows.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowactivity")]
		public System.Nullable<bool> IsWorkflowActivity
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isworkflowactivity");
			}
		}
		
		/// <summary>
		/// Major of the version number of the assembly for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("major")]
		public System.Nullable<int> Major
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("major");
			}
		}
		
		/// <summary>
		/// Minor of the version number of the assembly for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minor")]
		public System.Nullable<int> Minor
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("minor");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in type was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the plugintype.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the plug-in type is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in assembly that contains this plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
		public Microsoft.Xrm.Sdk.EntityReference PluginAssemblyId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pluginassemblyid");
			}
			set
			{
				this.OnPropertyChanging("PluginAssemblyId");
				this.SetAttributeValue("pluginassemblyid", value);
				this.OnPropertyChanged("PluginAssemblyId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		public System.Nullable<System.Guid> PluginTypeId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypeid");
			}
			set
			{
				this.OnPropertyChanging("PluginTypeId");
				this.SetAttributeValue("plugintypeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PluginTypeId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeidunique")]
		public System.Nullable<System.Guid> PluginTypeIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypeidunique");
			}
		}
		
		/// <summary>
		/// Public key token of the assembly for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publickeytoken")]
		public string PublicKeyToken
		{
			get
			{
				return this.GetAttributeValue<string>("publickeytoken");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Fully qualified type name of the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("typename")]
		public string TypeName
		{
			get
			{
				return this.GetAttributeValue<string>("typename");
			}
			set
			{
				this.OnPropertyChanging("TypeName");
				this.SetAttributeValue("typename", value);
				this.OnPropertyChanged("TypeName");
			}
		}
		
		/// <summary>
		/// Version number of the assembly for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
		public string Version
		{
			get
			{
				return this.GetAttributeValue<string>("version");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Group name of workflow custom activity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowactivitygroupname")]
		public string WorkflowActivityGroupName
		{
			get
			{
				return this.GetAttributeValue<string>("workflowactivitygroupname");
			}
			set
			{
				this.OnPropertyChanging("WorkflowActivityGroupName");
				this.SetAttributeValue("workflowactivitygroupname", value);
				this.OnPropertyChanged("WorkflowActivityGroupName");
			}
		}
		
		/// <summary>
		/// 1:N plugintype_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> plugintype_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("plugintype_sdkmessageprocessingstep");
				this.SetRelatedEntities<SdkMessageProcessingStep>("plugintype_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("plugintype_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// 1:N plugintype_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_plugintypestatistic")]
		public System.Collections.Generic.IEnumerable<PluginTypeStatistic> plugintype_plugintypestatistic
		{
			get
			{
				return this.GetRelatedEntities<PluginTypeStatistic>("plugintype_plugintypestatistic", null);
			}
			set
			{
				this.OnPropertyChanging("plugintype_plugintypestatistic");
				this.SetRelatedEntities<PluginTypeStatistic>("plugintype_plugintypestatistic", null, value);
				this.OnPropertyChanged("plugintype_plugintypestatistic");
			}
		}
		
		/// <summary>
		/// 1:N plugintypeid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintypeid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> plugintypeid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
				this.SetRelatedEntities<SdkMessageProcessingStep>("plugintypeid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 pluginassembly_plugintype
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
		public PluginAssembly pluginassembly_plugintype
		{
			get
			{
				return this.GetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", null);
			}
			set
			{
				this.OnPropertyChanging("pluginassembly_plugintype");
				this.SetRelatedEntity<PluginAssembly>("pluginassembly_plugintype", null, value);
				this.OnPropertyChanged("pluginassembly_plugintype");
			}
		}
	}
	public class PluginTypeEnums
		{
			[DataContractAttribute]
			public enum ComponentState 
			{
				[EnumMemberAttribute]Published = 0,
				[EnumMemberAttribute]Unpublished = 1,
				[EnumMemberAttribute]Deleted = 2,
				[EnumMemberAttribute]DeletedUnpublished = 3,
			}		
		}
		public class PluginTypeFields
		{
			public const string SchemaName = "plugintype";
			
			public const string AssemblyName = "assemblyname";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string Culture = "culture";
			public const string CustomizationLevel = "customizationlevel";
			public const string CustomWorkflowActivityInfo = "customworkflowactivityinfo";
			public const string Description = "description";
			public const string FriendlyName = "friendlyname";
			public const string IsManaged = "ismanaged";
			public const string IsWorkflowActivity = "isworkflowactivity";
			public const string Major = "major";
			public const string Minor = "minor";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverwriteTime = "overwritetime";
			public const string PluginAssemblyId = "pluginassemblyid";
			public const string PluginAssemblyIdName = "pluginassemblyidName";
			public const string PluginTypeId = "plugintypeid";
			public const string PluginTypeIdUnique = "plugintypeidunique";
			public const string PublicKeyToken = "publickeytoken";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string TypeName = "typename";
			public const string Version = "version";
			public const string VersionNumber = "versionnumber";
			public const string WorkflowActivityGroupName = "workflowactivitygroupname";
		}

	/// <summary>
	/// Plug-in type statistic.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("plugintypestatistic")]
	public partial class PluginTypeStatistic : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public PluginTypeStatistic() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "plugintypestatistic";
		
		public const int EntityTypeCode = 4603;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypestatisticid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				base.Id = value;
			}
		}
		
		/// <summary>
		/// The average execution time (in milliseconds) for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("averageexecutetimeinmilliseconds")]
		public System.Nullable<int> AverageExecuteTimeInMilliseconds
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("averageexecutetimeinmilliseconds");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to crashes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashcontributionpercent")]
		public System.Nullable<int> CrashContributionPercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crashcontributionpercent");
			}
		}
		
		/// <summary>
		/// Number of times the plug-in type has crashed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashcount")]
		public System.Nullable<int> CrashCount
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crashcount");
			}
		}
		
		/// <summary>
		/// Percentage of crashes for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashpercent")]
		public System.Nullable<int> CrashPercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("crashpercent");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in type statistic was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Number of times the plug-in type has been executed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executecount")]
		public System.Nullable<int> ExecuteCount
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("executecount");
			}
		}
		
		/// <summary>
		/// Number of times the plug-in type has failed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
		public System.Nullable<int> FailureCount
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("failurecount");
			}
		}
		
		/// <summary>
		/// Percentage of failures for the plug-in type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurepercent")]
		public System.Nullable<int> FailurePercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("failurepercent");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the plug-in type statistic was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the plug-in type statistic is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type associated with this plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type statistic.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypestatisticid")]
		public System.Nullable<System.Guid> PluginTypeStatisticId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypestatisticid");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to excessive CPU usage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatecpucontributionpercent")]
		public System.Nullable<int> TerminateCpuContributionPercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminatecpucontributionpercent");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to excessive handle usage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatehandlescontributionpercent")]
		public System.Nullable<int> TerminateHandlesContributionPercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminatehandlescontributionpercent");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to excessive memory usage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatememorycontributionpercent")]
		public System.Nullable<int> TerminateMemoryContributionPercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminatememorycontributionpercent");
			}
		}
		
		/// <summary>
		/// The plug-in type percentage contribution to Worker process termination due to unknown reasons.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminateothercontributionpercent")]
		public System.Nullable<int> TerminateOtherContributionPercent
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("terminateothercontributionpercent");
			}
		}
		
		/// <summary>
		/// N:1 plugintype_plugintypestatistic
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_plugintypestatistic")]
		public PluginType plugintype_plugintypestatistic
		{
			get
			{
				return this.GetRelatedEntity<PluginType>("plugintype_plugintypestatistic", null);
			}
		}
	}
	public class PluginTypeStatisticEnums
		{
		}
		public class PluginTypeStatisticFields
		{
			public const string SchemaName = "plugintypestatistic";
			
			public const string AverageExecuteTimeInMilliseconds = "averageexecutetimeinmilliseconds";
			public const string CrashContributionPercent = "crashcontributionpercent";
			public const string CrashCount = "crashcount";
			public const string CrashPercent = "crashpercent";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string ExecuteCount = "executecount";
			public const string FailureCount = "failurecount";
			public const string FailurePercent = "failurepercent";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string PluginTypeId = "plugintypeid";
			public const string PluginTypeIdName = "plugintypeidName";
			public const string PluginTypeStatisticId = "plugintypestatisticid";
			public const string TerminateCpuContributionPercent = "terminatecpucontributionpercent";
			public const string TerminateHandlesContributionPercent = "terminatehandlescontributionpercent";
			public const string TerminateMemoryContributionPercent = "terminatememorycontributionpercent";
			public const string TerminateOtherContributionPercent = "terminateothercontributionpercent";
		}

	/// <summary>
	/// Message that is supported by the SDK.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessage")]
	public partial class SdkMessage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessage";
		
		public const int EntityTypeCode = 4606;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageId = value;
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is automatically transacted.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("autotransact")]
		public System.Nullable<bool> AutoTransact
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("autotransact");
			}
			set
			{
				this.OnPropertyChanging("AutoTransact");
				this.SetAttributeValue("autotransact", value);
				this.OnPropertyChanged("AutoTransact");
			}
		}
		
		/// <summary>
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> Availability
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("availability");
			}
			set
			{
				this.OnPropertyChanging("Availability");
				this.SetAttributeValue("availability", value);
				this.OnPropertyChanged("Availability");
			}
		}
		
		/// <summary>
		/// If this is a categorized method, this is the name, otherwise None.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("categoryname")]
		public string CategoryName
		{
			get
			{
				return this.GetAttributeValue<string>("categoryname");
			}
			set
			{
				this.OnPropertyChanging("CategoryName");
				this.SetAttributeValue("categoryname", value);
				this.OnPropertyChanged("CategoryName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expand")]
		public System.Nullable<bool> Expand
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("expand");
			}
			set
			{
				this.OnPropertyChanging("Expand");
				this.SetAttributeValue("expand", value);
				this.OnPropertyChanged("Expand");
			}
		}
		
		/// <summary>
		/// Information about whether the SDK message is active.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactive")]
		public System.Nullable<bool> IsActive
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isactive");
			}
			set
			{
				this.OnPropertyChanging("IsActive");
				this.SetAttributeValue("isactive", value);
				this.OnPropertyChanged("IsActive");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is private.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
		public System.Nullable<bool> IsPrivate
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isprivate");
			}
			set
			{
				this.OnPropertyChanging("IsPrivate");
				this.SetAttributeValue("isprivate", value);
				this.OnPropertyChanged("IsPrivate");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidforexecuteasync")]
		public System.Nullable<bool> IsValidForExecuteAsync
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvalidforexecuteasync");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public System.Nullable<System.Guid> SdkMessageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageId");
				this.SetAttributeValue("sdkmessageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageidunique")]
		public System.Nullable<System.Guid> SdkMessageIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageidunique");
			}
		}
		
		/// <summary>
		/// Indicates whether the SDK message is a template.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("template")]
		public System.Nullable<bool> Template
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("template");
			}
			set
			{
				this.OnPropertyChanging("Template");
				this.SetAttributeValue("template", value);
				this.OnPropertyChanged("Template");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("throttlesettings")]
		public string ThrottleSettings
		{
			get
			{
				return this.GetAttributeValue<string>("throttlesettings");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message. 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageid_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
		public System.Collections.Generic.IEnumerable<SdkMessageFilter> sdkmessageid_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
				this.SetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
			}
		}
		
		/// <summary>
		/// 1:N message_sdkmessagepair
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("message_sdkmessagepair")]
		public System.Collections.Generic.IEnumerable<SdkMessagePair> message_sdkmessagepair
		{
			get
			{
				return this.GetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null);
			}
			set
			{
				this.OnPropertyChanging("message_sdkmessagepair");
				this.SetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null, value);
				this.OnPropertyChanged("message_sdkmessagepair");
			}
		}
	}
	public class SdkMessageEnums
		{
		}
		public class SdkMessageFields
		{
			public const string SchemaName = "sdkmessage";
			
			public const string AutoTransact = "autotransact";
			public const string Availability = "availability";
			public const string CategoryName = "categoryname";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string Expand = "expand";
			public const string IsActive = "isactive";
			public const string IsPrivate = "isprivate";
			public const string IsValidForExecuteAsync = "isvalidforexecuteasync";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string SdkMessageId = "sdkmessageid";
			public const string SdkMessageIdUnique = "sdkmessageidunique";
			public const string Template = "template";
			public const string ThrottleSettings = "throttlesettings";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// Filter that defines which SDK messages are valid for each type of entity.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagefilter")]
	public partial class SdkMessageFilter : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageFilter() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagefilter";
		
		public const int EntityTypeCode = 4607;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageFilterId = value;
			}
		}
		
		/// <summary>
		/// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
		public System.Nullable<int> Availability
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("availability");
			}
			set
			{
				this.OnPropertyChanging("Availability");
				this.SetAttributeValue("availability", value);
				this.OnPropertyChanged("Availability");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message filter was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagefilter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Indicates whether a custom SDK message processing step is allowed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomprocessingstepallowed")]
		public System.Nullable<bool> IsCustomProcessingStepAllowed
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscustomprocessingstepallowed");
			}
			set
			{
				this.OnPropertyChanging("IsCustomProcessingStepAllowed");
				this.SetAttributeValue("iscustomprocessingstepallowed", value);
				this.OnPropertyChanged("IsCustomProcessingStepAllowed");
			}
		}
		
		/// <summary>
		/// Indicates whether the filter should be visible.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
		public System.Nullable<bool> IsVisible
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isvisible");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message filter was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagefilter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message filter is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK message filter is primarily associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryobjecttypecode")]
		public string PrimaryObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("primaryobjecttypecode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public System.Nullable<System.Guid> SdkMessageFilterId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilterid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageFilterId");
				this.SetAttributeValue("sdkmessagefilterid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageFilterId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilteridunique")]
		public System.Nullable<System.Guid> SdkMessageFilterIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilteridunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the related SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageId");
				this.SetAttributeValue("sdkmessageid", value);
				this.OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK message filter is secondarily associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondaryobjecttypecode")]
		public string SecondaryObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("secondaryobjecttypecode");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessagefilterid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
				this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageid_sdkmessagefilter
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
		public SdkMessage sdkmessageid_sdkmessagefilter
		{
			get
			{
				return this.GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
				this.SetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessagefilter", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
			}
		}
	}
	public class SdkMessageFilterEnums
		{
		}
		public class SdkMessageFilterFields
		{
			public const string SchemaName = "sdkmessagefilter";
			
			public const string Availability = "availability";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string IsCustomProcessingStepAllowed = "iscustomprocessingstepallowed";
			public const string IsVisible = "isvisible";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string PrimaryObjectTypeCode = "primaryobjecttypecode";
			public const string SdkMessageFilterId = "sdkmessagefilterid";
			public const string SdkMessageFilterIdUnique = "sdkmessagefilteridunique";
			public const string SdkMessageId = "sdkmessageid";
			public const string SdkMessageIdName = "sdkmessageidName";
			public const string SecondaryObjectTypeCode = "secondaryobjecttypecode";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagepair")]
	public partial class SdkMessagePair : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessagePair() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagepair";
		
		public const int EntityTypeCode = 4613;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessagePairId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message pair.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message pair was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagepair.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Endpoint that the message pair is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endpoint")]
		public string Endpoint
		{
			get
			{
				return this.GetAttributeValue<string>("endpoint");
			}
			set
			{
				this.OnPropertyChanging("Endpoint");
				this.SetAttributeValue("endpoint", value);
				this.OnPropertyChanged("Endpoint");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message pair.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message pair was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagepair.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Namespace that the message pair is associated with.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("namespace")]
		public string Namespace
		{
			get
			{
				return this.GetAttributeValue<string>("namespace");
			}
			set
			{
				this.OnPropertyChanging("Namespace");
				this.SetAttributeValue("namespace", value);
				this.OnPropertyChanged("Namespace");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message pair is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message with which the SDK message pair is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message pair entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
		public System.Nullable<System.Guid> SdkMessagePairId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagepairid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessagePairId");
				this.SetAttributeValue("sdkmessagepairid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessagePairId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message pair.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairidunique")]
		public System.Nullable<System.Guid> SdkMessagePairIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagepairidunique");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N messagepair_sdkmessagerequest
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagepair_sdkmessagerequest")]
		public System.Collections.Generic.IEnumerable<SdkMessageRequest> messagepair_sdkmessagerequest
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null);
			}
			set
			{
				this.OnPropertyChanging("messagepair_sdkmessagerequest");
				this.SetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null, value);
				this.OnPropertyChanged("messagepair_sdkmessagerequest");
			}
		}
		
		/// <summary>
		/// N:1 message_sdkmessagepair
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("message_sdkmessagepair")]
		public SdkMessage message_sdkmessagepair
		{
			get
			{
				return this.GetRelatedEntity<SdkMessage>("message_sdkmessagepair", null);
			}
		}
	}
	public class SdkMessagePairEnums
		{
		}
		public class SdkMessagePairFields
		{
			public const string SchemaName = "sdkmessagepair";
			
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string Endpoint = "endpoint";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Namespace = "namespace";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string SdkMessageId = "sdkmessageid";
			public const string SdkMessageIdName = "sdkmessageidName";
			public const string SdkMessagePairId = "sdkmessagepairid";
			public const string SdkMessagePairIdUnique = "sdkmessagepairidunique";
			public const string VersionNumber = "versionnumber";
		}

	[System.Runtime.Serialization.DataContractAttribute()]
	public enum SdkMessageProcessingStepState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Enabled = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Disabled = 1,
	}

	/// <summary>
	/// Stage in the execution pipeline that a plug-in is to execute.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageprocessingstep")]
	public partial class SdkMessageProcessingStep : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStep() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstep";
		
		public const int EntityTypeCode = 4608;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageProcessingStepId = value;
			}
		}
		
		/// <summary>
		/// Indicates whether the asynchronous system job is automatically deleted on completion.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncautodelete")]
		public System.Nullable<bool> AsyncAutoDelete
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("asyncautodelete");
			}
			set
			{
				this.OnPropertyChanging("AsyncAutoDelete");
				this.SetAttributeValue("asyncautodelete", value);
				this.OnPropertyChanged("AsyncAutoDelete");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configuration")]
		public string Configuration
		{
			get
			{
				return this.GetAttributeValue<string>("configuration");
			}
			set
			{
				this.OnPropertyChanging("Configuration");
				this.SetAttributeValue("configuration", value);
				this.OnPropertyChanged("Configuration");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Description of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated event handler.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
		public Microsoft.Xrm.Sdk.EntityReference EventHandler
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("eventhandler");
			}
			set
			{
				this.OnPropertyChanging("EventHandler");
				this.SetAttributeValue("eventhandler", value);
				this.OnPropertyChanged("EventHandler");
			}
		}
		
		/// <summary>
		/// Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filteringattributes")]
		public string FilteringAttributes
		{
			get
			{
				return this.GetAttributeValue<string>("filteringattributes");
			}
			set
			{
				this.OnPropertyChanging("FilteringAttributes");
				this.SetAttributeValue("filteringattributes", value);
				this.OnPropertyChanged("FilteringAttributes");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user to impersonate context when step is executed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("impersonatinguserid")]
		public Microsoft.Xrm.Sdk.EntityReference ImpersonatingUserId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("impersonatinguserid");
			}
			set
			{
				this.OnPropertyChanging("ImpersonatingUserId");
				this.SetAttributeValue("impersonatinguserid", value);
				this.OnPropertyChanged("ImpersonatingUserId");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invocationsource")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.OptionSetValue InvocationSource
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invocationsource");
			}
			set
			{
				this.OnPropertyChanging("InvocationSource");
				this.SetAttributeValue("invocationsource", value);
				this.OnPropertyChanged("InvocationSource");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component should be hidden.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
			}
			set
			{
				this.OnPropertyChanging("IsHidden");
				this.SetAttributeValue("ishidden", value);
				this.OnPropertyChanged("IsHidden");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component is managed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Run-time mode of execution, for example, synchronous or asynchronous.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
		public Microsoft.Xrm.Sdk.OptionSetValue Mode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode");
			}
			set
			{
				this.OnPropertyChanging("Mode");
				this.SetAttributeValue("mode", value);
				this.OnPropertyChanged("Mode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of SdkMessage processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Unique identifier of the plug-in type associated with the step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		[System.ObsoleteAttribute()]
		public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
			}
			set
			{
				this.OnPropertyChanging("PluginTypeId");
				this.SetAttributeValue("plugintypeid", value);
				this.OnPropertyChanged("PluginTypeId");
			}
		}
		
		/// <summary>
		/// Processing order within the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rank")]
		public System.Nullable<int> Rank
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("rank");
			}
			set
			{
				this.OnPropertyChanging("Rank");
				this.SetAttributeValue("rank", value);
				this.OnPropertyChanged("Rank");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message filter.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageFilterId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagefilterid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageFilterId");
				this.SetAttributeValue("sdkmessagefilterid", value);
				this.OnPropertyChanged("SdkMessageFilterId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageId");
				this.SetAttributeValue("sdkmessageid", value);
				this.OnPropertyChanged("SdkMessageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageProcessingStepId");
				this.SetAttributeValue("sdkmessageprocessingstepid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageProcessingStepId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepidunique")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the Sdk message processing step secure configuration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepSecureConfigId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepsecureconfigid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
				this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
				this.OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Stage in the execution pipeline that the SDK message processing step is in.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stage")]
		public Microsoft.Xrm.Sdk.OptionSetValue Stage
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("stage");
			}
			set
			{
				this.OnPropertyChanging("Stage");
				this.SetAttributeValue("stage", value);
				this.OnPropertyChanged("Stage");
			}
		}
		
		/// <summary>
		/// Status of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<SdkMessageProcessingStepState> StateCode
		{
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((SdkMessageProcessingStepState)(System.Enum.ToObject(typeof(SdkMessageProcessingStepState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// Deployment that the SDK message processing step should be executed on; server, client, or both.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supporteddeployment")]
		public Microsoft.Xrm.Sdk.OptionSetValue SupportedDeployment
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("supporteddeployment");
			}
			set
			{
				this.OnPropertyChanging("SupportedDeployment");
				this.SetAttributeValue("supporteddeployment", value);
				this.OnPropertyChanged("SupportedDeployment");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the SDK message processing step. 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
		public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
				this.SetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
				this.OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
			}
		}
		
		/// <summary>
		/// N:1 plugintype_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_sdkmessageprocessingstep")]
		public PluginType plugintype_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("plugintype_sdkmessageprocessingstep");
				this.SetRelatedEntity<PluginType>("plugintype_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("plugintype_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 plugintypeid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintypeid_sdkmessageprocessingstep")]
		public PluginType plugintypeid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
				this.SetRelatedEntity<PluginType>("plugintypeid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessagefilterid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
		public SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
				this.SetRelatedEntity<SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
		public SdkMessage sdkmessageid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
				this.SetRelatedEntity<SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
		public SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
				this.SetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
			}
		}
	}
	public class SdkMessageProcessingStepEnums
		{
			[DataContractAttribute]
			public enum ComponentState 
			{
				[EnumMemberAttribute]Published = 0,
				[EnumMemberAttribute]Unpublished = 1,
				[EnumMemberAttribute]Deleted = 2,
				[EnumMemberAttribute]DeletedUnpublished = 3,
			}		
			[DataContractAttribute]
			public enum InvocationSource 
			{
				[EnumMemberAttribute]Internal = -1,
				[EnumMemberAttribute]Parent = 0,
				[EnumMemberAttribute]Child = 1,
			}		
			[DataContractAttribute]
			public enum Mode 
			{
				[EnumMemberAttribute]Synchronous = 0,
				[EnumMemberAttribute]Asynchronous = 1,
			}		
			[DataContractAttribute]
			public enum Stage 
			{
				[EnumMemberAttribute]InitialPreoperationForinternaluseonly = 5,
				[EnumMemberAttribute]Prevalidation = 10,
				[EnumMemberAttribute]InternalPreoperationBeforeExternalPluginsForinternaluseonly = 15,
				[EnumMemberAttribute]Preoperation = 20,
				[EnumMemberAttribute]InternalPreoperationAfterExternalPluginsForinternaluseonly = 25,
				[EnumMemberAttribute]MainOperationForinternaluseonly = 30,
				[EnumMemberAttribute]InternalPostoperationBeforeExternalPluginsForinternaluseonly = 35,
				[EnumMemberAttribute]Postoperation = 40,
				[EnumMemberAttribute]InternalPostoperationAfterExternalPluginsForinternaluseonly = 45,
				[EnumMemberAttribute]PostoperationDeprecated = 50,
				[EnumMemberAttribute]FinalPostoperationForinternaluseonly = 55,
			}		
			[DataContractAttribute]
			public enum StateCode 
			{
				[EnumMemberAttribute]Enabled = 0,
				[EnumMemberAttribute]Disabled = 1,
			}		
			[DataContractAttribute]
			public enum StatusCode 
			{
				[EnumMemberAttribute]Enabled = 1,
				[EnumMemberAttribute]Disabled = 2,
			}		
			[DataContractAttribute]
			public enum SupportedDeployment 
			{
				[EnumMemberAttribute]ServerOnly = 0,
				[EnumMemberAttribute]MicrosoftDynamicsCRMClientforOutlookOnly = 1,
				[EnumMemberAttribute]Both = 2,
			}		
		}
		public class SdkMessageProcessingStepFields
		{
			public const string SchemaName = "sdkmessageprocessingstep";
			
			public const string AsyncAutoDelete = "asyncautodelete";
			public const string ComponentState = "componentstate";
			public const string Configuration = "configuration";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string Description = "description";
			public const string EventHandler = "eventhandler";
			public const string EventHandlerName = "eventhandlerName";
			public const string EventHandlerType = "eventhandlerType";
			public const string FilteringAttributes = "filteringattributes";
			public const string ImpersonatingUserId = "impersonatinguserid";
			public const string ImpersonatingUserIdName = "impersonatinguseridName";
			public const string IntroducedVersion = "introducedversion";
			public const string InvocationSource = "invocationsource";
			public const string IsCustomizable = "iscustomizable";
			public const string IsHidden = "ishidden";
			public const string IsManaged = "ismanaged";
			public const string Mode = "mode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverwriteTime = "overwritetime";
			public const string PluginTypeId = "plugintypeid";
			public const string PluginTypeIdName = "plugintypeidName";
			public const string Rank = "rank";
			public const string SdkMessageFilterId = "sdkmessagefilterid";
			public const string SdkMessageFilterIdName = "sdkmessagefilteridName";
			public const string SdkMessageId = "sdkmessageid";
			public const string SdkMessageIdName = "sdkmessageidName";
			public const string SdkMessageProcessingStepId = "sdkmessageprocessingstepid";
			public const string SdkMessageProcessingStepIdUnique = "sdkmessageprocessingstepidunique";
			public const string SdkMessageProcessingStepSecureConfigId = "sdkmessageprocessingstepsecureconfigid";
			public const string SdkMessageProcessingStepSecureConfigIdName = "sdkmessageprocessingstepsecureconfigidName";
			public const string SolutionId = "solutionid";
			public const string Stage = "stage";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string SupportedDeployment = "supporteddeployment";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// Copy of an entity's attributes before or after the core system operation.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageprocessingstepimage")]
	public partial class SdkMessageProcessingStepImage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStepImage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstepimage";
		
		public const int EntityTypeCode = 4615;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepimageid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageProcessingStepImageId = value;
			}
		}
		
		/// <summary>
		/// Comma-separated list of attributes that are to be passed into the SDK message processing step image.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributes")]
		public string Attributes1
		{
			get
			{
				return this.GetAttributeValue<string>("attributes");
			}
			set
			{
				this.OnPropertyChanging("Attributes1");
				this.SetAttributeValue("attributes", value);
				this.OnPropertyChanged("Attributes1");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step image.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step image was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstepimage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message processing step image.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Description of the SDK message processing step image.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Key name used to access the pre-image or post-image property bags in a step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityalias")]
		public string EntityAlias
		{
			get
			{
				return this.GetAttributeValue<string>("entityalias");
			}
			set
			{
				this.OnPropertyChanging("EntityAlias");
				this.SetAttributeValue("entityalias", value);
				this.OnPropertyChanged("EntityAlias");
			}
		}
		
		/// <summary>
		/// Type of image requested.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("imagetype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ImageType
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("imagetype");
			}
			set
			{
				this.OnPropertyChanging("ImageType");
				this.SetAttributeValue("imagetype", value);
				this.OnPropertyChanged("ImageType");
			}
		}
		
		/// <summary>
		/// Version in which the form is introduced.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
		public string IntroducedVersion
		{
			get
			{
				return this.GetAttributeValue<string>("introducedversion");
			}
			set
			{
				this.OnPropertyChanging("IntroducedVersion");
				this.SetAttributeValue("introducedversion", value);
				this.OnPropertyChanged("IntroducedVersion");
			}
		}
		
		/// <summary>
		/// Information that specifies whether this component can be customized.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Name of the property on the Request message.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messagepropertyname")]
		public string MessagePropertyName
		{
			get
			{
				return this.GetAttributeValue<string>("messagepropertyname");
			}
			set
			{
				this.OnPropertyChanging("MessagePropertyName");
				this.SetAttributeValue("messagepropertyname", value);
				this.OnPropertyChanged("MessagePropertyName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepimage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of SdkMessage processing step image.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Name of the related entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedattributename")]
		public string RelatedAttributeName
		{
			get
			{
				return this.GetAttributeValue<string>("relatedattributename");
			}
			set
			{
				this.OnPropertyChanging("RelatedAttributeName");
				this.SetAttributeValue("relatedattributename", value);
				this.OnPropertyChanged("RelatedAttributeName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageProcessingStepId");
				this.SetAttributeValue("sdkmessageprocessingstepid", value);
				this.OnPropertyChanged("SdkMessageProcessingStepId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step image entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepimageid")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepImageId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepimageid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageProcessingStepImageId");
				this.SetAttributeValue("sdkmessageprocessingstepimageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageProcessingStepImageId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step image.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepimageidunique")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepImageIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepimageidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingsolutionid")]
		public System.Nullable<System.Guid> SupportingSolutionId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("supportingsolutionid");
			}
		}
		
		/// <summary>
		/// Number that identifies a specific revision of the step image. 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
		public SdkMessageProcessingStep sdkmessageprocessingstepid_sdkmessageprocessingstepimage
		{
			get
			{
				return this.GetRelatedEntity<SdkMessageProcessingStep>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
				this.SetRelatedEntity<SdkMessageProcessingStep>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
				this.OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
			}
		}
	}
	public class SdkMessageProcessingStepImageEnums
		{
			[DataContractAttribute]
			public enum ComponentState 
			{
				[EnumMemberAttribute]Published = 0,
				[EnumMemberAttribute]Unpublished = 1,
				[EnumMemberAttribute]Deleted = 2,
				[EnumMemberAttribute]DeletedUnpublished = 3,
			}		
			[DataContractAttribute]
			public enum ImageType 
			{
				[EnumMemberAttribute]PreImage = 0,
				[EnumMemberAttribute]PostImage = 1,
				[EnumMemberAttribute]Both = 2,
			}		
		}
		public class SdkMessageProcessingStepImageFields
		{
			public const string SchemaName = "sdkmessageprocessingstepimage";
			
			public const string Attributes1 = "attributes";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string Description = "description";
			public const string EntityAlias = "entityalias";
			public const string ImageType = "imagetype";
			public const string IntroducedVersion = "introducedversion";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string MessagePropertyName = "messagepropertyname";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string OverwriteTime = "overwritetime";
			public const string RelatedAttributeName = "relatedattributename";
			public const string SdkMessageProcessingStepId = "sdkmessageprocessingstepid";
			public const string SdkMessageProcessingStepIdName = "sdkmessageprocessingstepidName";
			public const string SdkMessageProcessingStepImageId = "sdkmessageprocessingstepimageid";
			public const string SdkMessageProcessingStepImageIdUnique = "sdkmessageprocessingstepimageidunique";
			public const string SolutionId = "solutionid";
			public const string SupportingSolutionId = "supportingsolutionid";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// Non-public custom configuration that is passed to a plug-in's constructor.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageprocessingstepsecureconfig")]
	public partial class SdkMessageProcessingStepSecureConfig : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageProcessingStepSecureConfig() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageprocessingstepsecureconfig";
		
		public const int EntityTypeCode = 4616;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageProcessingStepSecureConfigId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message processing step secure configuration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message processing step was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message processing step is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step secure configuration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepsecureconfigid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
				this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message processing step.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigidunique")]
		public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepsecureconfigidunique");
			}
		}
		
		/// <summary>
		/// Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secureconfig")]
		public string SecureConfig
		{
			get
			{
				return this.GetAttributeValue<string>("secureconfig");
			}
			set
			{
				this.OnPropertyChanging("SecureConfig");
				this.SetAttributeValue("secureconfig", value);
				this.OnPropertyChanged("SecureConfig");
			}
		}
		
		/// <summary>
		/// 1:N sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
		public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
			}
			set
			{
				this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
				this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
				this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
			}
		}
	}
	public class SdkMessageProcessingStepSecureConfigEnums
		{
		}
		public class SdkMessageProcessingStepSecureConfigFields
		{
			public const string SchemaName = "sdkmessageprocessingstepsecureconfig";
			
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string SdkMessageProcessingStepSecureConfigId = "sdkmessageprocessingstepsecureconfigid";
			public const string SdkMessageProcessingStepSecureConfigIdUnique = "sdkmessageprocessingstepsecureconfigidunique";
			public const string SecureConfig = "secureconfig";
		}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagerequest")]
	public partial class SdkMessageRequest : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageRequest() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagerequest";
		
		public const int EntityTypeCode = 4609;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageRequestId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagerequest.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagerequest.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message request is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Type of entity with which the SDK request is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryobjecttypecode")]
		public string PrimaryObjectTypeCode
		{
			get
			{
				return this.GetAttributeValue<string>("primaryobjecttypecode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message pair with which the SDK message request is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessagePairId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagepairid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message request entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public System.Nullable<System.Guid> SdkMessageRequestId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageRequestId");
				this.SetAttributeValue("sdkmessagerequestid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageRequestId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message request.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestidunique")]
		public System.Nullable<System.Guid> SdkMessageRequestIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestidunique");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N messagerequest_sdkmessageresponse
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessageresponse")]
		public System.Collections.Generic.IEnumerable<SdkMessageResponse> messagerequest_sdkmessageresponse
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null);
			}
			set
			{
				this.OnPropertyChanging("messagerequest_sdkmessageresponse");
				this.SetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null, value);
				this.OnPropertyChanged("messagerequest_sdkmessageresponse");
			}
		}
		
		/// <summary>
		/// 1:N messagerequest_sdkmessagerequestfield
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessagerequestfield")]
		public System.Collections.Generic.IEnumerable<SdkMessageRequestField> messagerequest_sdkmessagerequestfield
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null);
			}
			set
			{
				this.OnPropertyChanging("messagerequest_sdkmessagerequestfield");
				this.SetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null, value);
				this.OnPropertyChanged("messagerequest_sdkmessagerequestfield");
			}
		}
		
		/// <summary>
		/// N:1 messagepair_sdkmessagerequest
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagepair_sdkmessagerequest")]
		public SdkMessagePair messagepair_sdkmessagerequest
		{
			get
			{
				return this.GetRelatedEntity<SdkMessagePair>("messagepair_sdkmessagerequest", null);
			}
		}
	}
	public class SdkMessageRequestEnums
		{
		}
		public class SdkMessageRequestFields
		{
			public const string SchemaName = "sdkmessagerequest";
			
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string PrimaryObjectTypeCode = "primaryobjecttypecode";
			public const string SdkMessagePairId = "sdkmessagepairid";
			public const string SdkMessagePairIdName = "sdkmessagepairidName";
			public const string SdkMessageRequestId = "sdkmessagerequestid";
			public const string SdkMessageRequestIdUnique = "sdkmessagerequestidunique";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagerequestfield")]
	public partial class SdkMessageRequestField : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageRequestField() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessagerequestfield";
		
		public const int EntityTypeCode = 4614;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestfieldid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageRequestFieldId = value;
			}
		}
		
		/// <summary>
		/// Common language runtime (CLR)-based parser for the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clrparser")]
		public string ClrParser
		{
			get
			{
				return this.GetAttributeValue<string>("clrparser");
			}
			set
			{
				this.OnPropertyChanging("ClrParser");
				this.SetAttributeValue("clrparser", value);
				this.OnPropertyChanged("ClrParser");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request field was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessagerequestfield.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Indicates how field contents are used during message processing. 1 - Primary entity, 2- Secondary entity
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldmask")]
		public System.Nullable<int> FieldMask
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("fieldmask");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message request field was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessagerequestfield.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Information about whether SDK message request field is optional.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optional")]
		public System.Nullable<bool> Optional
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("optional");
			}
			set
			{
				this.OnPropertyChanging("Optional");
				this.SetAttributeValue("optional", value);
				this.OnPropertyChanged("Optional");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message request field is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Parser for the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parser")]
		public string Parser
		{
			get
			{
				return this.GetAttributeValue<string>("parser");
			}
			set
			{
				this.OnPropertyChanging("Parser");
				this.SetAttributeValue("parser", value);
				this.OnPropertyChanged("Parser");
			}
		}
		
		/// <summary>
		/// Position of the Sdk message request field
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("position")]
		public System.Nullable<int> Position
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("position");
			}
		}
		
		/// <summary>
		/// Public name of the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publicname")]
		public string PublicName
		{
			get
			{
				return this.GetAttributeValue<string>("publicname");
			}
			set
			{
				this.OnPropertyChanging("PublicName");
				this.SetAttributeValue("publicname", value);
				this.OnPropertyChanged("PublicName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message request field entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestfieldid")]
		public System.Nullable<System.Guid> SdkMessageRequestFieldId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestfieldid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageRequestFieldId");
				this.SetAttributeValue("sdkmessagerequestfieldid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageRequestFieldId");
			}
		}
		
		/// <summary>
		/// Entity identifier of the SDK message request field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestfieldidunique")]
		public System.Nullable<System.Guid> SdkMessageRequestFieldIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestfieldidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message request with which the SDK message request field is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageRequestId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagerequestid");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 messagerequest_sdkmessagerequestfield
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessagerequestfield")]
		public SdkMessageRequest messagerequest_sdkmessagerequestfield
		{
			get
			{
				return this.GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessagerequestfield", null);
			}
		}
	}
	public class SdkMessageRequestFieldEnums
		{
		}
		public class SdkMessageRequestFieldFields
		{
			public const string SchemaName = "sdkmessagerequestfield";
			
			public const string ClrParser = "clrparser";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string FieldMask = "fieldmask";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string Optional = "optional";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string Parser = "parser";
			public const string Position = "position";
			public const string PublicName = "publicname";
			public const string SdkMessageRequestFieldId = "sdkmessagerequestfieldid";
			public const string SdkMessageRequestFieldIdUnique = "sdkmessagerequestfieldidunique";
			public const string SdkMessageRequestId = "sdkmessagerequestid";
			public const string SdkMessageRequestIdName = "sdkmessagerequestidName";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageresponse")]
	public partial class SdkMessageResponse : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageResponse() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageresponse";
		
		public const int EntityTypeCode = 4610;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageResponseId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message response.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageresponse.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message response.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message response.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageresponse.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message response is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message request with which the SDK message response is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageRequestId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagerequestid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public System.Nullable<System.Guid> SdkMessageResponseId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponseid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageResponseId");
				this.SetAttributeValue("sdkmessageresponseid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageResponseId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseidunique")]
		public System.Nullable<System.Guid> SdkMessageResponseIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponseidunique");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N messageresponse_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
		public System.Collections.Generic.IEnumerable<SdkMessageResponseField> messageresponse_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null);
			}
			set
			{
				this.OnPropertyChanging("messageresponse_sdkmessageresponsefield");
				this.SetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null, value);
				this.OnPropertyChanged("messageresponse_sdkmessageresponsefield");
			}
		}
		
		/// <summary>
		/// N:1 messagerequest_sdkmessageresponse
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessageresponse")]
		public SdkMessageRequest messagerequest_sdkmessageresponse
		{
			get
			{
				return this.GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessageresponse", null);
			}
		}
	}
	public class SdkMessageResponseEnums
		{
		}
		public class SdkMessageResponseFields
		{
			public const string SchemaName = "sdkmessageresponse";
			
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string SdkMessageRequestId = "sdkmessagerequestid";
			public const string SdkMessageRequestIdName = "sdkmessagerequestidName";
			public const string SdkMessageResponseId = "sdkmessageresponseid";
			public const string SdkMessageResponseIdUnique = "sdkmessageresponseidunique";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageresponsefield")]
	public partial class SdkMessageResponseField : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public SdkMessageResponseField() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "sdkmessageresponsefield";
		
		public const int EntityTypeCode = 4611;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.SdkMessageResponseFieldId = value;
			}
		}
		
		/// <summary>
		/// Common language runtime (CLR)-based formatter of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clrformatter")]
		public string ClrFormatter
		{
			get
			{
				return this.GetAttributeValue<string>("clrformatter");
			}
			set
			{
				this.OnPropertyChanging("ClrFormatter");
				this.SetAttributeValue("clrformatter", value);
				this.OnPropertyChanged("ClrFormatter");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response field was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the sdkmessageresponsefield.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
		}
		
		/// <summary>
		/// Customization level of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
		public System.Nullable<int> CustomizationLevel
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
			}
		}
		
		/// <summary>
		/// Formatter for the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formatter")]
		public string Formatter
		{
			get
			{
				return this.GetAttributeValue<string>("formatter");
			}
			set
			{
				this.OnPropertyChanging("Formatter");
				this.SetAttributeValue("formatter", value);
				this.OnPropertyChanged("Formatter");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the SDK message response field was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who last modified the sdkmessageresponsefield.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Name of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message response field is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Position of the Sdk message response field
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("position")]
		public System.Nullable<int> Position
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("position");
			}
		}
		
		/// <summary>
		/// Public name of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publicname")]
		public string PublicName
		{
			get
			{
				return this.GetAttributeValue<string>("publicname");
			}
			set
			{
				this.OnPropertyChanging("PublicName");
				this.SetAttributeValue("publicname", value);
				this.OnPropertyChanged("PublicName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response field entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
		public System.Nullable<System.Guid> SdkMessageResponseFieldId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldid");
			}
			set
			{
				this.OnPropertyChanging("SdkMessageResponseFieldId");
				this.SetAttributeValue("sdkmessageresponsefieldid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SdkMessageResponseFieldId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldidunique")]
		public System.Nullable<System.Guid> SdkMessageResponseFieldIdUnique
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the message response with which the SDK message response field is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
		public Microsoft.Xrm.Sdk.EntityReference SdkMessageResponseId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageresponseid");
			}
		}
		
		/// <summary>
		/// Actual value of the SDK message response field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("value")]
		public string Value
		{
			get
			{
				return this.GetAttributeValue<string>("value");
			}
			set
			{
				this.OnPropertyChanging("Value");
				this.SetAttributeValue("value", value);
				this.OnPropertyChanged("Value");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 messageresponse_sdkmessageresponsefield
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
		public SdkMessageResponse messageresponse_sdkmessageresponsefield
		{
			get
			{
				return this.GetRelatedEntity<SdkMessageResponse>("messageresponse_sdkmessageresponsefield", null);
			}
		}
	}
	public class SdkMessageResponseFieldEnums
		{
		}
		public class SdkMessageResponseFieldFields
		{
			public const string SchemaName = "sdkmessageresponsefield";
			
			public const string ClrFormatter = "clrformatter";
			public const string CreatedBy = "createdby";
			public const string CreatedByName = "createdbyName";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string CreatedOnBehalfByName = "createdonbehalfbyName";
			public const string CustomizationLevel = "customizationlevel";
			public const string Formatter = "formatter";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByName = "modifiedbyName";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyName";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OrganizationIdName = "organizationidName";
			public const string Position = "position";
			public const string PublicName = "publicname";
			public const string SdkMessageResponseFieldId = "sdkmessageresponsefieldid";
			public const string SdkMessageResponseFieldIdUnique = "sdkmessageresponsefieldidunique";
			public const string SdkMessageResponseId = "sdkmessageresponseid";
			public const string SdkMessageResponseIdName = "sdkmessageresponseidName";
			public const string Value = "value";
			public const string VersionNumber = "versionnumber";
		}

	/// <summary>
	/// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class XrmServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public XrmServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}

		/// <summary>
		/// Gets a binding to the set of all <see cref="PluginAssembly"/> entities.
		/// </summary>
		public System.Linq.IQueryable<PluginAssembly> PluginAssemblySet
		{
			get
			{
				return this.CreateQuery<PluginAssembly>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="PluginType"/> entities.
		/// </summary>
		public System.Linq.IQueryable<PluginType> PluginTypeSet
		{
			get
			{
				return this.CreateQuery<PluginType>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="PluginTypeStatistic"/> entities.
		/// </summary>
		public System.Linq.IQueryable<PluginTypeStatistic> PluginTypeStatisticSet
		{
			get
			{
				return this.CreateQuery<PluginTypeStatistic>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessage"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessage> SdkMessageSet
		{
			get
			{
				return this.CreateQuery<SdkMessage>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageFilter"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageFilter> SdkMessageFilterSet
		{
			get
			{
				return this.CreateQuery<SdkMessageFilter>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessagePair"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessagePair> SdkMessagePairSet
		{
			get
			{
				return this.CreateQuery<SdkMessagePair>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageProcessingStep"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageProcessingStep> SdkMessageProcessingStepSet
		{
			get
			{
				return this.CreateQuery<SdkMessageProcessingStep>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageProcessingStepImage"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageProcessingStepImage> SdkMessageProcessingStepImageSet
		{
			get
			{
				return this.CreateQuery<SdkMessageProcessingStepImage>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageProcessingStepSecureConfig"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageProcessingStepSecureConfig> SdkMessageProcessingStepSecureConfigSet
		{
			get
			{
				return this.CreateQuery<SdkMessageProcessingStepSecureConfig>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageRequest"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageRequest> SdkMessageRequestSet
		{
			get
			{
				return this.CreateQuery<SdkMessageRequest>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageRequestField"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageRequestField> SdkMessageRequestFieldSet
		{
			get
			{
				return this.CreateQuery<SdkMessageRequestField>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageResponse"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageResponse> SdkMessageResponseSet
		{
			get
			{
				return this.CreateQuery<SdkMessageResponse>();
			}
		}
		/// <summary>
		/// Gets a binding to the set of all <see cref="SdkMessageResponseField"/> entities.
		/// </summary>
		public System.Linq.IQueryable<SdkMessageResponseField> SdkMessageResponseFieldSet
		{
			get
			{
				return this.CreateQuery<SdkMessageResponseField>();
			}
		}
	}
}
