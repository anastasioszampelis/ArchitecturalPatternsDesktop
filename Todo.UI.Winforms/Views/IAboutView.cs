using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.UI.Winforms.Presenters;

namespace Todo.UI.Winforms.Views
{
    public interface IAboutView
    {
        string AssemblyTitle { set; }
        string AssemblyVersion { set; }
        string AssemblyDescription { set; }
        string AssemblyProduct { set; }
        string AssemblyCopyright { set; }
        string AssemblyCompany { set; }
        AboutPresenter MyAboutPresenter { set; }
        void DisplayView();
    }
}
