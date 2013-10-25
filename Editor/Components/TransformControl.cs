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
    

    public partial class TransformControl : UserControl
    {
        public event EventHandler<TransformValueChangedEventArgs> PropertyChanged = null;

        private void OnPropertyChanged(string property, float value)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new TransformValueChangedEventArgs(property, value));
        }

        public TransformControl()
        {
            InitializeComponent();
        }

        private void transformValueChanged(object sender, EventArgs e)
        {
            TextBox tr = sender as TextBox;
            string [] temp = tr.Name.Split(new char[] { '_' });
            string property = temp[1];
            string value = temp[2]; 
            OnPropertyChanged(property, float.Parse(value));
        }
    }
}
