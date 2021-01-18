using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Todo.Shared.Interfaces;
using Todo.Shared.Models;

namespace Todo.DataAccess.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public ICollection<MyTodo> MyTodos { get; set; }
        public TodoRepository()
        {
            this.GenerateTodos();
        }
        public void GenerateTodos()
        {
            var todoIds = 1;
            var todosFaker = new Faker<MyTodo>()
                .StrictMode(true)
                .RuleFor(o => o.Id, f => todoIds++)
                .RuleFor(o => o.Description, f => f.Lorem.Sentence(5))
                .RuleFor(o => o.Important, f => f.Random.Bool())
                .RuleFor(o => o.ToDoDateTime, f => f.Date.Future(1));

            MyTodos = todosFaker.Generate(50);
        }
        public IEnumerable<MyTodo> GetAllTodos()
        {
            return MyTodos;
        }

        public MyTodo GetMyTodo(int id)
        {
            return MyTodos.Where(d => d.Id == id).SingleOrDefault();
        }



        public Tuple<bool, string> UpdateTodo(MyTodo todo)
        {
            try
            {
                var selectedTodo = this.GetMyTodo(todo.Id.Value);
                if (selectedTodo == null)
                {
                    throw new ArgumentNullException(nameof(selectedTodo));
                }
                else
                {
                    selectedTodo.Description = todo.Description;
                    selectedTodo.Important = todo.Important;
                    selectedTodo.ToDoDateTime = todo.ToDoDateTime;
                    return new Tuple<bool, string>(true, "Todo updated succesfully.");
                }
            }
            catch(ArgumentNullException ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
            catch(Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
        }

        public Tuple<bool, string> AddTodo(MyTodo todo)
        {
            try
            {
                var lastId = MyTodos.Select(d => d.Id).DefaultIfEmpty(0).Max();
                var newTodo = new MyTodo()
                {
                    Id = ++lastId,
                    Description = todo.Description,
                    Important = todo.Important,
                    ToDoDateTime = todo.ToDoDateTime
                };
                MyTodos.Add(newTodo);
                return new Tuple<bool, string>(true, "Todo added succesfully.");
            }
            catch (Exception ex)
            {
                return new Tuple<bool, string>(false, ex.Message);
            }
            
        }
    }
}
