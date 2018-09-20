module Leap

let leapYear (year: int): bool = 
    year % 4 = 0 && (year % 100 <> 0 || year % 400 = 0);

(*  
    let (|DivisibleBy|_|) by x = if x % by = 0 then Some DivisibleBy else None
    match year with
        | DivisibleBy 400 -> true
        | DivisibleBy 100 -> false
        | DivisibleBy 4   -> true
        | _               -> false
*)