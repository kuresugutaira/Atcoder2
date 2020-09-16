open System

let n = stdin.ReadLine() |> int

let pointList = [for _ in 1..n -> stdin.ReadLine().Split(' ') |> Array.map int |> Array.toList]

let findMinPoint list =
    let rec subF accum (list2: int list list) =
        match list2 with
        | [] -> accum
        | hd :: tl -> subF (min accum (List.sum hd)) tl
    
    let compV = subF Int32.MaxValue list

    List.find (fun x -> (List.sum x) = compV) list

let minPoint = findMinPoint pointList

let getDistance list2 =
    let x = List.head list2
    let y = List.head (List.tail list2)
    Math.Abs (((List.head minPoint) - x) + (List.head (List.tail minPoint) - y))
    

let solve list =
    let rec subS accum list2 =
        match list2 with
        | [] -> accum
        | hd :: tl -> subS (max accum (getDistance hd)) tl
    
    subS 0 list

solve pointList |> printfn "%i"