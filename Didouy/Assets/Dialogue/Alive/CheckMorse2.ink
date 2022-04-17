-> main

=== main ===
"Maybe that key fits in here"
    + [Use Key]
        -> chosen("Use Key")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
A group of books emerged from the wall. What does it mean?

-> END

=== chosen2(option) ===
You left.

-> END