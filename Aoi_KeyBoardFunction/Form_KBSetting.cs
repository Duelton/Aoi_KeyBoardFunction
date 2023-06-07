using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aoi_KeyBoardFunction
{
    public partial class Form_KBSetting : Form
    {
        public Form_KBSetting()
        {
            InitializeComponent();
        }

        private Button FindButtonByName(string buttonName)
        {
            return Controls.OfType<Button>().FirstOrDefault(button => button.Name == buttonName);
        }


        private void Btn_ESC_Click(object sender, EventArgs e)
        {
            
        }

        private void TBX_Save_Click(object sender, EventArgs e)
        {

        }

        private void TBX_Apply_Click(object sender, EventArgs e)
        {

        }

        private void TBX_Clear_Click(object sender, EventArgs e)
        {

        }
    }
}
