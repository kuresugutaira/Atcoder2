open System

let N = stdin.ReadLine() |> int

let aList = [ for _ in 1..N -> stdin.ReadLine() |> int ]

let SolveF list =
    let rec subSolveF accum list2 =

        match list2 with
        | hd::tl when (List.tryFind ((=) hd) accum) = None -> subSolveF (hd::accum) tl
        | hd::tl -> subSolveF accum tl
        | [] -> accum
    
    subSolveF [] list

SolveF aList |> List.length |> printfn "%i"