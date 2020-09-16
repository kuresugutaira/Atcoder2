open System

let x = stdin.ReadLine() |> int

x
|> (fun y -> if y >= 30 then "Yes" else "No")
|> printfn "%s"