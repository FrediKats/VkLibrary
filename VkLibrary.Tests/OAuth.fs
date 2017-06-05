namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// Library section responsible for
/// OAuth API section tests.
module OAuth =

    open VkLibrary.Core.Auth
    open VkLibrary.Core
    open Extensions
    open System.Net
    open System

    // Locally stored library.
    let mutable lib = null
    
    [<OneTimeSetUp>]
    /// Methods fixture setup.
    let fixtureSetUp () = 
        lib <- getLib Constants.appId String.Empty Constants.apiVersion

    [<OneTimeTearDown>]
    /// Dispose library when tests have completed.
    let fixtureTearDown () = lib.Dispose()

    [<Test>]
    /// OAuth prepare url tests.
    let oAuthPrepareUrlTest () =
        let scope = ScopeSettings.IamTheGod
        let display = AuthDisplayType.Page
        let parameters =
            (scope, display)
            |> lib.OAuth.GetAuthUrl
            |> fun x -> Uri(x).Query
            |> WebUtility.UrlDecode
            |> substring 1
            |> split '&'
            |> Seq.map (split '=')
            |> Seq.map (fun p -> p.[0], p.[1])
            |> dict
        dict [
            "display", string display |> lower;
            "client_id", string Constants.appId;
            "response_type", "token";
            "scope", scope |> int |> string ]
        |> Seq.iter (fun x -> 
            parameters.[x.Key] 
            |> should equal x.Value)

    [<Test>]
    /// OAuth success url parsing test.
    let oAuthParseSuccessUrlTest () =
        let success = "https://oauth.vk.com/blank.html#\
            access_token=foo&expires_in=0&user_id=1234&email=bar"
        let parsed =
            success 
            |> Uri
            |> lib.OAuth.ParseResponseUrl
        let token = parsed.AccessToken.Token 
        parsed.IsSuccess |> should equal true
        parsed.Error     |> should be Null
        token            |> should equal "foo"

    [<Test>]
    /// OAuth failure url parsing test.
    let oAuthParseFailureUrlTest () =
        let failure = "https://oauth.vk.com/blank.html#\
            error=access_denied&error_reason=user_denied&\
            error_description=User denied access"
        let parsed = 
            failure
            |> Uri
            |> lib.OAuth.ParseResponseUrl
        let token = parsed.AccessToken.Token
        parsed.IsSuccess |> should equal false
        parsed.Error     |> should equal "access_denied"
        token            |> should be Null

        
        
