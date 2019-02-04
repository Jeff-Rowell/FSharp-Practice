open System
open System.Numerics
(*
     Problem statement: https://projecteuler.net/problem=623
     
     problem #623 - Lambda Count
*) 
let LambdaCount(n : BigInteger) = 
    let MOD_NUM = new BigInteger(1000000007)
    let MAX = n/(BigInteger 5)
    let mutable lambda_terms = Array2D.create (int MAX + 1) (int n + 1) (BigInteger 0)
    for i = int MAX downto 0 do
        for j = 1 to int n do
            if(j = 1) then lambda_terms.[i, j] <- ((BigInteger i) % MOD_NUM)
            else 
                if(i < int MAX && j >= 5) then lambda_terms.[i, j] <- lambda_terms.[i, j] + lambda_terms.[i + 1, j - 5]
                for a = 1 to (j - 2) do
                    let b = j - 2 - a
                    lambda_terms.[i, j] <- lambda_terms.[i, j] + ((lambda_terms.[i, a] * lambda_terms.[i, b]) % MOD_NUM)
                lambda_terms.[i, j] <- lambda_terms.[i, j] % MOD_NUM
    let result = (Seq.sum(lambda_terms.[0..0,*] |> Seq.cast<BigInteger>))
    printfn "LambdaCount = %A" (result % MOD_NUM)
    
let start = System.DateTime.Now
LambdaCount(BigInteger 2000)
let stop = System.DateTime.Now
printfn"Elapsed = %A" (stop - start)
