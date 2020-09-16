open System

let [|X;K;D|] = Console.ReadLine().Split(' ') |> Array.map int64

if X > (int64 0) then 
    if X > K * D then printfn "%d" (X - K * D)
    else
        if (K - (min K (X/D))) % (int64 2) = (int64 0) then printfn "%d" (X%D)
        else printfn "%d" (D - X%D)
elif X < (int64 0) then 
    if -X > K * D then printfn "%d" (-X - K * D)
    else
        if (K - (min K (X/D))) % (int64 2) = (int64 0) then printfn "%d" ((-X)%D)
        else printfn "%d" (D - (-X)%D)
else
    if K%(int64 2) = (int64 0) then printfn "%d" (int64 0) else printfn "%d" D