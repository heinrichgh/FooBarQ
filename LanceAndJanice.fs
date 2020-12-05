module FooBarQ.LanceAndJanice

open System

let alphabet = [|'a'..'z'|]

let testCases = [|
    "wrw blf hvv ozhg mrtsg'h vkrhlwv?";
    "Yvzs! I xzm'g yvorvev Lzmxv olhg srh qly zg gsv xlolmb!!"
|]

let dictionary = Array.zip alphabet (Array.rev alphabet)

let dictionaryLookup char =
    match char with
    | a when a >= 'a' && a <= 'z' ->
                            (
                                dictionary
                                |> Array.filter (fun (a, b) -> a = char)
                                |> Array.map snd
                            ).[0]
    | _ -> char
    

let decrypt (message:string) =
    message
    |> Seq.map dictionaryLookup

let answers =
    testCases
    |> Array.map
           (
            decrypt
            >> Seq.toArray
            >> String
           )