using Microsoft.EntityFrameworkCore;

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
            this.dataGridViewTypes.DataSource = this.db.TypeOfPartners.Local.OrderBy(o=>o.TypeOfPartner1).ToList();
            dataGridViewTypes.Columns["TypeOfPartner1"].HeaderText = "“ип";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
 
        }
    }
}
