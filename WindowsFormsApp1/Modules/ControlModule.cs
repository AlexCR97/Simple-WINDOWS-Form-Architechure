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
    public partial class ControlModule : UserControl
    {
        public ParentForm GlobalForm { get; set; }

        public ControlModule()
        {
            InitializeComponent();

            btnInputs.Click += (s, e) =>
            {
                GlobalForm.SumModule.BackColor = Color.Blue;
            };

            btnModules.Click += (s, e) =>
            {
                GlobalForm.ResultModule.BackColor = Color.Red;
            };
        }
    }
}
