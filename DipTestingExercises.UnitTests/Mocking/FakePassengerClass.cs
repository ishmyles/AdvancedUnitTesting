using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipTestingExercises.UnitTests.Mocking
{
    class FakePassengerClass : Passenger
    {
        public FakePassengerClass(string pFname, string pLname, string pGender, string pTicketType) : base(pFname, pLname, pGender, pTicketType)
        { }
    }
}
