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
        |> VkLibrary.DateTimeToUnixTime
        |> should equal 1234567890

    [<Test>]
    /// UnixTimeStamp to DateTime conversions.
    let unixTimeToDateTimeTest () =
        let dateTimeUtc = // Expected DateTime.
            (2009, 2, 13, 23, 31, 30) 
            |> DateTime
        float 1234567890
        |> VkLibrary.UnixTimeToDateTime
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
        VkLibrary.BuildUrl(baseUri, queryDict)
        |> should equal "http://a.bcd/ef.gh?foo=bar&key=1234"

