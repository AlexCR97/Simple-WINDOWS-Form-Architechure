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
    public partial class Module1 : UserControl
    {
        public double? Number1
        {
            get {
                try
                {
                    decimal value = inputNum1.Value;
                    return double.Parse(value.ToString());
                }
                catch
                {
                    return null;
                }
            }
        }

        public double? Number2
        {
            get {
                try
                {
                    decimal value = inputNum2.Value;
                    return double.Parse(value.ToString());
                }
                catch
                {
                    return null;
                }
            }
        }

        public Func<double, double> OnClickCallback { get; set; }

        public Module1()
        {
            InitializeComponent();

            btn.Click += (sender, ev) =>
            {
                var value1 = Number1 ?? 0;
                var value2 = Number2 ?? 0;
                var sum = value1 + value2;
                OnClickCallback(sum);
            };
        }
    }
}
