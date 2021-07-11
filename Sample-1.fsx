module Sample1 =
    let sampleFunction x = x * x + 3

    let result = sampleFunction 134
    printfn "Result 1: %d" result

    let sampleFunction2 (x: int) = 2 * x * x - x / 5 + 3

    let result2 = sampleFunction2 (7 + 4)
    printfn $"Result 2: {result2}"

    let sampleFunction3 x =
        if x < 100.0 then
            2.0 * x * x - x / 5.0 + 3.0
        else
            2.0 * x * x + x / 5.0 - 37.0

    let result3 = sampleFunction3 (6.5 + 4.5)
    printfn $"Result 3: %f{result3}"
