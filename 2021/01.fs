h# 5000 constant filespace

: initfile s" input01.txt" filename ;

: readnum
    0 ( return val )
    begin
    ( push char to stack [awkward] )
    filespace 1 fileread filespace c@
    swap over h# 0a <> and while ( not [newline or eof] )
    h# 30 - swap 10 * + ( convert ascii val )
    repeat
    drop
;


: solvea
  initfile
  0
  readnum
  2000 1 do
  readnum dup -rot > 0<> 1+ rot
  + swap
  loop
  drop
;

: 3dup 2 pick 2 pick 2 pick ;



variable total
variable last

: solveb
  initfile
  readnum readnum readnum \ read 3 nums
  2000 3 do
  3dup + + dup \ sum
  last @ 
  swap < 0<> negate total +!
  last ! \ store variable
  rot drop \ remove oldest value
  readnum
  loop
  total @
;


: boot
    s" input01.txt" filename
    solvea . cr
    solveb .
    bye 
;
save 01.rom \ Replace with soln number
bye
