open System

let S = stdin.ReadLine() |> Seq.rev |> Seq.toArray

if S.[0] = 's' then 
    printfn "%s" ((String (Array.rev S)) + "es") 
else
    printfn "%s" ((String (Array.rev S)) + "s") 