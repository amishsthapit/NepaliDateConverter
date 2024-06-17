using NepaliDateConverter;

namespace Tests
{
    [TestFixture()]
    public class CalendarTest
    {
        Calendar calendar;
        [SetUp]
        public void Setup()
        {
            calendar = new Calendar();
        }

        [TearDown]
        public void Dispose()
        {
            calendar = null;
        }

        // IsLeapYear()
        [Test]
        public void TestIsLeapYearShouldReturnTrue()
        {
            Assert.That(calendar.IsLeapYear(1904),Is.True);
            Assert.That(calendar.IsLeapYear(1908),Is.True);
            Assert.That(calendar.IsLeapYear(1912),Is.True);
            Assert.That(calendar.IsLeapYear(1916),Is.True);
            Assert.That(calendar.IsLeapYear(2000),Is.True);
            Assert.That(calendar.IsLeapYear(2004),Is.True);
            Assert.That(calendar.IsLeapYear(2008),Is.True);
            Assert.That(calendar.IsLeapYear(2012),Is.True);
            Assert.That(calendar.IsLeapYear(2016),Is.True);
            Assert.That(calendar.IsLeapYear(2020),Is.True);
        }

        [Test]
        public void TestIsLeapYearShouldReturnFalse()
        {
            bool isLeapYear2017 = calendar.IsLeapYear(2017);
            bool isLeapYear2018 = calendar.IsLeapYear(2018);
            bool isLeapYear2025 = calendar.IsLeapYear(2025);
            Assert.That(isLeapYear2017,Is.False);
            Assert.That(isLeapYear2018,Is.False);
            Assert.That(isLeapYear2025, Is.False);
        }

        // GetDayOfWeek()
        [Test]
        public void TestGetDayOfWeekShouldReturnDayOfWeek()
        {
            Assert.That("Sunday", Is.EqualTo(calendar.GetDayOfWeek(0)));
            Assert.That("Sunday", Is.EqualTo(calendar.GetDayOfWeek(1)));
            Assert.That("Monday", Is.EqualTo(calendar.GetDayOfWeek(2)));
            Assert.That("Tuesday", Is.EqualTo(calendar.GetDayOfWeek(3)));
            Assert.That("Wednesday", Is.EqualTo(calendar.GetDayOfWeek(4)));
            Assert.That("Thursday", Is.EqualTo(calendar.GetDayOfWeek(5)));
            Assert.That("Friday", Is.EqualTo(calendar.GetDayOfWeek(6)));
            Assert.That("Saturday", Is.EqualTo(calendar.GetDayOfWeek(7)));
        }

        // GetEnglishMonth()
        [Test]
        public void TestGetEnglishMonthShouldReturnEnglishMonthName()
        {
            Assert.That("January", Is.EqualTo(calendar.GetEnglishMonth(0)));
            Assert.That("January", Is.EqualTo(calendar.GetEnglishMonth(1)));
            Assert.That("February", Is.EqualTo(calendar.GetEnglishMonth(2)));
            Assert.That("March", Is.EqualTo(calendar.GetEnglishMonth(3)));
            Assert.That("April", Is.EqualTo(calendar.GetEnglishMonth(4)));
            Assert.That("May", Is.EqualTo(calendar.GetEnglishMonth(5)));
            Assert.That("June", Is.EqualTo(calendar.GetEnglishMonth(6)));
            Assert.That("July", Is.EqualTo(calendar.GetEnglishMonth(7)));
            Assert.That("August", Is.EqualTo(calendar.GetEnglishMonth(8)));
            Assert.That("September", Is.EqualTo(calendar.GetEnglishMonth(9)));
            Assert.That("October", Is.EqualTo(calendar.GetEnglishMonth(10)));
            Assert.That("November", Is.EqualTo(calendar.GetEnglishMonth(11)));
            Assert.That("December", Is.EqualTo(calendar.GetEnglishMonth(12)));
        }

        // GetNepaliMonth()
        [Test]
        public void TestGetNepaliMonthShouldReturnNepaliMonthName()
        {
            Assert.That("Baishakh", Is.EqualTo(calendar.GetNepaliMonth(0)));
            Assert.That("Baishakh", Is.EqualTo(calendar.GetNepaliMonth(1)));
            Assert.That("Jestha", Is.EqualTo(calendar.GetNepaliMonth(2)));
            Assert.That("Ashad", Is.EqualTo(calendar.GetNepaliMonth(3)));
            Assert.That("Shrawan", Is.EqualTo(calendar.GetNepaliMonth(4)));
            Assert.That("Bhadra", Is.EqualTo(calendar.GetNepaliMonth(5)));
            Assert.That("Aswin", Is.EqualTo(calendar.GetNepaliMonth(6)));
            Assert.That("Kartik", Is.EqualTo(calendar.GetNepaliMonth(7)));
            Assert.That("Mangshir", Is.EqualTo(calendar.GetNepaliMonth(8)));
            Assert.That("Poush", Is.EqualTo(calendar.GetNepaliMonth(9)));
            Assert.That("Magh", Is.EqualTo(calendar.GetNepaliMonth(10)));
            Assert.That("Falgun", Is.EqualTo(calendar.GetNepaliMonth(11)));
            Assert.That("Chaitra", Is.EqualTo(calendar.GetNepaliMonth(12)));
        }

        // ValidEnglishDate()
        [Test]
        public void TestValidEnglishDateShouldReturnTrue()
        {
            // Valid years
            for (int year = 1944; year <= 2033; year++)
            {
                Assert.That(calendar.ValidEnglishDate(year, 1, 1), Is.True);
            }

            // valid months
            for (int month = 1; month <= 12; month++)
            {
                Assert.That(calendar.ValidEnglishDate(2017, month, 1), Is.True);
            }

            // valid days
            for (int day = 1; day <= 31; day++)
            {
                Assert.That(calendar.ValidEnglishDate(2017, 8, day),Is.True);
            }
        }

        [Test]
        public void TestValidEnglishDateShouldBeInvalid()
        {
            Assert.That(calendar.ValidEnglishDate(1943, 1, 1), Is.False);
            Assert.That(calendar.ValidEnglishDate(2017, 13, 1), Is.False);
            Assert.That(calendar.ValidEnglishDate(1943, 11, 33), Is.False);
            Assert.That(calendar.ValidEnglishDate(2034, 1, 1), Is.False);
        }

        // ValidNepaliDate()
        [Test]
        public void TestValidNepaliDateShouldReturnTrue()
        {
            // Valid years
            for (int year = 2000; year <= 2089; year++)
            {
                Assert.That(calendar.ValidNepaliDate(year, 1, 1), Is.True);
            }

            // valid months
            for (int month = 1; month <= 12; month++)
            {
                Assert.That(calendar.ValidNepaliDate(2074, month, 1), Is.True);
            }

            // valid days
            for (int day = 1; day <= 32; day++)
            {
                Assert.That(calendar.ValidNepaliDate(2074, 8, day), Is.True);
            }
        }

        [Test]
        public void TestValidNepaliDateShouldBeInvalid()
        {
            Assert.That(calendar.ValidNepaliDate(1999, 1, 1), Is.False);
            Assert.That(calendar.ValidNepaliDate(2090, 1, 1), Is.False);
            Assert.That(calendar.ValidNepaliDate(2074, 1, 33), Is.False);
            Assert.That(calendar.ValidNepaliDate(2090, 13, 1), Is.False);
        }
    }
}