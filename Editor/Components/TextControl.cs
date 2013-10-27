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
        private bool _locked;

        public event EventHandler<PropertyChangedEventArgs<string>> TextChanged = null;

        public TextControl()
        {
            InitializeComponent();
            _locked = false;
        }

        public void Setup(string text)
        {
            _locked = true;    
            textSprite.Text = text;
            _locked = false;
        }

        private void textSprite_TextChanged(object sender, EventArgs e)
        {
            if (!_locked && TextChanged != null)
                TextChanged(this, new PropertyChangedEventArgs<string>(textSprite.Text));
        }

        private void linkLongText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
