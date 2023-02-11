using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        private void frmGridView_Load(object sender, EventArgs e)
        {

            Person[] persons = new Person[5];
            persons[0] = new Person();
            persons[0].FirstName = "Ammar";
            persons[0].LastName = "Ali";
            persons[0].city = "Sukkur";

            persons[1] = new Person();
            persons[1].FirstName = "Sahil";
            persons[1].LastName = "Kah==";
            persons[1].city = "Sukkur";

            persons[2] = new Person();
            persons[2].FirstName = "Ammar";
            persons[2].LastName = "Ali";
            persons[2].city = "Sukkur";

            persons[3] = new Person();
            persons[3].FirstName = "Ammar";
            persons[3].LastName = "Ali";
            persons[3].city = "Sukkur";

            persons[4] = new Person();
            persons[4].FirstName = "Ammar";
            persons[4].LastName = "Ali";
            persons[4].city = "Sukkur";

            persons[5] = new Person();
            persons[5].FirstName = "Ammar";
            persons[5].LastName = "Ali";
            persons[5].city = "Sukkur";


        }
    }
}
