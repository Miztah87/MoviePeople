using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForCompulsory.Models;
using TestProxy.DomainModel;

namespace CompulsoryUnitTest
{
    [TestFixture]   
    class OrderLineTest
    {
        [Test]
        public void orderLine_properties_set_test()
        {
            OrderLine line = new OrderLine();
            var movie = new Movie() { Id=1, Title="Smurf"};
            line.Movie = movie;
            line.Amount = 10;

            Assert.AreEqual(line.Movie, movie, "My movie blabla");
            Assert.AreEqual(line.Amount, 10, "babla");

        }




    }
}
