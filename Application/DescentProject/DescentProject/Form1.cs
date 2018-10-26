using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescentProject
{
    public partial class frmDescent : Form
    {
        public frmDescent()
        {
            InitializeComponent();
            initMenu();
        }

        private void initMenu() {
            initMenuExpansion();
        }
        private void initMenuExpansion(){
            tsmExpansion.DropDownItems.Clear();
            //Lecture des expansion

            tsmExpansion.DropDownItems.Add("Basic");
        }

    }
}
