let fibonnacci = 
    (1,1) 
    |> Seq.unfold (fun (previous, next) -> 
        Some(next, (next, previous + next))) 

let result = 
    fibonnacci 
    |> Seq.takeWhile(fun x -> x < 4000000) 
    |> Seq.filter (fun x -> x%2 = 0) 
    |> Seq.sum
