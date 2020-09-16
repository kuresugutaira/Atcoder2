open System

let N = stdin.ReadLine() |> int
let aList = stdin.ReadLine().Split(' ') |> Array.map int |> Seq.toList |> List.sort |> List.rev

let solveF list =
    let rec subSolveF accumA accumB list2 =
        match list2 with
        | hd :: (md :: tl) -> subSolveF (hd + accumA) (md + accumB) tl
        | hd :: tl -> accumA + hd - accumB
        | [] -> accumA - accumB

    subSolveF 0 0 list

solveF aList |> printfn "%i"
