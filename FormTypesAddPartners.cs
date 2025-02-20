namespace PR4
{
    public partial class FormTypesAddPartners : Form
    {
        string msgError = "Поле не может быть пустым";
        public FormTypesAddPartners()
        {
            InitializeComponent();
        }

        private void flowLayoutPanelFill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void TextBoxTypeName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxTypeName_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxTypeName.Text))
            {
                errorProvider.SetError(textBoxTypeName, msgError);
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
