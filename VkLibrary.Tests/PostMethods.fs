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
    
    [<Test>]
    /// Post async test.
    let postTest () =
        let uploader = signedLib().UploadHelper
        let url = Uri <| "http://httpbin.org/post"
        uploader.PostAsync<JToken>(url, Array.create 2 1uy,"doc", "doc")
        |> awaitForResults
        |> tee log
        |> fun x -> x.["files"].["doc"]
        |> string
        |> should equal "\u0001\u0001"

    [<Test>]
    /// Multiple post uploads test.
    let postMultipleTest () =
        let uploader = signedLib().UploadHelper
        let url = Uri <| "http://httpbin.org/post"
        uploader.PostMultipleAsync<JToken>(url, 
            dict [
                "one", Array.create 2 1uy;
                "two", Array.create 2 1uy; ]
            |> Dictionary<_, _>)
        |> awaitForResults
        |> tee log
        |> ignore


