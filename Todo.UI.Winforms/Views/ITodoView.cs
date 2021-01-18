using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Shared.Models;
using Todo.UI.Winforms.Presenters;

namespace Todo.UI.Winforms.Views
{
    public interface ITodoView
    {
        BindingList<MyTodo> TodoList { get; set; }
        MyTodo SelectedTodo { get; set; }
        string TodoId { get; set; }
        string TodoDescription { get; set; }

        DateTime TodoDateAndTime { get; set; }
        bool TodoImportance { get; set; }
        TodoPresenter MyTodoPresenter { set; }

        void DisplayView();
    }
}
