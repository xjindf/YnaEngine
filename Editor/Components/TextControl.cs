using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yna.Editor.Components
{
    public partial class TextControl : UserControl
    {
        public event EventHandler<StringChangedEventArgs> TextChanged = null;
        public event EventHandler<EnabledChangedEventArgs> EnabledChanged = null;

        public TextControl()
        {
            InitializeComponent();
        }

        private void textSprite_TextChanged(object sender, EventArgs e)
        {
            if (TextChanged != null)
                TextChanged(this, new StringChangedEventArgs(textSprite.Text));
        }

        private void isEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (EnabledChanged != null)
                EnabledChanged(this, new EnabledChangedEventArgs(isEnabled.Checked));
        }

        public void SetText(string text)
        {
            textSprite.Text = text;
        }
    }
}
