namespace VkLibrary.Tests

[<AutoOpen>]
/// Contains usefull
/// language extensions.
module Extensions =

    open System
    open System.Threading.Tasks
    open System.Collections.Generic
    open VkLibrary.Core

    /// Returns prepared library instance.
    let getLibFull app parse secret version logger = 
        new Vkontakte (app, parse, secret, version, logger)

    /// Console logger.
    let logger : Action<obj> =
        Action<obj> (Console.WriteLine)

    /// Returns customized lib for debugging.
    let getLib app secret version =
        getLibFull (string app) JsonParsingType.UseString secret (string version) logger
        
    /// Awaits a task and returns results.
    let await (task: Task<'a>) = 
        async {
            let! result = 
                task 
                |> Async.AwaitTask 
            return result 
        } |> Async.RunSynchronously
        
    /// Awaits a task returning void.
    let awaitVoid (task: Task) = 
        task 
        |> Async.AwaitIAsyncResult 
        |> Async.Ignore

    /// Short syntax for nullable conversion.
    let nbl (x: 'a) = x |> Nullable<'a>

    /// Applies a function to a value and
    /// passes it further.
    let tee f x = x |> f; x

    /// Fun-styled split.
    let split (c: char) (s: string) = 
        s.Split c

    /// Fun-styled substring.
    let substring (n: int) (s: string) = 
        s.Substring n

    /// Lowercases string.
    let lower (s: string) =
        s.ToLowerInvariant()

    /// Returns a value by a key.
    let value (key: 'a) (dict: IDictionary<'a, 'b>) =
        dict.Item key

    /// Logs to output.
    let log (x: obj) = 
        x.ToString() 
        |> sprintf "[VKLIBRARY.TEST]: %s" 
        |> Console.WriteLine
    

