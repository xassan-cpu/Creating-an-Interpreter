## A Map of the Territory

### The Parts of a Language

#### Scanning

A `scanner` breaks down the source code into `tokens`.

#### Parsing

A `parser` builds an `abstract syntax tree` (or `AST`) from the `tokens`, and reports `syntax errors`.

#### Static analysis

The first bit of analysis is `binding`, where an `identifier` is associated with its declaration. This association happens in the `scope` (the region of the source code in which the `identifier` can be accessed or referenced).

For statically-typed languages, this is where the type checking occurs, ensuring variables and expressions are used with the correct types, and `type errors` are reported if there are mismathces.



#### Intermediate representations

`Intertermediate Representation` (`IR`) acts as an interface between the front end (which processes the source code) and the back end (which generates machine code). This allows the compiler to avoid dealing with specific details of the source language or target architecture at every stage.

`IR` reduces the effort required to support multiple languages and architectures. You write one front end for each source language and one back end for each architecture.


#### Optimization

At this stage, code optimizations are applied to improve performance or reduce memory usage. 


#### Code Generation

At this stage, we convert our program into assembly-like instructions that a CPU can run. Now, do we generate instructions for a real CPU, where it produces an executable that is bound to a specific hardware architecture, or a `virtual machine` which produces `bytecode` for a hypothetical, idealized machine?




#### Virtual Machine (VM)

a `Virtual Machine` (`VM`) is a program that a hypothetical chip supporting your virual architecture at runtime. Although this is slower than converting your program into native code for each target architecture, running your bytecode in a VM gives you simplicity and portability.


#### Runtime


We can finally execute the program. If the program was compiled to machine code (native code for a CPU), then OS load the executable into memory and runs it directly on the hardware. If the program was compiled to bytecode, a VM is required. 

We usually need some services provided by the `runtime system`, like a `garbage collector` is the language manages memory. 

For `compiled languages` (like C), the runtime system is included the resulting compiled executable. Each compiled program carries its own copy of the runtime along with the compiled code.

For `intepreted or VM-based languages`, the runtime is part of the `interpreter` or `VM`. 


### Shortcuts and Alternate Routes






