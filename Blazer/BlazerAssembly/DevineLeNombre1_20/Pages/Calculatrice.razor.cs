using Microsoft.AspNetCore.Components;

namespace DevineLeNombre1_20.Pages
{
    public partial class Calculatrice
    {
        [Parameter]
        public double Value1 { get; set; }

        [Parameter]
        public double Value2 { get; set; }

        public enum Operation
        {
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        public Operation SelectedOperation { get; set; }

        public double Resultat { get; set; }

        private void EffectuerCalcul()
        {
            switch (SelectedOperation)
            {
                case Operation.Addition:
                    Resultat = Value1 + Value2;
                    break;
                case Operation.Subtraction:
                    Resultat = Value1 - Value2;
                    break;
                case Operation.Multiplication:
                    Resultat = Value1 * Value2;
                    break;
                case Operation.Division:
                    if (Value2 != 0)
                    {
                        Resultat = Value1 / Value2;
                    }
                    break;
            }
        }
    }
}


