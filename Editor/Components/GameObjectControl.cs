using System;
using System.Windows.Forms;

namespace Yna.Editor.Components
{
    /// <summary>
    /// The GameObject control.
    /// </summary>
    public partial class GameObjectControl : UserControl
    {
        private bool _locked;

        public event EventHandler<PropertyChangedEventArgs<bool>> EnabledChanged = null;
        public event EventHandler<PropertyChangedEventArgs<string>> NameChanged = null;
        public event EventHandler<PropertyChangedEventArgs<string>> TagChanged = null;
        public event EventHandler<PropertyChangedEventArgs<int>> LayerChanged = null;

        public GameObjectControl()
        {
            InitializeComponent();
            _locked = false;
        }

        #region Event handlers

        private void isEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!_locked && EnabledChanged != null)
                EnabledChanged(this, new PropertyChangedEventArgs<bool>(isEnabled.Checked));
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            if (!_locked && NameChanged != null)
                NameChanged(this, new PropertyChangedEventArgs<string>(textName.Text));
        }

        private void textTag_TextChanged(object sender, EventArgs e)
        {
            if (!_locked && TagChanged != null)
                TagChanged(this, new PropertyChangedEventArgs<string>(textTag.Text));
        }

        private void comboLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_locked && LayerChanged != null)
                LayerChanged(this, new PropertyChangedEventArgs<int>(comboLayer.SelectedIndex));
        }

        #endregion

        public void Setup(string name, string tag, int layer)
        {
            _locked = true;

            textName.Text = name;
            textTag.Text = tag;
            comboLayer.SelectedIndex = (layer < comboLayer.Items.Count) ? layer : 0;

            _locked = false;
        }
    }
}
