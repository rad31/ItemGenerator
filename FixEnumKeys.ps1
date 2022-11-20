$fileName = $args[0];
$x = 0;
$lines = New-Object -TypeName "System.Collections.ArrayList"
Get-Content "$fileName" | ForEach-Object {
    if ($_ -match "(\s*public static readonly \w+ \w+ = new\()(\d+)(.*)") {
        $_ = $matches[1] + $x + $matches[3];
        $x++;
    }
    $lines.Add($_) | Out-Null;
}
$lines | Out-File "$fileName";
