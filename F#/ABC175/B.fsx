open System

let N = Console.ReadLine() |> int
let arr = Console.ReadLine().Split(' ') |> Array.map int

let jugde (x:int[]) = 
    Array.sort x
    |> (fun y -> if (y.[0] <> y.[1]) && (y.[1] <> y.[2]) && (y.[0] <> y.[2]) && (y.[0] + y.[1] > y.[2]) then 1 else 0)

[|for i in [1..N] do
    for j in [i..N] do
        for k in [j..N] do
            yield if (i <> j) && (j <> k) && (i <> k) then [|arr.[i-1];arr.[j-1];arr.[k-1]|] else [|0;0;0|]|]
|> Array.sumBy jugde
|> printfn "%d"