-> main

=== main ===
There is a mirror but it's broken. If you find the missing piece, you might be able to use it.
You can check the safe below the mirror
    + [Check Mirror]
        -> chosen("Check Mirror")
    + [Check Safe]
        -> chosen2("Check Safe")
...

=== chosen(option) ===
You need the missing piece.

-> END

=== chosen2(option) ===
You check the safe. You need a 4 digit combination to open it.

-> END