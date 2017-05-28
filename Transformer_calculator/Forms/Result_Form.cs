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
    public partial class Result_Form : Form
    {
        private Result data_result = new Result();
        private Calculate calc = new Calculate();
        private Input data_input;
        public Result_Form()
        {
            InitializeComponent();
            cbox_standard_diameter_primary.Items.AddRange(data_result.standard_diameter_string);
            cbox_standard_diameter_secondary.Items.AddRange(data_result.standard_diameter_string);
        }
        public void show(Result result, Input input)
        {
            data_result = result;
            data_input = input;
            txt_turns_primary.Text = result.turns_primary.ToString();
            txt_diameter_primary.Text = result.diameter_primary.ToString();
            txt_layers_primary.Text = result.number_of_layers_primary.ToString();
            txt_width_primary.Text = result.width_of_layers_primary.ToString();

            txt_turns_secondary.Text = result.turns_secondary.ToString();
            txt_diameter_secondary.Text = result.diameter_secondary.ToString();
            txt_layers_secondary.Text = result.number_of_layers_secondary.ToString();
            txt_width_secondary.Text = result.width_of_layers_secondary.ToString();

            txt_core_area.Text = result.core_area.ToString();
        }

        private void cbox_standard_diameter_primary_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_result.diameter_primary = double.Parse(cbox_standard_diameter_primary.Text);
            calc.calculate_layers(data_result, data_input);
            show(data_result, data_input);
        }

        private void cbox_standard_diameter_secondary_SelectedIndexChanged(object sender, EventArgs e)
        {
            data_result.diameter_secondary = double.Parse(cbox_standard_diameter_secondary.Text);
            calc.calculate_layers(data_result, data_input);
            show(data_result, data_input);
        }
    }
}
