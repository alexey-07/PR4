using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR4
{
    public partial class InfoProducts : Form
    {
        private AppContext db;

        public InfoProducts()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new AppContext();
            db.TypeOfProducts.Load();
            dataGridViewTypes.DataSource = db.TypeOfProducts.Local.OrderBy(o => o.TypeNameProduct).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["Products"].Visible = false;

            dataGridViewTypes.Columns["TypeNameProduct"].HeaderText = "Тип";
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db?.Dispose();
            db = null;
        }

        private void ButtonTypeAdd_Click(object sender, EventArgs e)
        {
            FormTypesAddProducts formTypesAdd = new FormTypesAddProducts();
            DialogResult result = formTypesAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (formTypesAdd.textBoxTypeName.Text == String.Empty)
                MessageBox.Show("Поле не может быть пустым!");

            TypeOfProduct typeOfProduct = new TypeOfProduct();
            typeOfProduct.TypeNameProduct = formTypesAdd.textBoxTypeName.Text;

            db.TypeOfProducts.Add(typeOfProduct);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен!");
            dataGridViewTypes.DataSource = db.TypeOfProducts.Local.OrderBy(o => o.TypeNameProduct).ToList();

        }

        private void ButtonTypeEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count > 0)
            {
                int index = dataGridViewTypes.SelectedRows[0].Index;
                short id = 0;
                bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);

                if (!converted)
                    return;

                TypeOfProduct typeOfProduct = db.TypeOfProducts.Find(id);

                FormTypesAddPartners formTypesAdd = new();
                formTypesAdd.textBoxTypeName.Text = typeOfProduct.TypeNameProduct;
                DialogResult result = formTypesAdd.ShowDialog(this);
                if (result == DialogResult.Cancel)
                {
                    return;

                }
                typeOfProduct.TypeNameProduct = formTypesAdd.textBoxTypeName.Text;
                db.SaveChanges();
                MessageBox.Show("Объект изменен!");
                dataGridViewTypes.DataSource = db.TypeOfProducts.Local.OrderBy(o => o.TypeNameProduct).ToList();
            }

        }

        private void ButtonTypeDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTypes.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show(
               "Вы уверены, что хотите удалить объект?",
               "",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            int index = dataGridViewTypes.SelectedRows[0].Index;
            short id = 0;
            bool converted = Int16.TryParse(dataGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            TypeOfProduct typeOfProduct = db.TypeOfProducts.Find(id);
            db.TypeOfProducts.Remove(typeOfProduct);
            db.SaveChanges();
            MessageBox.Show("Объект удален!");
            dataGridViewTypes.DataSource = db.TypeOfProducts.Local.OrderBy(o => o.TypeNameProduct).ToList();
        }
    }
}
