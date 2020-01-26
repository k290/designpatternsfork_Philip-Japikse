// #region Copyright
// /* 
// ============================================================
// PatternsExamples - RaceCar.cs
// All samples copyright 5/26/2013 Phil Japikse, www.skimedic.com
// see License.txt for license information
// ============================================================
// */
// Phil Japikse
// #endregion    

#region Copyright

#endregion

namespace PatternsExamples.B_Structural.C_Decorator
{
    public class RaceCar : ICar
    {
        private readonly ICar _decoratedCar;

        public RaceCar(ICar decoratedCar)
        {
            _decoratedCar = decoratedCar;
        }

        public int Drive() => _decoratedCar.Drive() + 40;

	    public int Attack() => _decoratedCar.Attack() - 10;

	    public int Defend() => _decoratedCar.Defend() - 10;
    }
}