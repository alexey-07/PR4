using Microsoft.EntityFrameworkCore;

namespace PR4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            using (PartnersContext db = new PartnersContext())
            {
                var partners = db.Partners.Include(u=>u.IdTypeOfPartnerNavigation).ToList();
                int yOffset = 10;
                foreach (Partner u in partners)
                {
                    Panel panelPartn = new Panel
                    {
                        AutoSize = true,
                       Location = new System.Drawing.Point(15, yOffset),
                        BorderStyle = BorderStyle.FixedSingle,
                    };


                    Label partnerLabel = new Label
                    {
                        Text = $"{u.IdTypeOfPartnerNavigation.TypeOfPartner1}| " +
                       $"{u.NameProduct}\n" +
                       $"{u.DirectorsName}\n" +
                       $"{u.MobilePhone}\n"+
                       $"Рейтинг: {u.Rating}",
                       AutoSize= true,

                    };

                   panelPartn.Controls.Add( partnerLabel);
                    panelFill.Controls.Add( panelPartn );
                    yOffset += panelPartn.Height + 15;
                }
            }
 
        }
    }
}
