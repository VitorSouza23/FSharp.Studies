let makeResource name =
    { new System.IDisposable with
        member this.Dispose() = printfn "%s disposed" name }

let exampleUseBinding name =
    use myResource = makeResource name
    printfn "done"

exampleUseBinding "hello"

let usingResource name callback =
    use myResource = makeResource name
    callback makeResource
    printfn "done"

let callback aReosurce = printfn "Ressource is %A" aReosurce
do usingResource "hello" callback

using (makeResource "hello") callback
