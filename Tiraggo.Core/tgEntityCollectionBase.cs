﻿/*  New BSD License
-------------------------------------------------------------------------------
Copyright (c) 2006-2012, EntitySpaces, LLC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the EntitySpaces, LLC nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL EntitySpaces, LLC BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
-------------------------------------------------------------------------------
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

using System.ComponentModel;

using Tiraggo.Interfaces;
using System.Runtime.Serialization;

namespace Tiraggo.Core
{
    [Serializable]
    [CollectionDataContract]
    abstract public class tgEntityCollectionBase : IEntityCollection, IEnumerable, IComponent
    {
        #region IComponent Members

        public event EventHandler Disposed;

        ISite IComponent.Site
        {
            get { return site; }
            set { site = value; }
        }
        [NonSerialized]
        private ISite site = null;

        #endregion

        #region IDisposable Members

        /// <summary>
        /// For <see cref="IDisposable"/> support.
        /// </summary>
        public void Dispose()
        {
            if (site != null && site.Container != null)
            {
                site.Container.Remove(this);
            }

            if (Disposed != null)
            {
                Disposed.Invoke(this, System.EventArgs.Empty);
            }
        }

        #endregion		

        #region Virtual Methods

        virtual protected tgEntity CreateEntity()
        {
            return null;
        }

        virtual internal IList GetList()
        {
            return null;
        }

        virtual internal IEnumerable GetDeletedEntities()
        {
            return null;
        }

        virtual internal IEnumerable GetEntities()
        {
            return null;
        }

        virtual internal PropertyDescriptorCollection GetProperties(tgEntity entity, tgEntityCollectionBase baseCollection)
        {
            return null;
        }

        virtual internal void AddEntityToDeletedList(tgEntity entity)
        {

        }

        virtual internal void ClearDeletedEntries()
        {

        }

        virtual internal void OnUpdateViewNotification(object sender, ListChangedType changeType, tgEntity obj)
        {

        }

        virtual protected tgDynamicQuery GetDynamicQuery()
        {
            return null;
        }

        virtual protected void HookupQuery(tgDynamicQuery query)
        {

        }

        virtual protected IMetadata Meta
        {
            get
            {
                return null;
            }
        }

        virtual public void Save()
        {

        }

        virtual public void Save(bool continueUpdateOnError)
        {

        }

        virtual protected string GetCollectionName()
        {
            return "";
        }

        /// <summary>
        /// Called whenever the Entity needs a connection. This can be used to override the default connection 
        /// per object manually, or automatically by filling in the "Connection Name" on the "Generated Master"
        /// template. 
        /// </summary>
        /// <returns></returns>
        virtual protected string GetConnectionName()
        {
            return null;
        }

        /// <summary>
        /// Overridden by the Generated classes to support the DynamicQuery Prefetch logic
        /// </summary>
        /// <param name="row">The row used to create the Entity in question</param>
        /// <param name="ordinals">The column ordinals, if null then create and return</param>
        /// <returns>The column ordinal positions</returns>
        virtual protected Dictionary<string, int> PopulateCollectionPrefetch(DataRow row, Dictionary<string, int> ordinals)
        {
            return null;
        }

        virtual public void AcceptChanges()
        {

        }

        virtual public void RejectChanges()
        {

        }

        virtual public int Count
        {
            get
            {
                return 0;
            }
        }

        virtual public bool IsDirty
        {
            get
            {
                return false;
            }
        }

        virtual public bool IsGraphDirty
        {
            get
            {
                return false;
            }
        }

        public virtual bool LoadAll()
        {
            return false;
        }

        public virtual bool LoadAll(tgSqlAccessType sqlAccessType)
        {
            return false;
        }

        virtual public void MarkAllAsDeleted()
        {

        }

        virtual public Type GetEntityType()
        {
            return null;
        }

        internal virtual void RemoveEntity(tgEntity entity)
        {

        }

        virtual public void CombineDeletedEntities()
        {

        }

        virtual public void SeparateDeletedEntities()
        {

        }



        #endregion

        /// <summary>
        /// The IEntityCollection interface serves to semi-hide many of the base class properties required by Tiraggo. 
        /// This serves two purposes, it keeps intellisense from getting polluted by noise and prevents the EntitySpaces
        /// "core" functionaltiy from colliding with your properties during code generation.
        /// </summary>
        public IEntityCollection tg
        {
            get { return this as IEntityCollection; }
        }


        private tgProviderSpecificMetadata GetProviderMetadata()
        {
            // We're on our own, use our own tgProviderSpecificMetadata
            string key = this.tg.Connection.ProviderMetadataKey;
            return this.Meta.GetProviderMetadata(key);
        }


        [NonSerialized]
        private tgConnection connection;

        #region IEntityCollection Members

        /// <summary>
        /// Used only to override the IConnectionNameService API when in use
        /// </summary>
        /// <param name="connectionName">The Name of the connection</param>
        /// <returns>The newly created tgConnection Connection</returns>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public tgConnection ConnectionServiceOverride(string connectionName)
        {
            if (this.connection == null)
            {
                this.connection = new tgConnection();

                this.connection.Name = connectionName;
            }

            return this.connection;
        }

        tgConnection IEntityCollection.Connection
        {
            get
            {
                if (this.connection == null)
                {
                    this.connection = new tgConnection();

                    if (tgConnection.ConnectionService != null)
                    {
                        this.connection.Name = tgConnection.ConnectionService.GetName();
                    }
                    else
                    {
                        string connName = this.GetConnectionName();
                        if (connName != null)
                        {
                            this.connection.Name = connName;
                        }
                    }
                }

                return this.connection;
            }
            set { this.connection = value; }
        }

        string IEntityCollection.Catalog
        {
            get
            {
                if (this.tg.Connection.Catalog != null)
                    return this.tg.Connection.Catalog;
                else
                    return this.GetProviderMetadata().Catalog;
            }
        }

        string IEntityCollection.Schema
        {
            get
            {
                if (this.tg.Connection.Schema != null)
                    return this.tg.Connection.Schema;
                else
                    return this.GetProviderMetadata().Schema;
            }
        }

        string IEntityCollection.Destination
        {
            get { return this.GetProviderMetadata().Destination; }
        }

        string IEntityCollection.Source
        {
            get { return this.GetProviderMetadata().Source; }
        }

        string IEntityCollection.spInsert
        {
            get { return this.GetProviderMetadata().spInsert; }
        }

        string IEntityCollection.spUpdate
        {
            get { return this.GetProviderMetadata().spUpdate; }
        }

        string IEntityCollection.spDelete
        {
            get { return this.GetProviderMetadata().spDelete; }
        }

        string IEntityCollection.spLoadAll
        {
            get { return this.GetProviderMetadata().spLoadAll; }
        }

        string IEntityCollection.spLoadByPrimaryKey
        {
            get { return this.GetProviderMetadata().spLoadByPrimaryKey; }
        }

        tgDynamicQuery IEntityCollection.Query
        {
            get { return this.GetDynamicQuery(); }
        }

        void IEntityCollection.HookupQuery(tgDynamicQuery query)
        {
            this.HookupQuery(query);
        }

        IEnumerable IEntityCollection.DeletedEntities
        {
            get { return GetDeletedEntities(); }
        }

        IMetadata IEntityCollection.Meta
        {
            get { return this.Meta; }
        }

        bool IEntityCollection.IsLazyLoadDisabled
        {
            get { return this._isLazyLoadDisabled; }
            set { this._isLazyLoadDisabled = value; }
        }

        Dictionary<string, int> IEntityCollection.PopulateCollection(DataRow row, Dictionary<string, int> ordinals)
        {
            return this.PopulateCollectionPrefetch(row, ordinals);
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEntities().GetEnumerator();
        }

        #endregion

        /// <summary>
        /// This method is valid for Windows.Forms applications only
        /// </summary>
        public bool EnableHierarchicalBinding
        {
            get
            {
                return this.enableHierarchcialBinding;
            }

            set
            {
                if (this.enableHierarchcialBinding != value)
                {
                    if (this.m_bindingPropertyCache != null)
                    {
                        this.m_bindingPropertyCache.Clear();
                    }
                    this.enableHierarchcialBinding = value;
                }
            }
        }

        protected Dictionary<Type, PropertyDescriptorCollection> BindingPropertyCache
        {
            get
            {
                if (this.m_bindingPropertyCache == null)
                {
                    this.m_bindingPropertyCache = new Dictionary<Type, PropertyDescriptorCollection>();
                }

                return this.m_bindingPropertyCache;
            }
        }

        [NonSerialized]
        internal bool isSorted;

        [NonSerialized]
        internal PropertyDescriptor sortProperty;

        [NonSerialized]
        internal ListSortDirection sortDirection = ListSortDirection.Ascending;

        [NonSerialized]
        private Dictionary<Type, PropertyDescriptorCollection> m_bindingPropertyCache;

        [NonSerialized]
        private bool enableHierarchcialBinding = true;

        [NonSerialized]
        internal Dictionary<string, int> selectedColumns;

        [NonSerialized]
        internal Dictionary<string, tgColumnMetadata> extraColumnMetadata;

        [NonSerialized]
        internal bool _isLazyLoadDisabled;
    }
}
