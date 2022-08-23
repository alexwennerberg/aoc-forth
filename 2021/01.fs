h# 5000 constant filespace

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

" input.txt" filename

: solvea
  0
  readnum
  2000 1 do
  readnum dup -rot > 0<> 1+ rot
  + swap
  loop
  drop
;

solvea .
( TODO solve part 2 )
