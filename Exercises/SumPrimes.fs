open System

(*
     Problem statement: The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17. 
                        Find the sum of all the primes below two million.
                        
     problem #10 - Summation of Primes                       
*)     
let is_prime (n : int64) = 
        let rec check i = 
            i > n/2L || (n % i <> 0L && check (i + 1L))
        check 2L
let prime_seq max = seq { for x in 1L..max do if is_prime x then yield x }
 
printfn "The sum of prime numbers below 10 is: %d" (((prime_seq 10L) |> Seq.sum) - 1L)
printfn "The sum of prime numbers below 2000000 is: %A" (((prime_seq 2000000L) |> Seq.sum) - 1L)
