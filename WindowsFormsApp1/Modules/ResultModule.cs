using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Modules
{
    public partial class ResultModule : UserControl
    {
        public double Result
        {
            set {
                labelResult.Text = value.ToString();
            }
        }

        public ResultModule()
        {
            InitializeComponent();
        }
    }
}
