namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// LongPolling-related tests.
module LongPolling =

    open System
    open Extensions
    open VkLibrary.Core
    open VkLibrary.Core.Auth
    open System.Threading.Tasks
    open System.Diagnostics

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
    let getLongPollServerTest () =
        lib.Messages.GetLongPollServer()
        |> await
        |> fun x -> x.Server
        |> Seq.length
        |> should be (greaterThan 0)

    [<Test>]
    /// Start long poll server test.
    let startLongPollServerTest() =
        let server = await <| lib.Messages.GetLongPollServer()
        use client = 
            (server.Server, server.Key, server.Ts)
            |> lib.StartLongPollClient
        let mutable success = false
        client.ResponseReceived += 
            fun jArray -> 
                success <- true
        wait <| Task.Delay(30000)
        client.Stop()
        success
        |> should equal true
            