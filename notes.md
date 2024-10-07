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

a `Virtual Machine` (`VM`) is a program that emulates a hypothetical chip supporting your virual architecture at runtime. Although this is slower than converting your program into native code for each target architecture, running your bytecode in a VM gives you simplicity and portability.


#### Runtime


We can finally execute the program. If the program was compiled to machine code (native code for a CPU), then OS loads the executable into memory and runs it directly on the hardware. If the program was compiled to bytecode, a VM is required. 

We usually need some services provided by the `runtime system`, like a `garbage collector` if the language manages memory. 

For `compiled languages` (like C), the runtime system is included in the resulting compiled executable. Each compiled program carries its own copy of the runtime along with the compiled code.

For `intepreted or VM-based languages`, the runtime is part of the `interpreter` or `VM`. 


### Shortcuts and Alternate Routes


#### Single-pass compilers

A `single-pass compiler` is a type of compiler that processes the source code in a single traversal and outputs the corresponding machine code. It forgoes tasks such as parsing, semantic analysis and code generation for a more simple and efficient design compared to multi-pass compilers. However, it has limited capabilities for complex optimization and forward references.


#### Tree-walk interpreters


A `Tree-walk interpreter` is a type of interpreter that traverses the `AST` of a program and executes the program. An `AST` is a tree-like data structure that represents the syntactic structure of source code. Each node corresponds to a construct, such as an expression, statement, or variable declaration.



#### Transpilers


Instead of compiling your source code to machine code or bytecode, `transpilers` translates code to another programming language (e.g. TypeScript -> JavaScript). 


#### Just-in-time compilation


A runtime compilation technique where code (bytecode or `IR`) is compiled into native machine code `during program execution`, rather than before the program is loaded. This allows the program to optimize performance for the specific architecture it is running on.


### Compilers and Interpreters

#### Compiling

An implementation technique which translates source code to some other form. This can include generating bytecode or machine code, or transpiling to another high-level language.

#### Compiler

A `compiler` compiles a source code (translates it to another form) but does not `execute` the program. The user has to take the resulting output and run it themselves.

#### Interpreter

An `interpreter` imediately executes the source code, running program "from source".


## Scanning

### Lexemes and Tokens

`Lexemes` are the smallest meaningful sequence of characters in source code, grouped together by the Scanner or `Lexer` during the `lexical analysis` phase of compilation. They represent fundamental elements like keywords, operators, identifiers, or literals in the source code.

A `token` is created when we take a lexeme and bundle it with addtitional information, such as its type (e.g. identifier, keyword, operator). The token represents a more structured unit that the parser can use during the syntax analysis.


### Regular Languages and Expressions


`Lexical grammar` is the rule that determines how a particular language groups characters into lexemes. 


### Reserved Words and Identifiers


To identify a reserved keyword from an identifier, we use `maximal munch`. `Maximal munch` refers to the princicple that the lexer should consume the longest possible sequence of characters when forming a lexeme. This has the limitation of not being able to identify a reserved keyword until we've reached the end of what might instead an indentifer.

Therefore, we first assume the set of characters we are trying to gategorize matches an identifer. We then see if the identidier's lexeme is one of the reserved words. If it is, then we tokenize it as a reserved keyword.
