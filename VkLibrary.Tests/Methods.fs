namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Common queries used in library.
module Methods =

    open Extensions
    open VkLibrary.Core
    
    [<Test>]
    /// Stored procedures tests.
    let executeTest () =
        signedLib().Execute("return 40 + 2;")
        |> awaitForResults
        |> should equal 42

    [<Test>]
    /// Status get test.
    let statusGetTest () =
        signedLib().Status.Get()
        |> awaitForResults
        |> fun x -> x.Text
        |> should be ofExactType<string>

    [<Test>]
    /// Newsfeed get test.
    let newsfeedGetTest () =
        signedLib().Newsfeed.Get(filters = ["post"], count = nbl 1)
        |> awaitForResults
        |> fun x -> x.Items
        |> should not' (be Null)

    [<Test>]
    /// Utils getServerTime method.
    let getServerTimeTest () =
        signedLib().Utils.GetServerTime()
        |> awaitForResults
        |> fun x -> x.Value
        |> should be (greaterThan 0)