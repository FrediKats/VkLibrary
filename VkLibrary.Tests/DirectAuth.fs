namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Library section responsible for 
/// direct authentication tests.
module DirectAuth =

    open VkLibrary.Core.Auth
    open VkLibrary.Core
    open Extensions

    [<Test>]
    /// Direct auth login test.
    let directAuthTest () =
        let lib = getLib Constants.officialAppId Constants.officialAppSecret Constants.apiVersion
        let login = Constants.login
        let pass = Constants.password
        lib.DirectAuth.Login(login, pass, ScopeSettings.CanAccessAdsCabinet)
        |> await
        |> fun x -> x.Token
        |> should not' (be Null)

