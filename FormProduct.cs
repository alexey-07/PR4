//using Microsoft.EntityFrameworkCore;
//using System.ComponentModel;
//using System.Data;

//namespace PR4
//{
//    public partial class FormProduct : Form
//    {
//        private PartnersContext db;

//        public FormProduct()
//        {
//            InitializeComponent();
//        }
//        protected override void OnLoad(EventArgs e)
//        {
//            base.OnLoad(e);
//            this.db = new PartnersContext();
//            this.db.TypeOfPartner.Load();
//            this.dataGridViewTypes.DataSource = db.TypeOfPartner.Local.OrderBy(o => o.TypeProducts1).ToList();
//            dataGridViewTypes.Columns["Id"].Visible = false;
//            dataGridViewTypes.Columns["Products"].Visible = false;

//            dataGridViewTypes.Columns["TypeProducts1"].HeaderText = "Тип";
//        }

//        protected override void OnClosing(CancelEventArgs e)
//        {
//            base.OnClosing(e);
//            this.db?.Dispose();
//            this.db = null;
//        }

//        private void ButtonTypeAdd_Click(object sender, EventArgs e)
//        {
//            FormTypesAdd formTypesAdd = new FormTypesAdd();
//            DialogResult result = formTypesAdd.ShowDialog(this);

//            if (result == DialogResult.Cancel)
//            {
//                return;
//            }

//            if (formTypesAdd.textBoxTypeName.Text == String.Empty)
//                MessageBox.Show("Поле не может быть пустым!");

//            TypeProduct typeOfProduct = new TypeProduct();
//            typeOfProduct.TypeProduct = formTypesAdd.textBoxTypeName.Text;

//            db.TypeOfPartner.Add(typeOfProduct);
//            db.SaveChanges();

//            MessageBox.Show("Новый объект добавлен!");
//            this.dataGridViewTypes.DataSource = this.db.TypeProducts1.Local.OrderBy(o => o.TypeProducts1).ToList();

//        }

//        private void ButtonTypeEdit_Click(object sender, EventArgs e)
//        {
//            if (dataGridViewTypes.SelectedRows.Count > 0)
//            {
//                int index = dataGridViewTypes.SelectedRows[0].Index;
//                short id = 0;
//                bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);

//                if (!converted)
//                    return;

//                TypeProduct typeOfProduct = db.TypeOfPartner.Find(id);

//                FormTypesAdd formTypesAdd = new();
//                formTypesAdd.textBoxTypeName.Text = typeOfProduct.TypeProducts1;
//                DialogResult result = formTypesAdd.ShowDialog(this);
//                if (result == DialogResult.Cancel)
//                {
//                    return;

//                }
//                typeOfProduct.TypeProducts1 = formTypesAdd.textBoxTypeName.Text;
//                db.SaveChanges();
//                MessageBox.Show("Объект изменен!");
//                this.dataGridViewTypes.DataSource = this.db.TypeOfPartner.Local.OrderBy(o => o.TypeProducts1).ToList();
//            }

//        }

//        private void buttonTypeDelete_Click(object sender, EventArgs e)
//        {
//            if (dataGridViewTypes.SelectedRows.Count == 0)
//                return;
//            DialogResult result = MessageBox.Show(
//               "Вы уверены, что хотите удалить объект?",
//               "",
//               MessageBoxButtons.YesNo,
//               MessageBoxIcon.Question);
//            if (result == DialogResult.No)
//                return;
//            int index = dataGridViewTypes.SelectedRows[0].Index;
//            short id = 0;
//            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
//            if (!converted)
//                return;

//            TypeProduct typeOfProduct = db.TypeOfPartner.Find(id);
//            db.TypeOfPartner.Remove(typeOfProduct);
//            db.SaveChanges();
//            MessageBox.Show("Объект удален!");
//            this.dataGridViewTypes.DataSource = this.db.TypeOfPartner.Local.OrderBy(o => o.TypeOfPartner1).ToList();
//        }
//    }
//}
