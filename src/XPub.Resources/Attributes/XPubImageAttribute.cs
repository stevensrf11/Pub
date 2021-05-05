using System;
using System.Collections.Generic;
using System.Text;

namespace XPub.Resources.Attributes
{
    /// <summary>
    /// ImageAttribute  object derived from the <see cref="Attribute"/>
    /// Used as a property or method data annotation attribute to specify an image url path
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class XPubImageAttribute : Attribute
    {
        #region Property Accessors
        /// <summary>
        /// ImageUri Property Get/Set Accessor
        /// Image URI Path
        /// </summary>
        /// <value>string</value>
        public string ImageUri { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public XPubImageAttribute()
        {
        }

        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="imageUri">Uri path</param>
        public XPubImageAttribute(string imageUri)
        {
            this.ImageUri = imageUri;
        }
            #endregion
}
}
