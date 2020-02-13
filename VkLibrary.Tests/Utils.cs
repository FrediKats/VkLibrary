using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using FluentAssertions;
using VkApi.Wrapper;
using VkLibrary.Tests.Helpers;
using Xunit.Abstractions;
using Xunit;

namespace VkLibrary.Tests
{
    public class Utils : ClassFixtureBase
    {
        public Utils(ITestOutputHelper testOutputHelper) : base(Constants.OfficialApplicationId, 
            Constants.OfficialApplicationSecret, Constants.AccessToken, testOutputHelper) { }

        [Fact]
        public void DateTimeToUnixTime()
        {
            var dateTime = new DateTime(2009, 2, 13, 23, 31, 30);
            var unixTime = Vkontakte.DateTimeToUnixTime(dateTime);
            unixTime.Should().Be(1234567890);
        }

        [Fact]
        public void UnixTimeToDateTime()
        {
            var expected = new DateTime(2009, 2, 13, 23, 31, 30);
            var real = Vkontakte.UnixTimeToDateTime(1234567890);
            real.Should().Be(expected);
        }

        [Theory, InlineData(true), InlineData(false)]
        public void BoolToApi(bool value)
        {
            var expected = new Dictionary<bool, string> {{true, "1"}, {false, "0"}};
            var actual = value.ToApiString();
            actual.Should().Be(expected[value]);
        }

        [Theory, InlineData(0), InlineData(99)]
        public void IntegerToApi(int value)
        {
            value.ToApiString().Should().Be(value.ToString());
        }

        [Theory, InlineData(0.5), InlineData(34.42)]
        public void DoubleToApi(double value)
        {
            var expected = value.ToString(CultureInfo.InvariantCulture);
            value.ToApiString().Should().Be(expected);
        }

        [Theory, InlineData("Foo"), InlineData("Hello, world!")]
        public void StringToApi(string value)
        {
            value.ToApiString().Should().Be(value);
        }

        [Theory, InlineData(new[] {1}), InlineData(new[] {1, 2, 3, 4})]
        public void EnumerableToApi(IEnumerable<int> value)
        {
            var expected = value
                .Select(i => i.ToString())
                .Aggregate((a, b) => $"{a},{b}");
            value.ToApiString().Should().Be(expected);
        }
    }
}