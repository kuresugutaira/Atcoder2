open System

let K = stdin.ReadLine() |> int

let rec f (x,y) =
    (10 * x + 7,y)
    |> (fun (x,y) -> if x % K = 0 then y elif K % 2 = 0 then -1 elif K % 5 = 0 then -1 else f (x % K , y + 1))

f (0,1)
|> printfn "%d"
