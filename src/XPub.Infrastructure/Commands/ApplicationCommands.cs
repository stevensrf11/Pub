using Prism.Commands;

namespace XPub.Infrastructure.Commands
{
    /// <summary>
    /// IApplicationCommands interface
    /// Contains composite command
    /// </summary>
    public interface IApplicationCommands
    {
        #region Property Accessors
        /// <summary>
        /// NavigateCommand Property Get Accessor
        /// Used for navigation to a view
        /// </summary>
        CompositeCommand NavigateCommand { get; }
    #endregion
    }

    /// <summary>
    /// ApplicationCommands object derived from the <see cref="IApplicationCommands"/> interface
    /// Contains composite command
    /// </summary>
    public class ApplicationCommands : IApplicationCommands
    {
        #region Property Accessors
        /// <summary>
        /// NavigateCommand Property Get Accessor
        /// Used for navigation to a view
        /// </summary>
        public CompositeCommand NavigateCommand { get; } = new CompositeCommand();
        #endregion
    }


    /// <summary>
    /// CompositeCommands static object 
    /// Contains static  composite command
    public static class CompositeCommands
    {
        #region Property Accessors
        /// <summary>
        /// NavigateCommand Static Property Get Accessor
        /// Used for navigation to a view
        /// </summary>
        public static CompositeCommand NavigateCommand { get; } = new CompositeCommand();
        #endregion

    }
}
