-> main

=== main ===
The door seems to be locked.
    + [Investigate]
        -> chosen("Investigate")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
It is shut. You need a key to get out of here.

-> END

=== chosen2(option) ===
You left.

-> END