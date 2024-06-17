using NepaliDateConverter;
using NUnit.Framework;

namespace Tests
{
    [TestFixture()]
    public class DateConverterTests
    {
        DateConverter converter;
        [SetUp]
        public void Setup()
        {
            converter = new DateConverter();
        }

        [TearDown]
        public void Dispose()
        {
            converter = null;
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_4_13()
        {
            converter = DateConverter.ConvertToEnglish(2073, 1, 1);
            Assert.That(2016, Is.EqualTo(converter.Year));
            Assert.That(4, Is.EqualTo(converter.Month), "Month doesn't matched");
            Assert.That(13, Is.EqualTo(converter.Day));
            Assert.That("Wednesday", Is.EqualTo(converter.WeekDayName));
            Assert.That("April", Is.EqualTo(converter.MonthName));
            Assert.That(4, Is.EqualTo(converter.WeekDay));
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2024_6_14()
        {
            converter = DateConverter.ConvertToEnglish(2081, 2, 32);            
            Assert.That(2024, Is.EqualTo(converter.Year));
            Assert.That(6, Is.EqualTo(converter.Month), "Month doesn't matched");
            Assert.That(14, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));            
            Assert.That("June", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2081_2_32()
        {
            converter = DateConverter.ConvertToNepali(2024, 6, 14);
            Assert.That(2081, Is.EqualTo(converter.Year));
            Assert.That(2, Is.EqualTo(converter.Month));
            Assert.That(32, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Jestha", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_1()
        {
            converter = DateConverter.ConvertToNepali(2016, 4, 13);
            Assert.That(2073, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(1, Is.EqualTo(converter.Day));
            Assert.That("Wednesday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(4, Is.EqualTo(converter.WeekDay));
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_4_14()
        {
            converter = DateConverter.ConvertToEnglish(2073, 1, 2);
            Assert.That(2016, Is.EqualTo(converter.Year));
            Assert.That(4, Is.EqualTo(converter.Month));
            Assert.That(14, Is.EqualTo(converter.Day));
            Assert.That("Thursday", Is.EqualTo(converter.WeekDayName));
            Assert.That("April", Is.EqualTo(converter.MonthName));
            Assert.That(5, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_2()
        {
            converter = DateConverter.ConvertToNepali(2016, 4, 14);
            Assert.That(2073, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(2, Is.EqualTo(converter.Day));
            Assert.That("Thursday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(5, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2047_5_11()
        {
            converter = DateConverter.ConvertToNepali(1990, 8, 27);
            Assert.That(2047, Is.EqualTo(converter.Year));
            Assert.That(5, Is.EqualTo(converter.Month));
            Assert.That(11, Is.EqualTo(converter.Day));
            Assert.That("Monday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Bhadra", Is.EqualTo(converter.MonthName));
            Assert.That(2, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToEnglishShouldReturn1990_8_27()
        {
            converter = DateConverter.ConvertToEnglish(2047, 5, 11);
            Assert.That(1990, Is.EqualTo(converter.Year));
            Assert.That(8, Is.EqualTo(converter.Month));
            Assert.That(27, Is.EqualTo(converter.Day));
            Assert.That("Monday", Is.EqualTo(converter.WeekDayName));
            Assert.That("August", Is.EqualTo(converter.MonthName));
            Assert.That(2, Is.EqualTo(converter.WeekDay));
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_4_27()
        {
            converter = DateConverter.ConvertToEnglish(2073, 1, 15);
            Assert.That(2016, Is.EqualTo(converter.Year));
            Assert.That(4, Is.EqualTo(converter.Month));
            Assert.That(27, Is.EqualTo(converter.Day));
            Assert.That("Wednesday", Is.EqualTo(converter.WeekDayName));
            Assert.That("April", Is.EqualTo(converter.MonthName));
            Assert.That(4, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_15()
        {
            converter = DateConverter.ConvertToNepali(2016, 4, 27);
            Assert.That(2073, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(15, Is.EqualTo(converter.Day));
            Assert.That("Wednesday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(4, Is.EqualTo(converter.WeekDay));
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_5_12()
        {
            converter = DateConverter.ConvertToEnglish(2073, 1, 30);
            Assert.That(2016, Is.EqualTo(converter.Year));
            Assert.That(5, Is.EqualTo(converter.Month));
            Assert.That(12, Is.EqualTo(converter.Day));
            Assert.That("Thursday", Is.EqualTo(converter.WeekDayName));
            Assert.That("May", Is.EqualTo(converter.MonthName));
            Assert.That(5, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_30()
        {
            converter = DateConverter.ConvertToNepali(2016, 5, 12);
            Assert.That(2073, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(30, Is.EqualTo(converter.Day));
            Assert.That("Thursday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(5, Is.EqualTo(converter.WeekDay));
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_5_13()
        {
            converter = DateConverter.ConvertToEnglish(2073, 1, 31);
            Assert.That(2016, Is.EqualTo(converter.Year));
            Assert.That(5, Is.EqualTo(converter.Month));
            Assert.That(13, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("May", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_31()
        {
            converter = DateConverter.ConvertToNepali(2016, 5, 13);
            Assert.That(2073, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(31, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }



        [Test()]
        public void ConvertToEnglishShouldReturn2017_1_6()
        {
            converter = DateConverter.ConvertToEnglish(2073, 9, 22);
            Assert.That(2017, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(6, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("January", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_9_22()
        {
            converter = DateConverter.ConvertToNepali(2017, 1, 6);
            Assert.That(2073, Is.EqualTo(converter.Year));
            Assert.That(9, Is.EqualTo(converter.Month));
            Assert.That(22, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Poush", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2017_4_14()
        {
            converter = DateConverter.ConvertToEnglish(2074, 1, 1);
            Assert.That(2017, Is.EqualTo(converter.Year));
            Assert.That(4, Is.EqualTo(converter.Month));
            Assert.That(14, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("April", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2074_1_1()
        {
            converter = DateConverter.ConvertToNepali(2017, 4, 14);
            Assert.That(2074, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(1, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToEnglishShouldReturn2017_4_28()
        {
            converter = DateConverter.ConvertToEnglish(2074, 1, 15);
            Assert.That(2017, Is.EqualTo(converter.Year));
            Assert.That(4, Is.EqualTo(converter.Month));
            Assert.That(28, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("April", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }

        [Test]
        public void ConvertToNepaliShouldReturn2074_1_15()
        {
            converter = DateConverter.ConvertToNepali(2017, 4, 28);
            Assert.That(2074, Is.EqualTo(converter.Year));
            Assert.That(1, Is.EqualTo(converter.Month));
            Assert.That(15, Is.EqualTo(converter.Day));
            Assert.That("Friday", Is.EqualTo(converter.WeekDayName));
            Assert.That("Baishakh", Is.EqualTo(converter.MonthName));
            Assert.That(6, Is.EqualTo(converter.WeekDay));
        }
    }
}