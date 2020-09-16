open System

stdin.ReadLine()
|> Seq.sumBy (fun c -> if c = '1' then 1 else 0)
|> printfn "%d"