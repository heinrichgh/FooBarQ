module FooBarQ.LanceAndJaniceBench
open BenchmarkDotNet.Attributes
open FooBarQ

[<MemoryDiagnoser>]
type LanceAndJaniceBench () =
    
    [<Benchmark>]
    member self.Normal() = LanceAndJanice.answers
    
    [<Benchmark>]
    member self.CpuPerf() = LanceAndJaniceCPUPerf.answers