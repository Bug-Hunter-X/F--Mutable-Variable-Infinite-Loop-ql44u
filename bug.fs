let mutable x = 0
let mutable y = 0

let rec loop () =
    if x = 10 then
        ()
    else
        x <- x + 1; 
        y <- y + 1; 
        loop ()

loop ()
printf "%d %d" x y