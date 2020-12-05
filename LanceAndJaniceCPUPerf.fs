module FooBarQ.LanceAndJaniceCPUPerf

open System

let testCases = [|
    "wrw blf hvv ozhg mrtsg'h vkrhlwv?";
    "Yvzs! I xzm'g yvorvev Lzmxv olhg srh qly zg gsv xlolmb!!"
|]
    
let dictionary = Map [
            ('z', 'a');
            ('y', 'b');
            ('x', 'c');
            ('w', 'd');
            ('v', 'e');
            ('u', 'f');
            ('t', 'g');
            ('s', 'h');
            ('r', 'i');
            ('q', 'j');
            ('p', 'k');
            ('o', 'l');
            ('n', 'm');
            ('m', 'n');
            ('l', 'o');
            ('k', 'p');                 
            ('j', 'q');
            ('i', 'r');
            ('h', 's');
            ('g', 't');
            ('f', 'u');
            ('e', 'v');
            ('d', 'w');
            ('c', 'x');
            ('b', 'y');
            ('a', 'z')
        ]
    
let dictionaryLookup char =
    match char with
    | a when a >= 'a' && a <= 'z' -> dictionary.[a]
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