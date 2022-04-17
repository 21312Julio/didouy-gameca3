-> main

=== main ===
The door is locked but you can use that key.
    + [Use Key]
        -> chosen("Use Key")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
You used the Key

-> END

=== chosen2(option) ===
You left.

-> END