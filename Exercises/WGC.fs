open System
open Operators
(*
    Problem Statement: A farmer needs to bring a wolf, a goat and a cabbage accros a river,
                       but can only take 1 passenger at a time. If left alone, the wolf will 
                       eat the goat and the goat will eat the cabbage. Can all passengers 
                       cross the river without being eaten?
*)
type position = | Src | Dest 
let Items = ["wolf";"goat";"cabbage"]
let death = [["wolf"; "goat"]; ["goat"; "cabbage"];]

let Validate items = 
    List.exists(fun x -> x = items) death
    
let Diff a b = 
    List.filter(fun x -> List.forall(fun y -> y <> x) a) b
    
let rec GoToDest items =
    match items with        
    | [] -> []
    | head::tail ->
        if(Validate tail) then GoToDest tail @ [head]
        else 
            Console.WriteLine("Moving " + head + " to the destination side.")
            tail 

let GoToSource items =
    let listy = Diff items Items
    let going_back = Validate listy
    if(going_back) then 
        let temp = List.head listy
        Console.WriteLine("Farmer brings " + temp + " back to source side.")
        [temp]
    else 
        Console.WriteLine("Farmer goes back to source side alone.")
        []
        
let rec CrossRiver location items = 
    match items with 
    | [] -> Console.WriteLine("Successfully crossed the river!")
    | _ ->
        match location with 
        | Src -> CrossRiver Dest (GoToDest items)
        | Dest -> CrossRiver Src (items @ GoToSource(items))
        
CrossRiver Src Items
