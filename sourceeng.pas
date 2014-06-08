Program MemInspector;
uses crt, DOS;

var
  d: char;
  i: Integer;
  stop: boolean;
begin
  clrscr;
  GotoXY (25,2);
  WriteLn ('|||Welcome to MemInspector|||');
  WriteLn (' ------------------------------------------------------------------------------');
  GotoXY (1,23);
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' MemInspector v.1.1 by HackFeed. All rights reserved!');
  GotoXY (1,5);
  Write (' Change drive: ');
  ReadLn (d);
  WriteLn();
  stop := false;
    case d of
      'A','a': i := 1;  'K','k': i := 11; 'U','u': i := 21;
      'B','b': i := 2;  'L','l': i := 12; 'V','v': i := 22;
      'C','c': i := 3;  'M','m': i := 13; 'W','w': i := 23;
      'D','d': i := 4;  'N','n': i := 14; 'X','x': i := 24;
      'E','e': i := 5;  'O','o': i := 15; 'Y','y': i := 25;
      'F','f': i := 6;  'P','p': i := 16; 'Z','z': i := 26;
      'G','g': i := 7;  'Q','q': i := 17;
      'H','h': i := 8;  'R','r': i := 18;
      'I','i': i := 9;  'S','s': i := 19;
      'J','j': i := 10; 'T','t': i := 20;
    else
    stop := true
    end;

  if ((DiskFree(i) = -1) or (stop = true)) then
  begin
    WriteLn (' ------------------------------------------------------------------------------');
    WriteLn (' Drive not found. Check existence of a drive or connection!');
    WriteLn (' ------------------------------------------------------------------------------');
  end;

  if ((DiskFree(i) <> -1) and (stop <> true)) then
  begin
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' All ', DiskSize(i),' bytes, ', DiskSize(i) div 1024,' kbytes, ',DiskSize(i) div 1048576,' mbytes, ',DiskSize(i) div 1073741824,' gbytes. ' );
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' Free ', DiskFree(i),' bytes, ', DiskFree(i) div 1024,' kbytes, ',DiskFree(i) div 1048576,' mbytes, ',DiskFree(i) div 1073741824,' gbytes. ' );
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' Occupied ', (DiskSize(i) - DiskFree(i)),' bytes, ', (DiskSize(i) - DiskFree(i)) div 1024,' kbytes, ',(DiskSize(i) - DiskFree(i)) div 1048576,' mbytes, ',(DiskSize(i) - DiskFree(i)) div 1073741824,' gbytes. ' );
  WriteLn (' ------------------------------------------------------------------------------');
  end;

  WriteLn ();
  WriteLn (' For an exit from the program press any key...');
  ReadLn
end.
