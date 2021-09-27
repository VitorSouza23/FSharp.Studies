let sample = [| 1 .. 100 |]

let primeNumbers =
    query {
        for number in sample do
            where (number % 2 = 0)
            select number
    }

printfn "%A" primeNumbers
