using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.071477,-84.296345,Taco Bell Alpharett...", -84.296345)]
        [InlineData("33.911058,-84.82554,Taco Bell Dalla...", -84.82554)]
        [InlineData("33.715798,-84.215646,Taco Bell Decatur...", -84.215646)]
        [InlineData("34.741158,-86.662532,Taco Bell Huntsville...", -86.662532)]
        [InlineData("33.924482,-84.574871,Taco Bell Mariett...", -84.574871)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var longParser = new TacoParser();

            //Act
            var actual = longParser.Parse(line).Location.Longitude;

            //Assert
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.071477,-84.296345,Taco Bell Alpharett...", 34.071477)]
        [InlineData("33.911058,-84.82554,Taco Bell Dalla...", 33.911058)]
        [InlineData("33.715798,-84.215646,Taco Bell Decatur...", 33.715798)]
        [InlineData("34.741158,-86.662532,Taco Bell Huntsville...", 34.741158)]
        [InlineData("33.924482,-84.574871,Taco Bell Mariett...", 33.924482)]

        public void ShouldParseLatitude(string line, double expected)
        {
            //Arrange
            var latParser = new TacoParser();

            //Act
            var actual = latParser.Parse(line).Location.Latitude;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
