let multiples max = 
    [0..max-1] 
    |> List.filter (fun n -> n%3 = 0 || n%5=0) 
    |> List.sum

let result = multiples 1000
