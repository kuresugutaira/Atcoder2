open System

//Aを固定して考えるとBの値が決まると同時にCの値も決まる
let N = stdin.ReadLine() |> int

let Alist = [1..(N-1)]

List.sumBy (fun a -> (N-1)/a) Alist
|> printfn "%i"