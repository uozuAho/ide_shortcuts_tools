# IDE shortcuts etc.

A quick demo project to demonstrate and practice IDE tools and shortcuts.
Geared for my Visual Studio + Resharper setup, but should be repeatable in other
IDEs.

Note for myself: Follow from here, in order.

Please yell out if you miss anything while I'm demonstrating, there's probably
some stuff I do by muscle memory without thinking :)

Don't modify anything yet - go through navigation and tests first.


## navigation

- goto anything: ctrl+t
- goto definition: ctrl+click
- find usages: F11 (custom)
- navigate back/forward: ctrl +/- ??? mine's custom


## tests

- run all tests: no shortcut, alt-enter
- repeat previous run: no shortcut, alt-enter
- run single test
- show fail/pass


## refactoring

Now copy 'initial_state' to a new directory, in `StarCannon` and `StarCannon.Test`

- fix namespaces: menu. Show what happened, and what's wrong in initial_state
    - resharper does a lot in one go!
        - remove unused imports
- accept resharper suggestions: alt+enter
- format code: no shortcuts, alt+enter
    - format block
    - format selection
    - format doc
- rename: F2 (custom?)
- introduce parameter
- extract method
- extract class
- inline method


# Further reading/exercises

- [refactoring kata](https://github.com/MYOB-Technology/General_Developer/tree/main/katas/kata-refactoring)
- [MYOB things we value: refactoring](https://github.com/MYOB-Technology/General_Developer/blob/main/things-we-value/technical/programming/refactoring.md)
- https://refactoring.guru/
- [Martin Fowler's refactoring](https://refactoring.com/catalog/)
- [Refactoring to patterns](https://www.amazon.com.au/Refactoring-Patterns-Joshua-Kerievsky/dp/0321213351)