using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer_calculator
{
    public class Result
    {
        public double turns_primary;
        public double turns_secondary;
        public double diameter_primary;
        public double diameter_secondary;
        public double turns_per_volts;
        public double core_area;
        public double primary_current;
        public double secondary_current;
        public double number_of_layers_primary;
        public double number_of_layers_secondary;
        public double width_of_layers_primary;
        public double width_of_layers_secondary;

        public string[] standard_diameter_string = new string[]   { "8.25246",
                                                                    "7.34822",
                                                                    "6.54304",
                                                                    "5.82676",
                                                                    "5.18922",
                                                                    "4.62026",
                                                                    "4.1148",
                                                                    "3.66522",
                                                                    "3.2639",
                                                                    "2.90576",
                                                                    "2.58826",
                                                                    "2.30378",
                                                                    "2.05232",
                                                                    "1.8288",
                                                                    "1.62814",
                                                                    "1.45034",
                                                                    "1.29032",
                                                                    "1.15062",
                                                                    "1.02362",
                                                                    "0.91186",
                                                                    "0.8128",
                                                                    "0.7239",
                                                                    "0.64516",
                                                                    "0.57404",
                                                                    "0.51054",
                                                                    "0.45466",
                                                                    "0.40386",
                                                                    "0.36068",
                                                                    "0.32004",
                                                                    "0.28702",
                                                                    "0.254",
                                                                    "0.22606",
                                                                    "0.2032",
                                                                    "0.2",
                                                                    "0.18034",
                                                                    "0.18",
                                                                    "0.16002",
                                                                    "0.16002",
                                                                    "0.14224",
                                                                    "0.14",
                                                                    "0.127",
                                                                    "0.125",
                                                                    "0.1143",
                                                                    "0.112",
                                                                    "0.1016"
                                                                     };
    }
}
