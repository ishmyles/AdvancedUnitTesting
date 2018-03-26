using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises.UnitTests.Mocking
{
    public class FakeMotorVehicle : MotorVehicle
    {
        public FakeMotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM) : base(pDriver, pMax, pCurrent, pLitresPerKM)
        {
            maxFuel = pMax;
            currentFuel = pCurrent;
            litresPerKM = pLitresPerKM;
        }
    }
}
