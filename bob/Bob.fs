module Bob

open System

let (|IsQuestion|_|) (i:string) = if i.EndsWith '?' then Some IsQuestion else None

let (|IsSilence|_|) (i:string) = if i.Length = 0 then Some IsSilence else None

let (|IsYelling |_|) (i:string) = 
    let letters = i |> Seq.filter(fun x -> Char.IsLetter(x))
    if not <| Seq.isEmpty letters  && Seq.forall (fun x -> Char.IsUpper(x)) letters 
    then Some IsYelling else None

let response (input: string): string = 
    match input.Trim() with
        | IsSilence                 -> "Fine. Be that way!"
        | IsYelling & IsQuestion    -> "Calm down, I know what I'm doing!"
        | IsQuestion                -> "Sure."
        | IsYelling                 -> "Whoa, chill out!"
        | _                         -> "Whatever."