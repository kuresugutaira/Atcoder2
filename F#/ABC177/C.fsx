open System

let Mod = Math.Pow (10.,9.) + 7. |> int64

let Ruisekiwa list = 

    let rec subRuisekiwa accum list2 temp = 
        match list2 with
        | [] -> accum
        | hd :: tl -> subRuisekiwa ((hd + temp) :: accum) tl (hd + temp)

    subRuisekiwa [] (List.rev list) 0L |> List.tail |> List.map (fun x -> x % Mod)

let N = Console.ReadLine() |> int64
let AList = Console.ReadLine().Split(' ') |> Array.map int64 |> Seq.toList

let result list =
    
    let ruisekiList = Ruisekiwa list

    let rec subR accum list2 (ruisekiL:list<int64>) =
        match list2 with
        | [] -> accum
        | hd :: tl when List.isEmpty tl -> accum
        | hd :: tl -> subR ((accum + ((hd * (ruisekiL.Head)) % Mod)) % Mod) tl ruisekiL.Tail

    subR 0L list ruisekiList

printfn "%i" (result AList)