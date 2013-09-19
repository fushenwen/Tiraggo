//===============================================================================
//                    Generated by http://www.My2ndGeneration.com
//===============================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using Tiraggo.Core;
using Tiraggo.Interfaces;
using Tiraggo.DynamicQuery;

namespace BusinessObjects
{

	//===============================================
	// Concrete Entity Class
	//===============================================
	[DebuggerDisplay("Data = {Debug}")]
	[Serializable]
	[DataContract]
	[KnownType(typeof(Employees))]
	[XmlType("Employees")]
	public partial class Employees : tgEmployees
	{
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden | DebuggerBrowsableState.Never)]
		protected override tgEntityDebuggerView[] Debug
		{
			get { return base.Debug; }
		}

		override public tgEntity CreateInstance()
		{
			return new Employees();
		}

		#region Static Quick Access Methods
		static public void Delete(System.Int32 employeeID)
		{
			var obj = new Employees();
			obj.EmployeeID = employeeID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save();
		}

		static public void Delete(System.Int32 employeeID, tgSqlAccessType sqlAccessType)
		{
			var obj = new Employees();
			obj.EmployeeID = employeeID;
			obj.AcceptChanges();
			obj.MarkAsDeleted();
			obj.Save(sqlAccessType);
		}
		#endregion
	}

	//===============================================
	// Abstract Entity Class
	//===============================================	
	[DataContract]
	[Serializable]
	abstract public partial class tgEmployees : tgEntity
	{
		public tgEmployees()
		{

		}

		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 employeeID)
		{
			if (this.tg.Connection.SqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeID);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeID);
		}

		public virtual bool LoadByPrimaryKey(tgSqlAccessType sqlAccessType, System.Int32 employeeID)
		{
			if (sqlAccessType == tgSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(employeeID);
			else
				return LoadByPrimaryKeyStoredProcedure(employeeID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 employeeID)
		{
			EmployeesQuery query = new EmployeesQuery();
			query.Where(query.EmployeeID == employeeID);
			return this.Load(query);
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 employeeID)
		{
			tgParameters parms = new tgParameters();
			parms.Add("EmployeeID", employeeID);
			return this.Load(tgQueryType.StoredProcedure, this.tg.spLoadByPrimaryKey, parms);
		}
		#endregion

		#region Properties

		/// <summary>
		/// Maps to Employees.EmployeeID
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? EmployeeID
		{
			get
			{
				return base.GetSystemInt32(EmployeesMetadata.ColumnNames.EmployeeID);
			}

			set
			{
				if (base.SetSystemInt32(EmployeesMetadata.ColumnNames.EmployeeID, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.EmployeeID);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.LastName
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string LastName
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.LastName);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.LastName, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.LastName);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.FirstName
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string FirstName
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.FirstName);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.FirstName, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.FirstName);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Title
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Title
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Title);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.Title, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Title);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.TitleOfCourtesy
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string TitleOfCourtesy
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.TitleOfCourtesy);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.TitleOfCourtesy, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.TitleOfCourtesy);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.BirthDate
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public DateTime? BirthDate
		{
			get
			{
				return base.GetSystemDateTime(EmployeesMetadata.ColumnNames.BirthDate);
			}

			set
			{
				if (base.SetSystemDateTime(EmployeesMetadata.ColumnNames.BirthDate, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.BirthDate);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.HireDate
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public DateTime? HireDate
		{
			get
			{
				return base.GetSystemDateTime(EmployeesMetadata.ColumnNames.HireDate);
			}

			set
			{
				if (base.SetSystemDateTime(EmployeesMetadata.ColumnNames.HireDate, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.HireDate);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Address
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Address
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Address);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.Address, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Address);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.City
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string City
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.City);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.City, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.City);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Region
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Region
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Region);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.Region, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Region);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.PostalCode
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string PostalCode
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.PostalCode);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.PostalCode, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.PostalCode);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Country
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Country
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Country);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.Country, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Country);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.HomePhone
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string HomePhone
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.HomePhone);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.HomePhone, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.HomePhone);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Extension
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Extension
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Extension);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.Extension, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Extension);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Photo
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public byte[] Photo
		{
			get
			{
				return base.GetSystemByteArray(EmployeesMetadata.ColumnNames.Photo);
			}

			set
			{
				if (base.SetSystemByteArray(EmployeesMetadata.ColumnNames.Photo, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Photo);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.Notes
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string Notes
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.Notes);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.Notes, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.Notes);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.ReportsTo
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public int? ReportsTo
		{
			get
			{
				return base.GetSystemInt32(EmployeesMetadata.ColumnNames.ReportsTo);
			}

			set
			{
				if (base.SetSystemInt32(EmployeesMetadata.ColumnNames.ReportsTo, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.ReportsTo);
				}
			}
		}

		/// <summary>
		/// Maps to Employees.PhotoPath
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		virtual public string PhotoPath
		{
			get
			{
				return base.GetSystemString(EmployeesMetadata.ColumnNames.PhotoPath);
			}

			set
			{
				if (base.SetSystemString(EmployeesMetadata.ColumnNames.PhotoPath, value))
				{
					OnPropertyChanged(EmployeesMetadata.PropertyNames.PhotoPath);
				}
			}
		}

        [DataMember(EmitDefaultValue = false)]  
        public Dictionary<string, object> tgExtendedData  
        {  
            get { return GetExtraColumns(); }  
            private set { }  
        } 

		#endregion

		#region Housekeeping methods

		override protected IMetadata Meta
		{
			get
			{
				return EmployeesMetadata.Meta();
			}
		}

		#endregion

		#region Query Logic

		public EmployeesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return this.Query.Load();
		}

		protected void InitQuery(EmployeesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;

			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntity)this).Connection;
			}
		}

		#endregion

		[IgnoreDataMember]
		private EmployeesQuery query;
	}

	//===============================================
	// Concrete Collection Class
	//===============================================
	[DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[CollectionDataContract]
	[XmlType("EmployeesCollection")]
	public partial class EmployeesCollection : tgEmployeesCollection, IEnumerable<Employees>
	{
		public Employees FindByPrimaryKey(int employeeID)
		{
			return this.SingleOrDefault(e => e.EmployeeID == employeeID);
		}

		#region WCF Service Class

		[DataContract]
		[KnownType(typeof(Employees))]
		public class EmployeesCollectionWCFPacket : tgCollectionWCFPacket<EmployeesCollection>
		{
			public static implicit operator EmployeesCollection(EmployeesCollectionWCFPacket packet)
			{
				return packet.Collection;
			}

			public static implicit operator EmployeesCollectionWCFPacket(EmployeesCollection collection)
			{
				return new EmployeesCollectionWCFPacket() { Collection = collection };
			}
		}

		#endregion
	}

	//===============================================
	// Abstract Collection Class
	//===============================================	
	[Serializable]
	abstract public partial class tgEmployeesCollection : tgEntityCollection<Employees>
	{
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return EmployeesMetadata.Meta();
			}
		}

		protected override string GetCollectionName()
		{
			return "EmployeesCollection";
		}

		#endregion

		#region Query Logic

		[BrowsableAttribute(false)]
		public EmployeesQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new EmployeesQuery();
					InitQuery(this.query);
				}

				return this.query;
			}
		}

		public bool Load(EmployeesQuery query)
		{
			this.query = query;
			InitQuery(this.query);
			return Query.Load();
		}

		override protected tgDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new EmployeesQuery();
				this.InitQuery(query);
			}
			return this.query;
		}

		protected void InitQuery(EmployeesQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			if (!query.tg2.HasConnection)
			{
				query.tg2.Connection = ((IEntityCollection)this).Connection;
			}
		}

		protected override void HookupQuery(tgDynamicQuery query)
		{
			this.InitQuery((EmployeesQuery)query);
		}

		#endregion

		private EmployeesQuery query;
	}	

	//===============================================
	// Concrete Query Class
	//===============================================	
	[DebuggerDisplay("Query = {Parse()}")]
	[Serializable]
	public partial class EmployeesQuery : tgEmployeesQuery
	{
		public EmployeesQuery(string joinAlias)
		{
			this.tg.JoinAlias = joinAlias;
		}

		override protected string GetQueryName()
		{
			return "EmployeesQuery";
		}

		#region Explicit Casts

		public static explicit operator string(EmployeesQuery query)
		{
			return EmployeesQuery.SerializeHelper.ToXml(query);
		}

		public static explicit operator EmployeesQuery(string query)
		{
			return (EmployeesQuery)EmployeesQuery.SerializeHelper.FromXml(query, typeof(EmployeesQuery));
		}

		#endregion
	}

	//===============================================
	// Abstract Query Class
	//===============================================
	[Serializable]
	abstract public partial class tgEmployeesQuery : tgDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return EmployeesMetadata.Meta();
			}
		}	

		#region QueryItemFromName

		protected override tgQueryItem QueryItemFromName(string name)
		{
			switch (name)
			{
				case "EmployeeID": return this.EmployeeID;
				case "LastName": return this.LastName;
				case "FirstName": return this.FirstName;
				case "Title": return this.Title;
				case "TitleOfCourtesy": return this.TitleOfCourtesy;
				case "BirthDate": return this.BirthDate;
				case "HireDate": return this.HireDate;
				case "Address": return this.Address;
				case "City": return this.City;
				case "Region": return this.Region;
				case "PostalCode": return this.PostalCode;
				case "Country": return this.Country;
				case "HomePhone": return this.HomePhone;
				case "Extension": return this.Extension;
				case "Photo": return this.Photo;
				case "Notes": return this.Notes;
				case "ReportsTo": return this.ReportsTo;
				case "PhotoPath": return this.PhotoPath;

				default: return null;
			}
		}		

		#endregion

		#region tgQueryItems

		public tgQueryItem EmployeeID
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.EmployeeID, tgSystemType.Int32); }
		}

		public tgQueryItem LastName
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.LastName, tgSystemType.String); }
		}

		public tgQueryItem FirstName
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.FirstName, tgSystemType.String); }
		}

		public tgQueryItem Title
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Title, tgSystemType.String); }
		}

		public tgQueryItem TitleOfCourtesy
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.TitleOfCourtesy, tgSystemType.String); }
		}

		public tgQueryItem BirthDate
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.BirthDate, tgSystemType.DateTime); }
		}

		public tgQueryItem HireDate
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.HireDate, tgSystemType.DateTime); }
		}

		public tgQueryItem Address
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Address, tgSystemType.String); }
		}

		public tgQueryItem City
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.City, tgSystemType.String); }
		}

		public tgQueryItem Region
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Region, tgSystemType.String); }
		}

		public tgQueryItem PostalCode
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.PostalCode, tgSystemType.String); }
		}

		public tgQueryItem Country
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Country, tgSystemType.String); }
		}

		public tgQueryItem HomePhone
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.HomePhone, tgSystemType.String); }
		}

		public tgQueryItem Extension
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Extension, tgSystemType.String); }
		}

		public tgQueryItem Photo
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Photo, tgSystemType.Byte); }
		}

		public tgQueryItem Notes
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.Notes, tgSystemType.String); }
		}

		public tgQueryItem ReportsTo
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.ReportsTo, tgSystemType.Int32); }
		}

		public tgQueryItem PhotoPath
		{
			get { return new tgQueryItem(this, EmployeesMetadata.ColumnNames.PhotoPath, tgSystemType.String); }
		}


		#endregion
	}

	//===============================================
	// Concrete Metadata Class
	//===============================================
	[Serializable]
	public partial class EmployeesMetadata : tgMetadata, IMetadata
	{
		#region Protected Constructor
		protected EmployeesMetadata()
		{
			m_columns = new tgColumnMetadataCollection();
			tgColumnMetadata c;

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.EmployeeID, 0, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = EmployeesMetadata.PropertyNames.EmployeeID;
			c.IsInPrimaryKey = true;
            c.IsAutoIncrement = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.LastName, 1, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.LastName;
			c.CharacterMaxLength = 20;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.FirstName, 2, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.FirstName;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Title, 3, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Title;
			c.IsNullable = true;
			c.CharacterMaxLength = 30;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.TitleOfCourtesy, 4, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.TitleOfCourtesy;
			c.IsNullable = true;
			c.CharacterMaxLength = 25;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.BirthDate, 5, typeof(System.DateTime), tgSystemType.DateTime);
			c.PropertyName = EmployeesMetadata.PropertyNames.BirthDate;
			c.IsNullable = true;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.HireDate, 6, typeof(System.DateTime), tgSystemType.DateTime);
			c.PropertyName = EmployeesMetadata.PropertyNames.HireDate;
			c.IsNullable = true;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Address, 7, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Address;
			c.IsNullable = true;
			c.CharacterMaxLength = 60;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.City, 8, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.City;
			c.IsNullable = true;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Region, 9, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Region;
			c.IsNullable = true;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.PostalCode, 10, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.PostalCode;
			c.IsNullable = true;
			c.CharacterMaxLength = 10;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Country, 11, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Country;
			c.IsNullable = true;
			c.CharacterMaxLength = 15;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.HomePhone, 12, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.HomePhone;
			c.IsNullable = true;
			c.CharacterMaxLength = 24;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Extension, 13, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Extension;
			c.IsNullable = true;
			c.CharacterMaxLength = 4;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Photo, 14, typeof(System.Byte[]), tgSystemType.Byte);
			c.PropertyName = EmployeesMetadata.PropertyNames.Photo;
			c.IsNullable = true;
			c.CharacterMaxLength = 2147483647;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.Notes, 15, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.Notes;
			c.IsNullable = true;
			c.CharacterMaxLength = 1073741823;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.ReportsTo, 16, typeof(System.Int32), tgSystemType.Int32);
			c.PropertyName = EmployeesMetadata.PropertyNames.ReportsTo;
			c.IsNullable = true;
			c.NumericPrecision = 10;
			m_columns.Add(c);

			c = new tgColumnMetadata(EmployeesMetadata.ColumnNames.PhotoPath, 17, typeof(System.String), tgSystemType.String);
			c.PropertyName = EmployeesMetadata.PropertyNames.PhotoPath;
			c.IsNullable = true;
			c.CharacterMaxLength = 255;
			m_columns.Add(c);
		}
		#endregion

		static public EmployeesMetadata Meta()
		{
			return meta;
		}

		public Guid DataID
		{
			get { return base.m_dataID; }
		}

		public bool MultiProviderMode
		{
			get { return false; }
		}

		public tgColumnMetadataCollection Columns
		{
			get { return base.m_columns; }
		}

		#region ColumnNames
		public class ColumnNames
		{
			public const string EmployeeID = "EmployeeID";
			public const string LastName = "LastName";
			public const string FirstName = "FirstName";
			public const string Title = "Title";
			public const string TitleOfCourtesy = "TitleOfCourtesy";
			public const string BirthDate = "BirthDate";
			public const string HireDate = "HireDate";
			public const string Address = "Address";
			public const string City = "City";
			public const string Region = "Region";
			public const string PostalCode = "PostalCode";
			public const string Country = "Country";
			public const string HomePhone = "HomePhone";
			public const string Extension = "Extension";
			public const string Photo = "Photo";
			public const string Notes = "Notes";
			public const string ReportsTo = "ReportsTo";
			public const string PhotoPath = "PhotoPath";
		}
		#endregion

		#region PropertyNames
		public class PropertyNames
		{
			public const string EmployeeID = "EmployeeID";
			public const string LastName = "LastName";
			public const string FirstName = "FirstName";
			public const string Title = "Title";
			public const string TitleOfCourtesy = "TitleOfCourtesy";
			public const string BirthDate = "BirthDate";
			public const string HireDate = "HireDate";
			public const string Address = "Address";
			public const string City = "City";
			public const string Region = "Region";
			public const string PostalCode = "PostalCode";
			public const string Country = "Country";
			public const string HomePhone = "HomePhone";
			public const string Extension = "Extension";
			public const string Photo = "Photo";
			public const string Notes = "Notes";
			public const string ReportsTo = "ReportsTo";
			public const string PhotoPath = "PhotoPath";
		}
		#endregion

		public tgProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];
			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}

		#region MAP esDefault

		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(EmployeesMetadata))
			{
				if (EmployeesMetadata.mapDelegates == null)
				{
					EmployeesMetadata.mapDelegates = new Dictionary<string, MapToMeta>();
				}

				if (EmployeesMetadata.meta == null)
				{
					EmployeesMetadata.meta = new EmployeesMetadata();
				}

				MapToMeta mapMethod = new MapToMeta(meta.tgDefault);
				mapDelegates.Add("tgDefault", mapMethod);
				mapMethod("tgDefault");
			}
			return 0;
		}

		private tgProviderSpecificMetadata tgDefault(string mapName)
		{
			if (!m_providerMetadataMaps.ContainsKey(mapName))
			{
				tgProviderSpecificMetadata meta = new tgProviderSpecificMetadata();


				meta.AddTypeMap("EmployeeID", new tgTypeMap("int", "System.Int32"));
				meta.AddTypeMap("LastName", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("FirstName", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Title", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("TitleOfCourtesy", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("BirthDate", new tgTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("HireDate", new tgTypeMap("datetime", "System.DateTime"));
				meta.AddTypeMap("Address", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("City", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Region", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("PostalCode", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Country", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("HomePhone", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Extension", new tgTypeMap("nvarchar", "System.String"));
				meta.AddTypeMap("Photo", new tgTypeMap("image", "System.Byte[]"));
				meta.AddTypeMap("Notes", new tgTypeMap("ntext", "System.String"));
				meta.AddTypeMap("ReportsTo", new tgTypeMap("int", "System.Int32"));
				meta.AddTypeMap("PhotoPath", new tgTypeMap("nvarchar", "System.String"));

				meta.Source = "Employees";
				meta.Destination = "Employees";

				meta.spInsert = "proc_EmployeesInsert";
				meta.spUpdate = "proc_EmployeesUpdate";
				meta.spDelete = "proc_EmployeesDelete";
				meta.spLoadAll = "proc_EmployeesLoadAll";
				meta.spLoadByPrimaryKey = "proc_EmployeesLoadByPrimaryKey";

				this.m_providerMetadataMaps["tgDefault"] = meta;
			}

			return this.m_providerMetadataMaps["tgDefault"];
		}

		#endregion

		static private EmployeesMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _tgDefault = RegisterDelegateesDefault();
	}
}

