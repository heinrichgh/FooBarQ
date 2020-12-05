open BenchmarkDotNet.Running
open FooBarQ

[<EntryPoint>]
let main argv =
//    printfn "%A" LanceAndJanice.answers
//    printfn "%A" LanceAndJaniceCPUPerf.answers
    
    BenchmarkRunner.Run typeof<LanceAndJaniceBench.LanceAndJaniceBench> |> ignore
    
    0 // return an integer exit code