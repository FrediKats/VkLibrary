namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Common queries used in library.
module Methods =

    open System
    open Extensions
    open VkLibrary.Core
    open System.Collections.Generic
    open VkLibrary.Core.Responses.Newsfeed
    open VkLibrary.Core.Auth

    [<OneTimeSetUp>]
    /// Methods fixture setup.
    let lib =
        getLib Constants.officialAppId String.Empty Constants.apiVersion
        |> tee (fun x -> x.AccessToken <- AccessToken ())
        |> tee (fun x -> x.AccessToken.Token <- Constants.accessToken)

    [<OneTimeTearDown>]
    /// Dispose library when tests have completed.
    let fixtureTearDown () = lib.Dispose()

    [<Test>]
    /// Stored procedures tests.
    let executeTest () =
        lib.Execute("return 40 + 2;")
        |> await
        |> should equal 42

    [<Test>]
    /// Status get test.
    let statusGetTest () =
        lib.Status.Get()
        |> await
        |> fun x -> x.Text
        |> should be ofExactType<string>
        
    [<Test>]
    /// Status set test.
    let statusSetTest () =
        lib.Status.Set("coldest summer")
        |> await
        |> should equal 1

    [<Test>]
    /// Newsfeed get test.
    let newsfeedGetTest () =
        lib.Newsfeed.Get(filters = ["post"], count = nbl 1)
        |> await
        |> fun x -> x.Items
        |> should not' (be Null)

    [<Test>]
    /// Get shortened url history tests.
    let utilsGetLastShortenedLinksTest () =
        lib.Utils.GetLastShortenedLinks(nbl 10, nbl 0)
        |> await
        |> fun x -> x.Items.[0].Key 
        |> tee log
        |> should not' (be Null)

    [<Test; Ignore("Links spam.")>]
    /// Shorten url test.
    let utilsGetShortLinkTest () =
        lib.Utils.GetShortLink("google.ru")
        |> await 
        |> tee log
        |> fun x -> x.ShortUrl
        |> should be ofExactType<string>

    [<Test>]
    /// Get link stats info test.
    let utilsGetLinkStatsTest () =
        let key = "6drK78"
        lib.Utils.GetLinkStats(key, interval="day", 
            intervalsCount=nbl 4, extended=nbl true)
        |> await
        |> fun x -> x.Key
        |> should equal key

    [<Test>]
    /// Get likes list info test.
    let likesGetListTest () =
        lib.Likes.GetList("post", nbl 1, nbl 45546, filter="likes")
        |> await
        |> fun x -> x.Items
        |> Seq.item 0
        |> should be (greaterThan 0)

    [<Test>]
    /// Get hints method test from search API section.
    let searchGetHintsTest () =
        lib.Search.GetHints("VK API", nbl 2, searchGlobal=nbl true)
        |> await
        |> Seq.item 0
        |> fun x -> x.Type
        |> should not' (be Null)

    [<Test>]
    /// Get all user photos test.
    let photosGetAllTest () =
        lib.Photos.GetAll(count=nbl 10)
        |> await
        |> fun x -> x.Count
        |> should be (greaterThanOrEqualTo 0)

