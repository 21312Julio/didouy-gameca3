-> main

=== main ===
Look like a lifeless doll. There are candles around it.
    + [Investigate]
        -> chosen("Investigate")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
Looks like you need to complete it.

-> END

=== chosen2(option) ===
You left.

-> END