open System

let S = stdin.ReadLine() |> Seq.rev |> string

let solve str =
    let rec subsolve str2 = 
        match str2 with
        | _ when (String.IsNullOrWhiteSpace str2) -> "Yes"