-> main

=== main ===
Look like a lifeless doll. There are candles around it.
    + [Investigate]
        -> chosen("Investigate")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
You use the items on the doll and suddenly feel a gush of wind passing by through you.

-> END

=== chosen2(option) ===
You left.

-> END