using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.UI.Winforms.Helpers;

namespace Todo.UI.Winforms
{
    public partial class MainForm : Form
    {
        private readonly IMyAppSettingsHandler _mySettings;
        public MainForm(IMyAppSettingsHandler mySettings)
        {
            InitializeComponent();
            this.Text = mySettings.GetAppName();
        }

    }
}
