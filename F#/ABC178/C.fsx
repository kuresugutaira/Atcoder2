open System
 
let modConst = 1e9+7. |> int64
 
let N = stdin.ReadLine() |> int64
 
let modpow x y =
    let rec submodpow accum index =
        match index with
        | _ when index = y -> accum
        | _ -> submodpow (accum * x % modConst) (index + 1L)
 
    submodpow 1L 0L
 
let solveF x = modpow x N
 
printfn "%d" ((((solveF 10L) - (solveF 9L) - (solveF 9L) + (solveF 8L)) + 2L * modConst ) % modConst)