open System

let n = stdin.ReadLine()
let a = stdin.ReadLine().Split(' ') |> Array.map int

let rec canDiv2 = fun v -> if v % 2 = 1 then 0 else (1 + canDiv2(v / 2))

a
|> Array.map canDiv2
|> Array.min
|> printfn "%d"