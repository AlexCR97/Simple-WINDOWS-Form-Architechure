using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modules;

namespace WindowsFormsApp1
{
    public partial class ParentForm : Form
    {
        public Module1 SumModule { get; set; }
        public ResultModule ResultModule { get; set; }
        public ControlModule ControlModule { get; set; }

        public ParentForm()
        {
            InitializeComponent();

            SumModule = sumModule;
            ResultModule = resultModule;
            ControlModule = controlModule;

            ControlModule.GlobalForm = this;

            SumModule.OnClickCallback += (result) =>
            {
                ResultModule.Result = result;
                return result;
            };
        }
    }
}
