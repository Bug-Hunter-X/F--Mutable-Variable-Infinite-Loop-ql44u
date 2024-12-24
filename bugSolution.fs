let x = ref 0
let y = ref 0

let rec loop () =
    if !x = 10 then
        ()
    else
        x := !x + 1; 
        y := !y + 1; 
        loop ()

loop ()
printf "%d %d" !x !y