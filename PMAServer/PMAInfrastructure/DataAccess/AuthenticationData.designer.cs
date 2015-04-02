﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMAInfrastructure.DataAccess
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PMA_TEST")]
	public partial class AuthenticationDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public AuthenticationDataDataContext() : 
				base(global::PMAInfrastructure.Properties.Settings.Default.PMA_TESTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AuthenticationDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fcn_Authenticate", IsComposable=true)]
		public IQueryable<fcn_AuthenticateResult> fcn_Authenticate([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Login", DbType="VarChar(80)")] string login)
		{
			return this.CreateMethodCallQuery<fcn_AuthenticateResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), login);
		}
	}
	
	public partial class fcn_AuthenticateResult
	{
		
		private int _Id;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _Address;
		
		private string _PostalCode;
		
		private string _City;
		
		private System.DateTime _BirthDate;
		
		private string _Telephone;
		
		private string _Mail;
		
		private string _Password;
		
		public fcn_AuthenticateResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this._Address = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostalCode", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string PostalCode
		{
			get
			{
				return this._PostalCode;
			}
			set
			{
				if ((this._PostalCode != value))
				{
					this._PostalCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this._City = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="DateTime NOT NULL")]
		public System.DateTime BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this._BirthDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this._Telephone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this._Mail = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(500) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this._Password = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
