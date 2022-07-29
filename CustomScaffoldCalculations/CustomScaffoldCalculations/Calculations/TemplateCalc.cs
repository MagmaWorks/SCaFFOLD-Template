using CalcCore;
using System.Collections.Generic;

namespace TestScaffoldCalc.Calculations
{
    [CalcName("Test Calc")]
    public class TemplateCalc : CalcBase
    {
        CalcDouble _templateExample;
        CalcDouble _someOutput;

        public TemplateCalc()
        {
            //
            // Inputs
            //
            _templateExample = inputValues.CreateDoubleCalcValue("example", @"\gamma", @"N/mm^2", 100);

            //
            // Outputs
            //
            _someOutput = outputValues.CreateDoubleCalcValue("output", @"\alpha", @"N/mm^2", 0);
        }


        public override List<Formula> GenerateFormulae()
        {
            return new List<Formula>();
        }

        public override void UpdateCalc()
        {
            formulae = new List<Formula>();

            // add your calc logic here
            _someOutput.Value = _templateExample.Value / 2;

            // add formulae and commentary as you work through
            formulae.Add(Formula.FormulaWithNarrative("Calculate output")
                .AddExpression(_someOutput.Symbol + "=" + _templateExample.Symbol + "/2")
                .AddExpression(_someOutput.Symbol + "=" + _templateExample.Value + "/2")
                .AddExpression(_someOutput.Symbol + "=" + _someOutput.Value + _someOutput.Unit)
                .AddRef("a code clause")
                );
 
        }
    }
}
