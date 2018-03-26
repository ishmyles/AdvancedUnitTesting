using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises.UnitTests.Mocking
{
    class FakeDriverClass : Driver
    {
        public FakeDriverClass(string pFname, string pLname, string pGender, string pLicenceType) : base(pFname, pLname, pGender, pLicenceType)
        { }
    }
}
