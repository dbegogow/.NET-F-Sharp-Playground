﻿let myOne = 1

let hello = "hello"

let letterA = 'a'

let isEnable = true

// int -> (int -> int)
let add (x: int) (y:int) = x + y

let add' = fun x y -> x + y

let add'' x = fun y -> x + y

let add5 x =
    let five = 5
    x + five

// let add5' x = add 5 x
let add5' = add 5

let result = add5' 6

// (2 * (number + 3)) ^ 2

let operation number = (2. * (number + 3.)) ** 2.