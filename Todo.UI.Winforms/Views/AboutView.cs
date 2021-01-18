using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.UI.Winforms.Presenters;

namespace Todo.UI.Winforms.Views
{
    partial class AboutView : Form, IAboutView
    {
        public AboutView()
        {
            InitializeComponent();
            //this.Text = String.Format("About {0}", AssemblyTitle);
            //this.labelProductName.Text = AssemblyProduct;
            //this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            //this.labelCopyright.Text = AssemblyCopyright;
            //this.labelCompanyName.Text = AssemblyCompany;
            //this.textBoxDescription.Text = AssemblyDescription;
        }

        public string AssemblyTitle
        {
            set { this.Text = String.Format("About {0}", value); }
        }
        public string AssemblyProduct
        {
            set { this.labelProductName.Text = value; }
        }
        public string AssemblyDescription
        {
            set { this.textBoxDescription.Text = value; }
        }
        public string AssemblyVersion
        {
            set { this.labelVersion.Text = String.Format("Version {0}", value); }
        }
        public string AssemblyCopyright
        {
            set { this.labelCopyright.Text = value; }
        }
        public string AssemblyCompany
        {
            set { this.labelCompanyName.Text = value; }
        }

        public AboutPresenter MyAboutPresenter { private get; set; }

        public void DisplayView()
        {
            this.ShowDialog();
        }
    }
}
