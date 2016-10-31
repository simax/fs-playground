module abc


let (|Int|_|) str =
   match System.Int32.TryParse(str) with
   | (true,int) -> Some(int)
   | _ -> None

let (|Bool|_|) str =
   match System.Boolean.TryParse(str) with
   | (true,bool) -> Some(bool)
   | _ -> None


[<EntryPoint>]
let main argv =
    // let x = "Hello World!!!!!"
    // printfn "%A" x
    let str = "true"
    let returnedValue = 
        match str with
            | Int i -> sprintf "The value is an int '%i'" i
            | Bool b -> sprintf "The value is a bool '%b'" b
            | _ -> sprintf "The value '%s' is something else" str
    
    printfn "%A" returnedValue        

    0 // return an integer exit code
