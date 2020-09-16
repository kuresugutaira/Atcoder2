open System

let f () = stdin.ReadLine() |> int

let a = f ()
let b = f ()
let c = f ()
let t = f ()

[for i in [0..a] do
    for j in [0..b] do
        for k in [0..c] do
            yield 500 * i + 100 * j + 50 * k]
|> List.sumBy (fun x -> if x = t then 1 else 0)
|> printfn "%d"