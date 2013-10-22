using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yna.Editor
{
    using GdiColor = System.Drawing.Color;
    using XnaColor = Microsoft.Xna.Framework.Color;

    public partial class MainEditor : Form
    {
        public MainEditor()
        {
            InitializeComponent();
            ynGameControl.Click += menuItemAddYnSprite_Click;
        }

        private void menuItemAddYnSprite_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            ynGameControl.AddSprite(me.X, me.Y);
        }
    }
}
