namespace Todo.UI.Winforms
{
    partial class TodoView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlpTodo = new System.Windows.Forms.TableLayoutPanel();
            this.chkTodoImportance = new System.Windows.Forms.CheckBox();
            this.lblTodoId = new System.Windows.Forms.Label();
            this.lblTodoDescription = new System.Windows.Forms.Label();
            this.lblTodoDate = new System.Windows.Forms.Label();
            this.lblTodoTime = new System.Windows.Forms.Label();
            this.dtpTodoDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTodoTime = new System.Windows.Forms.DateTimePicker();
            this.txtTodoDescription = new System.Windows.Forms.TextBox();
            this.txtTodoId = new System.Windows.Forms.TextBox();
            this.btnTodoSaveChanges = new System.Windows.Forms.Button();
            this.chkAddOrEdit = new System.Windows.Forms.CheckBox();
            this.dgvTodos = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTodo
            // 
            this.tlpTodo.ColumnCount = 4;
            this.tlpTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTodo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpTodo.Controls.Add(this.chkTodoImportance, 1, 5);
            this.tlpTodo.Controls.Add(this.lblTodoId, 1, 1);
            this.tlpTodo.Controls.Add(this.lblTodoDescription, 1, 2);
            this.tlpTodo.Controls.Add(this.lblTodoDate, 1, 3);
            this.tlpTodo.Controls.Add(this.lblTodoTime, 1, 4);
            this.tlpTodo.Controls.Add(this.dtpTodoDate, 2, 3);
            this.tlpTodo.Controls.Add(this.dtpTodoTime, 2, 4);
            this.tlpTodo.Controls.Add(this.txtTodoDescription, 2, 2);
            this.tlpTodo.Controls.Add(this.txtTodoId, 2, 1);
            this.tlpTodo.Controls.Add(this.btnTodoSaveChanges, 2, 6);
            this.tlpTodo.Controls.Add(this.chkAddOrEdit, 1, 6);
            this.tlpTodo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpTodo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlpTodo.Location = new System.Drawing.Point(0, 41);
            this.tlpTodo.Name = "tlpTodo";
            this.tlpTodo.RowCount = 8;
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpTodo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpTodo.Size = new System.Drawing.Size(669, 278);
            this.tlpTodo.TabIndex = 0;
            // 
            // chkTodoImportance
            // 
            this.chkTodoImportance.AutoSize = true;
            this.chkTodoImportance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTodoImportance.Location = new System.Drawing.Point(170, 153);
            this.chkTodoImportance.Name = "chkTodoImportance";
            this.chkTodoImportance.Size = new System.Drawing.Size(161, 24);
            this.chkTodoImportance.TabIndex = 6;
            this.chkTodoImportance.Text = "Important?";
            this.chkTodoImportance.UseVisualStyleBackColor = true;
            // 
            // lblTodoId
            // 
            this.lblTodoId.AutoSize = true;
            this.lblTodoId.Location = new System.Drawing.Point(170, 30);
            this.lblTodoId.Name = "lblTodoId";
            this.lblTodoId.Size = new System.Drawing.Size(23, 21);
            this.lblTodoId.TabIndex = 0;
            this.lblTodoId.Text = "Id";
            this.lblTodoId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodoDescription
            // 
            this.lblTodoDescription.AutoSize = true;
            this.lblTodoDescription.Location = new System.Drawing.Point(170, 60);
            this.lblTodoDescription.Name = "lblTodoDescription";
            this.lblTodoDescription.Size = new System.Drawing.Size(89, 21);
            this.lblTodoDescription.TabIndex = 2;
            this.lblTodoDescription.Text = "Description";
            this.lblTodoDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodoDate
            // 
            this.lblTodoDate.AutoSize = true;
            this.lblTodoDate.Location = new System.Drawing.Point(170, 90);
            this.lblTodoDate.Name = "lblTodoDate";
            this.lblTodoDate.Size = new System.Drawing.Size(42, 21);
            this.lblTodoDate.TabIndex = 3;
            this.lblTodoDate.Text = "Date";
            this.lblTodoDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodoTime
            // 
            this.lblTodoTime.AutoSize = true;
            this.lblTodoTime.Location = new System.Drawing.Point(170, 120);
            this.lblTodoTime.Name = "lblTodoTime";
            this.lblTodoTime.Size = new System.Drawing.Size(44, 21);
            this.lblTodoTime.TabIndex = 8;
            this.lblTodoTime.Text = "Time";
            // 
            // dtpTodoDate
            // 
            this.dtpTodoDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTodoDate.Location = new System.Drawing.Point(337, 93);
            this.dtpTodoDate.Name = "dtpTodoDate";
            this.dtpTodoDate.Size = new System.Drawing.Size(161, 29);
            this.dtpTodoDate.TabIndex = 4;
            // 
            // dtpTodoTime
            // 
            this.dtpTodoTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTodoTime.Location = new System.Drawing.Point(337, 123);
            this.dtpTodoTime.Name = "dtpTodoTime";
            this.dtpTodoTime.Size = new System.Drawing.Size(161, 29);
            this.dtpTodoTime.TabIndex = 9;
            // 
            // txtTodoDescription
            // 
            this.txtTodoDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTodoDescription.Location = new System.Drawing.Point(337, 63);
            this.txtTodoDescription.Name = "txtTodoDescription";
            this.txtTodoDescription.Size = new System.Drawing.Size(161, 29);
            this.txtTodoDescription.TabIndex = 5;
            // 
            // txtTodoId
            // 
            this.txtTodoId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTodoId.Location = new System.Drawing.Point(337, 33);
            this.txtTodoId.Name = "txtTodoId";
            this.txtTodoId.Size = new System.Drawing.Size(161, 29);
            this.txtTodoId.TabIndex = 1;
            // 
            // btnTodoSaveChanges
            // 
            this.btnTodoSaveChanges.Location = new System.Drawing.Point(337, 183);
            this.btnTodoSaveChanges.Name = "btnTodoSaveChanges";
            this.btnTodoSaveChanges.Size = new System.Drawing.Size(161, 37);
            this.btnTodoSaveChanges.TabIndex = 7;
            this.btnTodoSaveChanges.Text = "Save";
            this.btnTodoSaveChanges.UseVisualStyleBackColor = true;
            this.btnTodoSaveChanges.Click += new System.EventHandler(this.btnTodoSaveChanges_Click);
            // 
            // chkAddOrEdit
            // 
            this.chkAddOrEdit.AutoSize = true;
            this.chkAddOrEdit.Location = new System.Drawing.Point(170, 183);
            this.chkAddOrEdit.Name = "chkAddOrEdit";
            this.chkAddOrEdit.Size = new System.Drawing.Size(57, 25);
            this.chkAddOrEdit.TabIndex = 10;
            this.chkAddOrEdit.Text = "Add";
            this.chkAddOrEdit.UseVisualStyleBackColor = true;
            this.chkAddOrEdit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgvTodos
            // 
            this.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodos.Location = new System.Drawing.Point(0, 24);
            this.dgvTodos.Name = "dgvTodos";
            this.dgvTodos.RowTemplate.Height = 25;
            this.dgvTodos.Size = new System.Drawing.Size(669, 17);
            this.dgvTodos.TabIndex = 1;
            this.dgvTodos.SelectionChanged += new System.EventHandler(this.dgvTodos_SelectionChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(669, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "&Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmiAbout.Text = "&About...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // TodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 319);
            this.Controls.Add(this.dgvTodos);
            this.Controls.Add(this.tlpTodo);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TodoView";
            this.Text = "Form1";
            this.tlpTodo.ResumeLayout(false);
            this.tlpTodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTodo;
        private System.Windows.Forms.DataGridView dgvTodos;
        private System.Windows.Forms.Label lblTodoId;
        private System.Windows.Forms.TextBox txtTodoId;
        private System.Windows.Forms.Label lblTodoDescription;
        private System.Windows.Forms.Label lblTodoDate;
        private System.Windows.Forms.DateTimePicker dtpTodoDate;
        private System.Windows.Forms.TextBox txtTodoDescription;
        private System.Windows.Forms.CheckBox chkTodoImportance;
        private System.Windows.Forms.Button btnTodoSaveChanges;
        private System.Windows.Forms.Label lblTodoTime;
        private System.Windows.Forms.DateTimePicker dtpTodoTime;
        private System.Windows.Forms.CheckBox chkAddOrEdit;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}

