type LoggingBuilder() =
    let log p = printfn "expresion is %A" p

    member this.Bind(x, f) =
        log x
        f x

    member this.Return(x) = x

let logger = LoggingBuilder()

let loggedWorkflow =
    logger {
        let! x = 42
        let! y = 43
        let! z = x + y
        return z
    }

loggedWorkflow
