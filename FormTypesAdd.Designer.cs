namespace PR4
{
    partial class FormTypesAdd
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
            components = new System.ComponentModel.Container();
            panelFIll = new Panel();
            textBoxTypeName = new TextBox();
            labelTypeName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFIll.SuspendLayout();
            flowLayoutPanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFIll
            // 
            panelFIll.Controls.Add(textBoxTypeName);
            panelFIll.Controls.Add(labelTypeName);
            panelFIll.Dock = DockStyle.Fill;
            panelFIll.Location = new Point(0, 0);
            panelFIll.Name = "panelFIll";
            panelFIll.Padding = new Padding(15);
            panelFIll.Size = new Size(384, 176);
            panelFIll.TabIndex = 0;
            // 
            // textBoxTypeName
            // 
            textBoxTypeName.Dock = DockStyle.Top;
            textBoxTypeName.Location = new Point(15, 40);
            textBoxTypeName.Name = "textBoxTypeName";
            textBoxTypeName.Size = new Size(354, 33);
            textBoxTypeName.TabIndex = 1;
            textBoxTypeName.TextChanged += textBoxTypeName_TextChanged;
            textBoxTypeName.Validated += textBoxTypeName_Validated;
            // 
            // labelTypeName
            // 
            labelTypeName.AutoSize = true;
            labelTypeName.Dock = DockStyle.Top;
            labelTypeName.Location = new Point(15, 15);
            labelTypeName.Name = "labelTypeName";
            labelTypeName.Size = new Size(145, 25);
            labelTypeName.TabIndex = 0;
            labelTypeName.Text = "Тип Партнеров";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(buttonSave);
            flowLayoutPanelBottom.Controls.Add(buttonCancel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(0, 76);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10);
            flowLayoutPanelBottom.Size = new Size(384, 100);
            flowLayoutPanelBottom.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(219, 25);
            buttonSave.Margin = new Padding(15);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(130, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(59, 25);
            buttonCancel.Margin = new Padding(15);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(130, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormTypesAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 176);
            Controls.Add(flowLayoutPanelBottom);
            Controls.Add(panelFIll);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypesAdd";
            panelFIll.ResumeLayout(false);
            panelFIll.PerformLayout();
            flowLayoutPanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFIll;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelTypeName;
        protected internal TextBox textBoxTypeName;
        private ErrorProvider errorProvider;
    }
}