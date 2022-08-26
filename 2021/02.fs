h# 5000 constant filespace

: chartonum h# 30 - ;

: readline \ read a line to filespace
    0 begin dup 
    filespace + dup 1 fileread 
    swap c@ h# 0a <> and while ( not [newline or eof] )
    1+ repeat drop
;

variable xpos
variable ydepth

: solvea 
  1000 0 do readline 
  filespace c@ \ get direction
  filespace 20 32 scan drop 1+ \ read until space
  c@ chartonum swap \ get number
  dup 102 = if \ 'f'
  over xpos +!
  then dup 100 = if \ 'd'
  over ydepth +!
  then dup 117 = if \ 'u'
  over negate ydepth +!
  then 
  2drop loop
  xpos @ ydepth @ . 
;

: solveb
  10
;

: boot
    s" input02.txt" filename
    solvea . cr \ TODO double math??
    bye ;
save 02.rom \ Replace with soln number
bye
