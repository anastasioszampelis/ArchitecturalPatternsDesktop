using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Shared.Extensions;
using Todo.Shared.Interfaces;
using Todo.Shared.Models;
using Todo.UI.Winforms.Views;

namespace Todo.UI.Winforms.Presenters
{
    public class TodoPresenter
    {
        private readonly ITodoRepository _repository;
        private readonly ITodoView _view;
        private readonly Lazy<IAboutPresenter> _aboutPresenter;
        public TodoPresenter(ITodoRepository repository, ITodoView view, Lazy<IAboutPresenter> aboutPresenter)
        {
            _view = view;
            _view.MyTodoPresenter = this;
            this._repository = repository;
            this._aboutPresenter = aboutPresenter;
            UpdateTodoListView();
        }

        public void UpdateSelectedTodoView(MyTodo todo)
        {
            var selectedTodo = todo.Id != null ? _repository.GetMyTodo(todo.Id.Value) : todo;
            _view.SelectedTodo = selectedTodo;
            _view.TodoId = selectedTodo.Id?.ToString();
            _view.TodoDescription = selectedTodo.Description;
            _view.TodoImportance = selectedTodo.Important;
            _view.TodoDateAndTime = selectedTodo.ToDoDateTime;
        }

        public void DisplayView()
        {
            _view.DisplayView();
        }

        private void UpdateTodoListView()
        {
            _view.TodoList.Clear();
            var todoList = _repository.GetAllTodos().ToList();
            BindingListExtensions.AddRange(_view.TodoList, todoList);
        }

        public Tuple<MyTodo, List<ValidationResult>> SetUpdatedValuesToSelectedTodo()
        {
            int outValue;
            var selectedTodo = new MyTodo()
            {
                Id = int.TryParse(_view.TodoId, out outValue) ? (int?)outValue : null,
                Description = _view.TodoDescription,
                ToDoDateTime = _view.TodoDateAndTime,
                Important = _view.TodoImportance
            };

            List<ValidationResult> errors = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(selectedTodo, null, null);
            Validator.TryValidateObject(selectedTodo, context, errors, true);
            return new Tuple<MyTodo, List<ValidationResult>>(selectedTodo, errors); 
        }

        public Tuple<bool, string> SaveChanges(MyTodo myTodo)
        {
            Tuple<bool, string> response;
            if (myTodo.Id == null)
            {
                response = _repository.AddTodo(myTodo);
            }
            else
            {
                response = _repository.UpdateTodo(myTodo);
            }
            if (response.Item1)
            {
                UpdateTodoListView();
            }
            return response;
        }

        public void ShowAboutForm()
        {
            _aboutPresenter.Value.DisplayView();
        }
    }
}
