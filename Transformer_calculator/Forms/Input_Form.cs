using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer_calculator
{
    public partial class Transformer_calculator_form : Form
    {
        public Transformer_calculator_form()
        {
            InitializeComponent();
        }

        private Input data_in = new Input();
        private ICalculate calc = new Calculate();
        private Result data_result = new Result();
        private Result_Form result_form;

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            bool result = double.TryParse(txt_power.Text, out data_in.power);
            result &= double.TryParse(txt_primary_voltage.Text, out data_in.primary_voltage);
            result &= double.TryParse(txt_secondary_voltage.Text, out data_in.secondary_voltage);
            result &= double.TryParse(txt_magnetic_flux_density.Text, out data_in.magnetic_flux_density);
            result &= double.TryParse(txt_frequency.Text, out data_in.frequency);
            result &= double.TryParse(txt_efficiency.Text, out data_in.effieciency);
            result &= double.TryParse(txt_wire_current_density.Text, out data_in.wire_current_density);
            double.TryParse(txt_area_of_core.Text, out data_in.core_area);
            double.TryParse(txt_a.Text, out data_in.area_a);
            double.TryParse(txt_b.Text, out data_in.area_b);
            result &= double.TryParse(txt_c.Text, out data_in.length_c);
            if (result == false)
            {
                MessageBox.Show("Please fill in input with proper values.");
                return;
            }
            data_result = calc.do_calculation(data_in);
            result_form = new Result_Form();
            result_form.show(data_result, data_in);
            result_form.Show();
        }
    }
}
