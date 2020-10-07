using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Songs;

namespace SongTest

{
    [TestClass]
    public class SongTest
    {
        [TestMethod()]
        public void SilverMaxCertTest()
        {
            //Arrange
            Song s = new Song("test", "test", 399999);

            string expected = s.GetCertification();
            string actual;

            //Act
           actual = s.GetCertification();

            //Assert
            Assert.AreEqual("Silver", s.GetCertification());
        }

        [TestMethod()]
        public void SilverMinCertTest()
        {
            //Arrange
            Song s = new Song("","",200000);
                       
            //Assert
            Assert.AreEqual("Silver", s.GetCertification());
        }

        [TestMethod()]
        public void GetDetails()
        {
            //Arrange
           Song s = new Song("the song", "steve", 400000);

           //Assert
            Assert.AreEqual($"Name: {s.GetsongName()} Artist: {s.GetArtist()} Copies Sold: {s.GetCopiesSold()}", s.GetDetails());

        }

        [TestMethod()]
        public void GoldMaxCertTest()
        {
            //Arrange
            Song s = new Song("", "", 599999);

            //Assert
            Assert.AreEqual("Gold", s.GetCertification());
        }

        [TestMethod()]
        public void GoldMinCertTest()
        {
            //Arrange
            Song s = new Song("", "", 400000);

            //Assert
            Assert.AreEqual("Gold", s.GetCertification());
        }
        [TestMethod()]
        public void PlatCertTest()
        {
            //Arrange
            Song s = new Song("", "", 600000);

            //Assert
            Assert.AreEqual("Platinum", s.GetCertification());
        }
        public void nullCertTest()
        {
            //Arrange
            Song s = new Song("", "", 199999);

            //Assert
            Assert.IsNull(s.GetCertification());
        }

    }
}
