(*
    Problem Statement: 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any 
                       remainder. What is the smallest positive number that is evenly divisible by all of the numbers 
                       from 1 to 20?
                       
    Problem #5 Smallest Multiple
*)

let toTwenty = [for i in 1..20 -> i] // Numbers 1 to 20
let nums = { 100000000..250000000 }  // All positive integers from 100,000,000 to 250,000,000

(* 
    isDiv: takes the list of numbers 1-20 and the current positive integer interating over and checks if 
           it is evenly divisible by all the numbers 1-20
*)
let isDiv listy x  
  = List.map (fun i -> if (x % i = 0) then true else false) listy    // Generate a list of booleans for each tried int
 |> List.filter (fun cond -> if (cond = false) then true else false) // False means there's a num 1-20 not evenly divi
 |> List.length                                                      // If length of the list is 0, we know we got it

let answers = nums |> Seq.filter (fun x -> (isDiv toTwenty x = 0))
let answer = Seq.head answers
printf "The smallest positive integer evenly divisible by all numbers 1-20 is %d\n" answer
