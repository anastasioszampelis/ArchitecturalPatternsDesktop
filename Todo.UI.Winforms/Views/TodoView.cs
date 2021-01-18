using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todo.Shared.Models;
using Todo.UI.Winforms.Helpers;
using Todo.UI.Winforms.Presenters;
using Todo.UI.Winforms.Views;

namespace Todo.UI.Winforms
{
    public partial class TodoView : Form, ITodoView
    {
        private readonly IMyAppSettingsHandler _mySettings;
        public TodoView(IMyAppSettingsHandler mySettings)
        {
            InitializeComponent();
            this._mySettings = mySettings;
            this.HandleUIInitialization();
            TodoList = new BindingList<MyTodo>();
        }

        private void HandleUIInitialization()
        {
            notifyIcon.Icon = SystemIcons.Application;
            txtTodoId.ReadOnly = true;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.WindowState = FormWindowState.Maximized;
            this.Text = _mySettings.GetAppName();
            dgvTodos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodos.MultiSelect = false;
            dgvTodos.ReadOnly = true;
            dgvTodos.AllowUserToAddRows = false;
            dgvTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtpTodoDate.Format = DateTimePickerFormat.Custom;
            dtpTodoDate.CustomFormat = "dd-MM-yyyy";
            dtpTodoTime.Format = DateTimePickerFormat.Time;
            dtpTodoTime.ShowUpDown = true;
        }

        public void DisplayView()
        {
            this.Show();
        }

        public BindingList<MyTodo> TodoList
        {
            get { return (BindingList<MyTodo>)this.dgvTodos.DataSource; }
            set { this.dgvTodos.DataSource = value; }
        }
        public MyTodo SelectedTodo { get; set; }

        private bool IsEdit
        {
            get { return this.chkAddOrEdit.Checked; }
            set { this.chkAddOrEdit.Checked = value; }
        }
        public string TodoId
        {
            get { return this.txtTodoId.Text; }
            set { this.txtTodoId.Text = value; }
        }
        public string TodoDescription
        {
            get { return this.txtTodoDescription.Text; }
            set { this.txtTodoDescription.Text = value; }
        }

        public DateTime TodoDateAndTime
        {
            get
            {
                DateTime myDate = dtpTodoDate.Value.Date +
                    dtpTodoTime.Value.TimeOfDay;
                return myDate;
            }
            set
            {
                dtpTodoDate.Value = value.Date;
                dtpTodoTime.Value = value.Date + value.TimeOfDay;
            }
        }
        public bool TodoImportance
        {
            get { return this.chkTodoImportance.Checked; }
            set { this.chkTodoImportance.Checked = value; }
        }
        public TodoPresenter MyTodoPresenter { private get; set; }


        private void dgvTodos_SelectionChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (TodoList.Any())
            {
                UpdateSelectedTodoView();
            }
        }
        private void UpdateSelectedTodoView()
        {
            if (!IsEdit)
            {
                var newTodo = new MyTodo()
                {
                    Description = string.Empty,
                    Important = false,
                    ToDoDateTime = DateTime.Now
                };
                MyTodoPresenter.UpdateSelectedTodoView(newTodo);
            }
            else
            {
                MyTodoPresenter.UpdateSelectedTodoView((MyTodo)dgvTodos.CurrentRow.DataBoundItem);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chkAddOrEdit.Text = IsEdit ? "Edit" : "Add";
            UpdateSelectedTodoView();
        }

        private void btnTodoSaveChanges_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            var response = MyTodoPresenter.SetUpdatedValuesToSelectedTodo();
            if (response.Item2.Any())
            {
                foreach (ValidationResult result in response.Item2)
                {
                    switch (result.MemberNames.First())
                    {
                        case "Description":
                            errorProvider.SetError(txtTodoDescription, result.ErrorMessage);
                            break;
                        default:
                            MessageBox.Show(result.ErrorMessage, _mySettings.GetAppName());
                            break;
                    }
                }
            }
            else
            {
                var updateResponse = MyTodoPresenter.SaveChanges(response.Item1);
                if (!updateResponse.Item1)
                { 
                    MessageBox.Show(updateResponse.Item2, _mySettings.GetAppName());
                }
                else
                {
                    notifyIcon.BalloonTipText = updateResponse.Item2;
                    notifyIcon.BalloonTipTitle = _mySettings.GetAppName();
                    notifyIcon.ShowBalloonTip(3);
                }
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MyTodoPresenter.ShowAboutForm();
        }
    }
}
