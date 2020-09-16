open System

let [|D; T; S|] = Console.ReadLine().Split(' ') |> Array.map float
if T * S >= D then
    printfn "%s" "Yes"
else
    printfn "%s" "No"
