#SingleInstance, Force
#NoEnv
SetBatchLines, -1

F2::
IfWinActive, Path of Exile
{
WinActivate
BlockInput On
SendInput, {Esc}
WinGetPos,,,Width,Height,A
X := (Width / 2)
Y := Height * .4
MouseClick, Left, X, Y, 1, 1
BlockInput Off
}
return


^x::
IfWinActive, Path of Exile
{
WinActivate
BlockInput On
SendInput, {Enter}
sleep, 20
SendInput, {/}oos
SendInput, {Enter}
BlockInput Off
}
return

^a::
IfWinActive, Path of Exile
{
WinActivate
BlockInput On
SendInput, {Enter}
sleep, 20
SendInput, {/}remaining
SendInput, {Enter}
BlockInput Off
}
return


!c::
IfWinActive, Path of Exile
{
WinActivate
BlockInput On
MouseClick, Left
SendInput, {Enter}
SendInput, {/}itemlevel
SendInput, {Enter}
Sleep, 100
MouseClick, Left
BlockInput Off
}
return
