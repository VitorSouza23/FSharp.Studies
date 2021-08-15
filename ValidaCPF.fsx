open System

let args = fsi.CommandLineArgs |> Array.tail

let removeMask (arg: string) = arg.Replace(".", "").Replace("-", "")

let checkSize (arg: string) =
    arg
    |> String.length
    |> function
        | l when l = 11 -> Some(arg)
        | _ -> None

let isValidArgument arg = removeMask arg |> checkSize

let firstDigitArray = [| 2 .. 10 |] |> Array.rev
let secondDigitArray = [| 2 .. 11 |] |> Array.rev

let stringToNumbers (arg: string) =
    Array.map (fun c -> Int32.Parse(c.ToString())) (arg.ToCharArray())

let sumOfProducts values numbersValidator =
    Array.map2 (*) values numbersValidator
    |> Array.sum

let mult10 value = value * 10

let rest11 value =
    value % 11 |> fun x -> if x >= 10 then 0 else x

let numberCalculation values numberValidation =
    sumOfProducts values numberValidation
    |> mult10
    |> rest11

let doValidation (cpf: int []) =
    let cpf1 = Array.take 9 cpf
    let cpf2 = Array.take 10 cpf
    let firstDigit = cpf.[9]
    let secondDigit = cpf.[10]

    let resultFirstDigit = numberCalculation cpf1 firstDigitArray
    let resultSecondDigit = numberCalculation cpf2 secondDigitArray

    let isCpfvalid =
        firstDigit = resultFirstDigit
        && secondDigit = resultSecondDigit

    isCpfvalid

let isValid = isValidArgument args.[0]

let cleanData = removeMask >> stringToNumbers

let processCpf isValidCpf cpf =
    match isValidCpf with
    | Some v -> doValidation (cleanData cpf)
    | None -> false

printfn "%A" (processCpf isValid args.[0])
