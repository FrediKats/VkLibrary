namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Some open methods used in library.
module OpenMethods =

    open VkLibrary.Core
    open Extensions
    
    [<Test>]
    /// Wall get test.
    let wallGetTest () =
        lib().Wall.Get (nbl 1)
        |> awaitForResults
        |> fun x -> x.Count
        |> should be ofExactType<int>

    [<Test>]
    /// Users get by id tests.
    let usersGetTest () =
        lib().Users.Get ([string 1])
        |> awaitForResults
        |> Seq.item 0
        |> fun x -> x.FirstName
        |> should be ofExactType<string>

    [<Test>]
    /// Groups get by id tests.
    let groupsGetTest () =
        lib().Groups.GetById ([string 1])
        |> awaitForResults
        |> Seq.item 0
        |> fun x -> x.Name
        |> should be ofExactType<string>
        

