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
variable aim

: getcommand 
  filespace c@ \ get direction
  filespace 20 32 scan drop 1+ \ read until space
  c@ chartonum swap \ get number
;
: solvea 
  1000 0 do readline getcommand
  dup 102 = if \ 'f'
  over xpos +!
  then dup 100 = if \ 'd'
  over ydepth +!
  then dup 117 = if \ 'u'
  over negate ydepth +!
  then 
  2drop loop
  xpos @ ydepth @ um*
;

: solveb \ TODO figure out how to store double
  s" input02.txt" filename
  1000 0 do readline getcommand
  dup 102 = if \ 'f'
  over xpos +!
  over aim @ * ydepth +!
  then dup 100 = if \ 'd'
  over aim +!
  then dup 117 = if \ 'u'
  over negate aim +!
  then 
  xpos @ ydepth @ aim @ . . . cr
  2drop loop
  xpos @ ydepth @ .s um*
;

: boot
    s" input02.txt" filename
    solvea d. cr \ TODO double math??
    0 xpos ! 0 ydepth !
    solveb d. cr
    bye ;
save 02.rom \ Replace with soln number
bye
