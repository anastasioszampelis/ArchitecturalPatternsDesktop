using System;
using System.Collections.Generic;
using System.Text;
using Todo.Shared.Models;

namespace Todo.Shared.Interfaces
{
    public interface ITodoRepository
    {
        IEnumerable<MyTodo> GetAllTodos();

        MyTodo GetMyTodo(int id);

        Tuple<bool, string> UpdateTodo(MyTodo todo);
        Tuple<bool, string> AddTodo(MyTodo todo);
    }
}
