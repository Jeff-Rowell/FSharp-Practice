open System

(*
    Problem Statement: https://projecteuler.net/problem=6
    
    problem #6 - Sum Square Differences
*)
printfn"Answer: %d" ( ({1 .. 100} |> Seq.sum |> fun x -> x * x) - 
                      (Seq.unfold (fun x -> if x > 100 then None else Some(x*x, x+1)) 1 |> Seq.sum) )
