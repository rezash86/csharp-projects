﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace session17_projects
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ZzModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ZzModelContainer object using the connection string found in the 'ZzModelContainer' section of the application configuration file.
        /// </summary>
        public ZzModelContainer() : base("name=ZzModelContainer", "ZzModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ZzModelContainer object.
        /// </summary>
        public ZzModelContainer(string connectionString) : base(connectionString, "ZzModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ZzModelContainer object.
        /// </summary>
        public ZzModelContainer(EntityConnection connection) : base(connection, "ZzModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
