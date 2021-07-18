let lambda = fun () -> 1

printfn "%A" lambda

let matchSample =
    match 1 with
    | 1 -> "a"
    | _ -> "b"

printfn "%A" matchSample

let ifElse = if true then "a" else "b"

printfn "%A" ifElse

let forLoop =
    for i in [ 1 .. 10 ] do
        printfn "%i" i

forLoop

let tryBlock =
    try
        let result = 1 / 0
        printfn "%i" result
    with
    | e -> printfn "%s" e.Message

tryBlock

let n = 1 in
n + 2 |> ignore

printfn "%A" n
