open System

stdin.ReadLine() |> (fun x -> if x = "0" then "1" else "0") |> printfn "%s"