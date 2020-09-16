open System

let [|N;Y|] = stdin.ReadLine().Split(' ') |> Array.map int


let printS (a,b,c) = printfn "%d %d %d" a b c

seq { for i in 0..N do
        for j in 0..(N-i)
            -> (i,j,N-i-j)}
|> Seq.tryFind (fun (a,b,c) -> a * 10000 + b * 5000 + c * 1000 = Y)
|> (fun opt -> if Option.isSome opt then Option.get opt else (-1,-1,-1))
|> printS