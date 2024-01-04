using System.Collections.Generic;
using CalcCore;

namespace CustomScaffoldCalculations.Calculations
{
    /// <summary>
    /// This template is a starting point for creating a new calculation.
    /// After understanding the basics of this calculation,
    /// 
    /// you should edit:
    /// 
    /// - CalcName attribute to the name of your calculation
    /// 
    /// - The class, to have the correct name (spaces are not allowed), [Control + R + R] to rename
    /// 
    /// - Formula reference: https://katex.org/docs/supported.html
    /// 
    /// </summary>
 
    [CalcName("Rectangle area")]
    public class RectangleAreaCalc : CalcBase
    {
        //
        // Input declarations here
        //
        private CalcInt _length;
        private CalcInt _width;

        //
        // Output declarations here
        //
        private CalcInt _area;
        
        public RectangleAreaCalc()
        {
            //
            // Inputs
            //
            _length = inputValues.CreateIntCalcValue("Length", "L", "mm", 200);
            _width = inputValues.CreateIntCalcValue("Width", "W", "mm", 100);

            //
            // Outputs
            //
            _area = outputValues.CreateIntCalcValue("Area", "A", "mm2", _length.Value + _width.Value);
        }


        public override List<Formula> GenerateFormulae()
        {
            return new List<Formula>();
        }

        public override void UpdateCalc()
        {
            formulae = new List<Formula>();

            //
            // add your calc logic here
            //
            _area.Value = _width.Value * _length.Value;

            //
            // add formulae and commentary as you work through
            // it's best to put formulae after the calculation, as you may use the values from the calculation
            //
            // In the example below, AddExpression will show the square root of x as a symbol
            //
            formulae.Add(Formula.FormulaWithNarrative("Calculate output")
                .AddExpression(@"\sqrt{x}")
                .AddRef("a reference for the expression clause")
                );
 
        }
    }
}
