open System

let chars = Console.ReadLine().ToCharArray()

let n = Array.sumBy (fun x -> if x = 'R' then 1 else 0) chars

let ans = 
    match n with
    | 2 -> if chars.[1] = 'S' then 1 else 2
    | _ -> n

printfn "%d" ans