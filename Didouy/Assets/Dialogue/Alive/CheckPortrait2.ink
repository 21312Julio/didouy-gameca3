-> main

=== main ===
A portrait. Someone seems to have messed up with it. You can't point your finger on it, but the figure seems to be looking relentlessly at you.
You can check the portrait.
    + [Check Portrait]
        -> chosen("Check Portrait")
    + [Leave]
        -> chosen2("Leave")

...

=== chosen(option) ===
You check the portrait. Looks like you need a combination.

-> END

=== chosen2(option) ===
You decide to leave. The figure is creeping you out.

-> END