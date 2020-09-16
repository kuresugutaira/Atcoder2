open System

let [|a;b;c;d|] = stdin.ReadLine().Split(' ') |> Array.map int64

[|a*c; a*d; b*c; b*d|]
|> Array.max
|> printfn "%i"