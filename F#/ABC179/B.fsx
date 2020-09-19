open System

let N = stdin.ReadLine() |> int
let Ds = seq { for _ in 1..N do stdin.ReadLine().Split(' ') } |> Seq.toList

let judgeArray = List.map (fun (x:string []) -> x.[0] = x.[1]) Ds |> List.toArray

let solve = seq {for i in 0..(N-3) -> judgeArray.[i] && judgeArray.[i+1] && judgeArray.[i+2]} |> Seq.toList

match (List.tryFind id solve) with
| Some(x) -> printfn "%s" "Yes"
| None -> printfn "%s" "No"