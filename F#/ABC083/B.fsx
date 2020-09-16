open System

let arr = Console.ReadLine().Split(' ')
let N = arr.[0] |> int
let A = arr.[1] |> int
let B = arr.[2] |> int

let sum (x:int) = 
    x
    |> string
    |> Seq.sumBy (fun c -> int c - int '0')
    
[1..N]
|> Seq.sumBy (fun x -> if (A <= sum x && sum x <= B) then x else 0)
|> printfn "%d"