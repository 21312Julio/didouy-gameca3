-> main

=== main ===
There is a mirror but it's broken. You can try to put the piece back in the mirror.
    + [Fix Mirror]
        -> chosen("Check Mirror")
    + [Check Safe]
        -> chosen2("Check Safe")
...

=== chosen(option) ===
You fixed the mirror. You notice something something different in the clock behind you.

-> END

=== chosen2(option) ===
You check the safe. You need a 4 digit combination to open it.

-> END