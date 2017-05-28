using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformer_calculator
{
    public class Calculate : ICalculate
    {
        //private Result result;

        public Result do_calculation(Input input)
        {
            Result result = new Result();
            double core_area = 1.156 * Math.Sqrt(input.power);
            if (input.core_area > 0)
            {
                result.core_area = input.core_area;
            }
            else if (input.area_a > 0 && input.area_b > 0)
            {
                result.core_area = input.area_a * input.area_b;
            }
            if (core_area > result.core_area) result.core_area = core_area;

            result.turns_per_volts = 10000 / (4.44 * input.frequency * input.magnetic_flux_density * result.core_area);
            
            result.turns_primary = result.turns_per_volts * input.primary_voltage;
            result.primary_current = input.power / input.primary_voltage;
            result.diameter_primary = 1.128 * Math.Sqrt(result.primary_current / input.wire_current_density);

            result.turns_primary = Math.Round(result.turns_primary, 3);
            result.diameter_primary = Math.Round(result.diameter_primary, 3);

            result.turns_secondary = result.turns_per_volts * input.secondary_voltage;
            result.secondary_current = input.power / input.secondary_voltage;
            result.diameter_secondary = 1.128 * Math.Sqrt(result.secondary_current / input.wire_current_density);

            result.turns_secondary = Math.Round(result.turns_secondary, 3);
            result.diameter_secondary = Math.Round(result.diameter_secondary, 3);

            result = calculate_layers(result, input);

            return result;
        }

        public Result calculate_layers(Result result, Input input)
        {

            result.number_of_layers_primary = result.turns_primary * result.diameter_primary / input.length_c;
            result.number_of_layers_primary = Math.Round(result.number_of_layers_primary, 3);
            result.width_of_layers_primary = result.number_of_layers_primary * result.diameter_primary;
            result.width_of_layers_primary = Math.Round(result.width_of_layers_primary, 3);

            result.number_of_layers_secondary = result.turns_secondary * result.diameter_secondary / input.length_c;
            result.number_of_layers_secondary = Math.Round(result.number_of_layers_secondary, 3);
            result.width_of_layers_secondary = result.number_of_layers_secondary * result.diameter_secondary;
            result.width_of_layers_secondary = Math.Round(result.width_of_layers_secondary, 3);

            return result;
        }
    }
}
