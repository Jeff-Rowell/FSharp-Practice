open System

(*
    Problem statement: “If we list all the natural numbers below 10 that are multiples of 3 or 5, 
                        we get 3, 5, 6 and 9. The sum of these multiples is 23.  Find the sum of 
                        all the multiples of 3 or 5 below 1000.”
     
     problem #1 - Multiples of 3 or 5
*)
let multiples_of_3_or_5 x = Seq.init x (fun x -> x) 
                          |> Seq.reduce (fun sum y -> if y % 3 = 0 || y % 5 = 0 then sum + y else sum)
printfn "Sum of the multiples of 3 or 5 less than 10: %d" (multiples_of_3_or_5 10)
printfn "Sum of the multiples of 3 or 5 less than 1000: %d" (multiples_of_3_or_5 1000)
