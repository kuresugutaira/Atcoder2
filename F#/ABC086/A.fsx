open System

let input = stdin.ReadLine().Split(' ') |> Array.map int
let a = input.[0]
let b = input.[1]

let f x y = if (x * y) % 2 = 1 then "Odd" else "Even"
f a b |> printfn "%s"