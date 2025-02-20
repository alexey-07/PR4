namespace PR4
{
    partial class FormTypesAddProducts
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
            panelFIll = new Panel();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            panelFIll.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFIll
            // 
            panelFIll.Controls.Add(flowLayoutPanelBottom);
            panelFIll.Controls.Add(textBoxTypeName);
            panelFIll.Controls.Add(labelTypeName);
            panelFIll.Dock = DockStyle.Fill;
            panelFIll.Location = new Point(0, 0);
            panelFIll.Name = "panelFIll";
            panelFIll.Padding = new Padding(15);
            panelFIll.Size = new Size(405, 162);
            panelFIll.TabIndex = 1;
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(15, 71);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(375, 76);
            flowLayoutPanelBottom.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(195, 25);
            buttonSave.Margin = new Padding(15);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(145, 42);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(22, 25);
            buttonCancel.Margin = new Padding(15);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(143, 42);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTypeName.Location = new Point(15, 36);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(375, 29);
            textBoxTypeName.TabIndex = 1;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTypeName.Location = new Point(15, 15);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(120, 21);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип продукции";
            // 
            // FormTypesAddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 162);
            Controls.Add(panelFIll);
            Name = "FormTypesAddProducts";
            Text = "W";
            panelFIll.ResumeLayout(false);
            panelFIll.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFIll;
        protected internal TextBox textBoxTypeName;
        private Label labelTypeName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonSave;
        private Button buttonCancel;
    }
}