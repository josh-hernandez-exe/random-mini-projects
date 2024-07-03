package main

import (
	"fmt"

	"rsc.io/quote"
)

func add(x int, y int) int {
	return x + y
}

func main() {
	fmt.Println("Hello, World!")
	fmt.Println(quote.Go())
	fmt.Println(add(42, 13))
}
