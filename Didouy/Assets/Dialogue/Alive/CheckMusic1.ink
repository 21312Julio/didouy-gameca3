-> main

=== main ===
You see a music box in front of you. It is unlike any you have ever seen in your stay. 
You can check the music box.
    + [Check Music Box]
        -> chosen("Check Music Box")
    + [Leave]
        -> chosen2("Leave")
...

=== chosen(option) ===
You check the music box.

-> END

=== chosen2(option) ===
You decide it's best left alone.

-> END