//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace Models
{
	
	
	/// <summary>
	/// Azienda che rappresenta un cliente o un potenziale cliente. Societα a cui viene intestata la fattura nelle transazioni aziendali.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class Account : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Account() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "account";
		
		public const int EntityTypeCode = 1;
		
		/// <summary>
		/// Identificatore univoco dell'account.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public System.Nullable<System.Guid> AccountId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
			}
			set
			{
				this.SetAttributeValue("accountid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.AccountId = value;
			}
		}
		
		/// <summary>
		/// Digitare il nome della societα o dell'azienda.
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
				this.SetAttributeValue("name", value);
			}
		}
		
		/// <summary>
		/// Digitare il numero di dipendenti che lavorano presso l'account da usare nella segmentazione di marketing e nell'analisi demografica.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
		public System.Nullable<int> NumberOfEmployees
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
			}
			set
			{
				this.SetAttributeValue("numberofemployees", value);
			}
		}
		
		/// <summary>
		/// Scegliere il contatto primario per l'account per fornire accesso rapido ai dettagli di contatto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
		public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
			}
			set
			{
				this.SetAttributeValue("primarycontactid", value);
			}
		}
		
		public sealed class Fields
		{
			
			/// <summary>
			/// Identificatore univoco dell'account.
			/// </summary>
			public const string AccountId = "accountid";
			
			public const string Id = "accountid";
			
			/// <summary>
			/// Digitare il nome della societα o dell'azienda.
			/// </summary>
			public const string Name = "name";
			
			/// <summary>
			/// Digitare il numero di dipendenti che lavorano presso l'account da usare nella segmentazione di marketing e nell'analisi demografica.
			/// </summary>
			public const string NumberOfEmployees = "numberofemployees";
			
			/// <summary>
			/// Scegliere il contatto primario per l'account per fornire accesso rapido ai dettagli di contatto.
			/// </summary>
			public const string PrimaryContactId = "primarycontactid";
			
			/// <summary>
			/// Mostra se l'account Φ attivo o inattivo. Gli account inattivi sono di sola lettura e non possono essere modificati a meno che non vengano riattivati.
			/// </summary>
			public const string StateCode = "statecode";
		}
	}
	
	/// <summary>
	/// Persona con cui una Business Unit si relaziona, ad esempio un cliente, un fornitore o un collega.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contact")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.1.0.42")]
	public partial class Contact : Microsoft.Xrm.Sdk.Entity
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		public Contact() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "contact";
		
		public const int EntityTypeCode = 2;
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bb_myapikey")]
		public System.Nullable<int> bb_MyAPIKey
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("bb_myapikey");
			}
			set
			{
				this.SetAttributeValue("bb_myapikey", value);
			}
		}
		
		/// <summary>
		/// Identificatore univoco del contatto.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public System.Nullable<System.Guid> ContactId
		{
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid");
			}
			set
			{
				this.SetAttributeValue("contactid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
		public override System.Guid Id
		{
			get
			{
				return base.Id;
			}
			set
			{
				this.ContactId = value;
			}
		}
		
		/// <summary>
		/// Digitare il nome del contatto per assicurare che il contatto sia indicato correttamente nelle chiamate di vendita, nelle e-mail e nelle campagne di marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
		public string FirstName
		{
			get
			{
				return this.GetAttributeValue<string>("firstname");
			}
			set
			{
				this.SetAttributeValue("firstname", value);
			}
		}
		
		/// <summary>
		/// Digitare il cognome del contatto per assicurare che il contatto sia indicato correttamente nelle chiamate di vendita, nelle e-mail e nelle campagne di marketing.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
		public string LastName
		{
			get
			{
				return this.GetAttributeValue<string>("lastname");
			}
			set
			{
				this.SetAttributeValue("lastname", value);
			}
		}
		
		/// <summary>
		/// Selezionare l'account padre o il contatto padre per il contatto per fornire un collegamento rapido a dettagli aggiuntivi, ad esempio informazioni finanziarie, impegni e opportunitα.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcustomerid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentCustomerId
		{
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcustomerid");
			}
			set
			{
				this.SetAttributeValue("parentcustomerid", value);
			}
		}
		
		public sealed class Fields
		{
			
			/// <summary>
			/// 
			/// </summary>
			public const string bb_MyAPIKey = "bb_myapikey";
			
			/// <summary>
			/// Identificatore univoco del contatto.
			/// </summary>
			public const string ContactId = "contactid";
			
			public const string Id = "contactid";
			
			/// <summary>
			/// Digitare il nome del contatto per assicurare che il contatto sia indicato correttamente nelle chiamate di vendita, nelle e-mail e nelle campagne di marketing.
			/// </summary>
			public const string FirstName = "firstname";
			
			/// <summary>
			/// Digitare il cognome del contatto per assicurare che il contatto sia indicato correttamente nelle chiamate di vendita, nelle e-mail e nelle campagne di marketing.
			/// </summary>
			public const string LastName = "lastname";
			
			/// <summary>
			/// Selezionare l'account padre o il contatto padre per il contatto per fornire un collegamento rapido a dettagli aggiuntivi, ad esempio informazioni finanziarie, impegni e opportunitα.
			/// </summary>
			public const string ParentCustomerId = "parentcustomerid";
			
			/// <summary>
			/// Mostra se il contatto Φ attivo o inattivo. I contatti inattivi sono di sola lettura e non possono essere modificati a meno che non vengano riattivati.
			/// </summary>
			public const string StateCode = "statecode";
		}
	}
}
