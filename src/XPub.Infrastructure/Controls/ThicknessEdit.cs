using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.Native;
using DevExpress.Xpf.Editors;

namespace XPub.Infrastructure.Controls
{
    /// <summary>
    /// ThicknessMemberEdit custom control derived from the <see cref="Control"/> object
    /// Used as a custom editable checkbox
    /// </summary>
    [TemplatePart(Name = ThicknessMemberEdit.EditorElementName, Type = typeof(ComboBoxEdit))]
    public class ThicknessMemberEdit : Control {
        #region Dependency Properties
        /// <summary>
        /// ThicknessProperty
        /// A DependencyProperty used to set the thickness of the control
        /// </summary>
        public static readonly DependencyProperty ThicknessProperty =
            DependencyProperty.Register("Thickness", typeof(Thickness), typeof(ThicknessMemberEdit),
                new PropertyMetadata(new PropertyChangedCallback(OnThicknessChanged)));

        /// <summary>
        /// OnThicknessChanged event handler
        /// Property callback for the ThicknessProperty DependencyPropert
        /// Used to update the thickness of the control
        /// </summary>
        /// <param name="o">Sender</param>
        /// <param name="e">Event arguments</param>
        static void OnThicknessChanged(DependencyObject o, DependencyPropertyChangedEventArgs e) {
            ((ThicknessMemberEdit)o).OnThicknessChanged();
        }

          #endregion Dependency Properties

        private Side _Side;

        public ThicknessMemberEdit() {
            DefaultStyleKey = typeof(ThicknessMemberEdit);
        }

        public Side Side {
            get { return _Side; }
            set {
                if (Side.Equals(value))
                    return;
                _Side = value;
                UpdateSelectedItem();
            }
        }
        public Thickness Thickness {
            get { return (Thickness)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        #region Template

        internal const string EditorElementName = "EditorElement";

        /// <summary>
        /// OnApplyTemplate method
        /// Sets the template of the custom control
        ///  Called just before a UI element display
        /// </summary>
        public override void OnApplyTemplate() {
            if (EditorElement != null)
                EditorElement.SelectedIndexChanged -= OnEditorElementSelectedIndexChanged;
            base.OnApplyTemplate();
            EditorElement = GetTemplateChild(EditorElementName) as ComboBoxEdit;
            if (EditorElement != null)
                EditorElement.SelectedIndexChanged += OnEditorElementSelectedIndexChanged;
            UpdateSelectedItem();
        }

        /// <summary>
        /// EditorElement Property Get  Set Accessor
        /// ComboBoxEdit displayed in the control
        /// </summary>
        /// <value>EditorElement</value>
        protected ComboBoxEdit EditorElement { get; private set; }

        /// <summary>
        /// OnEditorElementSelectedIndexChanged event handler
        /// SelectedIndexChanged event handler for the EditorElement control
        /// </summary>
        /// <param name="sender">Sender of the event</param>
        /// <param name="e">RoutedEventArgs</param>        
        private void OnEditorElementSelectedIndexChanged(object sender, RoutedEventArgs e) {
            OnSelectionChanged();
        }

        #endregion Template

        #region Utility Methods
     /// <summary>
        /// OnThicknessChanged method
        /// Updates the thickness when the thickness has change 
        /// </summary>
        protected virtual void OnThicknessChanged() {
            UpdateSelectedItem();
        }

       /// <summary>
        /// OnSelectionChanged method
        /// Updates the thickness when a selection is change 
        /// </summary>
        protected virtual void OnSelectionChanged() {
            UpdateThickness();
        }

  

        /// <summary>
        /// UpdateSelectedItem method
        /// Updates the thickness when a item is selected 
        /// /// </summary>
        protected void UpdateSelectedItem() {
            if (EditorElement != null)
                EditorElement.SelectedItem = Thickness.GetValue(Side);
        }

        /// <summary>
        /// UpdateThickness method
        /// Updates the thickness of the control
        /// </summary>
        protected void UpdateThickness() {
            if (EditorElement != null)
                Thickness = Thickness.ChangeValue(Side, (double)EditorElement.SelectedItem);
        }   
        #endregion

    }

    /// <summary>
    /// ThicknessEdit custom control derived from the <see cref="Control"/> object
    /// Used as the control which embeds the  ThicknessMemberEdit fcontrol
    /// </summary>
    public class ThicknessEdit : Control {


        #region Constructor

        /// <summary>
        ///  Default constructor used to set the default style 
        /// </summary>
        public ThicknessEdit() {
            DefaultStyleKey = typeof(ThicknessEdit);
        }
        #endregion
        #region Dependency Properties
        /// <summary>
        /// ValueProperty 
        /// A dependency property used to set the thickness value
        /// </summary>
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(Thickness), typeof(ThicknessEdit), null);

        /// <summary>
        /// Value Property Get  Sect Accessors
        /// Used for referencing the ValueProperty
        /// </summary>
        /// <value>
        /// Thickness
        /// </value>
        public Thickness Value {
            get { return (Thickness)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }       
        #endregion Dependency Properties

    }
}
