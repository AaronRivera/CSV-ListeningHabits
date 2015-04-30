using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSV_ListeningHabits
{
    [TestFixture]
    class Test
    {
        [TestFixtureSetUp]
        public void Init()
        {
            Program.InitList();
        }
        [Test]
        public void testTotalPlays()
        {
            Assert.That(Program.TotalPlays() == 20475);
        }
        [Test]
        public void testTotalPlaysByArtistName1()
        {
            Assert.That(Program.TotalPlaysByArtistName("All Time Low") == 525);
        }
        [Test]
        public void testTotalPlaysByArtistName2()
        {
            Assert.That(Program.TotalPlaysByArtistName("nickelback") == 1);
        }
        [Test]
        public void testTotalPlaysByArtistName3()
        {
            Assert.That(Program.TotalPlaysByArtistName("britney spears") == 0);
        }
        [Test]
        public void testTotalPlaysByArtistNameInYear()
        {
            Assert.That(Program.TotalPlaysByArtistNameInYear("Skrillex","2014") == 140);
        }
        [Test]
        public void testCountUniqueArtistsAll()
        {
            Assert.That(Program.CountUniqueArtists() == 1866);
        }
        [Test]
        public void testCountUniqueArtists2014()
        {
            Assert.That(Program.CountUniqueArtists("2014") == 390);
        }
        [Test]
        public void testCountUniqueArtists2007()
        {
            Assert.That(Program.CountUniqueArtists("2007") == 502);
        }
        [Test]
        public void testTrackListByArtist()
        {
            List<string> trackList = new List<string>() {"Applied Science", "Eons", "You Would'nt Believe", "Beautiful Disaster", "All Mixed Up","Come Original"};
            Assert.AreEqual(trackList, Program.TrackListByArtist("311"));
        }
        [Test]
        public void testFirstPlayByArtist()
        {
            DateTime first = new DateTime(2007,7,11,19,5,7);
            Assert.AreEqual(first, Program.FirstPlayByArtist("cartel"));
        }
        [Test]
        public void testMostPopularArtistByYear2008()
        {
            StringAssert.AreEqualIgnoringCase("Say Anything",Program.MostPopularArtistByYear("2008"));
        }
        [Test]
        public void testMostPopularArtistByYear2014()
        {
            StringAssert.AreEqualIgnoringCase("ODESZA", Program.MostPopularArtistByYear("2014"));
        }
    }
}
