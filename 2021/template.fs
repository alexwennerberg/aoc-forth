: solvea 
;

: solveb
;

: boot
    s" input01.txt" filename
    solvea .  cr  solveb bye ;
save 01.rom \ Replace with soln number
bye
