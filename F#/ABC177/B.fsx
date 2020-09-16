open System

let S = Console.ReadLine() |> Seq.toArray
let T = Console.ReadLine() |> Seq.toArray

let result str1 str2 = 
    let rec subR accum index =
        let tempS = Array.sub str1 index (Array.length str2)
        let diff = Array.map2 (fun c1 c2 -> if c1 = c2 then 1 else 0)  tempS str2 |> Array.sum
        if index = str1.Length - str2.Length then
            max accum diff
        else 
            subR (max accum diff) (index+1)
    subR 0 0 

printfn "%i" ((Array.length T) - (result S T))