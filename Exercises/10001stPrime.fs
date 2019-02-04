open System

(*
    Problem Statement: By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that 
                       the 6th prime is 13. What is the 10 001st prime number?

    problem #7 - 100001st Prime Number
*)
let isPrime(n) = [2 .. int(Math.Sqrt(float(n)))] |> Seq.filter (fun x -> n % x = 0) |> Seq.length = 0
let primeNumber(n) = Seq.unfold(fun x -> Some(x, x + 1)) 2 |> Seq.filter isPrime |> Seq.item(n)
let start2 = System.DateTime.Now
printfn "Answer = %d" (primeNumber 10000)
let stop2 = System.DateTime.Now
printfn"Elapsed = %A" (stop2 - start2)
