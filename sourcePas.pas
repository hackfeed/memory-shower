Program MemInspector;
uses crt, DOS;

var
  d: char;
  i: Integer;
  stop: boolean;
begin
  clrscr;
  GotoXY (25,2);
  WriteLn ('|||Добро пожаловать в MemInspector|||');
  WriteLn (' ------------------------------------------------------------------------------');
  GotoXY (1,23);
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' MemInspector v.1.1 by HackFeed. All rights reserved!');
  GotoXY (1,5);
  Write (' Выберите диск: ');
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
    WriteLn (' Диск не найден/не существует. Проверьте наличие диска или подключение!');
    WriteLn (' ------------------------------------------------------------------------------');
  end;

  if ((DiskFree(i) <> -1) and (stop <> true)) then
  begin
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' Всего ', DiskSize(i),' байт, ', DiskSize(i) div 1024,' кбайт, ',DiskSize(i) div 1048576,' мбайт, ',DiskSize(i) div 1073741824,' гбайт. ' );
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' Свободно ', DiskFree(i),' байт, ', DiskFree(i) div 1024,' кбайт, ',DiskFree(i) div 1048576,' мбайт, ',DiskFree(i) div 1073741824,' гбайт. ' );
  WriteLn (' ------------------------------------------------------------------------------');
  WriteLn (' Занято ', (DiskSize(i) - DiskFree(i)),' байт, ', (DiskSize(i) - DiskFree(i)) div 1024,' кбайт, ',(DiskSize(i) - DiskFree(i)) div 1048576,' мбайт, ',(DiskSize(i) - DiskFree(i)) div 1073741824,' гбайт. ' );
  WriteLn (' ------------------------------------------------------------------------------');
  end;

  WriteLn ();
  WriteLn (' Для выхода из программы нажмите любую клавишу...');
  ReadLn
end.
