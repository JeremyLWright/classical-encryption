namespace Ciphers

module Ciphers =

    let fn = 1

    let ``test source`` = "WKH FDW LQ WKH KDW VWULNHV EDFN"

    let alphabet = [|'A'..'Z'|]

    let rand = new System.Random()

    let swap (a: _[]) x y =
        let tmp = a.[x]
        a.[x] <- a.[y]
        a.[y] <- tmp

    let shuffle a = 
        Array.iteri (fun i _ -> swap a i (rand.Next(i, Array.length a))) a


    open NUnit.Framework
    open FsUnit

    [<Test>]
    let ``simple test`` () = 
        fn |> should equal 1
