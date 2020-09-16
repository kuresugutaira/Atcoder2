open System

let N = stdin.ReadLine() |> int
let S = stdin.ReadLine().ToCharArray()

let count = Array.sumBy (fun x -> if x = 'R' then 1 else 0) S

let tmp = Array.sub S 0 count

tmp 
|> Array.sumBy (fun x -> if x = 'W' then 1 else 0)
|> printfn "%d"