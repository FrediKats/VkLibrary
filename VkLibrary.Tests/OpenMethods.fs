namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Some open methods used in library.
module OpenMethods =

    open System
    open Extensions
    open VkLibrary.Core
    open VkLibrary.Core.Responses.Newsfeed
    open VkLibrary.Core.Types.Base
    open System.Collections.Generic

    [<OneTimeSetUp>]
    /// Methods fixture setup.
    let lib = getLib Constants.officialAppId String.Empty Constants.apiVersion

    [<OneTimeTearDown>]
    /// Dispose library when tests have completed.
    let fixtureTearDown () = lib.Dispose()

    [<Test>]
    /// Universal GetAsync query test with token signing.
    let genericGetAsyncSignedTest () =
        ("newsfeed.get", dict [
            "filters", "post"; 
            "count", "1";
            "access_token", Constants.accessToken ] 
            |> Dictionary)
        |> lib.GetAsync<NewsFeedResponse>
        |> await
        |> fun x -> x.Items
        |> should not' (be Null)

    [<Test>]
    /// Users get by id tests.
    let usersGetTest () =
        lib.Users.Get([string 1])
        |> await
        |> Seq.item 0
        |> fun x -> x.FirstName
        |> should be ofExactType<string>

    [<Test>]
    /// Users get followers test.
    let usersGetFollowersTest () =
        lib.Users.GetFollowers(nbl 1, count = nbl 10)
        |> await
        |> fun x -> x.Count
        |> should be (greaterThan 1000000)

    [<Test>]
    /// Get subscriptions test.
    let usersGetSubscriptions () =
        lib.Users.GetSubscriptions(nbl 1, count = nbl 10)
        |> await
        |> fun x -> 
            x.Groups.Count |> should be (greaterThanOrEqualTo 0)
            x.Users.Count  |> should be (greaterThanOrEqualTo 0)

    [<Test>]
    /// Groups get by id tests.
    let groupsGetByIdTest () =
        lib.Groups.GetById([string 1])
        |> await
        |> Seq.item 0
        |> fun x -> x.Name
        |> should be ofExactType<string>

    [<Test>]
    /// Groups get members tests.
    let grousGetMembersTest () =
        lib.Groups.GetMembers(nbl 1, count=nbl 10)
        |> await
        |> fun x -> x.Items
        |> Seq.length
        |> should equal 10

    [<Test>]
    /// Checks if user is group member test.
    let groupsIsMemberTest () =
        lib.Groups.IsMember(string 1, nbl 1)
        |> await
        |> should equal 1

    [<Test>]
    /// Check link util test.
    let utilsCheckLinkTest () =
        lib.Utils.CheckLink(url="https://google.ru")
        |> await
        |> fun x -> x.Status
        |> should equal "not_banned"
    
    [<Test>]
    /// Resolve screen name util test.
    let utilsResolveScreenNameTest () =
        lib.Utils.ResolveScreenName("durov")
        |> await
        |> fun x -> x.Type
        |> should equal "user"

    [<Test>]
    /// Utils getServerTime method.
    let utilsGetServerTimeTest () =
        lib.Utils.GetServerTime()
        |> await
        |> fun x -> x.Value
        |> should be (greaterThan 0)

    [<Test>]
    /// Get cities by id test.
    let databaseGetCitiesByIdTest () =
        lib.Database.GetCitiesById([nbl 1])
        |> await
        |> Seq.item 0
        |> fun x -> x.Title
        |> should equal "Москва"

    [<Test>]
    /// Get countries by id test.
    let databaseGetCountriesByIdTest () =
        lib.Database.GetCountriesById([nbl 1])
        |> await
        |> Seq.item 0
        |> fun x -> x.Title
        |> should equal "Россия"

    [<Test>]
    /// Gte universities list test.
    let databaseGetUniversitiesTest () =
        lib.Database.GetUniversities(cityId = nbl 1)
        |> await
        |> fun x -> x.Count
        |> should be (greaterThan 0)

