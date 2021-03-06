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
	public partial class ProjectDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ProjectDataDataContext() : 
				base(global::PMAInfrastructure.Properties.Settings.Default.PMA_TESTConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProjectDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fcn_GetProjects", IsComposable=true)]
		public IQueryable<fcn_GetProjectsResult> fcn_GetProjects()
		{
			return this.CreateMethodCallQuery<fcn_GetProjectsResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fcn_GetProjectsByOwnerName", IsComposable=true)]
		public IQueryable<fcn_GetProjectsByOwnerNameResult> fcn_GetProjectsByOwnerName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FirstName", DbType="VarChar(30)")] string firstName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LastName", DbType="VarChar(40)")] string lastName)
		{
			return this.CreateMethodCallQuery<fcn_GetProjectsByOwnerNameResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), firstName, lastName);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.fcn_GetProjectsByName", IsComposable=true)]
		public IQueryable<fcn_GetProjectsByNameResult> fcn_GetProjectsByName([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(50)")] string name)
		{
			return this.CreateMethodCallQuery<fcn_GetProjectsByNameResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name);
		}
	}
	
	public partial class fcn_GetProjectsResult
	{
		
		private int _Id;
		
		private string _Name;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private System.Nullable<int> _OwnerId;
		
		private string _OwnerFirstName;
		
		private string _OwnerLastName;
		
		public fcn_GetProjectsResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this._StartDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this._EndDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerId", DbType="Int")]
		public System.Nullable<int> OwnerId
		{
			get
			{
				return this._OwnerId;
			}
			set
			{
				if ((this._OwnerId != value))
				{
					this._OwnerId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerFirstName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string OwnerFirstName
		{
			get
			{
				return this._OwnerFirstName;
			}
			set
			{
				if ((this._OwnerFirstName != value))
				{
					this._OwnerFirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerLastName", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string OwnerLastName
		{
			get
			{
				return this._OwnerLastName;
			}
			set
			{
				if ((this._OwnerLastName != value))
				{
					this._OwnerLastName = value;
				}
			}
		}
	}
	
	public partial class fcn_GetProjectsByOwnerNameResult
	{
		
		private int _Id;
		
		private string _Name;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private System.Nullable<int> _OwnerId;
		
		private string _OwnerFirstName;
		
		private string _OwnerLastName;
		
		public fcn_GetProjectsByOwnerNameResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this._StartDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this._EndDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerId", DbType="Int")]
		public System.Nullable<int> OwnerId
		{
			get
			{
				return this._OwnerId;
			}
			set
			{
				if ((this._OwnerId != value))
				{
					this._OwnerId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerFirstName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string OwnerFirstName
		{
			get
			{
				return this._OwnerFirstName;
			}
			set
			{
				if ((this._OwnerFirstName != value))
				{
					this._OwnerFirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerLastName", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string OwnerLastName
		{
			get
			{
				return this._OwnerLastName;
			}
			set
			{
				if ((this._OwnerLastName != value))
				{
					this._OwnerLastName = value;
				}
			}
		}
	}
	
	public partial class fcn_GetProjectsByNameResult
	{
		
		private int _Id;
		
		private string _Name;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private System.Nullable<int> _OwnerId;
		
		private string _OwnerFirstName;
		
		private string _OwnerLastName;
		
		public fcn_GetProjectsByNameResult()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this._StartDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this._EndDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerId", DbType="Int")]
		public System.Nullable<int> OwnerId
		{
			get
			{
				return this._OwnerId;
			}
			set
			{
				if ((this._OwnerId != value))
				{
					this._OwnerId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerFirstName", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string OwnerFirstName
		{
			get
			{
				return this._OwnerFirstName;
			}
			set
			{
				if ((this._OwnerFirstName != value))
				{
					this._OwnerFirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerLastName", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string OwnerLastName
		{
			get
			{
				return this._OwnerLastName;
			}
			set
			{
				if ((this._OwnerLastName != value))
				{
					this._OwnerLastName = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
