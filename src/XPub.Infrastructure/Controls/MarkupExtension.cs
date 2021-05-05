using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;

namespace XPub.Infrastructure.Controls
{

    #region MarkupExtension Derived Classes used as Converter
    /// <summary>
    /// DemoHeaderImageExtension markup extension class
    /// Used as coveter to provide an ImageSource reference to display 
    /// an image located in the header directory
    /// </summary>
    public class DemoHeaderImageExtension : MarkupExtension
    {
        #region Fields
        /// <summary>
        /// imageName field
        /// Name of the image
        /// </summary>
        /// <value>string</value>
        readonly string imageName;
        #endregion

        #region Constructors
        /// <summary>
        /// DemoHeaderImageExtension parameterized constructor
        /// </summary>
        /// <param name="imageName">Name of image</param>
        public DemoHeaderImageExtension(string imageName)
        {
            this.imageName = imageName;
        }
        #endregion

        #region MarkupExtension Implementation
        /// <summary>
        ///  Used to return the ImageSource object which is expected where the extension is applied..
        /// </summary>
        /// <param name="serviceProvider">Provider helper that can provide services for the markup extension</param>
        /// <returns></returns>
        /// <remarks>
        /// Using pack application for some reason would not work.
        /// So to work images must be place in the corresponding directory 
        /// located in the bin debug or release directory
        /// </remarks>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            //  string path = @"/XPub.Infrastructure;component/Images/HeaderImages/" + imageName.Replace(" ", String.Empty) + ".svg";
            var path = @"pack://siteoforigin:,,,/Images/HeaderImages/" + imageName.Replace(" ", String.Empty) + ".svg";
            var extension = new SvgImageSourceExtension() { Uri = new Uri(path), Size = new Size(16, 16) };
            var ass = (ImageSource)extension.ProvideValue(null);
            return ass;
        }
        #endregion
    }

    /// <summary>
    /// CellImageExtension markup extension class
    /// Used as coveter to provide an ImageSource reference to display 
    /// an image located in the HeaderImages directory
    /// </summary>
    public class CellImageExtension : MarkupExtension
    {
        #region Fields
        /// <summary>
        /// images field
        /// Collection of string that an image name must contain
        /// </summary>
        /// <value> Collection of strings</value>
        public static List<string> images = new List<string> { "Employee", "Administration", "Supervisor" };
       
        
        /// <summary>
        /// imageName field
        /// Name of the image
        /// </summary>
        /// <value>string</value>
        readonly string imageName;
        #endregion

        #region Constructors
        /// <summary>
        /// CellImageExtension parameterized constructor
        /// </summary>
        /// <param name="imageName">Name of image</param>
        public CellImageExtension(string imageName)
        {
            this.imageName = imageName;
        }
        #endregion

        #region MarkupExtension Implementation
        /// <summary>
        ///  Used to return the ImageSource object which is expected where the extension is applied..
        /// </summary>
        /// <param name="serviceProvider">Provider helper that can provide services for the markup extension</param>
        /// <returns></returns>
        /// <remarks>
        /// Using pack application for some reason would not work.
        /// So to work images must be place in the corresponding directory 
        /// located in the bin debug or release directory
        /// </remarks>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            //  string path = @"/XPub.Infrastructure;component/Images/HeaderImages/" + imageName.Replace(" ", String.Empty) + ".svg";
            var path = @"pack://siteoforigin:,,,/Images/CellImages/" + imageName.Replace(" ", String.Empty) + ".svg";
            var extension = new SvgImageSourceExtension() { Uri = new Uri(path), Size = new Size(16, 16) };
            var ass = (ImageSource)extension.ProvideValue(null);
            return ass;
        }
        #endregion


    }

    /// <summary>
    /// ImageExtension markup extension class
    /// Used as coveter to provide an ImageSource reference to display 
    /// an image located in the HeaderImages directory
    /// </summary>
    public class ImageExtension : MarkupExtension
    {
        #region Fields
        /// <summary>
        /// imageName field
        /// Name of the image
        /// </summary>
        /// <value>string</value>
        readonly string imageName;
        #endregion

        #region Constructors
        /// <summary>
        /// ImageExtension parameterized constructor
        /// </summary>
        /// <param name="imageName">Name of image</param>
        public ImageExtension(string imageName)
        {
            this.imageName = imageName;
        }
        #endregion

        #region MarkupExtension Implementation
        /// <summary>
        ///  Used to return the ImageSource object which is expected where the extension is applied..
        /// </summary>
        /// <param name="serviceProvider">Provider helper that can provide services for the markup extension</param>
        /// <returns></returns>
        /// <remarks>
        /// Using pack application for some reason would not work.
        /// So to work images must be place in the corresponding directory 
        /// located in the bin debug or release directory
        /// </remarks>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            //  string path = @"/XPub.Infrastructure;component/Images/HeaderImages/" + imageName.Replace(" ", String.Empty) + ".svg";
            var path = @"pack://siteoforigin:,,,/Images/" + imageName.Replace(" ", String.Empty) + ".svg";
            var extension = new SvgImageSourceExtension() { Uri = new Uri(path), Size = new Size(16, 16) };
            var ass = (ImageSource)extension.ProvideValue(null);
            return ass;
        }
        #endregion
    }

#endregion




}
