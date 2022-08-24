# Forth AOC

Advent of Code solutions in [UF
forth](http://www.call-with-current-continuation.org/uf/uf.html)

Forth is a stack-based programming language. It is extremely small. UF is a Forth targeting the
[uxn/varvara](https://100r.co/site/uxn.html) virtual computer.

I am going to try to work through 2021 using this language/environment as an exercise, and
in preparation for 2022.

A notable challenge will be that I only have access to 64kb of memory. May have to
use swap space of some sort.

To run each solution (after building or acquiring ufx.rom from the `uf` repo):

```
# make sure input is in inputN.txt (TODO: make a CLI arg)
uxncli ufx.rom < N.fs
uxnemu N.rom
```

Some solutions have visualizations, others do not. For those that don't, you can use uxncli

part 1 and part 2 solutions will be printed to the console, newline separated
