namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Common tools used in library.
module Tools =

    open System
    open System.Collections.Generic
    open VkLibrary.Core

    [<Test>]
    /// DateTime to UnitTimeStamp conversion tests.
    let dateTimeToUnixTimeTest () =
        (2009, 2, 13, 23, 31, 30)
        |> DateTime
        |> Vkontakte.DateTimeToUnixTime
        |> should equal 1234567890

    [<Test>]
    /// UnixTimeStamp to DateTime conversions.
    let unixTimeToDateTimeTest () =
        let dateTimeUtc = // Expected DateTime.
            (2009, 2, 13, 23, 31, 30) 
            |> DateTime
        float 1234567890
        |> Vkontakte.UnixTimeToDateTime
        |> should equal dateTimeUtc
    
    [<Test>]
    /// VkLibrary's query string builder.
    let queryBuilderTest () =
        let baseUri = "http://a.bcd/ef.gh"
        let queryDict = 
            dict [
                "foo", "bar"; 
                "key", string 1234 ]
            |> Dictionary<_, _>
        Vkontakte.BuildUrl(baseUri, queryDict)
        |> should equal "http://a.bcd/ef.gh?foo=bar&key=1234"

    [<Test>]
    /// Conversion: true -> '1'
    let apiStringTrueConverterTest () =
        true
        |> Extensions.ToApiString
        |> should equal (string 1)

    [<Test>]
    /// Conversion: false -> '0'
    let apiStringFalseConverterTest () =
        false
        |> Extensions.ToApiString
        |> should equal (string 0)

    [<Test>]
    /// Conversion: whatever -> string
    let apiStringCommonConverterTest () =
        "foo bar"
        |> Extensions.ToApiString
        |> should equal "foo bar"

    [<Test>]
    /// Conversion: seq [1] -> string
    let apiStringSeq1ConverterTest () =
        [1]
        |> Extensions.ToApiString
        |> tee log
        |> should equal (string 1)

    [<Test>]
    /// Conversion: seq [N] -> string
    let apiStringSeqNConverterTest () =
        [1; 2; 3; 4; 5]
        |> Extensions.ToApiString
        |> tee log
        |> should equal ("1,2,3,4,5")

    [<Test>]
    /// Conversion: enumerable -> string
    let apiStringEnumerableConverterTest () =
        [1; 2; 3]
        |> List<int>
        |> Extensions.ToApiString
        |> tee log
        |> should equal ("1,2,3")

