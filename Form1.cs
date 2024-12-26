using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PR4
{
    public partial class Form1 : Form
    {
        private PartnersContext db;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new PartnersContext();
            this.db.TypeOfPartners.Load();
            this.dataGridViewTypes.DataSource = this.db.TypeOfPartners.Local.OrderBy(o => o.TypeOfPartner1).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["Partners"].Visible = false;

            dataGridViewTypes.Columns["TypeOfPartner1"].HeaderText = "���";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void ButtonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypesAdd formTypesAdd = new FormTypesAdd();
            DialogResult result = formTypesAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (formTypesAdd.textBoxTypeName.Text == String.Empty)
                MessageBox.Show("���� �� ����� ���� ������!");

            TypeOfPartner typeOfPartner = new TypeOfPartner();
            typeOfPartner.TypeOfPartner1 = formTypesAdd.textBoxTypeName.Text;

            db.TypeOfPartners.Add(typeOfPartner);
            db.SaveChanges();

            MessageBox.Show("����� ������ ��������!");
            this.dataGridViewTypes.DataSource = this.db.TypeOfPartners.Local.OrderBy(o => o.TypeOfPartner1).ToList();

        }
    }
}
