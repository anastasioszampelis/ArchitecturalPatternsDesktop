using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.UI.Winforms.Presenters
{
    public interface IAboutPresenter
    {
        void DisplayView();
        string GetAssemblyCompany();
        string GetAssemblyCopyright();
        string GetAssemblyDescription();
        string GetAssemblyProduct();
        string GetAssemblyTitle();
        string GetAssemblyVersion();
    }
}
