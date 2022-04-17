-> main

=== main ===
The doll is gone.
    + [Investigate]
        -> chosen("Investigate")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
The doll isn't here anymore.

-> END

=== chosen2(option) ===
You left.

-> END