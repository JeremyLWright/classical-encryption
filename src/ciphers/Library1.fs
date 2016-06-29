namespace Ciphers

module Ciphers =

    let fn = 1

    open NUnit.Framework
    open FsUnit

    [<Test>]
    let ``simple test`` () = 
        fn |> should equal 1
