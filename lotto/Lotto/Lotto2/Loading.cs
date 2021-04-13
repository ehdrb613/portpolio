using Lotto2.json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto2
{
    public partial class Loading : Form
    {
        public static Loading loading;
        public Loading()
        {
            InitializeComponent();
            loading = this;
            
        }

        private void Loading_Shown(object sender, EventArgs e)
        {
            DataManager.urlJsonLoad();
        }
    }
}
