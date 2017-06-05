namespace VkLibrary.Tests

open FsUnit
open NUnit.Framework

[<TestFixture>]
/// UploadHelper library section.
module PostMethods =

    open System
    open Extensions
    open VkLibrary.Core
    open Newtonsoft.Json.Linq
    open System.Collections.Generic
    
    [<OneTimeSetUp>]
    /// Methods fixture setup.
    let lib = getLib Constants.appId String.Empty Constants.apiVersion

    [<OneTimeTearDown>]
    /// Dispose library when tests have completed.
    let fixtureTearDown () = lib.Dispose()

    [<Test>]
    /// Post async test.
    let postTest () =
        let uploader = lib.UploadHelper
        let url = Uri <| "http://httpbin.org/post"
        uploader.PostAsync<JToken>(url, Array.create 2 1uy, "doc", "doc")
        |> await
        |> tee log
        |> fun x -> x.["files"].["doc"]
        |> string
        |> should equal "\u0001\u0001"

    [<Test>]
    /// Multiple post uploads test.
    let postMultipleTest () =
        let uploader = lib.UploadHelper
        let url = Uri <| "http://httpbin.org/post"
        uploader.PostMultipleAsync<JToken>(url, 
            dict [
                "one", Array.create 2 1uy;
                "two", Array.create 2 1uy; ]
            |> Dictionary<_, _>)
        |> await
        |> tee log
        |> ignore


