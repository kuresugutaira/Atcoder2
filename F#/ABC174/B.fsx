open System

let arr = stdin.ReadLine().Split(' ') |> Array.map int
let n = float arr.[0]
let d = float arr.[1]

let list = [|for i in [1.0..n] do stdin.ReadLine().Split(' ') |> Array.map float|]

let f (x: float[]) = if Math.Sqrt (x.[0] * x.[0] + x.[1] * x.[1]) <= d then 1 else 0

list
|> Array.sumBy f
|> Console.WriteLine