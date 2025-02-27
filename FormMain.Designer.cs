namespace PR4
{
    partial class FormMain
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
            panel1 = new Panel();
            buttonTypes = new Button();
            buttonTypesProducts = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonTypes);
            panel1.Controls.Add(buttonTypesProducts);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // buttonTypes
            // 
            buttonTypes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypes.Location = new Point(264, 12);
            buttonTypes.Name = "buttonTypes";
            buttonTypes.Size = new Size(217, 55);
            buttonTypes.TabIndex = 1;
            buttonTypes.Text = "Типы партнеров";
            buttonTypes.UseVisualStyleBackColor = true;
            buttonTypes.Click += buttonTypes_Click;
            // 
            // buttonTypesProducts
            // 
            buttonTypesProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTypesProducts.Location = new Point(23, 12);
            buttonTypesProducts.Name = "buttonTypesProducts";
            buttonTypesProducts.Size = new Size(217, 55);
            buttonTypesProducts.TabIndex = 0;
            buttonTypesProducts.Text = "Типы продукции";
            buttonTypesProducts.UseVisualStyleBackColor = true;
            buttonTypesProducts.Click += buttonTypesProducts_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonTypes;
        private Button buttonTypesProducts;
    }
}