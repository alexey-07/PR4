namespace PR4
{
    partial class InfoProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            panelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.AutoSize = true;
            panelTop.Controls.Add(buttonTypeDelete);
            panelTop.Controls.Add(buttonTypeEdit);
            panelTop.Controls.Add(buttonTypeAdd);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(800, 79);
            panelTop.TabIndex = 1;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.AutoSize = true;
            buttonTypeDelete.Location = new Point(275, 36);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(120, 30);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            buttonTypeDelete.Click += ButtonTypeDelete_Click;
            // 
            // buttonTypeEdit
            // 
            buttonTypeEdit.AutoSize = true;
            buttonTypeEdit.Location = new Point(149, 36);
            buttonTypeEdit.Name = "buttonTypeEdit";
            buttonTypeEdit.Size = new Size(120, 30);
            buttonTypeEdit.TabIndex = 1;
            buttonTypeEdit.Text = "Редактировать";
            buttonTypeEdit.UseVisualStyleBackColor = true;
            buttonTypeEdit.Click += ButtonTypeEdit_Click;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.AutoSize = true;
            buttonTypeAdd.Location = new Point(23, 36);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(120, 30);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            buttonTypeAdd.Click += ButtonTypeAdd_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 79);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 371);
            panelFill.TabIndex = 2;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(780, 351);
            dataGridViewTypes.TabIndex = 0;
            // 
            // InfoProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Name = "InfoProducts";
            Text = "InfoProducts";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Button buttonTypeDelete;
        private Button buttonTypeEdit;
        private Button buttonTypeAdd;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
    }
}